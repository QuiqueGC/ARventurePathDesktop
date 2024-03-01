using ARventure_Path.Models;
using System;
using System.Collections;
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
    public partial class FragmentCreationForm : Form
    {
        StoryCreationForm storyCreationForm;
        public FragmentCreationForm(StoryCreationForm storyCreationForm)
        {
            InitializeComponent();
            this.storyCreationForm = storyCreationForm;

        }

        private void buttonAcceptFragment_Click(object sender, EventArgs e)
        {
            //story.TxtFragments.Add(textBoxCreateFragment.Text);
            if (textBoxCreateFragment.Text.Trim() == "")
            {
                MessageBox.Show("El campo de texto no puede estar vacío.", "¡Error!");
            }
            else
            {
                storyCreationForm.contentToFragment = textBoxCreateFragment.Text;
                this.Close();
            }
        }

        private void buttonCancelFragment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
