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
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.labelSelectStory.Location = new System.Drawing.Point(28, 18);
            this.labelSelectStory.Name = "labelSelectStory";
            this.labelSelectStory.Size = new System.Drawing.Size(147, 16);
            this.labelSelectStory.TabIndex = 0;
            this.labelSelectStory.Text = "Seleccionar Historia";
            // 
            // comboBoxSelectStory
            // 
            this.comboBoxSelectStory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectStory.FormattingEnabled = true;
            this.comboBoxSelectStory.Location = new System.Drawing.Point(181, 17);
            this.comboBoxSelectStory.Name = "comboBoxSelectStory";
            this.comboBoxSelectStory.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectStory.TabIndex = 0;
            // 
            // gbGenerateForIA
            // 
            this.gbGenerateForIA.Controls.Add(this.buttonGenerateStory);
            this.gbGenerateForIA.Controls.Add(this.buttonGenerateImage);
            this.gbGenerateForIA.Controls.Add(this.textBoxGenerateStoryAI);
            this.gbGenerateForIA.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerateForIA.Location = new System.Drawing.Point(31, 47);
            this.gbGenerateForIA.Name = "gbGenerateForIA";
            this.gbGenerateForIA.Size = new System.Drawing.Size(898, 91);
            this.gbGenerateForIA.TabIndex = 1;
            this.gbGenerateForIA.TabStop = false;
            this.gbGenerateForIA.Text = "Generar por IA";
            // 
            // buttonGenerateStory
            // 
            this.buttonGenerateStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateStory.Location = new System.Drawing.Point(145, 59);
            this.buttonGenerateStory.Name = "buttonGenerateStory";
            this.buttonGenerateStory.Size = new System.Drawing.Size(102, 23);
            this.buttonGenerateStory.TabIndex = 2;
            this.buttonGenerateStory.Text = "Generar historia";
            this.buttonGenerateStory.UseVisualStyleBackColor = false;
            // 
            // buttonGenerateImage
            // 
            this.buttonGenerateImage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateImage.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateImage.Location = new System.Drawing.Point(18, 59);
            this.buttonGenerateImage.Name = "buttonGenerateImage";
            this.buttonGenerateImage.Size = new System.Drawing.Size(103, 23);
            this.buttonGenerateImage.TabIndex = 1;
            this.buttonGenerateImage.Text = "Generar imagen";
            this.buttonGenerateImage.UseVisualStyleBackColor = false;
            // 
            // textBoxGenerateStoryAI
            // 
            this.textBoxGenerateStoryAI.Location = new System.Drawing.Point(18, 33);
            this.textBoxGenerateStoryAI.Name = "textBoxGenerateStoryAI";
            this.textBoxGenerateStoryAI.Size = new System.Drawing.Size(807, 21);
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
            this.gbStory.Location = new System.Drawing.Point(36, 157);
            this.gbStory.Name = "gbStory";
            this.gbStory.Size = new System.Drawing.Size(893, 372);
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
            this.gbFragments.Location = new System.Drawing.Point(496, 19);
            this.gbFragments.Name = "gbFragments";
            this.gbFragments.Size = new System.Drawing.Size(380, 338);
            this.gbFragments.TabIndex = 4;
            this.gbFragments.TabStop = false;
            this.gbFragments.Text = "Fragmentos";
            // 
            // listBoxFragmentStory
            // 
            this.listBoxFragmentStory.FormattingEnabled = true;
            this.listBoxFragmentStory.ItemHeight = 15;
            this.listBoxFragmentStory.Location = new System.Drawing.Point(15, 101);
            this.listBoxFragmentStory.Name = "listBoxFragmentStory";
            this.listBoxFragmentStory.Size = new System.Drawing.Size(353, 214);
            this.listBoxFragmentStory.TabIndex = 2;
            // 
            // buttonAddNewFragment
            // 
            this.buttonAddNewFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddNewFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddNewFragment.Location = new System.Drawing.Point(216, 63);
            this.buttonAddNewFragment.Name = "buttonAddNewFragment";
            this.buttonAddNewFragment.Size = new System.Drawing.Size(95, 23);
            this.buttonAddNewFragment.TabIndex = 1;
            this.buttonAddNewFragment.Text = "Añadir nuevo";
            this.buttonAddNewFragment.UseVisualStyleBackColor = false;
            // 
            // textBoxFragmentQuantity
            // 
            this.textBoxFragmentQuantity.Location = new System.Drawing.Point(233, 26);
            this.textBoxFragmentQuantity.Name = "textBoxFragmentQuantity";
            this.textBoxFragmentQuantity.Size = new System.Drawing.Size(63, 21);
            this.textBoxFragmentQuantity.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de fragmentos";
            // 
            // buttonSearchImage
            // 
            this.buttonSearchImage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchImage.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchImage.Location = new System.Drawing.Point(360, 239);
            this.buttonSearchImage.Name = "buttonSearchImage";
            this.buttonSearchImage.Size = new System.Drawing.Size(93, 23);
            this.buttonSearchImage.TabIndex = 2;
            this.buttonSearchImage.Text = "Buscar imagen";
            this.buttonSearchImage.UseVisualStyleBackColor = false;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(13, 299);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(440, 58);
            this.textBoxSummary.TabIndex = 3;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(10, 277);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(56, 15);
            this.labelSummary.TabIndex = 5;
            this.labelSummary.Text = "Resumen";
            // 
            // textBoxImageRoute
            // 
            this.textBoxImageRoute.Location = new System.Drawing.Point(13, 242);
            this.textBoxImageRoute.Name = "textBoxImageRoute";
            this.textBoxImageRoute.Size = new System.Drawing.Size(341, 21);
            this.textBoxImageRoute.TabIndex = 1;
            this.textBoxImageRoute.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta imagen";
            // 
            // pictureBoxStory
            // 
            this.pictureBoxStory.Location = new System.Drawing.Point(13, 61);
            this.pictureBoxStory.Name = "pictureBoxStory";
            this.pictureBoxStory.Size = new System.Drawing.Size(440, 139);
            this.pictureBoxStory.TabIndex = 2;
            this.pictureBoxStory.TabStop = false;
            // 
            // textBoxStoryTitle
            // 
            this.textBoxStoryTitle.Location = new System.Drawing.Point(52, 23);
            this.textBoxStoryTitle.Name = "textBoxStoryTitle";
            this.textBoxStoryTitle.Size = new System.Drawing.Size(401, 21);
            this.textBoxStoryTitle.TabIndex = 0;
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(10, 26);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(37, 15);
            this.labelStoryTitle.TabIndex = 0;
            this.labelStoryTitle.Text = "Titulo";
            // 
            // buttonCreateStory
            // 
            this.buttonCreateStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateStory.Location = new System.Drawing.Point(430, 556);
            this.buttonCreateStory.Name = "buttonCreateStory";
            this.buttonCreateStory.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateStory.TabIndex = 3;
            this.buttonCreateStory.Text = "Crear";
            this.buttonCreateStory.UseVisualStyleBackColor = false;
            // 
            // buttonCancelStory
            // 
            this.buttonCancelStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelStory.Location = new System.Drawing.Point(532, 556);
            this.buttonCancelStory.Name = "buttonCancelStory";
            this.buttonCancelStory.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelStory.TabIndex = 4;
            this.buttonCancelStory.Text = "Cancelar";
            this.buttonCancelStory.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.Location = new System.Drawing.Point(91, 63);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Borrar seleccionado";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // StoryCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(964, 601);
            this.Controls.Add(this.buttonCancelStory);
            this.Controls.Add(this.buttonCreateStory);
            this.Controls.Add(this.gbStory);
            this.Controls.Add(this.gbGenerateForIA);
            this.Controls.Add(this.comboBoxSelectStory);
            this.Controls.Add(this.labelSelectStory);
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