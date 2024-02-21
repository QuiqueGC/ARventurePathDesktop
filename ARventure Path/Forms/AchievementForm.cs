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
    public partial class AchievementForm : Form
    {
        bool isCreation;
        public AchievementForm(bool isCreation)
        {
            InitializeComponent();
            this.isCreation = isCreation;
        }

        private void hideAchievementSelection()
        {
            if (isCreation)
            {
                labelSelectAchievement.Visible = false;
                comboBoxSelectAchievement.Visible = false;
            }
        }

        private void buttonCancelAchievement_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AchievementForm_Load_1(object sender, EventArgs e)
        {
            hideAchievementSelection();
            bindingSourceAchievement.DataSource = AchievementOrm.Select();
        }
    }
}
