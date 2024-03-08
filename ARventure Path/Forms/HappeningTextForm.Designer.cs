namespace ARventure_Path.Forms
{
    partial class HappeningTextForm
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
            this.groupboxTxtHappening = new System.Windows.Forms.GroupBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSelectHappening = new System.Windows.Forms.Label();
            this.comboBoxHappenings = new System.Windows.Forms.ComboBox();
            this.bindingSourceHappenings = new System.Windows.Forms.BindingSource(this.components);
            this.textboxIAPrompt = new System.Windows.Forms.TextBox();
            this.buttonGenerateHappening = new System.Windows.Forms.Button();
            this.groupboxIA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStories = new System.Windows.Forms.ComboBox();
            this.bindingSourceStory = new System.Windows.Forms.BindingSource(this.components);
            this.groupboxTxtHappening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappenings)).BeginInit();
            this.groupboxIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxTxtHappening
            // 
            this.groupboxTxtHappening.Controls.Add(this.textBoxContent);
            this.groupboxTxtHappening.Controls.Add(this.labelContent);
            this.groupboxTxtHappening.Controls.Add(this.textBoxName);
            this.groupboxTxtHappening.Controls.Add(this.lblName);
            this.groupboxTxtHappening.Font = new System.Drawing.Font("Century", 10F);
            this.groupboxTxtHappening.Location = new System.Drawing.Point(12, 224);
            this.groupboxTxtHappening.Name = "groupboxTxtHappening";
            this.groupboxTxtHappening.Size = new System.Drawing.Size(511, 158);
            this.groupboxTxtHappening.TabIndex = 4;
            this.groupboxTxtHappening.TabStop = false;
            this.groupboxTxtHappening.Text = "Evento de texto";
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(202, 34);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(303, 111);
            this.textBoxContent.TabIndex = 3;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(204, 18);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(74, 17);
            this.labelContent.TabIndex = 2;
            this.labelContent.Text = "Contenido";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 24);
            this.textBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreate.Enabled = false;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreate.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreate.Location = new System.Drawing.Point(448, 390);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Crear";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(367, 390);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelSelectHappening
            // 
            this.labelSelectHappening.AutoSize = true;
            this.labelSelectHappening.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectHappening.Location = new System.Drawing.Point(18, 13);
            this.labelSelectHappening.Name = "labelSelectHappening";
            this.labelSelectHappening.Size = new System.Drawing.Size(164, 20);
            this.labelSelectHappening.TabIndex = 0;
            this.labelSelectHappening.Text = "Seleccionar evento";
            // 
            // comboBoxHappenings
            // 
            this.comboBoxHappenings.DataSource = this.bindingSourceHappenings;
            this.comboBoxHappenings.DisplayMember = "name";
            this.comboBoxHappenings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHappenings.FormattingEnabled = true;
            this.comboBoxHappenings.Location = new System.Drawing.Point(207, 12);
            this.comboBoxHappenings.Name = "comboBoxHappenings";
            this.comboBoxHappenings.Size = new System.Drawing.Size(235, 21);
            this.comboBoxHappenings.TabIndex = 1;
            this.comboBoxHappenings.ValueMember = "id";
            this.comboBoxHappenings.SelectedIndexChanged += new System.EventHandler(this.comboBoxHappenings_SelectedIndexChanged);
            // 
            // bindingSourceHappenings
            // 
            this.bindingSourceHappenings.DataSource = typeof(ARventure_Path.Models.happening);
            // 
            // textboxIAPrompt
            // 
            this.textboxIAPrompt.Location = new System.Drawing.Point(6, 27);
            this.textboxIAPrompt.Multiline = true;
            this.textboxIAPrompt.Name = "textboxIAPrompt";
            this.textboxIAPrompt.Size = new System.Drawing.Size(499, 53);
            this.textboxIAPrompt.TabIndex = 0;
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
            this.buttonGenerateHappening.Click += new System.EventHandler(this.buttonGenerateHappening_Click);
            // 
            // groupboxIA
            // 
            this.groupboxIA.Controls.Add(this.buttonGenerateHappening);
            this.groupboxIA.Controls.Add(this.textboxIAPrompt);
            this.groupboxIA.Font = new System.Drawing.Font("Century", 10F);
            this.groupboxIA.Location = new System.Drawing.Point(12, 69);
            this.groupboxIA.Name = "groupboxIA";
            this.groupboxIA.Size = new System.Drawing.Size(511, 134);
            this.groupboxIA.TabIndex = 3;
            this.groupboxIA.TabStop = false;
            this.groupboxIA.Text = "Generar por IA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccionar historia";
            // 
            // comboBoxStories
            // 
            this.comboBoxStories.DataSource = this.bindingSourceStory;
            this.comboBoxStories.DisplayMember = "name";
            this.comboBoxStories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStories.FormattingEnabled = true;
            this.comboBoxStories.Location = new System.Drawing.Point(207, 40);
            this.comboBoxStories.Name = "comboBoxStories";
            this.comboBoxStories.Size = new System.Drawing.Size(235, 21);
            this.comboBoxStories.TabIndex = 2;
            this.comboBoxStories.ValueMember = "id";
            // 
            // bindingSourceStory
            // 
            this.bindingSourceStory.DataSource = typeof(ARventure_Path.Models.story);
            // 
            // HappeningTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 422);
            this.Controls.Add(this.comboBoxStories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupboxTxtHappening);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.groupboxIA);
            this.Controls.Add(this.comboBoxHappenings);
            this.Controls.Add(this.labelSelectHappening);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HappeningTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de evento de texto";
            this.Load += new System.EventHandler(this.HappeningTextForm_Load);
            this.groupboxTxtHappening.ResumeLayout(false);
            this.groupboxTxtHappening.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappenings)).EndInit();
            this.groupboxIA.ResumeLayout(false);
            this.groupboxIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupboxTxtHappening;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelSelectHappening;
        private System.Windows.Forms.ComboBox comboBoxHappenings;
        private System.Windows.Forms.TextBox textboxIAPrompt;
        private System.Windows.Forms.Button buttonGenerateHappening;
        private System.Windows.Forms.GroupBox groupboxIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStories;
        private System.Windows.Forms.BindingSource bindingSourceStory;
        private System.Windows.Forms.BindingSource bindingSourceHappenings;
    }
}