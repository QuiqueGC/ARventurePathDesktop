using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;
using ARventure_Path.Models;
using ARventure_Path.Utils;
using System.Linq;
using System.ComponentModel;

namespace ARventure_Path.Forms
{
    // https://www.youtube.com/watch?v=CuFW7nYAJ88 
    // https://www.youtube.com/watch?v=ZyyU6MfbXvc&list=PLlD7n_T-mUjVuqIhWVfaNhnpqCZmNcA9e&index=10
    public partial class RouteCreationForm : Form
    {
        route route = new route();
        TimeSpan time;
        double distance;
        stop stop = new stop();
        private BindingList<stop> stopsList = new BindingList<stop>(); // Lista para almacenar las paradas
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        int selectedRow = 0;
        double LatStart = 41.390712;
        double LngStart = 2.169874;

        private MyUtils.FormType formType;

        public RouteCreationForm(MyUtils.FormType formType)
        {
            InitializeComponent();
            this.formType = formType;
        }

        private void refreshTable()
        {
            if (formType == MyUtils.FormType.Create)
            {
                bindingSourceStops.DataSource = null;
                bindingSourceStops.DataSource = stopsList;

            }
            else
            {
                bindingSourceStops.DataSource = null;
                bindingSourceStops.DataSource = StopOrm.Select(route);
            }

        }

        private void refreshOverlaysMap(string name, double lat, double lng)
        {
            // Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker); // Agregamos al mapa

            // Agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación:{0} \n Latitud:{1} \n Longitud: {2}", name, lat, lng);

            // Ahora agregamos el overlay en el mapa
            gMapControl1.Overlays.Add(markerOverlay);

            // Actualizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

            gMapControl1.Position = marker.Position;
        }

        private void RouteCreationForm_Load(object sender, EventArgs e)
        {
            ChooseTypeOfForm();

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatStart, LngStart);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 14;
            gMapControl1.AutoScroll = true;

            // Se posicionan en el textbox de la latidud y longitud
            textBoxLatitude.Text = LatStart.ToString();
            textBoxLongitude.Text = LngStart.ToString();

