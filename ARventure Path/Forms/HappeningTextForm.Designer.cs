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
            this.lblSelectHappening = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbIA = new System.Windows.Forms.GroupBox();
            this.btnGenerateHappening = new System.Windows.Forms.Button();
            this.tbIAPrompt = new System.Windows.Forms.TextBox();
            this.gbTxtHappening = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContain = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbIA.SuspendLayout();
            this.gbTxtHappening.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectHappening
            // 
            this.lblSelectHappening.AutoSize = true;
            this.lblSelectHappening.Location = new System.Drawing.Point(37, 28);
            this.lblSelectHappening.Name = "lblSelectHappening";
            this.lblSelectHappening.Size = new System.Drawing.Size(99, 13);
            this.lblSelectHappening.TabIndex = 0;
            this.lblSelectHappening.Text = "Seleccionar evento";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // gbIA
            // 
            this.gbIA.Controls.Add(this.btnGenerateHappening);
            this.gbIA.Controls.Add(this.tbIAPrompt);
            this.gbIA.Location = new System.Drawing.Point(12, 69);
            this.gbIA.Name = "gbIA";
            this.gbIA.Size = new System.Drawing.Size(511, 134);
            this.gbIA.TabIndex = 2;
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
            // gbTxtHappening
            // 
            this.gbTxtHappening.Controls.Add(this.textBox2);
            this.gbTxtHappening.Controls.Add(this.lblContain);
            this.gbTxtHappening.Controls.Add(this.textBox1);
            this.gbTxtHappening.Controls.Add(this.lblName);
            this.gbTxtHappening.Location = new System.Drawing.Point(12, 224);
            this.gbTxtHappening.Name = "gbTxtHappening";
            this.gbTxtHappening.Size = new System.Drawing.Size(511, 158);
            this.gbTxtHappening.TabIndex = 3;
            this.gbTxtHappening.TabStop = false;
            this.gbTxtHappening.Text = "Evento de texto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblContain
            // 
            this.lblContain.AutoSize = true;
            this.lblContain.Location = new System.Drawing.Point(204, 18);
            this.lblContain.Name = "lblContain";
            this.lblContain.Size = new System.Drawing.Size(55, 13);
            this.lblContain.TabIndex = 2;
            this.lblContain.Text = "Contenido";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 111);
            this.textBox2.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(448, 388);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 25);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(367, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EventTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 422);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbTxtHappening);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbIA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSelectHappening);
            this.Name = "EventTextForm";
            this.Text = "Creación de evento de texto";
            this.gbIA.ResumeLayout(false);
            this.gbIA.PerformLayout();
            this.gbTxtHappening.ResumeLayout(false);
            this.gbTxtHappening.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectHappening;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbIA;
        private System.Windows.Forms.TextBox tbIAPrompt;
        private System.Windows.Forms.Button btnGenerateHappening;
        private System.Windows.Forms.GroupBox gbTxtHappening;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblContain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}