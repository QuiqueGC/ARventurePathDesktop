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
            this.components = new System.ComponentModel.Container();
            this.labelSelectRoute = new System.Windows.Forms.Label();
            this.comboBoxSelectRoute = new System.Windows.Forms.ComboBox();
            this.bindingSourceRoute = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxIA = new System.Windows.Forms.GroupBox();
            this.textBoxNumberStops = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerateRoute = new System.Windows.Forms.Button();
            this.textBoxGenerateRouteAI = new System.Windows.Forms.TextBox();
            this.groupBoxRoute = new System.Windows.Forms.GroupBox();
            this.buttonStopChange = new System.Windows.Forms.Button();
            this.labelRuta = new System.Windows.Forms.Label();
            this.textBoxNameRoute = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStopName = new System.Windows.Forms.TextBox();
            this.labelStopName = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridViewStops = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceStops = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteStop = new System.Windows.Forms.Button();
            this.labelRouteDistance = new System.Windows.Forms.Label();
            this.labelRouteTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNewStop = new System.Windows.Forms.Button();
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.buttonCancelRoute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).BeginInit();
            this.groupBoxIA.SuspendLayout();
            this.groupBoxRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStops)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectRoute
            // 
            this.labelSelectRoute.AutoSize = true;
            this.labelSelectRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSelectRoute.Location = new System.Drawing.Point(23, 19);
            this.labelSelectRoute.Name = "labelSelectRoute";
            this.labelSelectRoute.Size = new System.Drawing.Size(140, 20);
            this.labelSelectRoute.TabIndex = 1;
            this.labelSelectRoute.Text = "Seleccionar ruta";
            // 
            // comboBoxSelectRoute
            // 
            this.comboBoxSelectRoute.DataSource = this.bindingSourceRoute;
            this.comboBoxSelectRoute.DisplayMember = "name";
            this.comboBoxSelectRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectRoute.FormattingEnabled = true;
            this.comboBoxSelectRoute.Location = new System.Drawing.Point(174, 21);
            this.comboBoxSelectRoute.Name = "comboBoxSelectRoute";
            this.comboBoxSelectRoute.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectRoute.TabIndex = 2;
            this.comboBoxSelectRoute.ValueMember = "id";
            this.comboBoxSelectRoute.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectRoute_SelectedIndexChanged);
            // 
            // bindingSourceRoute
            // 
            this.bindingSourceRoute.DataSource = typeof(ARventure_Path.Models.route);
            // 
            // groupBoxIA
            // 
            this.groupBoxIA.Controls.Add(this.textBoxNumberStops);
            this.groupBoxIA.Controls.Add(this.label6);
            this.groupBoxIA.Controls.Add(this.label3);
            this.groupBoxIA.Controls.Add(this.buttonGenerateRoute);
            this.groupBoxIA.Controls.Add(this.textBoxGenerateRouteAI);
            this.groupBoxIA.Enabled = false;
            this.groupBoxIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxIA.Location = new System.Drawing.Point(26, 52);
            this.groupBoxIA.Name = "groupBoxIA";
            this.groupBoxIA.Size = new System.Drawing.Size(898, 91);
            this.groupBoxIA.TabIndex = 2;
            this.groupBoxIA.TabStop = false;
            this.groupBoxIA.Text = "Generar por IA";
            // 
            // textBoxNumberStops
            // 
            this.textBoxNumberStops.Location = new System.Drawing.Point(841, 33);
            this.textBoxNumberStops.Name = "textBoxNumberStops";
            this.textBoxNumberStops.Size = new System.Drawing.Size(51, 23);
            this.textBoxNumberStops.TabIndex = 28;
            this.textBoxNumberStops.TextChanged += new System.EventHandler(this.textBoxNumberStops_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(686, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Número de paradas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Input IA";
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
            this.buttonGenerateRoute.Click += new System.EventHandler(this.buttonGenerateRoute_Click);
            // 
            // textBoxGenerateRouteAI
            // 
            this.textBoxGenerateRouteAI.Location = new System.Drawing.Point(87, 33);
            this.textBoxGenerateRouteAI.Name = "textBoxGenerateRouteAI";
            this.textBoxGenerateRouteAI.Size = new System.Drawing.Size(593, 23);
            this.textBoxGenerateRouteAI.TabIndex = 0;
            // 
            // groupBoxRoute
            // 
            this.groupBoxRoute.Controls.Add(this.buttonStopChange);
            this.groupBoxRoute.Controls.Add(this.labelRuta);
            this.groupBoxRoute.Controls.Add(this.textBoxNameRoute);
            this.groupBoxRoute.Controls.Add(this.textBoxLongitude);
            this.groupBoxRoute.Controls.Add(this.textBoxLatitude);
            this.groupBoxRoute.Controls.Add(this.label4);
            this.groupBoxRoute.Controls.Add(this.label5);
            this.groupBoxRoute.Controls.Add(this.textBoxStopName);
            this.groupBoxRoute.Controls.Add(this.labelStopName);
            this.groupBoxRoute.Controls.Add(this.gMapControl1);
            this.groupBoxRoute.Controls.Add(this.dataGridViewStops);
            this.groupBoxRoute.Controls.Add(this.buttonDeleteStop);
            this.groupBoxRoute.Controls.Add(this.labelRouteDistance);
            this.groupBoxRoute.Controls.Add(this.labelRouteTime);
            this.groupBoxRoute.Controls.Add(this.label2);
            this.groupBoxRoute.Controls.Add(this.label1);
            this.groupBoxRoute.Controls.Add(this.buttonAddNewStop);
            this.groupBoxRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxRoute.Location = new System.Drawing.Point(31, 160);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(893, 372);
            this.groupBoxRoute.TabIndex = 9;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "Ruta";
            // 
            // buttonStopChange
            // 
            this.buttonStopChange.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonStopChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopChange.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStopChange.Location = new System.Drawing.Point(23, 296);
            this.buttonStopChange.Name = "buttonStopChange";
            this.buttonStopChange.Size = new System.Drawing.Size(132, 29);
            this.buttonStopChange.TabIndex = 25;
            this.buttonStopChange.Text = "Cambiar parada";
            this.buttonStopChange.UseVisualStyleBackColor = false;
            this.buttonStopChange.Click += new System.EventHandler(this.buttonStopChange_Click);
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRuta.Location = new System.Drawing.Point(10, 35);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(135, 20);
            this.labelRuta.TabIndex = 24;
            this.labelRuta.Text = "Nombre de la ruta";
            // 
            // textBoxNameRoute
            // 
            this.textBoxNameRoute.Location = new System.Drawing.Point(13, 55);
            this.textBoxNameRoute.Name = "textBoxNameRoute";
            this.textBoxNameRoute.Size = new System.Drawing.Size(151, 23);
            this.textBoxNameRoute.TabIndex = 23;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(13, 192);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(151, 23);
            this.textBoxLongitude.TabIndex = 22;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(13, 267);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(151, 23);
            this.textBoxLatitude.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Longitud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Latitud";
            // 
            // textBoxStopName
            // 
            this.textBoxStopName.Location = new System.Drawing.Point(13, 121);
            this.textBoxStopName.Name = "textBoxStopName";
            this.textBoxStopName.Size = new System.Drawing.Size(151, 23);
            this.textBoxStopName.TabIndex = 18;
            // 
            // labelStopName
            // 
            this.labelStopName.AutoSize = true;
            this.labelStopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopName.Location = new System.Drawing.Point(9, 100);
            this.labelStopName.Name = "labelStopName";
            this.labelStopName.Size = new System.Drawing.Size(120, 20);
            this.labelStopName.TabIndex = 17;
            this.labelStopName.Text = "Nombre Parada";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(436, 14);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(451, 307);
            this.gMapControl1.TabIndex = 16;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // dataGridViewStops
            // 
            this.dataGridViewStops.AllowUserToAddRows = false;
            this.dataGridViewStops.AllowUserToDeleteRows = false;
            this.dataGridViewStops.AllowUserToResizeColumns = false;
            this.dataGridViewStops.AllowUserToResizeRows = false;
            this.dataGridViewStops.AutoGenerateColumns = false;
            this.dataGridViewStops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn});
            this.dataGridViewStops.DataSource = this.bindingSourceStops;
            this.dataGridViewStops.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewStops.Location = new System.Drawing.Point(170, 14);
            this.dataGridViewStops.MultiSelect = false;
            this.dataGridViewStops.Name = "dataGridViewStops";
            this.dataGridViewStops.ReadOnly = true;
            this.dataGridViewStops.RowHeadersVisible = false;
            this.dataGridViewStops.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStops.Size = new System.Drawing.Size(260, 307);
            this.dataGridViewStops.TabIndex = 15;
            this.dataGridViewStops.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStops_CellMouseClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceStops
            // 
            this.bindingSourceStops.DataSource = typeof(ARventure_Path.Models.stop);
            // 
            // buttonDeleteStop
            // 
            this.buttonDeleteStop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDeleteStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteStop.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteStop.Location = new System.Drawing.Point(170, 327);
            this.buttonDeleteStop.Name = "buttonDeleteStop";
            this.buttonDeleteStop.Size = new System.Drawing.Size(129, 29);
            this.buttonDeleteStop.TabIndex = 14;
            this.buttonDeleteStop.Text = "Eliminar";
            this.buttonDeleteStop.UseVisualStyleBackColor = false;
            this.buttonDeleteStop.Click += new System.EventHandler(this.buttonDeleteStop_Click);
            // 
            // labelRouteDistance
            // 
            this.labelRouteDistance.AutoSize = true;
            this.labelRouteDistance.Location = new System.Drawing.Point(790, 350);
            this.labelRouteDistance.Name = "labelRouteDistance";
            this.labelRouteDistance.Size = new System.Drawing.Size(16, 17);
            this.labelRouteDistance.TabIndex = 10;
            this.labelRouteDistance.Text = "0";
            // 
            // labelRouteTime
            // 
            this.labelRouteTime.AutoSize = true;
            this.labelRouteTime.Location = new System.Drawing.Point(484, 350);
            this.labelRouteTime.Name = "labelRouteTime";
            this.labelRouteTime.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTime.TabIndex = 8;
            this.labelRouteTime.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Distancia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo estimado";
            // 
            // buttonAddNewStop
            // 
            this.buttonAddNewStop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddNewStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewStop.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddNewStop.Location = new System.Drawing.Point(305, 327);
            this.buttonAddNewStop.Name = "buttonAddNewStop";
            this.buttonAddNewStop.Size = new System.Drawing.Size(125, 29);
            this.buttonAddNewStop.TabIndex = 5;
            this.buttonAddNewStop.Text = "Añadir";
            this.buttonAddNewStop.UseVisualStyleBackColor = false;
            this.buttonAddNewStop.Click += new System.EventHandler(this.buttonAddNewStop_Click);
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.buttonCancelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancelRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelRoute.Location = new System.Drawing.Point(528, 556);
            this.buttonCancelRoute.Name = "buttonCancelRoute";
            this.buttonCancelRoute.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRoute.TabIndex = 12;
            this.buttonCancelRoute.Text = "Cancelar";
            this.buttonCancelRoute.UseVisualStyleBackColor = false;
            this.buttonCancelRoute.Click += new System.EventHandler(this.buttonCancelRoute_Click);
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
            this.Controls.Add(this.groupBoxIA);
            this.Controls.Add(this.comboBoxSelectRoute);
            this.Controls.Add(this.labelSelectRoute);
            this.Name = "RouteCreationForm";
            this.Text = "Creación de ruta";
            this.Load += new System.EventHandler(this.RouteCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).EndInit();
            this.groupBoxIA.ResumeLayout(false);
            this.groupBoxIA.PerformLayout();
            this.groupBoxRoute.ResumeLayout(false);
            this.groupBoxRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectRoute;
        private System.Windows.Forms.ComboBox comboBoxSelectRoute;
        private System.Windows.Forms.GroupBox groupBoxIA;
        private System.Windows.Forms.Button buttonGenerateRoute;
        private System.Windows.Forms.TextBox textBoxGenerateRouteAI;
        private System.Windows.Forms.GroupBox groupBoxRoute;
        private System.Windows.Forms.Button buttonAddNewStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRouteDistance;
        private System.Windows.Forms.Label labelRouteTime;
        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Button buttonCancelRoute;
        private System.Windows.Forms.Button buttonDeleteStop;
        private System.Windows.Forms.DataGridView dataGridViewStops;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStopName;
        private System.Windows.Forms.Label labelStopName;
        private System.Windows.Forms.BindingSource bindingSourceRoute;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.TextBox textBoxNameRoute;
        private System.Windows.Forms.BindingSource bindingSourceStops;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonStopChange;
        private System.Windows.Forms.TextBox textBoxNumberStops;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}