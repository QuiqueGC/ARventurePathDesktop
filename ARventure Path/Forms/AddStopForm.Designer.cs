namespace ARventure_Path.Forms
{
    partial class AddStopForm
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
            this.labelStopName = new System.Windows.Forms.Label();
            this.textBoxStopName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLatitud = new System.Windows.Forms.TextBox();
            this.textBoxLongitud = new System.Windows.Forms.TextBox();
            this.buttonAcceptStop = new System.Windows.Forms.Button();
            this.buttonCancelStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStopName
            // 
            this.labelStopName.AutoSize = true;
            this.labelStopName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopName.Location = new System.Drawing.Point(56, 29);
            this.labelStopName.Name = "labelStopName";
            this.labelStopName.Size = new System.Drawing.Size(68, 20);
            this.labelStopName.TabIndex = 0;
            this.labelStopName.Text = "Nombre";
            // 
            // textBoxStopName
            // 
            this.textBoxStopName.Location = new System.Drawing.Point(151, 29);
            this.textBoxStopName.Name = "textBoxStopName";
            this.textBoxStopName.Size = new System.Drawing.Size(402, 20);
            this.textBoxStopName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitud";
            // 
            // textBoxLatitud
            // 
            this.textBoxLatitud.Location = new System.Drawing.Point(151, 80);
            this.textBoxLatitud.Name = "textBoxLatitud";
            this.textBoxLatitud.Size = new System.Drawing.Size(402, 20);
            this.textBoxLatitud.TabIndex = 4;
            // 
            // textBoxLongitud
            // 
            this.textBoxLongitud.Location = new System.Drawing.Point(151, 129);
            this.textBoxLongitud.Name = "textBoxLongitud";
            this.textBoxLongitud.Size = new System.Drawing.Size(402, 20);
            this.textBoxLongitud.TabIndex = 5;
            // 
            // buttonAcceptStop
            // 
            this.buttonAcceptStop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAcceptStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAcceptStop.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptStop.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAcceptStop.Location = new System.Drawing.Point(332, 179);
            this.buttonAcceptStop.Name = "buttonAcceptStop";
            this.buttonAcceptStop.Size = new System.Drawing.Size(88, 36);
            this.buttonAcceptStop.TabIndex = 6;
            this.buttonAcceptStop.Text = "Aceptar";
            this.buttonAcceptStop.UseVisualStyleBackColor = false;
            // 
            // buttonCancelStop
            // 
            this.buttonCancelStop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelStop.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelStop.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelStop.Location = new System.Drawing.Point(212, 179);
            this.buttonCancelStop.Name = "buttonCancelStop";
            this.buttonCancelStop.Size = new System.Drawing.Size(88, 36);
            this.buttonCancelStop.TabIndex = 7;
            this.buttonCancelStop.Text = "Cancelar";
            this.buttonCancelStop.UseVisualStyleBackColor = false;
            // 
            // AddStopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(602, 240);
            this.Controls.Add(this.buttonCancelStop);
            this.Controls.Add(this.buttonAcceptStop);
            this.Controls.Add(this.textBoxLongitud);
            this.Controls.Add(this.textBoxLatitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStopName);
            this.Controls.Add(this.labelStopName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddStopForm";
            this.Text = "Añadir Parada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStopName;
        private System.Windows.Forms.TextBox textBoxStopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLatitud;
        private System.Windows.Forms.TextBox textBoxLongitud;
        private System.Windows.Forms.Button buttonAcceptStop;
        private System.Windows.Forms.Button buttonCancelStop;
    }
}