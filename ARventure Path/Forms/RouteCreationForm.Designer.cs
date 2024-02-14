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
            this.dataGridViewStops = new System.Windows.Forms.DataGridView();
            this.buttonDeleteStop = new System.Windows.Forms.Button();
            this.labelRouteDistance = new System.Windows.Forms.Label();
            this.labelRouteTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddNewRoute = new System.Windows.Forms.Button();
            this.textBoxStops = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.buttonCancelRoute = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBoxGenerateRoute.SuspendLayout();
            this.groupBoxRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).BeginInit();
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
            this.comboBoxSelectRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.groupBoxRoute.Controls.Add(this.webBrowser1);
            this.groupBoxRoute.Controls.Add(this.dataGridViewStops);
            this.groupBoxRoute.Controls.Add(this.buttonDeleteStop);
            this.groupBoxRoute.Controls.Add(this.labelRouteDistance);
            this.groupBoxRoute.Controls.Add(this.labelRouteTime);
            this.groupBoxRoute.Controls.Add(this.label2);
            this.groupBoxRoute.Controls.Add(this.label1);
            this.groupBoxRoute.Controls.Add(this.pictureBox1);
            this.groupBoxRoute.Controls.Add(this.buttonAddNewRoute);
            this.groupBoxRoute.Controls.Add(this.textBoxStops);
            this.groupBoxRoute.Controls.Add(this.label3);
            this.groupBoxRoute.Font = new System.Drawing.Font("Century", 10F);
            this.groupBoxRoute.Location = new System.Drawing.Point(31, 160);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(893, 372);
            this.groupBoxRoute.TabIndex = 9;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "Ruta";
            // 
            // dataGridViewStops
            // 
            this.dataGridViewStops.AllowUserToAddRows = false;
            this.dataGridViewStops.AllowUserToDeleteRows = false;
            this.dataGridViewStops.AllowUserToResizeColumns = false;
            this.dataGridViewStops.AllowUserToResizeRows = false;
            this.dataGridViewStops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStops.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewStops.Location = new System.Drawing.Point(28, 120);
            this.dataGridViewStops.Name = "dataGridViewStops";
            this.dataGridViewStops.ReadOnly = true;
            this.dataGridViewStops.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStops.Size = new System.Drawing.Size(421, 212);
            this.dataGridViewStops.TabIndex = 15;
            // 
            // buttonDeleteStop
            // 
            this.buttonDeleteStop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDeleteStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteStop.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteStop.Location = new System.Drawing.Point(143, 69);
            this.buttonDeleteStop.Name = "buttonDeleteStop";
            this.buttonDeleteStop.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteStop.TabIndex = 14;
            this.buttonDeleteStop.Text = "Eliminar";
            this.buttonDeleteStop.UseVisualStyleBackColor = false;
            this.buttonDeleteStop.Click += new System.EventHandler(this.buttonDeleteStop_Click);
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
            // textBoxStops
            // 
            this.textBoxStops.Location = new System.Drawing.Point(264, 32);
            this.textBoxStops.Name = "textBoxStops";
            this.textBoxStops.Size = new System.Drawing.Size(63, 24);
            this.textBoxStops.TabIndex = 4;
            this.textBoxStops.TextChanged += new System.EventHandler(this.textBoxStops_TextChanged);
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
            this.buttonCreateRoute.Click += new System.EventHandler(this.buttonCreateRoute_Click);
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
            this.buttonCancelRoute.Click += new System.EventHandler(this.buttonCancelRoute_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(497, 32);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(377, 250);
            this.webBrowser1.TabIndex = 16;
            // 
            // RouteCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(964, 611);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).EndInit();
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
        private System.Windows.Forms.Button buttonAddNewRoute;
        private System.Windows.Forms.TextBox textBoxStops;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRouteDistance;
        private System.Windows.Forms.Label labelRouteTime;
        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Button buttonCancelRoute;
        private System.Windows.Forms.Button buttonDeleteStop;
        private System.Windows.Forms.DataGridView dataGridViewStops;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}