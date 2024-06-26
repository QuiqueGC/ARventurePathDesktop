﻿using ARventure_Path.Models;
using ARventure_Path.Utils;
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
        string fileName;
        private MyUtils.FormType formType;


        private string AchievementImagePath = Path.Combine(Application.StartupPath, "..", "..", "filesToServer", "imgAchievement");

        public AchievementForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();

        }

        private void buttonAcceptAchievement_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
            {
                // Crear Logro
                string msg = "";

                if (textBoxNameAchievement.Text.Trim() != null && fileName != null)
                {
                    achievement.name = textBoxNameAchievement.Text.Trim();
                    achievement.img = fileName;

                    msg = AchievementOrm.Insert(achievement);
                    MyUtils.ShowPosibleError(msg);

                    this.Close();

                }
                else 
                {
                    MessageBox.Show("Tienes que escribir el nombre del logro", "" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                // Borrar Logro
                string msg = "";

                if (comboBoxSelectAchievement.SelectedItem != null)
                {
                    
                    achievement = (achievement)comboBoxSelectAchievement.SelectedItem;
                    achievement.name = textBoxNameAchievement.Text;
                    achievement.img = fileName;

                    msg = AchievementOrm.Delete(achievement);
                    MyUtils.ShowPosibleError(msg);

                    this.Close();

                }
                else 
                {
                    MessageBox.Show("Tienes que seleccionar un logro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
            ChooseTypeOfForm();
        }

        private void comboBoxSelectAchievement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectAchievement.SelectedItem != null)
            {
                achievement = (achievement)comboBoxSelectAchievement.SelectedItem;
                textBoxNameAchievement.Text = achievement.name;
                textBoxImageAchievement.Text = achievement.img;

                string imagePath = Path.Combine(AchievementImagePath, achievement.img);
                var image = Image.FromFile(imagePath);
                pictureBoxAchievement.Image = image;

                buttonAcceptAchievement.Enabled = true;

            }
            

        }
        private void ChooseTypeOfForm()
        {

            if (formType == MyUtils.FormType.Create)
            {
                becomeInCreatonForm();
            }
            else
            {
                becomeInDeleteForm();

            }
        }

        private void becomeInDeleteForm()
        {
            buttonAcceptAchievement.Text = "Borrar";
            bindingSourceAchievement.DataSource = AchievementOrm.Select();
            comboBoxSelectAchievement.SelectedItem = null;
            textBoxNameAchievement.Enabled = false;
            textBoxImageAchievement.Enabled = false;
            buttonSearchImageAchievement.Visible = false;
            buttonAcceptAchievement.Enabled = false;
        }
        private void becomeInCreatonForm()
        {
            labelSelectAchievement.Visible = false;
            comboBoxSelectAchievement.Visible = false;
        }
    }
}
