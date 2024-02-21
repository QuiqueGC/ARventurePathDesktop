using ARventure_Path.Models;
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
    public partial class HappeningImageForm : Form
    {
        bool isCreation;
        public HappeningImageForm(bool isCreation)
        {
            InitializeComponent();
            this.isCreation = isCreation;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(openFileDialog.FileName);
                
                imgHappening.Image = image;
                textBoxUrl.Text = openFileDialog.FileName;
                SaveImage(image);
            }
        }

        private void SaveImage(Image image)
        {
            // TODO: guardar la imagen en donde sea que haya que guardarla
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            happening happening = new happening();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HappeningImageForm_Load(object sender, EventArgs e)
        {
            bindingSourceStory.DataSource = StoryOrm.Select();
            hideHappeningSelection();
        }
        private void hideHappeningSelection()
        {
            if (isCreation)
            {
                labelSelectHappening.Visible = false;
                comboBoxHappenings.Visible = false;
            }
        }
    }
}
