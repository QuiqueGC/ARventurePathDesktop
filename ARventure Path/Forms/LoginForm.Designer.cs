namespace ARventure_Path.Forms
{
    partial class LoginForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(280, 413);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(384, 413);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Registro";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(244, 326);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Usuario";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(244, 364);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(61, 13);
            this.labelPwd.TabIndex = 6;
            this.labelPwd.Text = "Contraseña";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(335, 319);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(232, 20);
            this.textBoxUser.TabIndex = 7;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(335, 357);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(232, 20);
            this.textBoxPwd.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARventure_Path.Properties.Resources.Login_Aventuras;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}