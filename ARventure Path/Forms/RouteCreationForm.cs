using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;

namespace ARventure_Path.Forms
{

    public partial class RouteCreationForm : Form
    {

       // private List<Stop> stopsList = new List<Stop>(); // Lista para almacenar las paradas
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        int selectedRow = 0;
        double LatStart = 41.390712;
        double LngStart = 2.169874;


        public RouteCreationForm()
        {
            InitializeComponent();
        }

        private void refreshTable()
        {
            dataGridViewStops.DataSource = null;
            //dataGridViewStops.DataSource = stopsList;
            dataGridViewStops.Columns[0].Visible = false;
            dataGridViewStops.Columns[2].Visible = false;
            dataGridViewStops.Columns[3].Visible = false;
        }

        private void RouteCreationForm_Load(object sender, EventArgs e)
        {
           // Stop stop = new Stop ("Ubicación 1", LngStart, LatStart);
            //stopsList.Add (stop);
            refreshTable();


            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatStart, LngStart);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            // Marcador

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatStart, LngStart), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker); // Agregamos al mapa

            // Agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", LatStart, LngStart);

            // Ahora agregamos el overlay en el mapa
            gMapControl1.Overlays.Add(markerOverlay);



        }

        private void buttonAddNewRoute_Click(object sender, EventArgs e)
        {
            //Stop newStop = new Stop(textBoxStopName.Text, Convert.ToDouble(textBoxLongitude.Text), Convert.ToDouble(textBoxLatitude.Text));
           //stopsList.Add(newStop);

            refreshTable();
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
                    // Obtener el índice de la fila seleccionada
                    int selectedIndex = dataGridViewStops.SelectedRows[0].Index;

                    // Eliminar la parada de la lista
                   // stopsList.RemoveAt(selectedIndex);

                    // Actualizar la DataGridView
                    refreshTable();
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
            MessageBox.Show("Ruta creada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBoxStops_TextChanged(object sender, EventArgs e)
        { /*
            // Verificar si el texto en el TextBox es un número válido
            if (int.TryParse(textBoxStops.Text, out int maxStops))
            {
                // Verificar si el número de filas en la DataGridView es menor que el valor en el TextBox
                if (dataGridViewStops.Rows.Count < maxStops)
                {
                    MessageBox.Show("El número de paradas no puede ser menor que el número de filas en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el texto no es un número válido, mostrar un mensaje de error
                MessageBox.Show("Por favor, introduce un número válido en el campo de paradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Actualizar el texto del TextBox para que sea igual al número de filas en la DataGridView
            textBoxStops.Text = dataGridViewStops.Rows.Count.ToString();*/
        }

        private void dataGridViewStops_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex; // Fila seleccionada
            if(selectedRow != -1)
            {
                // Recuperamos los datos del grid y los asignamos a los textbox
                textBoxStopName.Text = dataGridViewStops.Rows[selectedRow].Cells[1].Value.ToString();
                textBoxLongitude.Text = dataGridViewStops.Rows[selectedRow].Cells[2].Value.ToString();
                textBoxLatitude.Text = dataGridViewStops.Rows[selectedRow].Cells[3].Value.ToString();
                // Se asignan los valores del grid al marcador
                marker.Position = new PointLatLng(Convert.ToDouble(textBoxLatitude.Text), Convert.ToDouble(textBoxLongitude.Text));
                // Se posiciona el foco del mapa en ese punto
                gMapControl1.Position = marker.Position;
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

        private void buttonPreviewRoute_Click(object sender, EventArgs e)
        {
            GMapOverlay route = new GMapOverlay("Ruta");
            List<PointLatLng> stops = new List<PointLatLng>();
            // Variables para almacenar datos.
            double lat, lng;
            // Pillamos los datos del grid
            for(int rows = 0; rows < dataGridViewStops.Rows.Count; rows++)
            {
                lat = Convert.ToDouble(dataGridViewStops.Rows[rows].Cells[3].Value);
                lng = Convert.ToDouble(dataGridViewStops.Rows[rows].Cells[2].Value);
                stops.Add(new PointLatLng(lat, lng));

            }
            GMapRoute stopsRoute = new GMapRoute(stops, "Ruta");
            route.Routes.Add(stopsRoute);
            gMapControl1.Overlays.Add(route);
            // Actualizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

            labelRouteDistance.Text = stopsRoute.Distance.ToString("N2") + " km"; // Mostrar la distancia en kilómetros con dos decimales

        }
    }
}
