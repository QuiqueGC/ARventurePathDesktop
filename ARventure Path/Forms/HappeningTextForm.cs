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
    public partial class HappeningTextForm : Form
    {
        public HappeningTextForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" &&
                textBoxContent.Text != "" &&
                comboBoxStories.SelectedIndex > 0)
            {
                happening happening = new happening();
                happening.name = textBoxName.Text.Trim();
                happening.text = textBoxContent.Text.Trim();
                happening.type = "text";
                happening.idStory = comboBoxStories.SelectedIndex;

                HappeningOrm.Insert(happening);

            }
            else if (textBoxName.Text == "")
            {
                MessageBox.Show("No has introducido nombre de evento.", "Error");

            } else if (comboBoxStories.SelectedIndex <= 0)
            {
                MessageBox.Show("No has escogido la historia a la que pertenece.", "Error");

            } else if(textBoxContent.Text == "")
            {
                MessageBox.Show("No has escrito nada en el contenido.", "Error");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
