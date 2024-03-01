﻿using ARventure_Path.Models;
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
    public partial class ARventureCreationForm : Form
    {
        private MyUtils.FormType formType;
        public ARventureCreationForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();
        }

        private void ARventureCreationForm_Load(object sender, EventArgs e)
        {
            ChooseTypeOfForm();
            bindingSourceStory.DataSource = StoryOrm.Select();
            //bindingSourceRoute.DataSource = RouteOrm.Select();
        }

        private void buttonCancelArventure_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void buttonCreateArventure_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
            {
                // Crear ARventure
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                // Modificar ARventure
            }
            else
            {
                // Borrar ARventure
            }
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
            buttonCreateArventure.Text = "Borrar";
            bindingSourceArventure.DataSource = ArventureOrm.Select();
            comboBoxSelectArventure.SelectedItem = null;
        }

        private void becomeInModifyForm()
        {
            buttonCreateArventure.Text = "Guardar";
            bindingSourceArventure.DataSource = ArventureOrm.Select();
            comboBoxSelectArventure.SelectedItem = null;
        }

        private void becomeInCreatonForm()
        {
            labelSelectArventure.Visible = false;
            comboBoxSelectArventure.Visible = false;
        }

        private void listBoxStories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
