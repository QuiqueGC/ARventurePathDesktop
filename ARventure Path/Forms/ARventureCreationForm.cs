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

namespace ARventure_Path.Forms
{
    public partial class ARventureCreationForm : Form
    {
        arventure arventure = new arventure();
        private story story;
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
            bindingSourceStory.DataSource = StoryOrm.Select();
            bindingSourceRoute.DataSource = RouteOrm.Select();
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
            
        }
        private void buttonSelectRoute_Click(object sender, EventArgs e)
        {
            if (listBoxRoutes.SelectedItems.Count > 0) 
            { 
                route = (route)listBoxRoutes.SelectedItem;
                labelRouteName.Text = route.name;
                labelDistanceRoute.Text = route.distance.ToString();
                labelTimeRoute.Text = route.time.ToString();
                listBoxRouteStops.DataSource = route.stop.ToList();
                listBoxRouteStops.DisplayMember = "Name";
                
            }
        }

        private void buttonSelectEvent_Click(object sender, EventArgs e)
        {


            if (dataGridViewHappening.SelectedRows.Count > 0) 
            { 
                happening happening = (happening)dataGridViewHappening.SelectedRows[0].DataBoundItem;
                happenings.Add(happening);

            }
        }

        private void buttonRemoveEvent_Click(object sender, EventArgs e)
        {
            if (listBoxSelectEvents.SelectedItem != null) 
            {
                happenings.Remove((happening)listBoxSelectEvents.SelectedItem);
            }
        }
    }
}
