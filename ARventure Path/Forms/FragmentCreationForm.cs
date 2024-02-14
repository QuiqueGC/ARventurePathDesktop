using ARventure_Path.DataClases;
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

        Story story = new Story();

        public FragmentCreationForm(Story story)
        {
            InitializeComponent();
            this.story = story;
        }

        private void buttonAcceptFragment_Click(object sender, EventArgs e)
        {
            story.TxtFragments.Add(textBoxCreateFragment.Text);
            
        }

        private void buttonCancelFragment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
