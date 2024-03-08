using ARventure_Path.Models;
using ARventure_Path.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Sql;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ARventure_Path.Forms
{
    public partial class ARventureCreationForm : Form
    {
        arventure arventure = new arventure();
        private story story;
        private achievement achievement;
        private List<story> originalStories = new List<story>();
        private List<route> originalRoutes = new List<route>();
        private route route;
        private string storyImagePath = Path.Combine(Application.StartupPath, "..", "..", "filesToServer", "imgStory");
        private BindingList<happening> happenings = new BindingList<happening>();

        private MyUtils.FormType formType;
        public ARventureCreationForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();
        }

        private void ARventureCreationForm_Load(object sender, EventArgs e)
        {
            ChooseTypeOfForm();
            originalStories = StoryOrm.Select();
            originalRoutes = RouteOrm.Select();
            bindingSourceStory.DataSource = originalStories;
            bindingSourceRoute.DataSource = originalRoutes;
            listBoxSelectEvents.DataSource = happenings;
            listBoxSelectEvents.DisplayMember = "Name";
        }

        private void buttonCancelArventure_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void buttonCreateArventure_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
            {
                if (check())
                {

                    if (story.fragment.Count == route.stop.Count)
                    {
                        // Crear ARventure
                        string msg = "";

                        arventure.name = textBoxTitleArventure.Text;
                        arventure.story = story;
                        arventure.route = route;

                        achievement = new achievement();
                        achievement.name = $"Completa la aventura: {arventure.name}";
                        achievement.img = story.img;

                        arventure.achievement = achievement;
                        arventure.happening = happenings;

                        msg = ArventureOrm.Insert(arventure);
                        MyUtils.ShowPosibleError(msg);
                        if (msg == "")
                        {
                            MessageBox.Show($"La arventure se ha creado con éxito.\nLogro: {achievement.name} creado con éxito ", "Que lo sepas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cleanForm();
                    }
                    else
                    {
                        MessageBox.Show("Debe haber el mismo número de fragmentos que de paradas", "Que lo sepas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }
            else if (formType == MyUtils.FormType.Modify)
            {
                // Modificar ARventure
                if (story.fragment.Count == route.stop.Count)
                {
                    arventure.name = textBoxTitleArventure.Text;
                    arventure.story = story;
                    arventure.route = route;
                    if (arventure.story != story)
                    {
                        arventure.happening = happenings;
                    }

                    string msg = Orm.Update();
                    MyUtils.ShowPosibleError(msg);
                }
                else
                {
                    MessageBox.Show("Debe haber el mismo número de fragmentos que de paradas", "Que lo sepas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                // Borrar ARventure
                string msg = "";
                arventure.happening.Clear();
                msg = ArventureOrm.Delete(arventure);
                MyUtils.ShowPosibleError(msg);
                if (msg == "")
                {
                    cleanForm();
                }
            }
        }

        private bool check()
        {
            if (story != null)
            {
                if (route != null)
                {
                    if (listBoxSelectEvents.Items.Count > 0)
                    {
                        if (textBoxTitleArventure.Text.Trim() != "")
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Introduce el titulo de la arventure", "Que lo sepas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Añade eventos", "Que lo sepas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una ruta", "Que lo sepas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una historia", "Que lo sepas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
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

        private void becomeInDeleteForm()
        {
            buttonCreateArventure.Text = "Borrar";
            bindingSourceArventure.DataSource = ArventureOrm.Select();
            comboBoxSelectArventure.SelectedItem = null;
            groupBoxStories.Enabled = false;
            groupBoxRoutes.Enabled = false;
            groupBoxHappeningStory.Enabled = false;
            groupBoxSelectedHappenings.Enabled = false;
            textBoxTitleArventure.Enabled = false;
            buttonCreateArventure.Enabled = false;
            
        }

        private void becomeInModifyForm()
        {
            buttonCreateArventure.Text = "Guardar";
            bindingSourceArventure.DataSource = ArventureOrm.Select();
            comboBoxSelectArventure.SelectedItem = null;
            groupBoxStories.Enabled = false;
            groupBoxRoutes.Enabled = false;
            groupBoxHappeningStory.Enabled = false;
            groupBoxSelectedHappenings.Enabled = false;
            textBoxTitleArventure.Enabled = false;
            buttonCreateArventure.Enabled = false;
        }

        private void becomeInCreatonForm()
        {
            labelSelectArventure.Visible = false;
            comboBoxSelectArventure.Visible = false;
        }

        private void listBoxStories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStories.SelectedItems.Count > 0) 
            {
                listBoxSelectEvents.DataSource = null;
                happenings.Clear();

                if(formType == MyUtils.FormType.Modify)
                {
                    arventure.happening.Clear();
                    string msg = Orm.Update();
                    MyUtils.ShowPosibleError(msg);
                }
                
                listBoxSelectEvents.DataSource = happenings;
                listBoxSelectEvents.DisplayMember = "Name";

                bindingSourceHappening.DataSource = HappeningOrm.Select((story)listBoxStories.SelectedItem);
                story = (story)listBoxStories.SelectedItem;
                labelStoryTitle.Text = story.name;
                var image = Image.FromFile(Path.Combine(storyImagePath, story.img));
                pictureBoxStoryImg.Image = image;
                textBoxStorySummary.Text = story.summary;
            }
        }

        private void comboBoxSelectArventure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectArventure.SelectedItem != null)
            {
                buttonCreateArventure.Enabled = true;
                arventure = (arventure)comboBoxSelectArventure.SelectedItem;

                textBoxTitleArventure.Text = arventure.name;
                story = arventure.story;
                route = arventure.route;
                achievement = arventure.achievement;
                arventure.happening = HappeningOrm.Select(arventure);
                bindingSourceHappening.DataSource = HappeningOrm.Select(story);

                // Story arventure
                labelStoryTitle.Text = story.name;

                var image = Image.FromFile(Path.Combine(storyImagePath, story.img));
                pictureBoxStoryImg.Image = image;
                textBoxStorySummary.Text = story.summary;

                // Ruta arventure
                labelRouteName.Text = route.name;
                labelDistanceRoute.Text = route.distance.ToString("N2") + " km";
                // Convertir a horas y minutos
                int totalMinutes = (int)route.time.TotalMinutes;
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
                labelTimeRoute.Text = formattedTime;
                listBoxRouteStops.DataSource = StopOrm.Select(route);
                listBoxRouteStops.DisplayMember = "Name";


                if (formType == MyUtils.FormType.Modify)
                {
                    groupBoxStories.Enabled = true;
                    groupBoxRoutes.Enabled = true;
                    groupBoxHappeningStory.Enabled = true;
                    groupBoxSelectedHappenings.Enabled = true;
                    textBoxTitleArventure.Enabled = true;
                    buttonCreateArventure.Enabled = true;

                    // Eventos arventure
                    listBoxSelectEvents.DataSource = HappeningOrm.Select(arventure);

                }
                else
                {
                  
                    bindingSourceStory.DataSource = arventure.story;
                    bindingSourceRoute.DataSource = arventure.route;

                    // Eventos arventure
                    listBoxSelectEvents.DataSource = HappeningOrm.Select(arventure);
                }
            }
        }

        private void cleanForm()
        {
            bindingSourceArventure.DataSource = ArventureOrm.Select();
            textBoxTitleArventure.Text = "";
            labelStoryTitle.Text = "Titulo de la historia";
            var image = Properties.Resources.Login_Aventuras;
            pictureBoxStoryImg.Image = image;
            textBoxStorySummary.Text = "";
            bindingSourceHappening.DataSource = null;
            story = null;
            labelRouteName.Text = "Nombre de la ruta";
            labelDistanceRoute.Text = "0";
            labelTimeRoute.Text = "0";
            listBoxRouteStops.DataSource = null;
            route = null;
            listBoxSelectEvents.DataSource = null;
            happenings.Clear();
            listBoxSelectEvents.DataSource = happenings;
            achievement = null;
        }

        private void listBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRoutes.SelectedItems.Count > 0)
            {
                route = (route)listBoxRoutes.SelectedItem;
                labelRouteName.Text = route.name;
                labelDistanceRoute.Text = route.distance.ToString("N2") + " km";
                // Convertir a horas y minutos
                int totalMinutes = (int)route.time.TotalMinutes;
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
                labelTimeRoute.Text = formattedTime;
                listBoxRouteStops.DataSource = StopOrm.Select(route);
                listBoxRouteStops.DisplayMember = "Name";

            }
        }

        private void buttonSelectEvent_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewHappening.SelectedRows.Count > 0)
            {
                happening selectedHappening = (happening)dataGridViewHappening.SelectedRows[0].DataBoundItem;
                if (formType == MyUtils.FormType.Modify)
                {
                    if (arventure.story == story)
                    {
                        if (listBoxSelectEvents.Items.Cast<happening>().Any(h => h.name == selectedHappening.name))
                        {
                            MessageBox.Show("Este evento ya ha sido seleccionado.", "Evento Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                            string msg = HappeningOrm.InsertForArventure(arventure, selectedHappening);
                            MyUtils.ShowPosibleError(msg);
                            listBoxSelectEvents.DataSource = HappeningOrm.Select(arventure);

                    }
                    else
                    {
                        // Verificar si el evento ya está en la lista
                        if (happenings.Any(h => h.name == selectedHappening.name))
                        {
                            MessageBox.Show("Este evento ya ha sido seleccionado.", "Evento Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Si no está en la lista, añadirlo
                            happenings.Add(selectedHappening);
                        }
                    }
                }
                else
                {
                    // Verificar si el evento ya está en la lista
                    if (happenings.Any(h => h.name == selectedHappening.name))
                    {
                        MessageBox.Show("Este evento ya ha sido seleccionado.", "Evento Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                        // Si no está en la lista, añadirlo
                        happenings.Add(selectedHappening);
                    
                }
                
            }
        }


        private void buttonRemoveEvent_Click(object sender, EventArgs e)
        {
            if (listBoxSelectEvents.SelectedItem != null) 
            {
                happenings.Remove((happening)listBoxSelectEvents.SelectedItem);
            }
        }

        private void textBoxSearchStory_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchStory.Text.ToLower(); // Obtener el texto de búsqueda en minúsculas

            // Verificar si el cuadro de búsqueda está vacío
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Si está vacío, mostrar todas las historias originales
                bindingSourceStory.DataSource = null;
                bindingSourceStory.DataSource = originalStories;
                listBoxStories.DisplayMember = "Name";
            }
            else
            {
                // Si no está vacío, realizar el filtrado
                List<story> filteredStories = new List<story>();
                foreach (story storyItem in originalStories)
                {
                    if (storyItem.name.ToLower().Contains(searchText))
                    {
                        filteredStories.Add(storyItem);
                    }
                }

                bindingSourceStory.DataSource = null;
                bindingSourceStory.DataSource = filteredStories;
                listBoxStories.DisplayMember = "Name";
            }
        }

        private void textBoxSearchRoute_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBoxSearchRoute.Text.ToLower(); // Obtener el texto de búsqueda en minúsculas

            // Verificar si el cuadro de búsqueda está vacío
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Si está vacío, mostrar todas las historias originales
                bindingSourceRoute.DataSource = null;
                bindingSourceRoute.DataSource = originalRoutes;
                listBoxRoutes.DisplayMember = "Name";
            }
            else
            {
                // Si no está vacío, realizar el filtrado
                List<route> filteredRoutes = new List<route>();
                foreach (route routeItem in originalRoutes)
                {
                    if (routeItem.name.ToLower().Contains(searchText))
                    {
                        filteredRoutes.Add(routeItem);
                    }
                }

                bindingSourceRoute.DataSource = null;
                bindingSourceRoute.DataSource = filteredRoutes;
                listBoxRoutes.DisplayMember = "Name";
            }
        }

        private void buttonFragments_Click(object sender, EventArgs e)
        {
            if (listBoxStories.SelectedItem != null)
            {
                // Obtener el story seleccionado
                story selectedStory = (story)listBoxStories.SelectedItem;

                // Crear e inicializar el formulario del diálogo
                using (FragmentsDialog storyDialog = new FragmentsDialog())
                {
                    // Pasar el story al diálogo para mostrar los detalles
                    storyDialog.loadFragments(selectedStory);

                    // Mostrar el diálogo
                    storyDialog.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un story.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
