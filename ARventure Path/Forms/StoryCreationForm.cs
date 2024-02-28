using ARventure_Path.Models;
using ARventure_Path.Utils;
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
        private MyUtils.FormType formType;
        private string fileName;
        private BindingList<fragment> fragments = new BindingList<fragment>();

        private string StoryImagePath = Path.Combine(Application.StartupPath, "..","..","filesToServer","imgStory");

        public StoryCreationForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();
            listBoxFragmentStory.DataSource = fragments;
            listBoxFragmentStory.DisplayMember = "content";

        }

        private void buttonCreateStory_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
            {
                CreateStory();
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                //modificar
            }
            else
            {
                //delete
            }





        }

        private void CreateStory()
        {
            string msg = "";
            story.name = textBoxStoryTitle.Text.ToLower().Trim();
            story.summary = textBoxSummary.Text.ToLower().Trim();
            story.img = fileName;
            msg = StoryOrm.Insert(story);
            MyUtils.ShowPosibleError(msg);

            foreach (fragment fragment in fragments)
            {
                msg = FragmentOrm.Insert(fragment);
                MyUtils .ShowPosibleError(msg);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            fragments.Remove((fragment)listBoxFragmentStory.SelectedItem);
          
        }

        private void buttonCancelStory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StoryCreationForm_Load(object sender, EventArgs e)
        {
            ChooseTypeOfForm();
            comboBoxSelectStory.SelectedItem = null;
        }

        /// <summary>
        /// Escoge el tipo de form que será (creación/modificación/borrado)
        /// en base al enum que se le haya pasado por parámetros al form
        /// </summary>
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

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de borrado
        /// </summary>
        private void becomeInDeleteForm()
        {
            buttonCreateStory.Text = "Borrar";
            bindingSourceStory.DataSource = StoryOrm.Select();
        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de modificación
        /// </summary>
        private void becomeInModifyForm()
        {
            buttonCreateStory.Text = "Guardar";
            bindingSourceStory.DataSource = StoryOrm.Select();
        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de creación
        /// </summary>
        private void becomeInCreatonForm()
        {
            labelSelectStory.Visible = false;
            comboBoxSelectStory.Visible = false;
        }

        private void comboBoxSelectStory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectStory.SelectedItem != null)
            {
                story story = (story)comboBoxSelectStory.SelectedItem;
                bindingSourceFragments.DataSource = FragmentOrm.Select(story);
                textBoxStoryTitle.Text = story.name;
                textBoxSummary.Text = story.summary;
                textBoxFragmentQuantity.Text = story.fragment.Count.ToString();
            }
            

        }
    }
}
