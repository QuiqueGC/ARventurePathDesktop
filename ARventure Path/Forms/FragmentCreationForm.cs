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

        public FragmentCreationForm()
        {
            InitializeComponent();
            
        }

        private void buttonAcceptFragment_Click(object sender, EventArgs e)
        {
            //story.TxtFragments.Add(textBoxCreateFragment.Text);
            
            this.Close();
            
        }

        public string getTextBoxCreateFragmentText()
        {
            return textBoxCreateFragment.Text;
        }

        private void buttonCancelFragment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
