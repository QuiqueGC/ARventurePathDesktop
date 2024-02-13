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
            this.gbTxtHappening = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbIA = new System.Windows.Forms.GroupBox();
            this.btnGenerateHappening = new System.Windows.Forms.Button();
            this.tbIAPrompt = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSelectHappening = new System.Windows.Forms.Label();
            this.imgHappening = new System.Windows.Forms.PictureBox();
            this.gbTxtHappening.SuspendLayout();
            this.gbIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHappening)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTxtHappening
            // 
            this.gbTxtHappening.Controls.Add(this.imgHappening);
            this.gbTxtHappening.Controls.Add(this.textBox2);
            this.gbTxtHappening.Controls.Add(this.lblUrl);
            this.gbTxtHappening.Controls.Add(this.textBox1);
            this.gbTxtHappening.Controls.Add(this.lblName);
            this.gbTxtHappening.Location = new System.Drawing.Point(17, 215);
            this.gbTxtHappening.Name = "gbTxtHappening";
            this.gbTxtHappening.Size = new System.Drawing.Size(511, 163);
            this.gbTxtHappening.TabIndex = 13;
            this.gbTxtHappening.TabStop = false;
            this.gbTxtHappening.Text = "Evento de texto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(10, 64);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(83, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Ruta de archivo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // gbIA
            // 
            this.gbIA.Controls.Add(this.btnGenerateHappening);
            this.gbIA.Controls.Add(this.tbIAPrompt);
            this.gbIA.Location = new System.Drawing.Point(17, 60);
            this.gbIA.Name = "gbIA";
            this.gbIA.Size = new System.Drawing.Size(511, 134);
            this.gbIA.TabIndex = 12;
            this.gbIA.TabStop = false;
            this.gbIA.Text = "Generar por IA";
            // 
            // btnGenerateHappening
            // 
            this.btnGenerateHappening.Location = new System.Drawing.Point(6, 89);
            this.btnGenerateHappening.Name = "btnGenerateHappening";
            this.btnGenerateHappening.Size = new System.Drawing.Size(121, 30);
            this.btnGenerateHappening.TabIndex = 1;
            this.btnGenerateHappening.Text = "Generar evento";
            this.btnGenerateHappening.UseVisualStyleBackColor = true;
            // 
            // tbIAPrompt
            // 
            this.tbIAPrompt.Location = new System.Drawing.Point(6, 27);
            this.tbIAPrompt.Multiline = true;
            this.tbIAPrompt.Name = "tbIAPrompt";
            this.tbIAPrompt.Size = new System.Drawing.Size(499, 53);
            this.tbIAPrompt.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(453, 384);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // lblSelectHappening
            // 
            this.lblSelectHappening.AutoSize = true;
            this.lblSelectHappening.Location = new System.Drawing.Point(42, 19);
            this.lblSelectHappening.Name = "lblSelectHappening";
            this.lblSelectHappening.Size = new System.Drawing.Size(99, 13);
            this.lblSelectHappening.TabIndex = 9;
            this.lblSelectHappening.Text = "Seleccionar evento";
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
            // EventImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 422);
            this.Controls.Add(this.gbTxtHappening);
            this.Controls.Add(this.gbIA);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblSelectHappening);
            this.Name = "EventImageForm";
            this.Text = "Creación de evento de imagen";
            this.gbTxtHappening.ResumeLayout(false);
            this.gbTxtHappening.PerformLayout();
            this.gbIA.ResumeLayout(false);
            this.gbIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHappening)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTxtHappening;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbIA;
        private System.Windows.Forms.Button btnGenerateHappening;
        private System.Windows.Forms.TextBox tbIAPrompt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblSelectHappening;
        private System.Windows.Forms.PictureBox imgHappening;
    }
}