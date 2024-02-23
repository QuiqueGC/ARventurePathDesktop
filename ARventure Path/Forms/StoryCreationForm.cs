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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARventure_Path.Forms
{
    public partial class StoryCreationForm : Form
    {

        story story = new story();
        bool isCreation;
        string fileName;

        private string StoryImagePath = Path.Combine(Application.StartupPath, "..","..","filesToServer","imgStory");

        public StoryCreationForm(bool isCreation)
        {
            this.isCreation = isCreation;
            InitializeComponent();
            //listBoxFragmentStory.DataSource = story.TxtFragments;

            //story.Id = ClaseDeDB.GetNewStoryId(); devolver tamaño de la lista de stories + 1
        }

        private void buttonCreateStory_Click(object sender, EventArgs e)
        {
            story.name = textBoxStoryTitle.Text.ToLower().Trim();
            story.summary = textBoxSummary.Text.ToLower().Trim();
            story.img = fileName;


            StoryOrm.Insert(story);


            /*for (int i = 0; listaLength; i++)
            {
                fragment fragment = new fragment();
                fragment.story = story;
                fragment.ordinal = i;
                fragment.content = ;
                FragmentOrm.Insert(fragment);
            }*/

            //FragmentOrm.Insert(fragment);

            //Guardar en la lista de stories...//Guardar en un objeto story que tenga los parámetros
            //Console.WriteLine(story);
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
                MessageBox.Show(fileName);

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
            String destinationPath = Path.Combine(StoryImagePath, fileName);
            image.Save(destinationPath, ImageFormat.Png);
            story.img = destinationPath;
        }

        private void buttonAddNewFragment_Click(object sender, EventArgs e)
        {

            // Añadir fragmento cuando el número de fragmentos en la
            // lista no supera al número indicado por el usuario
            if (CanAddFragments())
            {
                FragmentCreationForm fragmentCreationForm = new FragmentCreationForm(story);
                fragmentCreationForm.ShowDialog();
            }

        }

        public bool CanAddFragments() 
        {
            int numberTextBoxFragment = int.Parse(textBoxFragmentQuantity.Text);
            //Si es número que escribe el usuario es mayor que uno, y si el número añadido es mayor al número de fragments
            //if ((numberTextBoxFragment >= 1) && (numberTextBoxFragment > listBoxFragmentStory.Count))//nombre de la lista
            {

                return true;

            }

            //return false;

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

            // story.TxtFragments.Remove((string)listBoxFragmentStory.SelectedItem);
          

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
