namespace ARventure_Path.Forms
{
    partial class AchievementForm
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
            this.labelAchievement = new System.Windows.Forms.Label();
            this.pictureBoxAchievement = new System.Windows.Forms.PictureBox();
            this.textBoxNameAchievement = new System.Windows.Forms.TextBox();
            this.buttonCancelAchievement = new System.Windows.Forms.Button();
            this.buttonAchievement = new System.Windows.Forms.Button();
            this.labelSelectAchievement = new System.Windows.Forms.Label();
            this.comboBoxSelectAchievement = new System.Windows.Forms.ComboBox();
            this.bindingSourceAchievement = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImageAchievement = new System.Windows.Forms.TextBox();
            this.buttonSearchImageAchievement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAchievement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAchievement)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAchievement
            // 
            this.labelAchievement.AutoSize = true;
            this.labelAchievement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchievement.Location = new System.Drawing.Point(45, 116);
            this.labelAchievement.Name = "labelAchievement";
            this.labelAchievement.Size = new System.Drawing.Size(68, 20);
            this.labelAchievement.TabIndex = 0;
            this.labelAchievement.Text = "Nombre";
            // 
            // pictureBoxAchievement
            // 
            this.pictureBoxAchievement.Image = global::ARventure_Path.Properties.Resources.logros;
            this.pictureBoxAchievement.Location = new System.Drawing.Point(345, 44);
            this.pictureBoxAchievement.Name = "pictureBoxAchievement";
            this.pictureBoxAchievement.Size = new System.Drawing.Size(350, 283);
            this.pictureBoxAchievement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAchievement.TabIndex = 1;
            this.pictureBoxAchievement.TabStop = false;
            // 
            // textBoxNameAchievement
            // 
            this.textBoxNameAchievement.Location = new System.Drawing.Point(49, 156);
            this.textBoxNameAchievement.Multiline = true;
            this.textBoxNameAchievement.Name = "textBoxNameAchievement";
            this.textBoxNameAchievement.Size = new System.Drawing.Size(276, 25);
            this.textBoxNameAchievement.TabIndex = 2;
            // 
            // buttonCancelAchievement
            // 
            this.buttonCancelAchievement.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelAchievement.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAchievement.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelAchievement.Location = new System.Drawing.Point(264, 377);
            this.buttonCancelAchievement.Name = "buttonCancelAchievement";
            this.buttonCancelAchievement.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAchievement.TabIndex = 3;
            this.buttonCancelAchievement.Text = "Cancelar";
            this.buttonCancelAchievement.UseVisualStyleBackColor = false;
            this.buttonCancelAchievement.Click += new System.EventHandler(this.buttonCancelAchievement_Click);
            // 
            // buttonAchievement
            // 
            this.buttonAchievement.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAchievement.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAchievement.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAchievement.Location = new System.Drawing.Point(390, 377);
            this.buttonAchievement.Name = "buttonAchievement";
            this.buttonAchievement.Size = new System.Drawing.Size(75, 23);
            this.buttonAchievement.TabIndex = 4;
            this.buttonAchievement.Text = "Guardar";
            this.buttonAchievement.UseVisualStyleBackColor = false;
            this.buttonAchievement.Click += new System.EventHandler(this.buttonAchievement_Click);
            // 
            // labelSelectAchievement
            // 
            this.labelSelectAchievement.AutoSize = true;
            this.labelSelectAchievement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectAchievement.Location = new System.Drawing.Point(45, 44);
            this.labelSelectAchievement.Name = "labelSelectAchievement";
            this.labelSelectAchievement.Size = new System.Drawing.Size(134, 20);
            this.labelSelectAchievement.TabIndex = 5;
            this.labelSelectAchievement.Text = "Seleccionar logro";
            // 
            // comboBoxSelectAchievement
            // 
            this.comboBoxSelectAchievement.DataSource = this.bindingSourceAchievement;
            this.comboBoxSelectAchievement.DisplayMember = "name";
            this.comboBoxSelectAchievement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectAchievement.FormattingEnabled = true;
            this.comboBoxSelectAchievement.Location = new System.Drawing.Point(49, 77);
            this.comboBoxSelectAchievement.Name = "comboBoxSelectAchievement";
            this.comboBoxSelectAchievement.Size = new System.Drawing.Size(276, 21);
            this.comboBoxSelectAchievement.TabIndex = 6;
            this.comboBoxSelectAchievement.ValueMember = "id";
            // 
            // bindingSourceAchievement
            // 
            this.bindingSourceAchievement.DataSource = typeof(ARventure_Path.Models.achievement);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ruta imagen";
            // 
            // textBoxImageAchievement
            // 
            this.textBoxImageAchievement.Enabled = false;
            this.textBoxImageAchievement.Location = new System.Drawing.Point(49, 243);
            this.textBoxImageAchievement.Name = "textBoxImageAchievement";
            this.textBoxImageAchievement.Size = new System.Drawing.Size(276, 20);
            this.textBoxImageAchievement.TabIndex = 8;
            this.textBoxImageAchievement.TabStop = false;
            // 
            // buttonSearchImageAchievement
            // 
            this.buttonSearchImageAchievement.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearchImageAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchImageAchievement.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchImageAchievement.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchImageAchievement.Location = new System.Drawing.Point(49, 298);
            this.buttonSearchImageAchievement.Name = "buttonSearchImageAchievement";
            this.buttonSearchImageAchievement.Size = new System.Drawing.Size(120, 29);
            this.buttonSearchImageAchievement.TabIndex = 9;
            this.buttonSearchImageAchievement.Text = "Buscar imagen";
            this.buttonSearchImageAchievement.UseVisualStyleBackColor = false;
            this.buttonSearchImageAchievement.Click += new System.EventHandler(this.buttonSearchImageAchievement_Click);
            // 
            // AchievementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(707, 425);
            this.Controls.Add(this.buttonSearchImageAchievement);
            this.Controls.Add(this.textBoxImageAchievement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectAchievement);
            this.Controls.Add(this.labelSelectAchievement);
            this.Controls.Add(this.buttonAchievement);
            this.Controls.Add(this.buttonCancelAchievement);
            this.Controls.Add(this.textBoxNameAchievement);
            this.Controls.Add(this.pictureBoxAchievement);
            this.Controls.Add(this.labelAchievement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AchievementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logros";
            this.Load += new System.EventHandler(this.AchievementForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAchievement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAchievement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAchievement;
        private System.Windows.Forms.PictureBox pictureBoxAchievement;
        private System.Windows.Forms.TextBox textBoxNameAchievement;
        private System.Windows.Forms.Button buttonCancelAchievement;
        private System.Windows.Forms.Button buttonAchievement;
        private System.Windows.Forms.Label labelSelectAchievement;
        private System.Windows.Forms.ComboBox comboBoxSelectAchievement;
        private System.Windows.Forms.BindingSource bindingSourceAchievement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImageAchievement;
        private System.Windows.Forms.Button buttonSearchImageAchievement;
    }
}