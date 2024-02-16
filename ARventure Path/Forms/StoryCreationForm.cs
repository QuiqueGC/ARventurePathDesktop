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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARventure_Path.Forms
{
    public partial class StoryCreationForm : Form
    {

        Story story = new Story();

        public StoryCreationForm()
        {
            InitializeComponent();
            listBoxFragmentStory.DataSource = story.TxtFragments;
        }

        private void buttonCreateStory_Click(object sender, EventArgs e)
        {
            story.Name = textBoxStoryTitle.Text;
            //story.Img = pictureBoxStory.Image; Cómo guardar las fotos...Guardar las fotos con el nombre de la foto(string)
            story.Summary = textBoxSummary.Text;
            //Guardar en la lista de stories...//Guardar en un objeto story que tenga los parámetros
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

            //Si hay 5 fragments en la lista, no dejar añadir más
            if (CanAddFragments()) 
            {
                FragmentCreationForm fragmentCreationForm = new FragmentCreationForm(story);
                fragmentCreationForm.ShowDialog();
            }

        }

        public bool CanAddFragments() 
        {
            int numberTextBoxFragment = int.Parse(textBoxFragmentQuantity.Text);
            //Si el número de fragments es igual a 5 o si el número añadido es mayor al número de fragments
            if ((numberTextBoxFragment >= 1) && (numberTextBoxFragment > story.TxtFragments.Count))
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
            
            story.TxtFragments.Remove((string)listBoxFragmentStory.SelectedItem);

        }

        private void buttonCancelStory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
