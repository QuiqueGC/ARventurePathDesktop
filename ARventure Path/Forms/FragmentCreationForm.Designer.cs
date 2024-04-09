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
            this.buttonCancelFragment = new System.Windows.Forms.Button();
            this.buttonAcceptFragment = new System.Windows.Forms.Button();
            this.labelFragmento = new System.Windows.Forms.Label();
            this.textBoxCreateFragment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancelFragment
            // 
            this.buttonCancelFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelFragment.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelFragment.Location = new System.Drawing.Point(412, 337);
            this.buttonCancelFragment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCancelFragment.Name = "buttonCancelFragment";
            this.buttonCancelFragment.Size = new System.Drawing.Size(176, 69);
            this.buttonCancelFragment.TabIndex = 8;
            this.buttonCancelFragment.Text = "Cancelar";
            this.buttonCancelFragment.UseVisualStyleBackColor = false;
            this.buttonCancelFragment.Click += new System.EventHandler(this.buttonCancelFragment_Click);
            // 
            // buttonAcceptFragment
            // 
            this.buttonAcceptFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAcceptFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAcceptFragment.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAcceptFragment.Location = new System.Drawing.Point(684, 337);
            this.buttonAcceptFragment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAcceptFragment.Name = "buttonAcceptFragment";
            this.buttonAcceptFragment.Size = new System.Drawing.Size(176, 69);
            this.buttonAcceptFragment.TabIndex = 9;
            this.buttonAcceptFragment.Text = "Aceptar";
            this.buttonAcceptFragment.UseVisualStyleBackColor = false;
            this.buttonAcceptFragment.Click += new System.EventHandler(this.buttonAcceptFragment_Click);
            // 
            // labelFragmento
            // 
            this.labelFragmento.AutoSize = true;
            this.labelFragmento.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFragmento.Location = new System.Drawing.Point(108, 144);
            this.labelFragmento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFragmento.Name = "labelFragmento";
            this.labelFragmento.Size = new System.Drawing.Size(179, 38);
            this.labelFragmento.TabIndex = 10;
            this.labelFragmento.Text = "Fragmento";
            // 
            // textBoxCreateFragment
            // 
            this.textBoxCreateFragment.Location = new System.Drawing.Point(302, 81);
            this.textBoxCreateFragment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxCreateFragment.Multiline = true;
            this.textBoxCreateFragment.Name = "textBoxCreateFragment";
            this.textBoxCreateFragment.Size = new System.Drawing.Size(800, 162);
            this.textBoxCreateFragment.TabIndex = 11;
            // 
            // FragmentCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1204, 462);
            this.Controls.Add(this.textBoxCreateFragment);
            this.Controls.Add(this.labelFragmento);
            this.Controls.Add(this.buttonAcceptFragment);
            this.Controls.Add(this.buttonCancelFragment);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FragmentCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de Fragmento";
            this.Load += new System.EventHandler(this.FragmentCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancelFragment;
        private System.Windows.Forms.Button buttonAcceptFragment;
        private System.Windows.Forms.Label labelFragmento;
        private System.Windows.Forms.TextBox textBoxCreateFragment;
    }
}