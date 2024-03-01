using ARventure_Path.Models;
using ARventure_Path.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class HappeningImageForm : Form
    {
        private string imgPath = Path.Combine(Application.StartupPath, "..", "..", "filesToServer", "imgHappening");
        private static Image image;
        private string fileName;
        private string filePath;
        private MyUtils.FormType formType;

        public HappeningImageForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
            if (formType == MyUtils.FormType.Create)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image = Image.FromFile(openFileDialog.FileName);

                    imgHappening.Image = image;
                    string filePath = openFileDialog.FileName;
                    textBoxUrl.Text = filePath;

                    fileName = Path.GetFileName(filePath);
                }
            }else if(formType == MyUtils.FormType.Modify)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image.Dispose();
                    image = Image.FromFile(openFileDialog.FileName);
                    imgHappening.Image = image;
                    filePath = openFileDialog.FileName;
                    if(Path.GetFileName(filePath) != fileName)
                    {
                        deleteImage();
                    }
                    textBoxUrl.Text = filePath;

                    fileName = Path.GetFileName(filePath);
                }
            }
            
        }

        private void comboBoxHappenings_SelectedIndexChanged(object sender, EventArgs e)
        {
            happening happening = (happening)comboBoxHappenings.SelectedItem;
            if (happening != null)
            {
                if(formType == MyUtils.FormType.Modify)
                {
                    comboBoxStories.Enabled = true;
                    groupboxIA.Enabled = true;
                    groupboxImgHappening.Enabled = true;
                }
                buttonCreate.Enabled = true;
                comboBoxStories.SelectedItem = happening.story;
                textBoxName.Text = happening.name;
                fileName = happening.url;
                filePath = Path.Combine(imgPath, fileName);

                textBoxUrl.Text = filePath;
                image = Image.FromFile(filePath);

                imgHappening.Image = image;
            }
        }

        private void SaveImage()
        {
            // Si la carpeta no existe, la crea
            if (!Directory.Exists(imgPath))
            {
                Directory.CreateDirectory(imgPath);
            }
            String destinationPath = Path.Combine(imgPath, fileName);
            image.Save(destinationPath, ImageFormat.Png);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
            {
                if (textBoxName.Text.Trim() != "" &&
                    fileName != null &&
                    comboBoxStories.SelectedItem != null)
                {
                    happening happening = new happening();
                    happening.name = textBoxName.Text.Trim();
                    happening.url = fileName;
                    happening.type = "image";
                    happening.idStory = (int)comboBoxStories.SelectedValue;
                    SaveImage();

                    // Crear Evento de imagen
                    String msg = HappeningOrm.Insert(happening);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Evento creado satisfactoriamente.", "Éxito!");
                        Close();
                    }
                }
                else if (textBoxName.Text.Trim() == "")
                {
                    MessageBox.Show("No has introducido nombre de evento.", "Error");

                }
                else if (comboBoxStories.SelectedItem == null)
                {
                    MessageBox.Show("No has escogido la historia a la que pertenece.", "Error");

                }
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                // Modificar Evento de imagen
                happening happening = (happening)comboBoxHappenings.SelectedItem;

                if (happening != null
                    && textBoxName.Text.Trim() != "" &&
                    fileName != null &&
                    comboBoxStories.SelectedItem != null)
                {
                    if (happening.url != fileName)
                    {
                        SaveImage();
                    }
                    happening.name = textBoxName.Text.Trim();
                    happening.url = fileName;
                    happening.type = "image";
                    happening.idStory = (int)comboBoxStories.SelectedValue;
                    
                    

                    string msg = Orm.Update();
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Evento modificado satisfactoriamente.", "Éxito!");
                        Close();
                    }
                }
                else if (textBoxName.Text.Trim() == "")
                {
                    MessageBox.Show("No has introducido nombre de evento.", "Error");

                }
                else if (comboBoxStories.SelectedItem == null)
                {
                    MessageBox.Show("No has escogido la historia a la que pertenece.", "Error");

                }
            }
            else
            {
                // Borrar Evento de imagen
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
                        image.Dispose();
                        deleteImage();
                        Close();
                    }
                }
            }
        }

        private void deleteImage()
        {
            String destinationPath = Path.Combine(imgPath, fileName);
            if (File.Exists(destinationPath))
            {
                try
                {
                    File.Delete(destinationPath);
                } catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el archivo: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe en la ruta especificada.", "Error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HappeningImageForm_Load(object sender, EventArgs e)
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
            bindingSourceHappenings.DataSource = HappeningOrm.Select("image");
            comboBoxHappenings.SelectedItem = null;
            comboBoxStories.Enabled = false;
            groupboxIA.Enabled = false;
            groupboxImgHappening.Enabled = false;
            Text = "Borrar evento de imagen";
        }

        private void becomeInModifyForm()
        {
            buttonCreate.Text = "Guardar";
            bindingSourceHappenings.DataSource = HappeningOrm.Select("image");
            comboBoxHappenings.SelectedItem = null;
            comboBoxStories.Enabled = false;
            groupboxIA.Enabled = false;
            groupboxImgHappening.Enabled = false;
            Text = "Modificar evento de imagen";
        }

        private void becomeInCreatonForm()
        {
            labelSelectHappening.Visible = false;
            comboBoxHappenings.Visible = false;
            buttonCreate.Enabled = true;
        }

    }
}