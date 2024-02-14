using ARventure_Path.DataClases;
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
    public partial class StoryCreationForm : Form
    {

        Story story = new Story();

        

        public StoryCreationForm()
        {
            InitializeComponent();
        }

        private void buttonCreateStory_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";

            if (abrir.ShowDialog() == DialogResult.OK) 
            {
                pictureBoxStory.Image = Image.FromFile(abrir.FileName);
                textBoxImageRoute.Text = abrir.FileName;
            }
        }

        private void buttonAddNewFragment_Click(object sender, EventArgs e)
        {
            FragmentCreationForm fragmentCreationForm = new FragmentCreationForm(story);
            fragmentCreationForm.ShowDialog();


        }

        private void buttonCancelStory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
