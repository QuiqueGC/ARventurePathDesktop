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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAchievement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAchievement)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAchievement
            // 
            this.labelAchievement.AutoSize = true;
            this.labelAchievement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchievement.Location = new System.Drawing.Point(62, 54);
            this.labelAchievement.Name = "labelAchievement";
            this.labelAchievement.Size = new System.Drawing.Size(68, 20);
            this.labelAchievement.TabIndex = 0;
            this.labelAchievement.Text = "Nombre";
            // 
            // pictureBoxAchievement
            // 
            this.pictureBoxAchievement.Image = global::ARventure_Path.Properties.Resources.logros;
            this.pictureBoxAchievement.Location = new System.Drawing.Point(64, 90);
            this.pictureBoxAchievement.Name = "pictureBoxAchievement";
            this.pictureBoxAchievement.Size = new System.Drawing.Size(378, 179);
            this.pictureBoxAchievement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAchievement.TabIndex = 1;
            this.pictureBoxAchievement.TabStop = false;
            // 
            // textBoxNameAchievement
            // 
            this.textBoxNameAchievement.Location = new System.Drawing.Point(134, 52);
            this.textBoxNameAchievement.Multiline = true;
            this.textBoxNameAchievement.Name = "textBoxNameAchievement";
            this.textBoxNameAchievement.Size = new System.Drawing.Size(308, 25);
            this.textBoxNameAchievement.TabIndex = 2;
            // 
            // buttonCancelAchievement
            // 
            this.buttonCancelAchievement.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelAchievement.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAchievement.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelAchievement.Location = new System.Drawing.Point(165, 288);
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
            this.buttonAchievement.Location = new System.Drawing.Point(270, 288);
            this.buttonAchievement.Name = "buttonAchievement";
            this.buttonAchievement.Size = new System.Drawing.Size(75, 23);
            this.buttonAchievement.TabIndex = 4;
            this.buttonAchievement.Text = "Guardar";
            this.buttonAchievement.UseVisualStyleBackColor = false;
            // 
            // labelSelectAchievement
            // 
            this.labelSelectAchievement.AutoSize = true;
            this.labelSelectAchievement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectAchievement.Location = new System.Drawing.Point(60, 19);
            this.labelSelectAchievement.Name = "labelSelectAchievement";
            this.labelSelectAchievement.Size = new System.Drawing.Size(134, 20);
            this.labelSelectAchievement.TabIndex = 5;
            this.labelSelectAchievement.Text = "Seleccionar logro";
            // 
            // comboBoxSelectAchievement
            // 
            this.comboBoxSelectAchievement.DataSource = this.bindingSourceAchievement;
            this.comboBoxSelectAchievement.DisplayMember = "name";
            this.comboBoxSelectAchievement.FormattingEnabled = true;
            this.comboBoxSelectAchievement.Location = new System.Drawing.Point(200, 21);
            this.comboBoxSelectAchievement.Name = "comboBoxSelectAchievement";
            this.comboBoxSelectAchievement.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSelectAchievement.TabIndex = 6;
            this.comboBoxSelectAchievement.ValueMember = "id";
            // 
            // bindingSourceAchievement
            // 
            this.bindingSourceAchievement.DataSource = typeof(ARventure_Path.Models.achievement);
            // 
            // AchievementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(494, 323);
            this.Controls.Add(this.comboBoxSelectAchievement);
            this.Controls.Add(this.labelSelectAchievement);
            this.Controls.Add(this.buttonAchievement);
            this.Controls.Add(this.buttonCancelAchievement);
            this.Controls.Add(this.textBoxNameAchievement);
            this.Controls.Add(this.pictureBoxAchievement);
            this.Controls.Add(this.labelAchievement);
            this.Name = "AchievementForm";
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
    }
}