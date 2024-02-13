namespace ARventure_Path.Forms
{
    partial class RouteCreationForm
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
            this.labelSelectRoute = new System.Windows.Forms.Label();
            this.comboBoxSelectRoute = new System.Windows.Forms.ComboBox();
            this.groupBoxGenerateRoute = new System.Windows.Forms.GroupBox();
            this.buttonGenerateRoute = new System.Windows.Forms.Button();
            this.textBoxGenerateRouteAI = new System.Windows.Forms.TextBox();
            this.groupBoxRoute = new System.Windows.Forms.GroupBox();
            this.labelRouteDistance = new System.Windows.Forms.Label();
            this.labelRouteTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxRouteStops = new System.Windows.Forms.ListBox();
            this.buttonAddNewRoute = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.buttonCancelRoute = new System.Windows.Forms.Button();
            this.buttonDeleteRoute = new System.Windows.Forms.Button();
            this.groupBoxGenerateRoute.SuspendLayout();
            this.groupBoxRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectRoute
            // 
            this.labelSelectRoute.AutoSize = true;
            this.labelSelectRoute.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.labelSelectRoute.Location = new System.Drawing.Point(23, 19);
            this.labelSelectRoute.Name = "labelSelectRoute";
            this.labelSelectRoute.Size = new System.Drawing.Size(145, 20);
            this.labelSelectRoute.TabIndex = 1;
            this.labelSelectRoute.Text = "Seleccionar ruta";
            // 
            // comboBoxSelectRoute
            // 
            this.comboBoxSelectRoute.FormattingEnabled = true;
            this.comboBoxSelectRoute.Location = new System.Drawing.Point(174, 21);
            this.comboBoxSelectRoute.Name = "comboBoxSelectRoute";
            this.comboBoxSelectRoute.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectRoute.TabIndex = 2;
            // 
            // groupBoxGenerateRoute
            // 
            this.groupBoxGenerateRoute.Controls.Add(this.buttonGenerateRoute);
            this.groupBoxGenerateRoute.Controls.Add(this.textBoxGenerateRouteAI);
            this.groupBoxGenerateRoute.Font = new System.Drawing.Font("Century", 10F);
            this.groupBoxGenerateRoute.Location = new System.Drawing.Point(26, 52);
            this.groupBoxGenerateRoute.Name = "groupBoxGenerateRoute";
            this.groupBoxGenerateRoute.Size = new System.Drawing.Size(898, 91);
            this.groupBoxGenerateRoute.TabIndex = 2;
            this.groupBoxGenerateRoute.TabStop = false;
            this.groupBoxGenerateRoute.Text = "Generar por IA";
            // 
            // buttonGenerateRoute
            // 
            this.buttonGenerateRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateRoute.Location = new System.Drawing.Point(18, 59);
            this.buttonGenerateRoute.Name = "buttonGenerateRoute";
            this.buttonGenerateRoute.Size = new System.Drawing.Size(103, 23);
            this.buttonGenerateRoute.TabIndex = 1;
            this.buttonGenerateRoute.Text = "Generar ruta";
            this.buttonGenerateRoute.UseVisualStyleBackColor = false;
            // 
            // textBoxGenerateRouteAI
            // 
            this.textBoxGenerateRouteAI.Location = new System.Drawing.Point(18, 33);
            this.textBoxGenerateRouteAI.Name = "textBoxGenerateRouteAI";
            this.textBoxGenerateRouteAI.Size = new System.Drawing.Size(807, 24);
            this.textBoxGenerateRouteAI.TabIndex = 0;
            // 
            // groupBoxRoute
            // 
            this.groupBoxRoute.Controls.Add(this.buttonDeleteRoute);
            this.groupBoxRoute.Controls.Add(this.labelRouteDistance);
            this.groupBoxRoute.Controls.Add(this.labelRouteTime);
            this.groupBoxRoute.Controls.Add(this.label2);
            this.groupBoxRoute.Controls.Add(this.label1);
            this.groupBoxRoute.Controls.Add(this.pictureBox1);
            this.groupBoxRoute.Controls.Add(this.listBoxRouteStops);
            this.groupBoxRoute.Controls.Add(this.buttonAddNewRoute);
            this.groupBoxRoute.Controls.Add(this.textBox2);
            this.groupBoxRoute.Controls.Add(this.label3);
            this.groupBoxRoute.Font = new System.Drawing.Font("Century", 10F);
            this.groupBoxRoute.Location = new System.Drawing.Point(31, 160);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(893, 372);
            this.groupBoxRoute.TabIndex = 9;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "Ruta";
            // 
            // labelRouteDistance
            // 
            this.labelRouteDistance.AutoSize = true;
            this.labelRouteDistance.Location = new System.Drawing.Point(832, 332);
            this.labelRouteDistance.Name = "labelRouteDistance";
            this.labelRouteDistance.Size = new System.Drawing.Size(16, 17);
            this.labelRouteDistance.TabIndex = 10;
            this.labelRouteDistance.Text = "0";
            // 
            // labelRouteTime
            // 
            this.labelRouteTime.AutoSize = true;
            this.labelRouteTime.Location = new System.Drawing.Point(531, 332);
            this.labelRouteTime.Name = "labelRouteTime";
            this.labelRouteTime.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTime.TabIndex = 8;
            this.labelRouteTime.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Distancia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo estimado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARventure_Path.Properties.Resources.maps;
            this.pictureBox1.Location = new System.Drawing.Point(497, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxRouteStops
            // 
            this.listBoxRouteStops.FormattingEnabled = true;
            this.listBoxRouteStops.ItemHeight = 16;
            this.listBoxRouteStops.Location = new System.Drawing.Point(28, 120);
            this.listBoxRouteStops.Name = "listBoxRouteStops";
            this.listBoxRouteStops.Size = new System.Drawing.Size(419, 212);
            this.listBoxRouteStops.TabIndex = 6;
            // 
            // buttonAddNewRoute
            // 
            this.buttonAddNewRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddNewRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddNewRoute.Location = new System.Drawing.Point(248, 69);
            this.buttonAddNewRoute.Name = "buttonAddNewRoute";
            this.buttonAddNewRoute.Size = new System.Drawing.Size(95, 23);
            this.buttonAddNewRoute.TabIndex = 5;
            this.buttonAddNewRoute.Text = "Añadir nuevo";
            this.buttonAddNewRoute.UseVisualStyleBackColor = false;
            this.buttonAddNewRoute.Click += new System.EventHandler(this.buttonAddNewRoute_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 24);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de paradas";
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateRoute.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCreateRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateRoute.Location = new System.Drawing.Point(433, 556);
            this.buttonCreateRoute.Name = "buttonCreateRoute";
            this.buttonCreateRoute.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateRoute.TabIndex = 11;
            this.buttonCreateRoute.Text = "Crear";
            this.buttonCreateRoute.UseVisualStyleBackColor = false;
            // 
            // buttonCancelRoute
            // 
            this.buttonCancelRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelRoute.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCancelRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelRoute.Location = new System.Drawing.Point(528, 556);
            this.buttonCancelRoute.Name = "buttonCancelRoute";
            this.buttonCancelRoute.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRoute.TabIndex = 12;
            this.buttonCancelRoute.Text = "Cancelar";
            this.buttonCancelRoute.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteRoute
            // 
            this.buttonDeleteRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDeleteRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteRoute.Location = new System.Drawing.Point(143, 69);
            this.buttonDeleteRoute.Name = "buttonDeleteRoute";
            this.buttonDeleteRoute.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteRoute.TabIndex = 14;
            this.buttonDeleteRoute.Text = "Eliminar";
            this.buttonDeleteRoute.UseVisualStyleBackColor = false;
            // 
            // RouteCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(964, 601);
            this.Controls.Add(this.buttonCancelRoute);
            this.Controls.Add(this.buttonCreateRoute);
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.groupBoxGenerateRoute);
            this.Controls.Add(this.comboBoxSelectRoute);
            this.Controls.Add(this.labelSelectRoute);
            this.Name = "RouteCreationForm";
            this.Text = "Creación de ruta";
            this.groupBoxGenerateRoute.ResumeLayout(false);
            this.groupBoxGenerateRoute.PerformLayout();
            this.groupBoxRoute.ResumeLayout(false);
            this.groupBoxRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectRoute;
        private System.Windows.Forms.ComboBox comboBoxSelectRoute;
        private System.Windows.Forms.GroupBox groupBoxGenerateRoute;
        private System.Windows.Forms.Button buttonGenerateRoute;
        private System.Windows.Forms.TextBox textBoxGenerateRouteAI;
        private System.Windows.Forms.GroupBox groupBoxRoute;
        private System.Windows.Forms.ListBox listBoxRouteStops;
        private System.Windows.Forms.Button buttonAddNewRoute;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRouteDistance;
        private System.Windows.Forms.Label labelRouteTime;
        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Button buttonCancelRoute;
        private System.Windows.Forms.Button buttonDeleteRoute;
    }
}