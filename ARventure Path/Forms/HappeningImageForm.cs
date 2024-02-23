using ARventure_Path.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class HappeningImageForm : Form
    {
        bool isCreation;
        private string imgPath = Path.Combine(Application.StartupPath,"..","..", "filesToServer", "imgHappening");
        private static Image image;
        string fileName;

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
                image = Image.FromFile(openFileDialog.FileName);
                
                imgHappening.Image = image;
                string filePath = openFileDialog.FileName;
                textBoxUrl.Text = filePath;

                fileName = Path.GetFileName(filePath);
            }
        }

        private void SaveImage()
        {
            // Si la carpeta no existe, la crea
            if (!Directory.Exists(imgPath))
            {
                Directory.CreateDirectory(imgPath);
            }
            String destinationPath = Path.Combine(imgPath, fileName);
            image.Save(destinationPath, ImageFormat.Png);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            String msg = "";
            if (textBoxName.Text.Trim() != "" &&
                fileName != null &&
                comboBoxStories.SelectedItem != null) 
            {
                happening happening = new happening();
                happening.name = textBoxName.Text.Trim();
                happening.url = fileName;
                happening.type = "image";
                happening.idStory = (int)comboBoxStories.SelectedValue;
                SaveImage();

                msg = HappeningOrm.Insert(happening);
                if (msg != "")
                {
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Evento creado satisfactoriamente.", "Éxito!");
                    Close();
                }
            }
            else if(textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("No has introducido nombre de evento.", "Error");

            }
            else if (comboBoxStories.SelectedItem == null)
            {
                MessageBox.Show("No has escogido la historia a la que pertenece.", "Error");

            }
        }

    private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HappeningImageForm_Load(object sender, EventArgs e)
        {
            bindingSourceStory.DataSource = StoryOrm.Select();
            hideHappeningSelection();
            comboBoxStories.SelectedItem = null;
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
