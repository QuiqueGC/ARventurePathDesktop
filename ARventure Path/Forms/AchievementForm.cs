using ARventure_Path.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class AchievementForm : Form
    {
        achievement achievement = new achievement();
        bool isCreation;
        string fileName;

        private string AchievementImagePath = Path.Combine(Application.StartupPath, "..", "..", "filesToServer", "imgAchievement");

        public AchievementForm(bool isCreation)
        {
            InitializeComponent();
            this.isCreation = isCreation;

            if (isCreation)
            {
                buttonAcceptAchievement.Text = "Guardar";
            }
            else 
            {
                buttonAcceptAchievement.Text = "Borrar";
            }
            
        }

        private void buttonAcceptAchievement_Click(object sender, EventArgs e)
        {

            if (isCreation)
            {
                achievement.name = textBoxNameAchievement.Text;
                achievement.img = fileName;

                AchievementOrm.Insert(achievement);

            }
            else
            {
                //eliminar un logro

            }

        }

        private void buttonSearchImageAchievement_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(abrir.FileName);
                /*pictureBoxAchievement.Image = image;
                textBoxImageAchievement.Text = abrir.FileName;
                SaveImage(image);*/
                pictureBoxAchievement.Image = image;
                string filePath = abrir.FileName;
                textBoxImageAchievement.Text = filePath;
                fileName = Path.GetFileName(filePath);
                MessageBox.Show(fileName);

                SaveImage(image);
            }

        }
        private void SaveImage(Image image)
        {
            // Si la carpeta no existe, la crea
            if (!Directory.Exists(AchievementImagePath))
            {
                Directory.CreateDirectory(AchievementImagePath);
            }
            String destinationPath = Path.Combine(AchievementImagePath, fileName);
            image.Save(destinationPath, ImageFormat.Png);
            achievement.img = destinationPath;

        }

        private void buttonCancelAchievement_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AchievementForm_Load_1(object sender, EventArgs e)
        {
            hideAchievementSelection();
            bindingSourceAchievement.DataSource = AchievementOrm.Select();
            comboBoxSelectAchievement.DisplayMember = "name";
        }

        private void hideAchievementSelection()
        {
            if (isCreation)
            {
                labelSelectAchievement.Visible = false;
                comboBoxSelectAchievement.Visible = false;
            }
        }

        private void comboBoxSelectAchievement_SelectedIndexChanged(object sender, EventArgs e)
        {
            achievement achievement = (achievement)comboBoxSelectAchievement.SelectedItem;
            textBoxNameAchievement.Text = achievement.name;
            textBoxImageAchievement.Text = achievement.img;

            string imagePath = Path.Combine(AchievementImagePath, achievement.img);
            var image = Image.FromFile(imagePath);
            pictureBoxAchievement.Image = image;
        }
    }
}
