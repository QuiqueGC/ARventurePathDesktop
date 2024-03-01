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
        private List<stop> stopsList = new List<stop>(); // Lista para almacenar las paradas
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
                dataGridViewStops.DataSource = null;
                dataGridViewStops.DataSource = stopsList;
                dataGridViewStops.Columns[0].Visible = false;
                dataGridViewStops.Columns[4].Visible = false;
                dataGridViewStops.Columns[5].Visible = false;
            }
            bindingSourceStops.DataSource = null;
            bindingSourceStops.DataSource = route.stop;
        }

        private void refreshOverlaysMap(string name,double lat, double lng)
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
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            // Se posicionan en el textbox de la latidud y longitud
            textBoxLatitude.Text = LatStart.ToString();
            textBoxLongitude.Text = LngStart.ToString();

            refreshOverlaysMap("Barcelona",LatStart, LngStart);

        }
        private void comboBoxSelectRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            route = (route)comboBoxSelectRoute.SelectedItem;
            if (route != null)
            {
                gMapControl1.Zoom = 12;
                textBoxNameRoute.Text = route.name;
                bindingSourceStops.DataSource = null;
                bindingSourceStops.DataSource = route.stop;
                previewRoute();
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
        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de creación
        /// </summary>
        private void becomeInCreatonForm()
        {
             labelSelectRoute.Visible = false;
             comboBoxSelectRoute.Visible = false;
        }

        private void buttonAddNewStop_Click(object sender, EventArgs e)
        {
            stop newStop = new stop();
            newStop.name = textBoxStopName.Text;
            newStop.longitude = Convert.ToDouble(textBoxLongitude.Text);
            newStop.latitude = Convert.ToDouble(textBoxLatitude.Text);
            stopsList.Add(newStop);

            refreshTable();
            previewRoute();
            refreshOverlaysMap(newStop.name,(Double)newStop.latitude, (Double)newStop.longitude);

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
                        // Obtener el índice de la fila seleccionada
                        //int selectedIndex = dataGridViewStops.SelectedRows[0].Index;

                        //route.stop.Remove(stop.)

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
            switch(formType) 
            {
                case MyUtils.FormType.Create:
                    createRoute();
                    break;
                case MyUtils.FormType.Modify:
                    break;
                case MyUtils.FormType.Delete:
                    break;
            }
        }

        private void createRoute()
        {
            if (check())
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
                }
            }
        }

        private Boolean check()
        {
            Boolean check;

            if(stopsList.Count > 1)
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
            textBoxStopName.Text = "";

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

            // Show the estimated time in minutes without decimals
            labelRouteTime.Text = ((int)time.TotalMinutes).ToString() + " min";
        }

    }
}
