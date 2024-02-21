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
        bool isCreation;
        public HappeningTextForm(bool isCreation)
        {
            InitializeComponent();
            this.isCreation = isCreation;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() != "" &&
                textBoxContent.Text.Trim() != "" &&
                comboBoxStories.SelectedItem != null)
            {
                happening happening = new happening();
                happening.name = textBoxName.Text.Trim();
                happening.text = textBoxContent.Text.Trim();
                happening.type = "text";
                happening.idStory = (int)comboBoxStories.SelectedValue;

                HappeningOrm.Insert(happening);

                MessageBox.Show("El evento se ha guardado correctamente.", "Éxito!");

                Close();

            }
            else if (textBoxName.Text == "")
            {
                MessageBox.Show("No has introducido nombre de evento.", "Error");

            } else if (comboBoxStories.SelectedItem == null)
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

        private void HappeningTextForm_Load(object sender, EventArgs e)
        {
            
            bindingSourceStory.DataSource = StoryOrm.Select();
            hideHappeningSelection();
            comboBoxStories.SelectedItem = null;
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
