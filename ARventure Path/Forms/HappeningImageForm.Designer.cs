namespace ARventure_Path.Forms
{
    partial class HappeningImageForm
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
            this.groupboxImgHappening = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.imgHappening = new System.Windows.Forms.PictureBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupboxIA = new System.Windows.Forms.GroupBox();
            this.buttonGenerateHappening = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxHappenings = new System.Windows.Forms.ComboBox();
            this.bindingSourceHappenings = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelSelectHappening = new System.Windows.Forms.Label();
            this.comboBoxStories = new System.Windows.Forms.ComboBox();
            this.bindingSourceStory = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.groupboxImgHappening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHappening)).BeginInit();
            this.groupboxIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappenings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxImgHappening
            // 
            this.groupboxImgHappening.Controls.Add(this.buttonSearch);
            this.groupboxImgHappening.Controls.Add(this.imgHappening);
            this.groupboxImgHappening.Controls.Add(this.textBoxUrl);
            this.groupboxImgHappening.Controls.Add(this.labelUrl);
            this.groupboxImgHappening.Controls.Add(this.textBoxName);
            this.groupboxImgHappening.Controls.Add(this.lblName);
            this.groupboxImgHappening.Font = new System.Drawing.Font("Century", 10F);
            this.groupboxImgHappening.Location = new System.Drawing.Point(17, 150);
            this.groupboxImgHappening.Name = "groupboxImgHappening";
            this.groupboxImgHappening.Size = new System.Drawing.Size(511, 163);
            this.groupboxImgHappening.TabIndex = 3;
            this.groupboxImgHappening.TabStop = false;
            this.groupboxImgHappening.Text = "Evento de Imagen";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Century", 10F);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Location = new System.Drawing.Point(9, 110);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // imgHappening
            // 
            this.imgHappening.Image = global::ARventure_Path.Properties.Resources.Login_Aventuras;
            this.imgHappening.Location = new System.Drawing.Point(261, 22);
            this.imgHappening.Name = "imgHappening";
            this.imgHappening.Size = new System.Drawing.Size(231, 126);
            this.imgHappening.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHappening.TabIndex = 4;
            this.imgHappening.TabStop = false;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Enabled = false;
            this.textBoxUrl.Location = new System.Drawing.Point(9, 80);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(236, 24);
            this.textBoxUrl.TabIndex = 2;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(13, 64);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(111, 17);
            this.labelUrl.TabIndex = 2;
            this.labelUrl.Text = "Ruta de archivo";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(9, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 24);
            this.textBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // groupboxIA
            // 
            this.groupboxIA.Controls.Add(this.buttonGenerateHappening);
            this.groupboxIA.Font = new System.Drawing.Font("Century", 10F);
            this.groupboxIA.Location = new System.Drawing.Point(17, 60);
            this.groupboxIA.Name = "groupboxIA";
            this.groupboxIA.Size = new System.Drawing.Size(511, 74);
            this.groupboxIA.TabIndex = 2;
            this.groupboxIA.TabStop = false;
            this.groupboxIA.Text = "Generar por IA";
            // 
            // buttonGenerateHappening
            // 
            this.buttonGenerateHappening.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateHappening.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateHappening.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateHappening.Location = new System.Drawing.Point(192, 23);
            this.buttonGenerateHappening.Name = "buttonGenerateHappening";
            this.buttonGenerateHappening.Size = new System.Drawing.Size(121, 30);
            this.buttonGenerateHappening.TabIndex = 1;
            this.buttonGenerateHappening.Text = "Generar evento";
            this.buttonGenerateHappening.UseVisualStyleBackColor = false;
            this.buttonGenerateHappening.Click += new System.EventHandler(this.buttonGenerateHappening_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(372, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxHappenings
            // 
            this.comboBoxHappenings.DataSource = this.bindingSourceHappenings;
            this.comboBoxHappenings.DisplayMember = "name";
            this.comboBoxHappenings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHappenings.FormattingEnabled = true;
            this.comboBoxHappenings.Location = new System.Drawing.Point(209, 9);
            this.comboBoxHappenings.Name = "comboBoxHappenings";
            this.comboBoxHappenings.Size = new System.Drawing.Size(235, 21);
            this.comboBoxHappenings.TabIndex = 0;
            this.comboBoxHappenings.ValueMember = "id";
            this.comboBoxHappenings.SelectedIndexChanged += new System.EventHandler(this.comboBoxHappenings_SelectedIndexChanged);
            // 
            // bindingSourceHappenings
            // 
            this.bindingSourceHappenings.DataSource = typeof(ARventure_Path.Models.happening);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreate.Enabled = false;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreate.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreate.Location = new System.Drawing.Point(453, 319);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Crear";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelSelectHappening
            // 
            this.labelSelectHappening.AutoSize = true;
            this.labelSelectHappening.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectHappening.Location = new System.Drawing.Point(22, 10);
            this.labelSelectHappening.Name = "labelSelectHappening";
            this.labelSelectHappening.Size = new System.Drawing.Size(164, 20);
            this.labelSelectHappening.TabIndex = 9;
            this.labelSelectHappening.Text = "Seleccionar evento";
            // 
            // comboBoxStories
            // 
            this.comboBoxStories.DataSource = this.bindingSourceStory;
            this.comboBoxStories.DisplayMember = "name";
            this.comboBoxStories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStories.FormattingEnabled = true;
            this.comboBoxStories.Location = new System.Drawing.Point(209, 37);
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
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Seleccionar historia";
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelLoading.Location = new System.Drawing.Point(204, 162);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(137, 29);
            this.labelLoading.TabIndex = 28;
            this.labelLoading.Text = "Cargando...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoading.Visible = false;
            // 
            // HappeningImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 352);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.comboBoxStories);
            this.Controls.Add(this.groupboxImgHappening);
            this.Controls.Add(this.groupboxIA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxHappenings);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelSelectHappening);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HappeningImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de evento de imagen";
            this.Load += new System.EventHandler(this.HappeningImageForm_Load);
            this.groupboxImgHappening.ResumeLayout(false);
            this.groupboxImgHappening.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHappening)).EndInit();
            this.groupboxIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappenings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxImgHappening;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupboxIA;
        private System.Windows.Forms.Button buttonGenerateHappening;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxHappenings;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelSelectHappening;
        private System.Windows.Forms.PictureBox imgHappening;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxStories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceStory;
        private System.Windows.Forms.BindingSource bindingSourceHappenings;
        private System.Windows.Forms.Label labelLoading;
    }
}