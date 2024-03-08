using ARventure_Path.Models;
using ARventure_Path.Utils;
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
        fragment fragment;
        public FragmentCreationForm(StoryCreationForm storyCreationForm)
        {
            InitializeComponent();
            this.storyCreationForm = storyCreationForm;

        }
        public FragmentCreationForm(fragment fragment)
        {
            InitializeComponent();
            this.fragment = fragment;
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
                if(fragment == null)
                {
                    storyCreationForm.contentToFragment = textBoxCreateFragment.Text;
                }
                else
                {
                    fragment.content = textBoxCreateFragment.Text;
                    string msg = "";
                    msg = Orm.Update();
                    MyUtils.ShowPosibleError(msg);
                }
                
                this.Close();
            }
        }

        private void buttonCancelFragment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FragmentCreationForm_Load(object sender, EventArgs e)
        {
            if(fragment != null)
            {
                textBoxCreateFragment.Text = fragment.content;
            }
        }
    }
}
