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
            this.labelAchievement = new System.Windows.Forms.Label();
            this.pictureBoxAchievement = new System.Windows.Forms.PictureBox();
            this.textBoxNameAchievement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAchievement)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAchievement
            // 
            this.labelAchievement.AutoSize = true;
            this.labelAchievement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchievement.Location = new System.Drawing.Point(60, 42);
            this.labelAchievement.Name = "labelAchievement";
            this.labelAchievement.Size = new System.Drawing.Size(68, 20);
            this.labelAchievement.TabIndex = 0;
            this.labelAchievement.Text = "Nombre";
            // 
            // pictureBoxAchievement
            // 
            this.pictureBoxAchievement.Location = new System.Drawing.Point(42, 100);
            this.pictureBoxAchievement.Name = "pictureBoxAchievement";
            this.pictureBoxAchievement.Size = new System.Drawing.Size(417, 185);
            this.pictureBoxAchievement.TabIndex = 1;
            this.pictureBoxAchievement.TabStop = false;
            // 
            // textBoxNameAchievement
            // 
            this.textBoxNameAchievement.Location = new System.Drawing.Point(134, 36);
            this.textBoxNameAchievement.Multiline = true;
            this.textBoxNameAchievement.Name = "textBoxNameAchievement";
            this.textBoxNameAchievement.Size = new System.Drawing.Size(308, 31);
            this.textBoxNameAchievement.TabIndex = 2;
            // 
            // AchievementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(494, 323);
            this.Controls.Add(this.textBoxNameAchievement);
            this.Controls.Add(this.pictureBoxAchievement);
            this.Controls.Add(this.labelAchievement);
            this.Name = "AchievementForm";
            this.Text = "Logros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAchievement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAchievement;
        private System.Windows.Forms.PictureBox pictureBoxAchievement;
        private System.Windows.Forms.TextBox textBoxNameAchievement;
    }
}