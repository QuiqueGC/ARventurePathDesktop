using ARventure_Path.Models;
using ARventure_Path.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                // Crear ARventure
                string msg = "";
                
                arventure.name = textBoxTitleArventure.Text;
                arventure.story = story;
                arventure.route = route;
                arventure.idAchievement = 15;
                arventure.happening = happenings;

                


                msg = ArventureOrm.Insert(arventure);
                MyUtils.ShowPosibleError(msg);

            }
            else if (formType == MyUtils.FormType.Modify)
            {
                // Modificar ARventure
                

            }
            else
            {
                // Borrar ARventure
                string msg = "";
                if (comboBoxSelectArventure.SelectedItem != null)
                {

                }

                msg = ArventureOrm.Delete(arventure);
                MyUtils.ShowPosibleError(msg);
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
        }

        private void becomeInModifyForm()
        {
            buttonCreateArventure.Text = "Guardar";
            bindingSourceArventure.DataSource = ArventureOrm.Select();
            comboBoxSelectArventure.SelectedItem = null;
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
                arventure = (arventure)comboBoxSelectArventure.SelectedItem;
                textBoxTitleArventure.Text = arventure.name;


            }
        }

        private void buttonSelectStory_Click(object sender, EventArgs e)
        {
            if (listBoxStories.SelectedItems.Count > 0)
            {
                
                story = (story)listBoxStories.SelectedItem;
                labelStoryTitle.Text = story.name;
                var image = Image.FromFile(Path.Combine(storyImagePath, story.img));
                pictureBoxStoryImg.Image = image;
                textBoxStorySummary.Text = story.summary;
            }

            
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
                listBoxRouteStops.DataSource = route.stop.ToList();
                listBoxRouteStops.DisplayMember = "Name";

            }
        }

        private void buttonSelectEvent_Click(object sender, EventArgs e)
        {
            if (dataGridViewHappening.SelectedRows.Count > 0)
            {
                happening selectedHappening = (happening)dataGridViewHappening.SelectedRows[0].DataBoundItem;

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
    }
}
