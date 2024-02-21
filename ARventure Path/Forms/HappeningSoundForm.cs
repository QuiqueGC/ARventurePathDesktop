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
    public partial class HappeningSoundForm : Form
    {
        bool isCreation;
        public HappeningSoundForm(bool isCreation)
        {
            InitializeComponent();
            this.isCreation = isCreation;
        }

        private void HappeningSoundForm_Load(object sender, EventArgs e)
        {
            bindingSourceStory.DataSource = StoryOrm.Select();
            hideHappeningSelection();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
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
