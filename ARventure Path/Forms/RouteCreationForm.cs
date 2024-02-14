using ARventure_Path.DataClases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    //https://www.youtube.com/watch?v=_V7CRn47pZk

    public partial class RouteCreationForm : Form
    {
        private List<Stop> stopsList = new List<Stop>(); // Lista para almacenar las paradas

        public RouteCreationForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewRoute_Click(object sender, EventArgs e)
        {
            // Verificar si el número de paradas en la lista es mayor que el valor en el TextBox
            if (int.TryParse(textBoxStops.Text, out int maxStops) && stopsList.Count >= maxStops)
            {
                MessageBox.Show("No se puede agregar más paradas de las permitidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddStopForm addStopForm = new AddStopForm();
                if (addStopForm.ShowDialog() == DialogResult.OK)
                {
                    Stop stop = addStopForm.stop;
                    stopsList.Add(stop); // Agregar la parada a la lista
                    MessageBox.Show("Parada añadida a la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewStops.DataSource = null;
                    dataGridViewStops.DataSource = stopsList;
                }
            }
        }

        private void buttonDeleteStop_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada en la DataGridView
            if (dataGridViewStops.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int selectedIndex = dataGridViewStops.SelectedRows[0].Index;

                // Eliminar la parada de la lista
                stopsList.RemoveAt(selectedIndex);

                // Actualizar la DataGridView
                dataGridViewStops.DataSource = null;
                dataGridViewStops.DataSource = stopsList;

                MessageBox.Show("Parada eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        {
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
            textBoxStops.Text = dataGridViewStops.Rows.Count.ToString();
        }

    }
}
