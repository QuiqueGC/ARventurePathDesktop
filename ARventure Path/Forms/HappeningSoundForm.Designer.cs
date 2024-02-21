namespace ARventure_Path.Forms
{
    partial class HappeningSoundForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HappeningSoundForm));
            this.groupboxTxtHappening = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.imgPlay = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbIA = new System.Windows.Forms.GroupBox();
            this.buttonGenerateHappening = new System.Windows.Forms.Button();
            this.textboxIAPrompt = new System.Windows.Forms.TextBox();
            this.comboBoxHappenings = new System.Windows.Forms.ComboBox();
            this.labelSelectHappening = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxStories = new System.Windows.Forms.ComboBox();
            this.bindingSourceStory = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxTxtHappening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlay)).BeginInit();
            this.gbIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxTxtHappening
            // 
            this.groupboxTxtHappening.Controls.Add(this.buttonSearch);
            this.groupboxTxtHappening.Controls.Add(this.imgPlay);
            this.groupboxTxtHappening.Controls.Add(this.progressBar1);
            this.groupboxTxtHappening.Controls.Add(this.textBoxUrl);
            this.groupboxTxtHappening.Controls.Add(this.lblUrl);
            this.groupboxTxtHappening.Controls.Add(this.textBoxName);
            this.groupboxTxtHappening.Controls.Add(this.lblName);
            this.groupboxTxtHappening.Font = new System.Drawing.Font("Century", 10F);
            this.groupboxTxtHappening.Location = new System.Drawing.Point(17, 218);
            this.groupboxTxtHappening.Name = "groupboxTxtHappening";
            this.groupboxTxtHappening.Size = new System.Drawing.Size(511, 163);
            this.groupboxTxtHappening.TabIndex = 3;
            this.groupboxTxtHappening.TabStop = false;
            this.groupboxTxtHappening.Text = "Evento de Audio";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Century", 10F);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Location = new System.Drawing.Point(195, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // imgPlay
            // 
            this.imgPlay.Image = ((System.Drawing.Image)(resources.GetObject("imgPlay.Image")));
            this.imgPlay.Location = new System.Drawing.Point(204, 102);
            this.imgPlay.Name = "imgPlay";
            this.imgPlay.Size = new System.Drawing.Size(27, 23);
            this.imgPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlay.TabIndex = 7;
            this.imgPlay.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(243, 102);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(195, 39);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(303, 24);
            this.textBoxUrl.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(197, 23);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(111, 17);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Ruta de archivo";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 24);
            this.textBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // gbIA
            // 
            this.gbIA.Controls.Add(this.buttonGenerateHappening);
            this.gbIA.Controls.Add(this.textboxIAPrompt);
            this.gbIA.Font = new System.Drawing.Font("Century", 10F);
            this.gbIA.Location = new System.Drawing.Point(17, 63);
            this.gbIA.Name = "gbIA";
            this.gbIA.Size = new System.Drawing.Size(511, 134);
            this.gbIA.TabIndex = 2;
            this.gbIA.TabStop = false;
            this.gbIA.Text = "Generar por IA";
            // 
            // buttonGenerateHappening
            // 
            this.buttonGenerateHappening.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateHappening.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateHappening.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateHappening.Location = new System.Drawing.Point(6, 89);
            this.buttonGenerateHappening.Name = "buttonGenerateHappening";
            this.buttonGenerateHappening.Size = new System.Drawing.Size(121, 30);
            this.buttonGenerateHappening.TabIndex = 1;
            this.buttonGenerateHappening.Text = "Generar evento";
            this.buttonGenerateHappening.UseVisualStyleBackColor = false;
            // 
            // textboxIAPrompt
            // 
            this.textboxIAPrompt.Location = new System.Drawing.Point(6, 27);
            this.textboxIAPrompt.Multiline = true;
            this.textboxIAPrompt.Name = "textboxIAPrompt";
            this.textboxIAPrompt.Size = new System.Drawing.Size(499, 53);
            this.textboxIAPrompt.TabIndex = 0;
            // 
            // comboBoxHappenings
            // 
            this.comboBoxHappenings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHappenings.FormattingEnabled = true;
            this.comboBoxHappenings.Location = new System.Drawing.Point(215, 11);
            this.comboBoxHappenings.Name = "comboBoxHappenings";
            this.comboBoxHappenings.Size = new System.Drawing.Size(235, 21);
            this.comboBoxHappenings.TabIndex = 0;
            // 
            // labelSelectHappening
            // 
            this.labelSelectHappening.AutoSize = true;
            this.labelSelectHappening.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectHappening.Location = new System.Drawing.Point(25, 9);
            this.labelSelectHappening.Name = "labelSelectHappening";
            this.labelSelectHappening.Size = new System.Drawing.Size(164, 20);
            this.labelSelectHappening.TabIndex = 4;
            this.labelSelectHappening.Text = "Seleccionar evento";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreate.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreate.Location = new System.Drawing.Point(453, 387);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Crear";
            this.buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(372, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxStories
            // 
            this.comboBoxStories.DataSource = this.bindingSourceStory;
            this.comboBoxStories.DisplayMember = "name";
            this.comboBoxStories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStories.FormattingEnabled = true;
            this.comboBoxStories.Location = new System.Drawing.Point(215, 37);
            this.comboBoxStories.Name = "comboBoxStories";
            this.comboBoxStories.Size = new System.Drawing.Size(235, 21);
            this.comboBoxStories.TabIndex = 1;
            this.comboBoxStories.ValueMember = "id";
            // 
            // bindingSourceStory
            // 
            this.bindingSourceStory.DataSource = typeof(ARventure_Path.Models.story);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccionar historia";
            // 
            // HappeningSoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 422);
            this.Controls.Add(this.comboBoxStories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupboxTxtHappening);
            this.Controls.Add(this.gbIA);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxHappenings);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelSelectHappening);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HappeningSoundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de evento de audio                       ";
            this.Load += new System.EventHandler(this.HappeningSoundForm_Load);
            this.groupboxTxtHappening.ResumeLayout(false);
            this.groupboxTxtHappening.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlay)).EndInit();
            this.gbIA.ResumeLayout(false);
            this.gbIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxTxtHappening;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbIA;
        private System.Windows.Forms.Button buttonGenerateHappening;
        private System.Windows.Forms.TextBox textboxIAPrompt;
        private System.Windows.Forms.ComboBox comboBoxHappenings;
        private System.Windows.Forms.Label labelSelectHappening;
        private System.Windows.Forms.PictureBox imgPlay;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxStories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceStory;
    }
}