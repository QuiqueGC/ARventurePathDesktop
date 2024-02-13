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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBoxGenerateRoute.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectRoute
            // 
            this.labelSelectRoute.AutoSize = true;
            this.labelSelectRoute.Location = new System.Drawing.Point(23, 19);
            this.labelSelectRoute.Name = "labelSelectRoute";
            this.labelSelectRoute.Size = new System.Drawing.Size(84, 13);
            this.labelSelectRoute.TabIndex = 1;
            this.labelSelectRoute.Text = "Seleccionar ruta";
            // 
            // comboBoxSelectRoute
            // 
            this.comboBoxSelectRoute.FormattingEnabled = true;
            this.comboBoxSelectRoute.Location = new System.Drawing.Point(129, 16);
            this.comboBoxSelectRoute.Name = "comboBoxSelectRoute";
            this.comboBoxSelectRoute.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectRoute.TabIndex = 2;
            // 
            // groupBoxGenerateRoute
            // 
            this.groupBoxGenerateRoute.Controls.Add(this.buttonGenerateRoute);
            this.groupBoxGenerateRoute.Controls.Add(this.textBoxGenerateRouteAI);
            this.groupBoxGenerateRoute.Location = new System.Drawing.Point(26, 52);
            this.groupBoxGenerateRoute.Name = "groupBoxGenerateRoute";
            this.groupBoxGenerateRoute.Size = new System.Drawing.Size(898, 91);
            this.groupBoxGenerateRoute.TabIndex = 3;
            this.groupBoxGenerateRoute.TabStop = false;
            this.groupBoxGenerateRoute.Text = "Generar por IA";
            // 
            // buttonGenerateRoute
            // 
            this.buttonGenerateRoute.Location = new System.Drawing.Point(18, 59);
            this.buttonGenerateRoute.Name = "buttonGenerateRoute";
            this.buttonGenerateRoute.Size = new System.Drawing.Size(103, 23);
            this.buttonGenerateRoute.TabIndex = 1;
            this.buttonGenerateRoute.Text = "Generar ruta";
            this.buttonGenerateRoute.UseVisualStyleBackColor = true;
            // 
            // textBoxGenerateRouteAI
            // 
            this.textBoxGenerateRouteAI.Location = new System.Drawing.Point(18, 33);
            this.textBoxGenerateRouteAI.Name = "textBoxGenerateRouteAI";
            this.textBoxGenerateRouteAI.Size = new System.Drawing.Size(807, 20);
            this.textBoxGenerateRouteAI.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRouteDistance);
            this.groupBox2.Controls.Add(this.labelRouteTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.listBoxRouteStops);
            this.groupBox2.Controls.Add(this.buttonAddNewRoute);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(31, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 372);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ruta";
            // 
            // labelRouteDistance
            // 
            this.labelRouteDistance.AutoSize = true;
            this.labelRouteDistance.Location = new System.Drawing.Point(826, 332);
            this.labelRouteDistance.Name = "labelRouteDistance";
            this.labelRouteDistance.Size = new System.Drawing.Size(13, 13);
            this.labelRouteDistance.TabIndex = 15;
            this.labelRouteDistance.Text = "0";
            // 
            // labelRouteTime
            // 
            this.labelRouteTime.AutoSize = true;
            this.labelRouteTime.Location = new System.Drawing.Point(531, 332);
            this.labelRouteTime.Name = "labelRouteTime";
            this.labelRouteTime.Size = new System.Drawing.Size(13, 13);
            this.labelRouteTime.TabIndex = 14;
            this.labelRouteTime.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Distancia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
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
            this.listBoxRouteStops.Location = new System.Drawing.Point(28, 120);
            this.listBoxRouteStops.Name = "listBoxRouteStops";
            this.listBoxRouteStops.Size = new System.Drawing.Size(419, 225);
            this.listBoxRouteStops.TabIndex = 4;
            // 
            // buttonAddNewRoute
            // 
            this.buttonAddNewRoute.Location = new System.Drawing.Point(193, 69);
            this.buttonAddNewRoute.Name = "buttonAddNewRoute";
            this.buttonAddNewRoute.Size = new System.Drawing.Size(95, 23);
            this.buttonAddNewRoute.TabIndex = 4;
            this.buttonAddNewRoute.Text = "Añadir nuevo";
            this.buttonAddNewRoute.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de paradas";
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.Location = new System.Drawing.Point(433, 556);
            this.buttonCreateRoute.Name = "buttonCreateRoute";
            this.buttonCreateRoute.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateRoute.TabIndex = 5;
            this.buttonCreateRoute.Text = "Crear";
            this.buttonCreateRoute.UseVisualStyleBackColor = true;
            // 
            // buttonCancelRoute
            // 
            this.buttonCancelRoute.Location = new System.Drawing.Point(528, 556);
            this.buttonCancelRoute.Name = "buttonCancelRoute";
            this.buttonCancelRoute.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRoute.TabIndex = 6;
            this.buttonCancelRoute.Text = "Cancelar";
            this.buttonCancelRoute.UseVisualStyleBackColor = true;
            // 
            // RouteCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 601);
            this.Controls.Add(this.buttonCancelRoute);
            this.Controls.Add(this.buttonCreateRoute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxGenerateRoute);
            this.Controls.Add(this.comboBoxSelectRoute);
            this.Controls.Add(this.labelSelectRoute);
            this.Name = "RouteCreationForm";
            this.Text = "Creación de ruta";
            this.groupBoxGenerateRoute.ResumeLayout(false);
            this.groupBoxGenerateRoute.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}