            refreshOverlaysMap("Barcelona", LatStart, LngStart);

        }
        private void comboBoxSelectRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            route = (route)comboBoxSelectRoute.SelectedItem;
            if (route != null)
            {
                buttonCreateRoute.Enabled = true;
                gMapControl1.Zoom = 14;
                textBoxNameRoute.Text = route.name;
                bindingSourceStops.DataSource = null;
                bindingSourceStops.DataSource = StopOrm.Select(route);
                previewRoute();
                stop = (stop)dataGridViewStops.SelectedRows[0].DataBoundItem;
                refreshOverlaysMap(stop.name, stop.latitude, stop.longitude);
                textBoxStopName.Text = stop.name;
                textBoxLongitude.Text = stop.longitude.ToString();
                textBoxLatitude.Text = stop.latitude.ToString();
                if (formType == MyUtils.FormType.Modify)
                {
                    groupBoxIA.Enabled = true;
                    groupBoxRoute.Enabled = true;
                    buttonCreateRoute.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Escoge el tipo de form que será (creación/modificación/borrado)
        /// en base al enum que se le haya pasado por parámetros al form
        /// </summary>
        private void ChooseTypeOfForm()
        {
            if (formType == MyUtils.FormType.Create)
            {
                becomeInCreatonForm();
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                becomeInModifyForm();
            }
            else
            {
                becomeInDeleteForm();
            }
        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de borrado
        /// </summary>
        private void becomeInDeleteForm()
        {
            buttonCreateRoute.Text = "Borrar";
            bindingSourceRoute.DataSource = RouteOrm.Select();
            comboBoxSelectRoute.SelectedItem = null;
            buttonCreateRoute.Enabled = false;
            textBoxNameRoute.Enabled = false;
            textBoxLongitude.Enabled = false;
            textBoxLatitude.Enabled = false;
            textBoxStopName.Enabled = false;
            buttonAddNewStop.Visible = false;
            buttonStopChange.Visible = false;
            buttonDeleteStop.Visible = false;

        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de modificación
        /// </summary>
        private void becomeInModifyForm()
        {
            buttonCreateRoute.Text = "Guardar";
            bindingSourceRoute.DataSource = RouteOrm.Select();
            comboBoxSelectRoute.SelectedItem = null;
            groupBoxRoute.Enabled = false;
            buttonCreateRoute.Enabled = false;
        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de creación
        /// </summary>
        private void becomeInCreatonForm()
        {
            labelSelectRoute.Visible = false;
            comboBoxSelectRoute.Visible = false;
            groupBoxIA.Enabled = true;
        }

        private void buttonAddNewStop_Click(object sender, EventArgs e)
        {

            stop newStop = new stop();
            if (textBoxStopName.Text.Trim() != "")
            {
                newStop.name = textBoxStopName.Text;
                newStop.longitude = Convert.ToDouble(textBoxLongitude.Text);
                newStop.latitude = Convert.ToDouble(textBoxLatitude.Text);

                if (formType == MyUtils.FormType.Create)
                {
                    stopsList.Add(newStop);

                    refreshTable();
                    previewRoute();
                    refreshOverlaysMap(newStop.name, (Double)newStop.latitude, (Double)newStop.longitude);
                }
                else
                {
                    newStop.route = route;
                    string msg = StopOrm.Insert(newStop);
                    MyUtils.ShowPosibleError(msg);
                    refreshTable();
                    previewRoute();
                    refreshOverlaysMap(newStop.name, (Double)newStop.latitude, (Double)newStop.longitude);
                }
            }
            else
            {
                MessageBox.Show("Introduzca un nombre a la parada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            textBoxStopName.Text = "";


        }

        private void buttonDeleteStop_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada en la DataGridView
            if (dataGridViewStops.SelectedRows.Count > 0)
            {
                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta parada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar si el usuario confirmó la acción
                if (result == DialogResult.Yes)
                {
                    if (formType == MyUtils.FormType.Create)
                    {
                        // Obtener el índice de la fila seleccionada
                        int selectedIndex = dataGridViewStops.SelectedRows[0].Index;

                        // Eliminar la parada de la lista
                        stopsList.RemoveAt(selectedIndex);

                        // Actualizar la DataGridView
                        refreshTable();

                        previewRoute();
                        if (stopsList.Count > 1)
                        {
                            if (selectedIndex > 0)
                            {
                                refreshOverlaysMap(stopsList[selectedIndex - 1].name, (Double)stopsList[selectedIndex - 1].latitude, (Double)stopsList[selectedIndex - 1].longitude);
                            }
                            else
                            {
                                refreshOverlaysMap(stopsList[selectedIndex].name, (Double)stopsList[selectedIndex].latitude, (Double)stopsList[selectedIndex].longitude);
                            }
                        }
                        else if (stopsList.Count == 1)
                        {
                            refreshOverlaysMap(stopsList[0].name, (Double)stopsList[0].latitude, (Double)stopsList[0].longitude);
                        }
                        else
                        {
                            refreshOverlaysMap("Barcelona", LatStart, LngStart);
                        }
                    }
                    else
                    {
                        string msg = StopOrm.Delete((stop)dataGridViewStops.SelectedRows[0].DataBoundItem);
                        MyUtils.ShowPosibleError(msg);
                        refreshTable();
                        previewRoute();
                        refreshOverlaysMap("Barcelona", LatStart, LngStart);

                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una parada para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelRoute_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cancelar la creación de la ruta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // El usuario ha confirmado que quiere cancelar la creación de la ruta
                Close(); // Cerrar el formulario
            }
        }

        private void buttonCreateRoute_Click(object sender, EventArgs e)
        {
            switch (formType)
            {
                case MyUtils.FormType.Create:
                    createRoute();
                    break;
                case MyUtils.FormType.Modify:
                    modifyRoute();
                    break;
                case MyUtils.FormType.Delete:
                    deleteRoute();
                    break;
            }
        }

        private void deleteRoute()
        {
            if (MyUtils.ShowConfirmDialogAndDelete())
            {
                if (ArventureOrm.Select(route).Count == 0)
                {
                    deleteStops();
                    string msg = RouteOrm.Delete(route);
                    MyUtils.ShowPosibleError(msg);
                    bindingSourceRoute.DataSource = RouteOrm.Select();
                    comboBoxSelectRoute.SelectedItem = null;
                    bindingSourceStops.DataSource = null;
                    buttonCreateRoute.Enabled = false;
                    textBoxNameRoute.Text = "";
                    textBoxStopName.Text = "";
                    textBoxLongitude.Text = "";
                    textBoxLatitude.Text = "";
                    gMapControl1.Overlays.Clear();
                    gMapControl1.Zoom = 9;
                }
                else
                {
                    MessageBox.Show("No se puede borrar la ruta, ya que pertenece a una aventura.", "¡Error!");
                }


            }
        }

        private void modifyRoute()
        {
            if (check())
            {
                if ((int)time.TotalMinutes <= 180)
                {
                    route.time = time;
                    route.distance = distance;
                    route.name = textBoxNameRoute.Text;
                    string msg = Orm.Update();
                    MyUtils.ShowPosibleError(msg);
                    bindingSourceRoute.DataSource= RouteOrm.Select();
                }
                else
                {
                    MessageBox.Show("La ruta no debe superar los 180 minutos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void deleteStops()
        {
            int i = route.stop.Count;

            do
            {
                if (route.stop.FirstOrDefault() != null)
                {
                    string msg = StopOrm.Delete(route.stop.FirstOrDefault());
                    MyUtils.ShowPosibleError(msg);
                }
                i--;

            } while (i > 0);
        }

        private void createRoute()
        {
            if (check())
            {
                if ((int)time.TotalMinutes <= 180)
                {
                    route.time = time;
                    route.distance = distance;
                    route.name = textBoxNameRoute.Text;

                    string msg = RouteOrm.Insert(route);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        for (int i = 0; i < stopsList.Count; i++)
                        {
                            stop.name = stopsList[i].name;
                            stop.longitude = stopsList[i].longitude;
                            stop.latitude = stopsList[i].latitude;
                            stop.route = route;
                            msg = "";
                            msg = StopOrm.Insert(stop);
                            if (msg != "")
                            {
                                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        MessageBox.Show("Ruta creada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxNameRoute.Text = "";
                        textBoxStopName.Text = "";
                        stopsList.Clear();
                        refreshTable();
                        gMapControl1.Overlays.Clear();
                        refreshOverlaysMap("Barcelona", LatStart, LngStart);
                        route = new route();
                    }
                }
                else
                {
                    MessageBox.Show("La ruta no debe superar los 180 minutos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private Boolean check()
        {
            Boolean check;

            if (dataGridViewStops.Rows.Count > 1)
            {
                if (textBoxNameRoute.Text.Trim() != "")
                {
                    check = true;
                }
                else
                {
                    MessageBox.Show("Introduce el nombre de la ruta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
            }
            else
            {
                MessageBox.Show("La ruta debe tener mínimo de 2 paradas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }

            return check;
        }

        private void dataGridViewStops_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex; // Fila seleccionada
            if (selectedRow != -1)
            {
                // Recuperamos los datos del grid y los asignamos a los textbox
                textBoxStopName.Text = dataGridViewStops.Rows[selectedRow].Cells[0].Value.ToString();
                textBoxLongitude.Text = dataGridViewStops.Rows[selectedRow].Cells[1].Value.ToString();
                textBoxLatitude.Text = dataGridViewStops.Rows[selectedRow].Cells[2].Value.ToString();


                // Se asignan los valores del grid al marcador
                marker.Position = new PointLatLng(Convert.ToDouble(textBoxLatitude.Text), Convert.ToDouble(textBoxLongitude.Text));
                // Se posiciona el foco del mapa en ese punto
                gMapControl1.Position = marker.Position;
                previewRoute();
                refreshOverlaysMap(textBoxStopName.Text, Convert.ToDouble(textBoxLatitude.Text), Convert.ToDouble(textBoxLongitude.Text));
            }

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Se obtiene los datos del lat y lng del mapa donde el usuario presionó

            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            // Se posicionan en el textbox de la latidud y longitud
            textBoxLatitude.Text = lat.ToString();
            textBoxLongitude.Text = lng.ToString();

            // Creamos el marcador para moverlo al lugar indicado
            marker.Position = new PointLatLng(lat, lng);
            // También se agrega el mensaje al tooltip
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);
        }

        private void previewRoute()
        {
            gMapControl1.Overlays.Clear();

            // Crear una nueva capa de superposición para la nueva ruta
            GMapOverlay routeOverlay = new GMapOverlay("Ruta");

            List<PointLatLng> stops = new List<PointLatLng>();

            // Variables para almacenar datos.
            double lat, lng;

            // Obtener los datos del grid
            for (int rows = 0; rows < dataGridViewStops.Rows.Count; rows++)
            {
                lat = Convert.ToDouble(dataGridViewStops.Rows[rows].Cells[2].Value);
                lng = Convert.ToDouble(dataGridViewStops.Rows[rows].Cells[1].Value);
                stops.Add(new PointLatLng(lat, lng));
            }

            // Crear la nueva ruta
            GMapRoute stopsRoute = new GMapRoute(stops, "Ruta");

            // Agregar la nueva ruta a la capa de superposición
            routeOverlay.Routes.Add(stopsRoute);

            // Agregar la capa de superposición al mapa
            gMapControl1.Overlays.Add(routeOverlay);

            // Actualizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

            // Mostrar la distancia en kilómetros con dos decimales
            distance = stopsRoute.Distance;
            labelRouteDistance.Text = distance.ToString("N2") + " km";

            // Calculate the estimated time for the new route
            time = TimeSpan.FromMinutes(15 * stopsRoute.Distance);

            // Convertir a horas y minutos
            int totalMinutes = (int)time.TotalMinutes;
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;

            // Construir el texto para mostrar
            string formattedTime;
            if (hours > 0)
            {
                formattedTime = hours + "h " + minutes + " min";
            }
            else
            {
                formattedTime = minutes + " min";
            }

            // Mostrar el tiempo estimado en horas y minutos
            labelRouteTime.Text = formattedTime;
        }

        private void buttonStopChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewStops.SelectedRows.Count > 0)
            {
                if (formType == MyUtils.FormType.Create)
                {
                    int selectedIndex = dataGridViewStops.SelectedRows[0].Index;

                    stop stop = new stop();

                    if(textBoxStopName.Text.Trim() != "")
                    {
                        stop.name = textBoxStopName.Text;
                        stop.longitude = Convert.ToDouble(textBoxLongitude.Text);
                        stop.latitude = Convert.ToDouble(textBoxLatitude.Text);

                        stopsList.RemoveAt(selectedIndex);
                        stopsList.Insert(selectedIndex, stop);
                        refreshTable();
                        previewRoute();
                        refreshOverlaysMap(stop.name, stop.latitude, stop.longitude);
                    }
                    else
                    {
                        MessageBox.Show("Introduzca un nombre a la parada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    stop = (stop)dataGridViewStops.SelectedRows[0].DataBoundItem;
                    if (textBoxStopName.Text.Trim() != "")
                    {
                        stop.name = textBoxStopName.Text;
                        stop.longitude = Convert.ToDouble(textBoxLongitude.Text);
                        stop.latitude = Convert.ToDouble(textBoxLatitude.Text);
                        string msg = Orm.Update();
                        MyUtils.ShowPosibleError(msg);
                        refreshTable();
                        previewRoute();
                        refreshOverlaysMap(stop.name, stop.latitude, stop.longitude);
                    }
                    else
                    {
                        MessageBox.Show("Introduzca un nombre a la parada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void textBoxNumberStops_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto en el TextBox no es un número
            if (!int.TryParse(textBoxNumberStops.Text, out _) && textBoxNumberStops.Text != "")
            {
                // Mostrar mensaje de error y limpiar el TextBox
                textBoxNumberStops.Text = ""; // Limpiar el contenido del TextBox
                MessageBox.Show("Por favor, introduce solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerateRoute_Click(object sender, EventArgs e)
        {
            stopsList.Clear();
            refreshTable();
            previewRoute();
            refreshOverlaysMap("Barcelona", LatStart, LngStart);

            if (textBoxNumberStops.Text.Trim() != ""
                && int.TryParse(textBoxNumberStops.Text.Trim(), out int numStopsText))
            {
                if (numStopsText >= 2)
                {
                    string numStops = textBoxNumberStops.Text.Trim();
                    string response = ChatGPTClient.MakeRequestRoute(numStops);

                    try
                    {
                        string[] lines = response.Split('\n');

                        textBoxNameRoute.Text = lines[0];

                        for (int i = 2; i < lines.Length; i += 4)
                        {
                            stop newStop = new stop();
                            // Nombre de la parada
                            newStop.name = lines[i].Substring(lines[i].IndexOf(":") + 1).Trim();

                            // Longitud
                            newStop.longitude = Convert.ToDouble((lines[i + 1].Substring(lines[i + 1].IndexOf(":") + 1).Trim()), System.Globalization.CultureInfo.InvariantCulture);

                            // Latitud
                            newStop.latitude = Convert.ToDouble((lines[i + 2].Substring(lines[i + 2].IndexOf(":") + 1).Trim()), System.Globalization.CultureInfo.InvariantCulture);

                            stopsList.Add(newStop);
                            refreshTable();
                            previewRoute();
                            refreshOverlaysMap(newStop.name, newStop.latitude, newStop.longitude);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar la ruta: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad de paradas debe ser superior a 2.", "Error!");
                }

            }
            else
            {
                MessageBox.Show("Debes introducir un numero de paradas.", "Error!");
            }
        }


    }

}
