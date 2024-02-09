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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGenerateStory = new System.Windows.Forms.Button();
            this.buttonGenerateImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddFragment = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectStory
            // 
            this.labelSelectStory.AutoSize = true;
            this.labelSelectStory.Location = new System.Drawing.Point(28, 18);
            this.labelSelectStory.Name = "labelSelectStory";
            this.labelSelectStory.Size = new System.Drawing.Size(101, 13);
            this.labelSelectStory.TabIndex = 0;
            this.labelSelectStory.Text = "Seleccionar Historia";
            // 
            // comboBoxSelectStory
            // 
            this.comboBoxSelectStory.FormattingEnabled = true;
            this.comboBoxSelectStory.Location = new System.Drawing.Point(149, 15);
            this.comboBoxSelectStory.Name = "comboBoxSelectStory";
            this.comboBoxSelectStory.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectStory.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenerateStory);
            this.groupBox1.Controls.Add(this.buttonGenerateImage);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(31, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar por IA";
            // 
            // buttonGenerateStory
            // 
            this.buttonGenerateStory.Location = new System.Drawing.Point(145, 59);
            this.buttonGenerateStory.Name = "buttonGenerateStory";
            this.buttonGenerateStory.Size = new System.Drawing.Size(102, 23);
            this.buttonGenerateStory.TabIndex = 2;
            this.buttonGenerateStory.Text = "Generar historia";
            this.buttonGenerateStory.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateImage
            // 
            this.buttonGenerateImage.Location = new System.Drawing.Point(18, 59);
            this.buttonGenerateImage.Name = "buttonGenerateImage";
            this.buttonGenerateImage.Size = new System.Drawing.Size(103, 23);
            this.buttonGenerateImage.TabIndex = 1;
            this.buttonGenerateImage.Text = "Generar imagen";
            this.buttonGenerateImage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(807, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonSearchImage);
            this.groupBox2.Controls.Add(this.textBoxSummary);
            this.groupBox2.Controls.Add(this.labelSummary);
            this.groupBox2.Controls.Add(this.textBoxImageRoute);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBoxStory);
            this.groupBox2.Controls.Add(this.textBoxStoryTitle);
            this.groupBox2.Controls.Add(this.labelStoryTitle);
            this.groupBox2.Location = new System.Drawing.Point(36, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 372);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.buttonAddFragment);
            this.groupBox3.Controls.Add(this.textBoxFragmentQuantity);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(496, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 338);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fragmentos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 225);
            this.listBox1.TabIndex = 3;
            // 
            // buttonAddFragment
            // 
            this.buttonAddFragment.Location = new System.Drawing.Point(152, 59);
            this.buttonAddFragment.Name = "buttonAddFragment";
            this.buttonAddFragment.Size = new System.Drawing.Size(95, 23);
            this.buttonAddFragment.TabIndex = 2;
            this.buttonAddFragment.Text = "Añadir nuevo";
            this.buttonAddFragment.UseVisualStyleBackColor = true;
            // 
            // textBoxFragmentQuantity
            // 
            this.textBoxFragmentQuantity.Location = new System.Drawing.Point(233, 26);
            this.textBoxFragmentQuantity.Name = "textBoxFragmentQuantity";
            this.textBoxFragmentQuantity.Size = new System.Drawing.Size(63, 20);
            this.textBoxFragmentQuantity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de fragmentos";
            // 
            // buttonSearchImage
            // 
            this.buttonSearchImage.Location = new System.Drawing.Point(360, 239);
            this.buttonSearchImage.Name = "buttonSearchImage";
            this.buttonSearchImage.Size = new System.Drawing.Size(93, 23);
            this.buttonSearchImage.TabIndex = 7;
            this.buttonSearchImage.Text = "Buscar imagen";
            this.buttonSearchImage.UseVisualStyleBackColor = true;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(13, 299);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(440, 58);
            this.textBoxSummary.TabIndex = 6;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(10, 277);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(52, 13);
            this.labelSummary.TabIndex = 5;
            this.labelSummary.Text = "Resumen";
            // 
            // textBoxImageRoute
            // 
            this.textBoxImageRoute.Location = new System.Drawing.Point(13, 242);
            this.textBoxImageRoute.Name = "textBoxImageRoute";
            this.textBoxImageRoute.Size = new System.Drawing.Size(341, 20);
            this.textBoxImageRoute.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
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
            this.textBoxStoryTitle.Size = new System.Drawing.Size(401, 20);
            this.textBoxStoryTitle.TabIndex = 1;
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(10, 26);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(33, 13);
            this.labelStoryTitle.TabIndex = 0;
            this.labelStoryTitle.Text = "Titulo";
            // 
            // buttonCreateStory
            // 
            this.buttonCreateStory.Location = new System.Drawing.Point(430, 556);
            this.buttonCreateStory.Name = "buttonCreateStory";
            this.buttonCreateStory.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateStory.TabIndex = 4;
            this.buttonCreateStory.Text = "Crear";
            this.buttonCreateStory.UseVisualStyleBackColor = true;
            // 
            // buttonCancelStory
            // 
            this.buttonCancelStory.Location = new System.Drawing.Point(532, 556);
            this.buttonCancelStory.Name = "buttonCancelStory";
            this.buttonCancelStory.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelStory.TabIndex = 5;
            this.buttonCancelStory.Text = "Cancelar";
            this.buttonCancelStory.UseVisualStyleBackColor = true;
            // 
            // StoryCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 601);
            this.Controls.Add(this.buttonCancelStory);
            this.Controls.Add(this.buttonCreateStory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSelectStory);
            this.Controls.Add(this.labelSelectStory);
            this.Name = "StoryCreationForm";
            this.Text = "Creación de historia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectStory;
        private System.Windows.Forms.ComboBox comboBoxSelectStory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGenerateStory;
        private System.Windows.Forms.Button buttonGenerateImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelStoryTitle;
        private System.Windows.Forms.TextBox textBoxStoryTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStory;
        private System.Windows.Forms.Button buttonSearchImage;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox textBoxImageRoute;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxFragmentQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddFragment;
        private System.Windows.Forms.Button buttonCreateStory;
        private System.Windows.Forms.Button buttonCancelStory;
    }
}