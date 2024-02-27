using ARventure_Path.Forms;
using ARventure_Path.Utils;
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
        private AchievementForm achievementForm;

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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void crearHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            storyCreationForm = new StoryCreationForm(MyUtils.FormType.Create);
            addingFormmToPanel(storyCreationForm);
        }

        private void modificarHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            storyCreationForm = new StoryCreationForm(MyUtils.FormType.Modify);
            addingFormmToPanel(storyCreationForm);
        }
        private void borrarHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            storyCreationForm = new StoryCreationForm(MyUtils.FormType.Delete);
            addingFormmToPanel(storyCreationForm);
        }

        private void crearRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            routeCreationForm = new RouteCreationForm(MyUtils.FormType.Create);
            addingFormmToPanel(routeCreationForm);
        }

        private void modificarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            routeCreationForm = new RouteCreationForm(MyUtils.FormType.Modify);
            addingFormmToPanel(routeCreationForm);
        }

        private void borrarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            routeCreationForm = new RouteCreationForm(MyUtils.FormType.Delete);
            addingFormmToPanel(routeCreationForm);
        }

        private void crearAventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            arventureCreationForm = new ARventureCreationForm(true);
            addingFormmToPanel(arventureCreationForm);

        }

        private void modificarAventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            arventureCreationForm = new ARventureCreationForm(false);
            addingFormmToPanel(arventureCreationForm);
        }

        private void borrarAventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFormsFromPanel();
            arventureCreationForm = new ARventureCreationForm(false);
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

        private void crearEventoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventTextForm = new HappeningTextForm(true);
            eventTextForm.ShowDialog();
        }

        private void modificarEventoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventTextForm = new HappeningTextForm(false);
            eventTextForm.ShowDialog();
        }

        private void borrarEventoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventTextForm = new HappeningTextForm(false);
            eventTextForm.ShowDialog();
        }

        private void crearEventoImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventImageForm = new HappeningImageForm(true);
            eventImageForm.ShowDialog();
        }

        private void modificarEventoImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventImageForm = new HappeningImageForm(false);
            eventImageForm.ShowDialog();
        }

        private void borrarEventoImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventImageForm = new HappeningImageForm(false);
            eventImageForm.ShowDialog();
        }

        private void crearEventoSonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventSoundForm = new HappeningSoundForm(true);
            eventSoundForm.ShowDialog();
        }

        private void modificarEventoSonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventSoundForm = new HappeningSoundForm(false);
            eventSoundForm.ShowDialog();
        }

        private void borrarEventoSonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventSoundForm = new HappeningSoundForm(false);
            eventSoundForm.ShowDialog();

        }

        private void aventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            achievementForm = new AchievementForm(true);
            achievementForm.ShowDialog();
        }

        private void borrarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            achievementForm = new AchievementForm(false);
            achievementForm.ShowDialog();
        }
    }
}
