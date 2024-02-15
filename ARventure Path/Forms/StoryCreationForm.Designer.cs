namespace ARventure_Path.Forms
{
    partial class StoryCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSelectStory = new System.Windows.Forms.Label();
            this.comboBoxSelectStory = new System.Windows.Forms.ComboBox();
            this.gbGenerateForIA = new System.Windows.Forms.GroupBox();
            this.buttonGenerateStory = new System.Windows.Forms.Button();
            this.buttonGenerateImage = new System.Windows.Forms.Button();
            this.textBoxGenerateStoryAI = new System.Windows.Forms.TextBox();
            this.gbStory = new System.Windows.Forms.GroupBox();
            this.gbFragments = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxFragmentStory = new System.Windows.Forms.ListBox();
            this.buttonAddNewFragment = new System.Windows.Forms.Button();
            this.textBoxFragmentQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchImage = new System.Windows.Forms.Button();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.textBoxImageRoute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxStory = new System.Windows.Forms.PictureBox();
            this.textBoxStoryTitle = new System.Windows.Forms.TextBox();
            this.labelStoryTitle = new System.Windows.Forms.Label();
            this.buttonCreateStory = new System.Windows.Forms.Button();
            this.buttonCancelStory = new System.Windows.Forms.Button();
            this.gbGenerateForIA.SuspendLayout();
            this.gbStory.SuspendLayout();
            this.gbFragments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectStory
            // 
            this.labelSelectStory.AutoSize = true;
            this.labelSelectStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectStory.Location = new System.Drawing.Point(56, 35);
            this.labelSelectStory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSelectStory.Name = "labelSelectStory";
            this.labelSelectStory.Size = new System.Drawing.Size(277, 31);
            this.labelSelectStory.TabIndex = 0;
            this.labelSelectStory.Text = "Seleccionar Historia";
            // 
            // comboBoxSelectStory
            // 
            this.comboBoxSelectStory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectStory.FormattingEnabled = true;
            this.comboBoxSelectStory.Location = new System.Drawing.Point(362, 33);
            this.comboBoxSelectStory.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSelectStory.Name = "comboBoxSelectStory";
            this.comboBoxSelectStory.Size = new System.Drawing.Size(486, 33);
            this.comboBoxSelectStory.TabIndex = 0;
            // 
            // gbGenerateForIA
            // 
            this.gbGenerateForIA.Controls.Add(this.buttonGenerateStory);
            this.gbGenerateForIA.Controls.Add(this.buttonGenerateImage);
            this.gbGenerateForIA.Controls.Add(this.textBoxGenerateStoryAI);
            this.gbGenerateForIA.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerateForIA.Location = new System.Drawing.Point(62, 90);
            this.gbGenerateForIA.Margin = new System.Windows.Forms.Padding(6);
            this.gbGenerateForIA.Name = "gbGenerateForIA";
            this.gbGenerateForIA.Padding = new System.Windows.Forms.Padding(6);
            this.gbGenerateForIA.Size = new System.Drawing.Size(1796, 175);
            this.gbGenerateForIA.TabIndex = 1;
            this.gbGenerateForIA.TabStop = false;
            this.gbGenerateForIA.Text = "Generar por IA";
            // 
            // buttonGenerateStory
            // 
            this.buttonGenerateStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateStory.Location = new System.Drawing.Point(290, 113);
            this.buttonGenerateStory.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGenerateStory.Name = "buttonGenerateStory";
            this.buttonGenerateStory.Size = new System.Drawing.Size(204, 44);
            this.buttonGenerateStory.TabIndex = 2;
            this.buttonGenerateStory.Text = "Generar historia";
            this.buttonGenerateStory.UseVisualStyleBackColor = false;
            // 
            // buttonGenerateImage
            // 
            this.buttonGenerateImage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateImage.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateImage.Location = new System.Drawing.Point(36, 113);
            this.buttonGenerateImage.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGenerateImage.Name = "buttonGenerateImage";
            this.buttonGenerateImage.Size = new System.Drawing.Size(206, 44);
            this.buttonGenerateImage.TabIndex = 1;
            this.buttonGenerateImage.Text = "Generar imagen";
            this.buttonGenerateImage.UseVisualStyleBackColor = false;
            // 
            // textBoxGenerateStoryAI
            // 
            this.textBoxGenerateStoryAI.Location = new System.Drawing.Point(36, 63);
            this.textBoxGenerateStoryAI.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxGenerateStoryAI.Name = "textBoxGenerateStoryAI";
            this.textBoxGenerateStoryAI.Size = new System.Drawing.Size(1610, 34);
            this.textBoxGenerateStoryAI.TabIndex = 0;
            // 
            // gbStory
            // 
            this.gbStory.Controls.Add(this.gbFragments);
            this.gbStory.Controls.Add(this.buttonSearchImage);
            this.gbStory.Controls.Add(this.textBoxSummary);
            this.gbStory.Controls.Add(this.labelSummary);
            this.gbStory.Controls.Add(this.textBoxImageRoute);
            this.gbStory.Controls.Add(this.label1);
            this.gbStory.Controls.Add(this.pictureBoxStory);
            this.gbStory.Controls.Add(this.textBoxStoryTitle);
            this.gbStory.Controls.Add(this.labelStoryTitle);
            this.gbStory.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStory.Location = new System.Drawing.Point(72, 302);
            this.gbStory.Margin = new System.Windows.Forms.Padding(6);
            this.gbStory.Name = "gbStory";
            this.gbStory.Padding = new System.Windows.Forms.Padding(6);
            this.gbStory.Size = new System.Drawing.Size(1786, 715);
            this.gbStory.TabIndex = 2;
            this.gbStory.TabStop = false;
            this.gbStory.Text = "Historia";
            // 
            // gbFragments
            // 
            this.gbFragments.Controls.Add(this.buttonDelete);
            this.gbFragments.Controls.Add(this.listBoxFragmentStory);
            this.gbFragments.Controls.Add(this.buttonAddNewFragment);
            this.gbFragments.Controls.Add(this.textBoxFragmentQuantity);
            this.gbFragments.Controls.Add(this.label2);
            this.gbFragments.Location = new System.Drawing.Point(992, 37);
            this.gbFragments.Margin = new System.Windows.Forms.Padding(6);
            this.gbFragments.Name = "gbFragments";
            this.gbFragments.Padding = new System.Windows.Forms.Padding(6);
            this.gbFragments.Size = new System.Drawing.Size(760, 650);
            this.gbFragments.TabIndex = 4;
            this.gbFragments.TabStop = false;
            this.gbFragments.Text = "Fragmentos";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.Location = new System.Drawing.Point(182, 121);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(190, 44);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Borrar seleccionado";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxFragmentStory
            // 
            this.listBoxFragmentStory.FormattingEnabled = true;
            this.listBoxFragmentStory.ItemHeight = 27;
            this.listBoxFragmentStory.Location = new System.Drawing.Point(30, 194);
            this.listBoxFragmentStory.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxFragmentStory.Name = "listBoxFragmentStory";
            this.listBoxFragmentStory.Size = new System.Drawing.Size(702, 382);
            this.listBoxFragmentStory.TabIndex = 2;
            // 
            // buttonAddNewFragment
            // 
            this.buttonAddNewFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddNewFragment.Enabled = false;
            this.buttonAddNewFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddNewFragment.Location = new System.Drawing.Point(432, 121);
            this.buttonAddNewFragment.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddNewFragment.Name = "buttonAddNewFragment";
            this.buttonAddNewFragment.Size = new System.Drawing.Size(190, 44);
            this.buttonAddNewFragment.TabIndex = 1;
            this.buttonAddNewFragment.Text = "Añadir nuevo";
            this.buttonAddNewFragment.UseVisualStyleBackColor = false;
            this.buttonAddNewFragment.Click += new System.EventHandler(this.buttonAddNewFragment_Click);
            // 
            // textBoxFragmentQuantity
            // 
            this.textBoxFragmentQuantity.Location = new System.Drawing.Point(466, 50);
            this.textBoxFragmentQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFragmentQuantity.Name = "textBoxFragmentQuantity";
            this.textBoxFragmentQuantity.Size = new System.Drawing.Size(122, 34);
            this.textBoxFragmentQuantity.TabIndex = 0;
            this.textBoxFragmentQuantity.TextChanged += new System.EventHandler(this.textBoxFragmentQuantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de fragmentos";
            // 
            // buttonSearchImage
            // 
            this.buttonSearchImage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchImage.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchImage.Location = new System.Drawing.Point(720, 460);
            this.buttonSearchImage.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSearchImage.Name = "buttonSearchImage";
            this.buttonSearchImage.Size = new System.Drawing.Size(186, 44);
            this.buttonSearchImage.TabIndex = 2;
            this.buttonSearchImage.Text = "Buscar imagen";
            this.buttonSearchImage.UseVisualStyleBackColor = false;
            this.buttonSearchImage.Click += new System.EventHandler(this.buttonSearchImage_Click);
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(26, 575);
            this.textBoxSummary.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(876, 108);
            this.textBoxSummary.TabIndex = 3;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(20, 533);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(106, 27);
            this.labelSummary.TabIndex = 5;
            this.labelSummary.Text = "Resumen";
            // 
            // textBoxImageRoute
            // 
            this.textBoxImageRoute.Enabled = false;
            this.textBoxImageRoute.Location = new System.Drawing.Point(26, 465);
            this.textBoxImageRoute.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxImageRoute.Name = "textBoxImageRoute";
            this.textBoxImageRoute.Size = new System.Drawing.Size(678, 34);
            this.textBoxImageRoute.TabIndex = 1;
            this.textBoxImageRoute.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta imagen";
            // 
            // pictureBoxStory
            // 
            this.pictureBoxStory.Location = new System.Drawing.Point(26, 96);
            this.pictureBoxStory.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxStory.Name = "pictureBoxStory";
            this.pictureBoxStory.Size = new System.Drawing.Size(880, 319);
            this.pictureBoxStory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStory.TabIndex = 2;
            this.pictureBoxStory.TabStop = false;
            // 
            // textBoxStoryTitle
            // 
            this.textBoxStoryTitle.Location = new System.Drawing.Point(104, 44);
            this.textBoxStoryTitle.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxStoryTitle.Name = "textBoxStoryTitle";
            this.textBoxStoryTitle.Size = new System.Drawing.Size(798, 34);
            this.textBoxStoryTitle.TabIndex = 0;
            this.textBoxStoryTitle.TextChanged += new System.EventHandler(this.textBoxStoryTitle_TextChanged);
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(20, 50);
            this.labelStoryTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(74, 27);
            this.labelStoryTitle.TabIndex = 0;
            this.labelStoryTitle.Text = "Titulo";
            // 
            // buttonCreateStory
            // 
            this.buttonCreateStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateStory.Location = new System.Drawing.Point(860, 1069);
            this.buttonCreateStory.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreateStory.Name = "buttonCreateStory";
            this.buttonCreateStory.Size = new System.Drawing.Size(150, 44);
            this.buttonCreateStory.TabIndex = 3;
            this.buttonCreateStory.Text = "Crear";
            this.buttonCreateStory.UseVisualStyleBackColor = false;
            this.buttonCreateStory.Click += new System.EventHandler(this.buttonCreateStory_Click);
            // 
            // buttonCancelStory
            // 
            this.buttonCancelStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelStory.Location = new System.Drawing.Point(1064, 1069);
            this.buttonCancelStory.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancelStory.Name = "buttonCancelStory";
            this.buttonCancelStory.Size = new System.Drawing.Size(150, 44);
            this.buttonCancelStory.TabIndex = 4;
            this.buttonCancelStory.Text = "Cancelar";
            this.buttonCancelStory.UseVisualStyleBackColor = false;
            this.buttonCancelStory.Click += new System.EventHandler(this.buttonCancelStory_Click);
            // 
            // StoryCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1928, 1175);
            this.Controls.Add(this.buttonCancelStory);
            this.Controls.Add(this.buttonCreateStory);
            this.Controls.Add(this.gbStory);
            this.Controls.Add(this.gbGenerateForIA);
            this.Controls.Add(this.comboBoxSelectStory);
            this.Controls.Add(this.labelSelectStory);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StoryCreationForm";
            this.Text = "Creación de historia";
            this.gbGenerateForIA.ResumeLayout(false);
            this.gbGenerateForIA.PerformLayout();
            this.gbStory.ResumeLayout(false);
            this.gbStory.PerformLayout();
            this.gbFragments.ResumeLayout(false);
            this.gbFragments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectStory;
        private System.Windows.Forms.ComboBox comboBoxSelectStory;
        private System.Windows.Forms.GroupBox gbGenerateForIA;
        private System.Windows.Forms.TextBox textBoxGenerateStoryAI;
        private System.Windows.Forms.Button buttonGenerateStory;
        private System.Windows.Forms.Button buttonGenerateImage;
        private System.Windows.Forms.GroupBox gbStory;
        private System.Windows.Forms.Label labelStoryTitle;
        private System.Windows.Forms.TextBox textBoxStoryTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStory;
        private System.Windows.Forms.Button buttonSearchImage;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox textBoxImageRoute;
        private System.Windows.Forms.GroupBox gbFragments;
        private System.Windows.Forms.TextBox textBoxFragmentQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFragmentStory;
        private System.Windows.Forms.Button buttonAddNewFragment;
        private System.Windows.Forms.Button buttonCreateStory;
        private System.Windows.Forms.Button buttonCancelStory;
        private System.Windows.Forms.Button buttonDelete;
    }
}