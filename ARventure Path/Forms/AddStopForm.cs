using ARventure_Path.DataClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class AddStopForm : Form
    {
        public AddStopForm()
        {
            InitializeComponent();
        }

        public Stop stop { get; private set; }
        private void buttonAcceptStop_Click(object sender, EventArgs e)
        {
            if (textBoxStopName.Text.Trim() != "")
            {
                if (double.TryParse(textBoxLatitud.Text, out double latitud) && latitud >= -90.0 && latitud <= 90.0)
                {
                    if (double.TryParse(textBoxLongitud.Text, out double longitud) && longitud >= -180.0 && longitud <= 180.0)
                    {
                        // Obtener los datos del formulario y crear un nuevo objeto Stop
                        string name = textBoxStopName.Text;
                        double latitude = Convert.ToDouble(latitud);
                        double longitude = Convert.ToDouble(longitud);
                        stop = new Stop(name, latitude, longitude); MessageBox.Show("Parada añadida con éxito.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK; // Configura el resultado del diálogo como OK
                    }
                    else
                    {
                        MessageBox.Show("La longitud ingresada no es válida. Debe estar entre -180.0 y +180.0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La latitud ingresada no es válida. Debe estar entre -90.0 y +90.0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelStop_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
