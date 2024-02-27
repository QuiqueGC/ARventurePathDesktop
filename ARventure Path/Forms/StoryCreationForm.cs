using ARventure_Path.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class StoryCreationForm : Form
    {
        private story story = new story();
        private bool isCreation;
        private string fileName;
        private BindingList<fragment> fragments = new BindingList<fragment>();

        private string StoryImagePath = Path.Combine(Application.StartupPath, "..","..","filesToServer","imgStory");

        public StoryCreationForm(bool isCreation)
        {
            this.isCreation = isCreation;
            InitializeComponent();
            listBoxFragmentStory.DataSource = fragments;
            listBoxFragmentStory.DisplayMember = "content";

        }

        private void buttonCreateStory_Click(object sender, EventArgs e)
        {
            string msg = "";
            story.name = textBoxStoryTitle.Text.ToLower().Trim();
            story.summary = textBoxSummary.Text.ToLower().Trim();
            story.img = fileName;


            msg = StoryOrm.Insert(story);

            if(msg != "")
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (fragment fragment in fragments)
            {
                msg = FragmentOrm.Insert(fragment);
                if (msg != "")
                {
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSearchImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(abrir.FileName);
                pictureBoxStory.Image = image;
                string filePath = abrir.FileName;
                textBoxImageStory.Text = filePath;
                fileName = Path.GetFileName(filePath);
                

                SaveImage(image);
            }
        }

        /// <summary>
        /// Guarda la imagen en la carpeta local
        /// </summary>
        /// <param name="fileName"></param>
        /// 
        
        private void SaveImage(Image image)
        {
            // Si la carpeta no existe, la crea
            if (!Directory.Exists(StoryImagePath))
            {
                Directory.CreateDirectory(StoryImagePath);
            }
            string destinationPath = Path.Combine(StoryImagePath, fileName);
            image.Save(destinationPath, ImageFormat.Png);
            story.img = destinationPath;
        }

        private void buttonAddNewFragment_Click(object sender, EventArgs e)
        {

            // Añadir fragmento cuando el número de fragmentos en la
            // lista no supera al número indicado por el usuario
            if (CanAddFragments())
            {
                FragmentCreationForm fragmentCreationForm = new FragmentCreationForm();
                fragmentCreationForm.ShowDialog();

                fragment newFragment = new fragment()
                {
                    story = story,
                    content = fragmentCreationForm.getTextBoxCreateFragmentText(),
                    ordinal = fragments.Count + 1,
                };
                fragments.Add(newFragment);
            }

        }

        public bool CanAddFragments() 
        {
            int numberTextBoxFragment = int.Parse(textBoxFragmentQuantity.Text);
            //Si es número que escribe el usuario es mayor que uno, y si el número añadido es mayor al número de fragments
            if ((numberTextBoxFragment >= 1) && (numberTextBoxFragment > fragments.Count))//nombre de la lista
            {

                return true;

            }

            return false;

        }

        private void textBoxFragmentQuantity_TextChanged(object sender, EventArgs e)
        {
            //Si los números del campo son de 1 - 5, si el número de fragmets en la lista es mayor al número del campo
            //Activar el botón de añadir fragment 
            //numeroFragments

            //TextBox acepta solo números
            //https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxFragmentQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxFragmentQuantity.Text = textBoxFragmentQuantity.Text.Remove(textBoxFragmentQuantity.Text.Length - 1);

                return;
            }


            if (string.IsNullOrEmpty(textBoxFragmentQuantity.Text))
            {
                buttonAddNewFragment.Enabled = true;
                return;
            }

            int numberTextBoxFragment = int.Parse(textBoxFragmentQuantity.Text);

            if (CanAddFragments())
            {
                buttonAddNewFragment.Enabled = true;
                return;
            }

            buttonAddNewFragment.Enabled = false;

        }

        private void textBoxStoryTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            fragments.Remove((fragment)listBoxFragmentStory.SelectedItem);
          
        }

        private void buttonCancelStory_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StoryCreationForm_Load(object sender, EventArgs e)
        {
            hideStorySelection();
            bindingSourceStory.DataSource = StoryOrm.Select();
        }

        private void hideStorySelection()
        {
            if (isCreation)
            {
                labelSelectStory.Visible = false;
                comboBoxSelectStory.Visible = false;
            }
        }
    }
}
