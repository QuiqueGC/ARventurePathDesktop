using ARventure_Path.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path
{
    public partial class MainForm : Form
    {

        private StoryCreationForm storyCreationForm;
        private RouteCreationForm routeCreationForm;
        private ARventureCreationForm arventureCreationForm;
        private LoginForm loginForm;
        private HappeningTextForm eventTextForm;
        private HappeningImageForm eventImageForm;
        private HappeningSoundForm eventSoundForm;


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            loginForm = new LoginForm(this);
            addingFormmToPanel(loginForm);
        }

        

        /// <summary>
        /// Añade un formulario al panel del MainForm y lo muestra
        /// </summary>
        /// <param name="form">El formulario que se mostrará en el panel</param>
        private void addingFormmToPanel(Form form)
        {
            // Configura el formulario que irá al panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Agrega el formulario al Panel
            panelMain.Controls.Add(form);

            // Muestra el formulario
            form.Show();
        }

        /// <summary>
        /// Vacía el panel principal
        /// </summary>
        private void removeFormsFromPanel()
        {
            checkingIfNullAndClose(loginForm);
            checkingIfNullAndClose(arventureCreationForm);
            checkingIfNullAndClose(storyCreationForm);
            checkingIfNullAndClose(routeCreationForm);
        }

        /// <summary>
        /// Chequea si un formulario no es null y lo cierra
        /// </summary>
        /// <param name="form">El formulario que chequea</param>
        private void checkingIfNullAndClose(Form form)
        {
            if (form != null)
            {
                // No sé si es mejor hacer remove
                // del panel o close en el form
                form.Dispose();
                panelMain.Controls.Remove(form);
                //form.Close();
            }
        }

        private void eventoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventTextForm = new HappeningTextForm();
            eventTextForm.ShowDialog();
        }

        private void eventoDeImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventImageForm = new HappeningImageForm();
            eventImageForm.ShowDialog();
        }

        private void eventoDeSonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventSoundForm = new HappeningSoundForm();
            eventSoundForm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void crearHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            storyCreationForm = new StoryCreationForm();
            addingFormmToPanel(storyCreationForm);
        }

        private void modificarHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            storyCreationForm = new StoryCreationForm();
            addingFormmToPanel(storyCreationForm);
        }
        private void borrarHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            storyCreationForm = new StoryCreationForm();
            addingFormmToPanel(storyCreationForm);
        }

        private void crearRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            routeCreationForm = new RouteCreationForm();
            addingFormmToPanel(routeCreationForm);
        }

        private void modificarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            routeCreationForm = new RouteCreationForm();
            addingFormmToPanel(routeCreationForm);
        }

        private void borrarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            routeCreationForm = new RouteCreationForm();
            addingFormmToPanel(routeCreationForm);
        }

        private void crearAventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            arventureCreationForm = new ARventureCreationForm();
            addingFormmToPanel(arventureCreationForm);

        }

        private void modificarAventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            arventureCreationForm = new ARventureCreationForm();
            addingFormmToPanel(arventureCreationForm);
        }

        private void borrarAventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            arventureCreationForm = new ARventureCreationForm();
            addingFormmToPanel(arventureCreationForm);
        }

        private void showConfirmDialogAndExit(FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que quieres salir?",
                "¡No te vayas!",
                buttons);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            showConfirmDialogAndExit(e);
        }
    }
}
