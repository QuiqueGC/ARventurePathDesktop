using ARventure_Path.Models;
using ARventure_Path.Utils;
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
        private MyUtils.FormType formType;

        public HappeningTextForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
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

                    string msg = HappeningOrm.Insert(happening);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El evento se ha guardado correctamente.", "Éxito!");
                        Close();
                    }
                }
                else if (textBoxName.Text == "")
                {
                    MessageBox.Show("No has introducido nombre de evento.", "Error");

                }
                else if (comboBoxStories.SelectedItem == null)
                {
                    MessageBox.Show("No has escogido la historia a la que pertenece.", "Error");

                }
                else if (textBoxContent.Text == "")
                {
                    MessageBox.Show("No has escrito nada en el contenido.", "Error");
                }
            }

            else if (formType == MyUtils.FormType.Modify)
            {
                // Modificar Evento de texto
                happening happening = (happening)comboBoxHappenings.SelectedItem;

                if (happening != null
                    && textBoxName.Text.Trim() != "" &&
                                textBoxContent.Text.Trim() != "" &&
                                comboBoxStories.SelectedItem != null)
                {
                    happening.name = textBoxName.Text.Trim();
                    happening.text = textBoxContent.Text.Trim();
                    happening.type = "text";
                    happening.idStory = (int)comboBoxStories.SelectedValue;

                    string msg = Orm.Update();
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El evento se ha modificado correctamente.", "Éxito!");
                        Close();
                    }
                }
                else if (textBoxName.Text == "")
                {
                    MessageBox.Show("No has introducido nombre de evento.", "Error");

                }
                else if (comboBoxStories.SelectedItem == null)
                {
                    MessageBox.Show("No has escogido la historia a la que pertenece.", "Error");

                }
                else if (textBoxContent.Text == "")
                {
                    MessageBox.Show("No has escrito nada en el contenido.", "Error");
                }

            }
            else if (formType == MyUtils.FormType.Delete)
            {
                // Borrar Evento de texto
                happening happening = (happening)comboBoxHappenings.SelectedItem;
                if (happening != null)
                {
                    string msg = HappeningOrm.Delete(happening);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El evento se ha eliminado correctamente.", "Éxito!");
                        Close();
                    }
                }
            }               
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HappeningTextForm_Load(object sender, EventArgs e)
        {
            ChooseTypeOfForm();
            bindingSourceStory.DataSource = StoryOrm.Select();
            comboBoxStories.SelectedItem = null;
        }

        private void ChooseTypeOfForm()
        {

            if (formType == MyUtils.FormType.Create)
            {
                becomeInCreatonForm();
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                becomeInModifyForm();

            }
            else
            {
                becomeInDeleteForm();
            }
    }

        private void becomeInDeleteForm()
        {
            buttonCreate.Text = "Borrar";
            bindingSourceHappenings.DataSource = HappeningOrm.Select("text");
            comboBoxHappenings.SelectedItem= null;
            comboBoxStories.Enabled = false;
            Text = "Borrar evento de texto";
            groupboxIA.Enabled = false;
            groupboxTxtHappening.Enabled = false;
        }

        private void becomeInModifyForm()
        {
            buttonCreate.Text = "Guardar";
            bindingSourceHappenings.DataSource = HappeningOrm.Select("text");
            comboBoxHappenings.SelectedItem = null;
            comboBoxStories.Enabled = false;
            groupboxIA.Enabled = false;
            groupboxTxtHappening.Enabled = false;
            Text = "Modificar evento de texto";
        }

        private void becomeInCreatonForm()
        {
            labelSelectHappening.Visible = false;
            comboBoxHappenings.Visible = false;
        }

        private void comboBoxHappenings_SelectedIndexChanged(object sender, EventArgs e)
        {

            happening happening = (happening)comboBoxHappenings.SelectedItem;
            if(happening != null && formType == MyUtils.FormType.Modify)
            {
                comboBoxStories.Enabled = true;
                groupboxIA.Enabled = true;
                groupboxTxtHappening.Enabled = true;
                comboBoxStories.SelectedItem = happening.story;
                textBoxName.Text = happening.name;
                textBoxContent.Text = happening.text;
            }
           

        }
    }
}
