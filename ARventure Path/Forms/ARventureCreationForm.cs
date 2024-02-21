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
    public partial class ARventureCreationForm : Form
    {
        bool isCreation;
        public ARventureCreationForm(bool isCreation)
        {
            this.isCreation = isCreation;
            InitializeComponent();
        }

        private void ARventureCreationForm_Load(object sender, EventArgs e)
        {
            bindingSourceStory.DataSource = StoryOrm.Select();

            hideArventureSelection();
        }

        private void hideArventureSelection()
        {
            if(isCreation)
            {
               labelSelectArventure.Visible = false;
                comboBoxSelectArventure.Visible = false;
            }
        }

        private void buttonCancelArventure_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
