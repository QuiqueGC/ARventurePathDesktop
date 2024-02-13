namespace ARventure_Path.Forms
{
    partial class FragmentCreationForm
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
            this.labelFragmentName = new System.Windows.Forms.Label();
            this.textBoxFragmentName = new System.Windows.Forms.TextBox();
            this.buttonCancelFragment = new System.Windows.Forms.Button();
            this.buttonAcceptFragment = new System.Windows.Forms.Button();
            this.labelFragmento = new System.Windows.Forms.Label();
            this.textBoxCreateFragment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFragmentName
            // 
            this.labelFragmentName.AutoSize = true;
            this.labelFragmentName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFragmentName.Location = new System.Drawing.Point(54, 44);
            this.labelFragmentName.Name = "labelFragmentName";
            this.labelFragmentName.Size = new System.Drawing.Size(68, 20);
            this.labelFragmentName.TabIndex = 1;
            this.labelFragmentName.Text = "Nombre";
            // 
            // textBoxFragmentName
            // 
            this.textBoxFragmentName.Location = new System.Drawing.Point(151, 43);
            this.textBoxFragmentName.Multiline = true;
            this.textBoxFragmentName.Name = "textBoxFragmentName";
            this.textBoxFragmentName.Size = new System.Drawing.Size(402, 21);
            this.textBoxFragmentName.TabIndex = 2;
            // 
            // buttonCancelFragment
            // 
            this.buttonCancelFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelFragment.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelFragment.Location = new System.Drawing.Point(206, 175);
            this.buttonCancelFragment.Name = "buttonCancelFragment";
            this.buttonCancelFragment.Size = new System.Drawing.Size(88, 36);
            this.buttonCancelFragment.TabIndex = 8;
            this.buttonCancelFragment.Text = "Cancelar";
            this.buttonCancelFragment.UseVisualStyleBackColor = false;
            // 
            // buttonAcceptFragment
            // 
            this.buttonAcceptFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAcceptFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAcceptFragment.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAcceptFragment.Location = new System.Drawing.Point(342, 175);
            this.buttonAcceptFragment.Name = "buttonAcceptFragment";
            this.buttonAcceptFragment.Size = new System.Drawing.Size(88, 36);
            this.buttonAcceptFragment.TabIndex = 9;
            this.buttonAcceptFragment.Text = "Aceptar";
            this.buttonAcceptFragment.UseVisualStyleBackColor = false;
            // 
            // labelFragmento
            // 
            this.labelFragmento.AutoSize = true;
            this.labelFragmento.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFragmento.Location = new System.Drawing.Point(54, 99);
            this.labelFragmento.Name = "labelFragmento";
            this.labelFragmento.Size = new System.Drawing.Size(91, 20);
            this.labelFragmento.TabIndex = 10;
            this.labelFragmento.Text = "Fragmento";
            // 
            // textBoxCreateFragment
            // 
            this.textBoxCreateFragment.Location = new System.Drawing.Point(151, 89);
            this.textBoxCreateFragment.Multiline = true;
            this.textBoxCreateFragment.Name = "textBoxCreateFragment";
            this.textBoxCreateFragment.Size = new System.Drawing.Size(402, 39);
            this.textBoxCreateFragment.TabIndex = 11;
            // 
            // FragmentCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(602, 240);
            this.Controls.Add(this.textBoxCreateFragment);
            this.Controls.Add(this.labelFragmento);
            this.Controls.Add(this.buttonAcceptFragment);
            this.Controls.Add(this.buttonCancelFragment);
            this.Controls.Add(this.textBoxFragmentName);
            this.Controls.Add(this.labelFragmentName);
            this.Name = "FragmentCreationForm";
            this.Text = "Creación de Fragmento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFragmentName;
        private System.Windows.Forms.TextBox textBoxFragmentName;
        private System.Windows.Forms.Button buttonCancelFragment;
        private System.Windows.Forms.Button buttonAcceptFragment;
        private System.Windows.Forms.Label labelFragmento;
        private System.Windows.Forms.TextBox textBoxCreateFragment;
    }
}