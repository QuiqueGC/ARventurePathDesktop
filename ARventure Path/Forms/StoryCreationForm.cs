using ARventure_Path.Models;
using ARventure_Path.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ARventure_Path.ChatGPTClient.GPTResponse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARventure_Path.Forms
{
    public partial class StoryCreationForm : Form
    {
        private story story = new story();
        private MyUtils.FormType formType;
        private string fileName = "";
        private BindingList<fragment> fragments = new BindingList<fragment>();

        private string storyImagePath = Path.Combine(Application.StartupPath, "..","..","filesToServer","imgStory");
        public string contentToFragment = "";

        public StoryCreationForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();
        }

        private void buttonCreateStory_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
            {
                CreateStory();
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                ModifyStory();
            }
            else
            {
                DeleteStory();
            }
        }


        /// <summary>
        /// Modifica la historia y hace el update en la base de
        /// </summary>
        private void ModifyStory()
        {
            string msg = "";
            if (textBoxStoryTitle.Text.Trim() != "" &&
               textBoxSummary.Text.Trim() != "" &&
               story.fragment.Count >= 2)
            {
                if (fileName.Length < 50)
                {
                    story.name = textBoxStoryTitle.Text.Trim();
                    story.summary = textBoxSummary.Text.Trim();

                    if (fileName != "")
                    {
                        story.img = fileName;
                    }
                    msg = Orm.Update();
                    MyUtils.ShowPosibleError(msg);
                    bindingSourceStory.DataSource = StoryOrm.Select();
                }
                else
                {
                    MessageBox.Show("El nombre del archivo de imagen es demasiado largo. Debes cambiarlo.", "¡Error!");
                }
            }
            else if (textBoxStoryTitle.Text.Trim() == "") 
            {
                MessageBox.Show("El campo de título está vacío.", "¡Error!");
            }
            else if (textBoxSummary.Text.Trim() == "") 
            {
                MessageBox.Show("El campo de resumen está vacío.", "¡Error!");
            }
            else
            {
                MessageBox.Show("La historia debe tener un mínimo de dos fragmentos.", "¡Error!");
            }
        }


        /// <summary>
        /// borra la historia y la lista de fragmentos
        /// asociados a ella haciendo sus respectivos deletes
        /// </summary>
        private void DeleteStory()
        {
            if (MyUtils.ShowConfirmDialogAndDelete()) 
            {
                if(ArventureOrm.Select(story).Count == 0)
                {

                    DeleteFragments();
                    
                    DeleteHappenings();

                    string msg = StoryOrm.Delete(story);

                    MyUtils.ShowPosibleError(msg);
                    bindingSourceStory.DataSource = StoryOrm.Select();
                    comboBoxSelectStory.SelectedItem = null;
                    bindingSourceFragments.DataSource = null;
                    buttonCreateStory.Enabled = false;
                    CleanForm();
                }
                else
                {
                    MessageBox.Show("No se puede borrar la historia, ya que pertenece a una aventura.", "¡Error!");
                }
            }
        }


        /// <summary>
        /// borra los eventos en la BBDD que 
        /// están relacionados con la historia
        /// </summary>
        private void DeleteHappenings()
        {
            
            int i = story.happening.Count;
            do
            {
                if (story.happening.FirstOrDefault() != null)
                {
                    string msg = HappeningOrm.Delete(story.happening.FirstOrDefault());
                    MyUtils.ShowPosibleError(msg);
                }
                i--;

            } while (i > 0);
        }



        /// <summary>
        /// borra los fragmentos de la historia
        /// </summary>
        private void DeleteFragments()
        {
            int i = story.fragment.Count;

            do
            {
                if (story.fragment.FirstOrDefault() != null) 
                {
                    string msg = FragmentOrm.Delete(story.fragment.FirstOrDefault());
                    MyUtils.ShowPosibleError(msg);
                }
                i--;

            } while (i > 0);
        }


        /// <summary>
        /// Crea la historia y hace el insert pertinente
        /// </summary>
        private void CreateStory()
        {
            if(textBoxStoryTitle.Text.Trim() != "" &&
               textBoxSummary.Text.Trim() != "" &&
               fileName != "" &&
               fragments.Count >= 2 ||
               story.fragment.Count >= 2) 
            {
                if (fileName.Length < 50) 
                {
                    string msg = "";
                    story.name = textBoxStoryTitle.Text.Trim();
                    story.summary = textBoxSummary.Text.Trim();
                    story.img = fileName;
                    msg = StoryOrm.Insert(story);
                    MyUtils.ShowPosibleError(msg);

                    foreach (fragment fragment in fragments)
                    {
                        msg = FragmentOrm.Insert(fragment);
                        MyUtils.ShowPosibleError(msg);
                    }
                    CleanForm();
                }
                else
                {
                    MessageBox.Show("El nombre del archivo de imagen es demasiado largo. Debes cambiarlo.", "¡Error!");
                }
            }
            else if (textBoxStoryTitle.Text.Trim() == "") 
            {
                MessageBox.Show("Debes poner un título en la historia.", "¡Error!");
            }
            else if (textBoxSummary.Text.Trim() == "") 
            {
                MessageBox.Show("Debes poner un resumen en la historia.", "¡Error!");
            }
            else if (fileName == "") 
            {
                MessageBox.Show("Debes asignar una imagen a la historia.", "¡Error!");
            }
            else
            {
                MessageBox.Show("La historia debe tener un mínimo de dos fragmentos.", "¡Error!");
            }
           
        }


        /// <summary>
        /// vacía todos los campos y vuelve
        /// a inicializar los objetos
        /// para volver a crear una nueva historia
        /// </summary>
        private void CleanForm()
        {
            textBoxStoryTitle.Clear();
            textBoxSummary.Clear();
            textBoxGenerateStoryAI.Clear();
            textBoxImageStory.Clear();
            textBoxFragmentQuantity.Clear();
            pictureBoxStory.Image = null;
            story = new story();
            fileName = null;
            fragments.Clear();
            DoSelectFragmentsDependingOnType();
        }

        private void buttonSearchImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(abrir.FileName);
                pictureBoxStory.Image = image;
                string filePath = abrir.FileName;
                textBoxImageStory.Text = filePath;
                fileName = Path.GetFileName(filePath);
                

                SaveImage(image);
            }
        }

        /// <summary>
        /// Guarda la imagen en la carpeta local
        /// </summary>
        /// <param name="fileName"></param>
        ///
        private void SaveImage(Image image)
        {
            // Si la carpeta no existe, la crea
            if (!Directory.Exists(storyImagePath))
            {
                Directory.CreateDirectory(storyImagePath);
            }
            string destinationPath = Path.Combine(storyImagePath, fileName);
            try
            {
                image.Save(destinationPath, ImageFormat.Png);
              
            }
            catch (ExternalException ex)
            {
                MessageBox.Show("Ya existe una imagen con ese nombre. Cámbiaselo o escoge otra, que seguro que tienes más.", "Error!");
                if(formType == MyUtils.FormType.Create)
                {
                    textBoxImageStory.Text = "";
                    pictureBoxStory.Image = null;
                }
                else
                {
                    textBoxImageStory.Text = Path.Combine(storyImagePath, story.img);
                    var savedImage = Image.FromFile(Path.Combine(storyImagePath, story.img));
                    pictureBoxStory.Image = savedImage;
                }
                
            }
        }

        private void buttonAddNewFragment_Click(object sender, EventArgs e)
        {
                FragmentCreationForm fragmentCreationForm = new FragmentCreationForm(this);
                fragmentCreationForm.ShowDialog();

                if(contentToFragment != "")
                {
                    fragment newFragment = CreateFragment();

                    if (formType == MyUtils.FormType.Create)
                    {
                        fragments.Add(newFragment);
                        DoSelectFragmentsDependingOnType();
                        contentToFragment = "";
                        textBoxFragmentQuantity.Text = fragments.Count.ToString();
                    }
                    else
                    {
                        string msg = FragmentOrm.Insert(newFragment);
                        MyUtils.ShowPosibleError(msg);
                        DoSelectFragmentsDependingOnType();
                        contentToFragment = "";
                        textBoxFragmentQuantity.Text = story.fragment.Count.ToString();
                    }
            }
        }

        private fragment CreateFragment()
        {
            fragment newFragment = new fragment()
            {
                story = story,
                content = contentToFragment,
                ordinal = formType == MyUtils.FormType.Create ?
                    fragments.Count + 1 : story.fragment.Count + 1,

            };

            return newFragment;
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewFragments.SelectedRows.Count > 0)
            {
                if (formType == MyUtils.FormType.Create)
                {
                    if(fragments.Count > 2)
                    {
                        fragments.Remove((fragment)dataGridViewFragments.SelectedRows[0].DataBoundItem);
                        ReorderingFragments();
                        DoSelectFragmentsDependingOnType();
                        textBoxFragmentQuantity.Text = fragments.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No puede haber menos de dos fragmentos en una historia.", "Error!");
                    }
                    
                }
                else
                {
                    if (story.fragment.Count > 2)
                    {
                        string msg = FragmentOrm.Delete((fragment)dataGridViewFragments.SelectedRows[0].DataBoundItem);
                        MyUtils.ShowPosibleError(msg);
                        ReorderingFragmentsOfStory();
                        DoSelectFragmentsDependingOnType();
                        textBoxFragmentQuantity.Text = story.fragment.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No puede haber menos de dos fragmentos en una historia.", "Error!");
                    }
                }
            }
        }


        /// <summary>
        /// Reordena los ordinales de los fragmentos (en caso de ser form de creación)
        /// tras el borrado de uno de ellos
        /// </summary>
        /// <param name="fragmentsToOrder"></param>
        private void ReorderingFragments()
        {
            for (int i = 0; i < fragments.Count; i++)
            {
                fragments[i].ordinal = i+1;
            }
            string msg = Orm.Update();
            MyUtils.ShowPosibleError(msg);
        }

        /// <summary>
        /// Reordena los ordinales de los fragmentos
        /// (en caso de ser form de modificación o borrado)
        /// tras el borrado de uno de ellos
        /// </summary>
        /// <param name="fragmentsToOrder"></param>
        private void ReorderingFragmentsOfStory()
        {
            int ordinalToPut = 1;
            foreach(fragment fragmentToOrder in story.fragment)
            {
                fragmentToOrder.ordinal = ordinalToPut;
                ordinalToPut++;
            }
            string msg = Orm.Update();
            MyUtils.ShowPosibleError(msg);
        }

        private void buttonCancelStory_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "¡No abandones!",
                buttons);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void StoryCreationForm_Load(object sender, EventArgs e)
        {
            ChooseTypeOfForm();
            comboBoxSelectStory.SelectedItem = null;
        }

        /// <summary>
        /// Escoge el tipo de form que será (creación/modificación/borrado)
        /// en base al enum que se le haya pasado por parámetros al form
        /// </summary>
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

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de borrado
        /// </summary>
        private void becomeInDeleteForm()
        {
            buttonCreateStory.Text = "Borrar";
            buttonCreateStory.Enabled = false;
            bindingSourceStory.DataSource = StoryOrm.Select();
            gbGenerateForIA.Enabled = false;
            gbStory.Enabled = false;
            DoSelectFragmentsDependingOnType();
        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de modificación
        /// </summary>
        private void becomeInModifyForm()
        {
            buttonCreateStory.Text = "Guardar";
            buttonCreateStory.Enabled = false;
            bindingSourceStory.DataSource = StoryOrm.Select();
            DoSelectFragmentsDependingOnType();
        }

        /// <summary>
        /// realiza los cambios pertinentes
        /// en el formularion para el formato de creación
        /// </summary>
        private void becomeInCreatonForm()
        {
            labelSelectStory.Visible = false;
            comboBoxSelectStory.Visible = false;
            DoSelectFragmentsDependingOnType();
        }

        private void comboBoxSelectStory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectStory.SelectedItem != null)
            {
                buttonCreateStory.Enabled = true;
                story = (story)comboBoxSelectStory.SelectedItem;
                textBoxStoryTitle.Text = story.name;
                textBoxSummary.Text = story.summary;
                textBoxFragmentQuantity.Text = story.fragment.Count.ToString();
                textBoxImageStory.Text = Path.Combine(storyImagePath, story.img);
                var image = Image.FromFile(Path.Combine(storyImagePath, story.img));
                pictureBoxStory.Image = image;


                DoSelectFragmentsDependingOnType();
            }
        }


        /// <summary>
        /// Escoge si va a hacer un select el la BBDD
        /// en caso de que sea modificación o borrado.
        /// En caso con
        /// </summary>
        private void DoSelectFragmentsDependingOnType()
        {
            if (formType == MyUtils.FormType.Create)
            {
                bindingSourceFragments.DataSource = null;
                bindingSourceFragments.DataSource = fragments;
            }
            else
            {
                bindingSourceFragments.DataSource = null;
                bindingSourceFragments.DataSource = FragmentOrm.Select(story);
            }
        }

        private void textBoxFragmentsIA_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxFragmentsIA.Text,out int parsedNum) && textBoxFragmentsIA.Text != "")
            {
                textBoxFragmentsIA.Clear();
                MessageBox.Show("Sólo puedes introducir números en esta celda.", "Error!");
            }
        }

        private void dataGridViewFragments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonDelete.PerformClick();
            }
        }

        private void buttonGenerateStory_Click(object sender, EventArgs e)
        {
            string keywords = textBoxGenerateStoryAI.Text;
            int fragmentQuantity = int.Parse(textBoxFragmentsIA.Text);
            

            string response = ChatGPTClient.MakeRequest(keywords);

            string[] splitResponse = response.Split('\n');
            string title = splitResponse[0].Split(':')[1].Replace('"', ' ').Trim();
            string summary = splitResponse[2];
            List<string> responseFragments = ChatGPTClient.generateFragments(title,fragmentQuantity);
            /*int fragmentStartIndex = 7;
            for (int i = 0; i < fragmentQuantity; i++)
            {
                responseFragments.Add(splitResponse[fragmentStartIndex].Split(':')[1].Trim());
                fragmentStartIndex += 2;
            }*/

            textBoxStoryTitle.Text = title;
            textBoxSummary.Text = summary;
            
            foreach (string fragment in responseFragments)
            {
               
                fragments.Add(new fragment()
                {
                    story = story,
                    content = fragment,
                    ordinal = formType == MyUtils.FormType.Create ?
                    fragments.Count + 1 : story.fragment.Count + 1,
                });
            }
        }

        private void btnModifyFragment_Click(object sender, EventArgs e)
        {
            if (dataGridViewFragments.SelectedRows.Count > 0)
            {
                FragmentCreationForm fragmentCreationForm =
                    new FragmentCreationForm((fragment)dataGridViewFragments.SelectedRows[0].DataBoundItem);
                fragmentCreationForm.ShowDialog();

                DoSelectFragmentsDependingOnType();
            }
        }
    }
}
