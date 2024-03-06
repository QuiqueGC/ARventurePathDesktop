namespace ARventure_Path.Forms
{
    partial class ARventureCreationForm
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
            this.labelSelectArventure = new System.Windows.Forms.Label();
            this.comboBoxSelectArventure = new System.Windows.Forms.ComboBox();
            this.bindingSourceArventure = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxStory = new System.Windows.Forms.GroupBox();
            this.buttonSeeDetailStory = new System.Windows.Forms.Button();
            this.buttonSelectStory = new System.Windows.Forms.Button();
            this.listBoxStories = new System.Windows.Forms.ListBox();
            this.bindingSourceStory = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxRoutes = new System.Windows.Forms.GroupBox();
            this.buttonSeeDetailRoute = new System.Windows.Forms.Button();
            this.buttonSelectRoute = new System.Windows.Forms.Button();
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.bindingSourceRoute = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxHappening = new System.Windows.Forms.GroupBox();
            this.dataGridViewHappening = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHappening = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSeeDetailEvent = new System.Windows.Forms.Button();
            this.buttonSelectEvent = new System.Windows.Forms.Button();
            this.groupBoxArventure = new System.Windows.Forms.GroupBox();
            this.groupBoxHappenings = new System.Windows.Forms.GroupBox();
            this.buttonRemoveEvent = new System.Windows.Forms.Button();
            this.listBoxSelectEvents = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxRouteStops = new System.Windows.Forms.ListBox();
            this.labelTimeRoute = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDistanceRoute = new System.Windows.Forms.Label();
            this.labelRouteName = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.textBoxTitleArventure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelStoryTitle = new System.Windows.Forms.Label();
            this.textBoxStorySummary = new System.Windows.Forms.TextBox();
            this.pictureBoxStoryImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateArventure = new System.Windows.Forms.Button();
            this.buttonCancelArventure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArventure)).BeginInit();
            this.groupBoxStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.groupBoxRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).BeginInit();
            this.groupBoxHappening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHappening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappening)).BeginInit();
            this.groupBoxArventure.SuspendLayout();
            this.groupBoxHappenings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoryImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectArventure
            // 
            this.labelSelectArventure.AutoSize = true;
            this.labelSelectArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectArventure.Location = new System.Drawing.Point(44, 35);
            this.labelSelectArventure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSelectArventure.Name = "labelSelectArventure";
            this.labelSelectArventure.Size = new System.Drawing.Size(304, 31);
            this.labelSelectArventure.TabIndex = 2;
            this.labelSelectArventure.Text = "Seleccionar Arventure";
            // 
            // comboBoxSelectArventure
            // 
            this.comboBoxSelectArventure.DataSource = this.bindingSourceArventure;
            this.comboBoxSelectArventure.DisplayMember = "name";
            this.comboBoxSelectArventure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectArventure.FormattingEnabled = true;
            this.comboBoxSelectArventure.Location = new System.Drawing.Point(376, 33);
            this.comboBoxSelectArventure.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSelectArventure.Name = "comboBoxSelectArventure";
            this.comboBoxSelectArventure.Size = new System.Drawing.Size(486, 33);
            this.comboBoxSelectArventure.TabIndex = 3;
            this.comboBoxSelectArventure.ValueMember = "id";
            this.comboBoxSelectArventure.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectArventure_SelectedIndexChanged);
            // 
            // bindingSourceArventure
            // 
            this.bindingSourceArventure.DataSource = typeof(ARventure_Path.Models.arventure);
            // 
            // groupBoxStory
            // 
            this.groupBoxStory.Controls.Add(this.buttonSeeDetailStory);
            this.groupBoxStory.Controls.Add(this.buttonSelectStory);
            this.groupBoxStory.Controls.Add(this.listBoxStories);
            this.groupBoxStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStory.Location = new System.Drawing.Point(50, 92);
            this.groupBoxStory.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxStory.Name = "groupBoxStory";
            this.groupBoxStory.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxStory.Size = new System.Drawing.Size(538, 398);
            this.groupBoxStory.TabIndex = 4;
            this.groupBoxStory.TabStop = false;
            this.groupBoxStory.Text = "Historias";
            // 
            // buttonSeeDetailStory
            // 
            this.buttonSeeDetailStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSeeDetailStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeeDetailStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeDetailStory.Location = new System.Drawing.Point(290, 325);
            this.buttonSeeDetailStory.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSeeDetailStory.Name = "buttonSeeDetailStory";
            this.buttonSeeDetailStory.Size = new System.Drawing.Size(204, 44);
            this.buttonSeeDetailStory.TabIndex = 2;
            this.buttonSeeDetailStory.Text = "Ver detalles";
            this.buttonSeeDetailStory.UseVisualStyleBackColor = false;
            // 
            // buttonSelectStory
            // 
            this.buttonSelectStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelectStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectStory.Location = new System.Drawing.Point(42, 325);
            this.buttonSelectStory.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectStory.Name = "buttonSelectStory";
            this.buttonSelectStory.Size = new System.Drawing.Size(216, 44);
            this.buttonSelectStory.TabIndex = 1;
            this.buttonSelectStory.Text = "Seleccionar";
            this.buttonSelectStory.UseVisualStyleBackColor = false;
            this.buttonSelectStory.Click += new System.EventHandler(this.buttonSelectStory_Click);
            // 
            // listBoxStories
            // 
            this.listBoxStories.DataSource = this.bindingSourceStory;
            this.listBoxStories.DisplayMember = "name";
            this.listBoxStories.FormattingEnabled = true;
            this.listBoxStories.ItemHeight = 31;
            this.listBoxStories.Location = new System.Drawing.Point(24, 46);
            this.listBoxStories.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxStories.Name = "listBoxStories";
            this.listBoxStories.Size = new System.Drawing.Size(492, 221);
            this.listBoxStories.TabIndex = 0;
            this.listBoxStories.ValueMember = "id";
            this.listBoxStories.SelectedIndexChanged += new System.EventHandler(this.listBoxStories_SelectedIndexChanged);
            // 
            // bindingSourceStory
            // 
            this.bindingSourceStory.DataSource = typeof(ARventure_Path.Models.story);
            // 
            // groupBoxRoutes
            // 
            this.groupBoxRoutes.Controls.Add(this.buttonSeeDetailRoute);
            this.groupBoxRoutes.Controls.Add(this.buttonSelectRoute);
            this.groupBoxRoutes.Controls.Add(this.listBoxRoutes);
            this.groupBoxRoutes.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoutes.Location = new System.Drawing.Point(672, 92);
            this.groupBoxRoutes.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxRoutes.Name = "groupBoxRoutes";
            this.groupBoxRoutes.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxRoutes.Size = new System.Drawing.Size(520, 398);
            this.groupBoxRoutes.TabIndex = 5;
            this.groupBoxRoutes.TabStop = false;
            this.groupBoxRoutes.Text = "Rutas";
            // 
            // buttonSeeDetailRoute
            // 
            this.buttonSeeDetailRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSeeDetailRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeeDetailRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeDetailRoute.Location = new System.Drawing.Point(256, 325);
            this.buttonSeeDetailRoute.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSeeDetailRoute.Name = "buttonSeeDetailRoute";
            this.buttonSeeDetailRoute.Size = new System.Drawing.Size(204, 44);
            this.buttonSeeDetailRoute.TabIndex = 3;
            this.buttonSeeDetailRoute.Text = "Ver detalles";
            this.buttonSeeDetailRoute.UseVisualStyleBackColor = false;
            // 
            // buttonSelectRoute
            // 
            this.buttonSelectRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelectRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectRoute.Location = new System.Drawing.Point(60, 325);
            this.buttonSelectRoute.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectRoute.Name = "buttonSelectRoute";
            this.buttonSelectRoute.Size = new System.Drawing.Size(184, 44);
            this.buttonSelectRoute.TabIndex = 3;
            this.buttonSelectRoute.Text = "Seleccionar";
            this.buttonSelectRoute.UseVisualStyleBackColor = false;
            this.buttonSelectRoute.Click += new System.EventHandler(this.buttonSelectRoute_Click);
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.DataSource = this.bindingSourceRoute;
            this.listBoxRoutes.DisplayMember = "name";
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.ItemHeight = 31;
            this.listBoxRoutes.Location = new System.Drawing.Point(26, 46);
            this.listBoxRoutes.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(470, 221);
            this.listBoxRoutes.TabIndex = 1;
            this.listBoxRoutes.ValueMember = "id";
            this.listBoxRoutes.SelectedIndexChanged += new System.EventHandler(this.listBoxRoutes_SelectedIndexChanged);
            // 
            // bindingSourceRoute
            // 
            this.bindingSourceRoute.DataSource = typeof(ARventure_Path.Models.route);
            // 
            // groupBoxHappening
            // 
            this.groupBoxHappening.Controls.Add(this.dataGridViewHappening);
            this.groupBoxHappening.Controls.Add(this.buttonSeeDetailEvent);
            this.groupBoxHappening.Controls.Add(this.buttonSelectEvent);
            this.groupBoxHappening.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHappening.Location = new System.Drawing.Point(1272, 92);
            this.groupBoxHappening.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxHappening.Name = "groupBoxHappening";
            this.groupBoxHappening.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxHappening.Size = new System.Drawing.Size(586, 398);
            this.groupBoxHappening.TabIndex = 6;
            this.groupBoxHappening.TabStop = false;
            this.groupBoxHappening.Text = "Eventos";
            // 
            // dataGridViewHappening
            // 
            this.dataGridViewHappening.AllowUserToAddRows = false;
            this.dataGridViewHappening.AllowUserToDeleteRows = false;
            this.dataGridViewHappening.AutoGenerateColumns = false;
            this.dataGridViewHappening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHappening.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewHappening.DataSource = this.bindingSourceHappening;
            this.dataGridViewHappening.Location = new System.Drawing.Point(26, 44);
            this.dataGridViewHappening.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewHappening.Name = "dataGridViewHappening";
            this.dataGridViewHappening.ReadOnly = true;
            this.dataGridViewHappening.RowHeadersVisible = false;
            this.dataGridViewHappening.RowHeadersWidth = 82;
            this.dataGridViewHappening.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHappening.Size = new System.Drawing.Size(540, 258);
            this.dataGridViewHappening.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 200;
            // 
            // bindingSourceHappening
            // 
            this.bindingSourceHappening.DataSource = typeof(ARventure_Path.Models.happening);
            // 
            // buttonSeeDetailEvent
            // 
            this.buttonSeeDetailEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSeeDetailEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeeDetailEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeDetailEvent.Location = new System.Drawing.Point(314, 325);
            this.buttonSeeDetailEvent.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSeeDetailEvent.Name = "buttonSeeDetailEvent";
            this.buttonSeeDetailEvent.Size = new System.Drawing.Size(196, 44);
            this.buttonSeeDetailEvent.TabIndex = 4;
            this.buttonSeeDetailEvent.Text = "Ver detalles";
            this.buttonSeeDetailEvent.UseVisualStyleBackColor = false;
            // 
            // buttonSelectEvent
            // 
            this.buttonSelectEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelectEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectEvent.Location = new System.Drawing.Point(82, 325);
            this.buttonSelectEvent.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectEvent.Name = "buttonSelectEvent";
            this.buttonSelectEvent.Size = new System.Drawing.Size(194, 44);
            this.buttonSelectEvent.TabIndex = 4;
            this.buttonSelectEvent.Text = "Seleccionar";
            this.buttonSelectEvent.UseVisualStyleBackColor = false;
            this.buttonSelectEvent.Click += new System.EventHandler(this.buttonSelectEvent_Click);
            // 
            // groupBoxArventure
            // 
            this.groupBoxArventure.Controls.Add(this.groupBoxHappenings);
            this.groupBoxArventure.Controls.Add(this.groupBox5);
            this.groupBoxArventure.Controls.Add(this.textBoxTitleArventure);
            this.groupBoxArventure.Controls.Add(this.label2);
            this.groupBoxArventure.Controls.Add(this.groupBox4);
            this.groupBoxArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxArventure.Location = new System.Drawing.Point(50, 502);
            this.groupBoxArventure.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxArventure.Name = "groupBoxArventure";
            this.groupBoxArventure.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxArventure.Size = new System.Drawing.Size(1808, 575);
            this.groupBoxArventure.TabIndex = 7;
            this.groupBoxArventure.TabStop = false;
            this.groupBoxArventure.Text = "Aventura";
            // 
            // groupBoxHappenings
            // 
            this.groupBoxHappenings.Controls.Add(this.buttonRemoveEvent);
            this.groupBoxHappenings.Controls.Add(this.listBoxSelectEvents);
            this.groupBoxHappenings.Location = new System.Drawing.Point(1246, 106);
            this.groupBoxHappenings.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxHappenings.Name = "groupBoxHappenings";
            this.groupBoxHappenings.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxHappenings.Size = new System.Drawing.Size(524, 435);
            this.groupBoxHappenings.TabIndex = 8;
            this.groupBoxHappenings.TabStop = false;
            this.groupBoxHappenings.Text = "Eventos";
            // 
            // buttonRemoveEvent
            // 
            this.buttonRemoveEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRemoveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveEvent.Location = new System.Drawing.Point(148, 367);
            this.buttonRemoveEvent.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRemoveEvent.Name = "buttonRemoveEvent";
            this.buttonRemoveEvent.Size = new System.Drawing.Size(250, 44);
            this.buttonRemoveEvent.TabIndex = 8;
            this.buttonRemoveEvent.Text = "Eliminar evento";
            this.buttonRemoveEvent.UseVisualStyleBackColor = false;
            this.buttonRemoveEvent.Click += new System.EventHandler(this.buttonRemoveEvent_Click);
            // 
            // listBoxSelectEvents
            // 
            this.listBoxSelectEvents.FormattingEnabled = true;
            this.listBoxSelectEvents.ItemHeight = 31;
            this.listBoxSelectEvents.Location = new System.Drawing.Point(26, 63);
            this.listBoxSelectEvents.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxSelectEvents.Name = "listBoxSelectEvents";
            this.listBoxSelectEvents.Size = new System.Drawing.Size(476, 252);
            this.listBoxSelectEvents.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxRouteStops);
            this.groupBox5.Controls.Add(this.labelTimeRoute);
            this.groupBox5.Controls.Add(this.labelTime);
            this.groupBox5.Controls.Add(this.labelDistanceRoute);
            this.groupBox5.Controls.Add(this.labelRouteName);
            this.groupBox5.Controls.Add(this.labelDistance);
            this.groupBox5.Location = new System.Drawing.Point(658, 106);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(524, 435);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ruta";
            // 
            // listBoxRouteStops
            // 
            this.listBoxRouteStops.FormattingEnabled = true;
            this.listBoxRouteStops.ItemHeight = 31;
            this.listBoxRouteStops.Location = new System.Drawing.Point(24, 202);
            this.listBoxRouteStops.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxRouteStops.Name = "listBoxRouteStops";
            this.listBoxRouteStops.Size = new System.Drawing.Size(472, 159);
            this.listBoxRouteStops.TabIndex = 9;
            // 
            // labelTimeRoute
            // 
            this.labelTimeRoute.AutoSize = true;
            this.labelTimeRoute.Location = new System.Drawing.Point(186, 146);
            this.labelTimeRoute.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTimeRoute.Name = "labelTimeRoute";
            this.labelTimeRoute.Size = new System.Drawing.Size(28, 31);
            this.labelTimeRoute.TabIndex = 8;
            this.labelTimeRoute.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(46, 146);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(103, 31);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Tiempo";
            // 
            // labelDistanceRoute
            // 
            this.labelDistanceRoute.AutoSize = true;
            this.labelDistanceRoute.Location = new System.Drawing.Point(186, 94);
            this.labelDistanceRoute.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDistanceRoute.Name = "labelDistanceRoute";
            this.labelDistanceRoute.Size = new System.Drawing.Size(28, 31);
            this.labelDistanceRoute.TabIndex = 6;
            this.labelDistanceRoute.Text = "0";
            // 
            // labelRouteName
            // 
            this.labelRouteName.AutoSize = true;
            this.labelRouteName.Location = new System.Drawing.Point(150, 37);
            this.labelRouteName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRouteName.Name = "labelRouteName";
            this.labelRouteName.Size = new System.Drawing.Size(233, 31);
            this.labelRouteName.TabIndex = 3;
            this.labelRouteName.Text = "Nombre de la ruta";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(46, 94);
            this.labelDistance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(128, 31);
            this.labelDistance.TabIndex = 5;
            this.labelDistance.Text = "Distancia";
            // 
            // textBoxTitleArventure
            // 
            this.textBoxTitleArventure.Location = new System.Drawing.Point(768, 31);
            this.textBoxTitleArventure.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTitleArventure.Multiline = true;
            this.textBoxTitleArventure.Name = "textBoxTitleArventure";
            this.textBoxTitleArventure.Size = new System.Drawing.Size(572, 39);
            this.textBoxTitleArventure.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título de la Aventura";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelStoryTitle);
            this.groupBox4.Controls.Add(this.textBoxStorySummary);
            this.groupBox4.Controls.Add(this.pictureBoxStoryImg);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(42, 106);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(524, 435);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Historia";
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(140, 37);
            this.labelStoryTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(250, 31);
            this.labelStoryTitle.TabIndex = 3;
            this.labelStoryTitle.Text = "Título de la historia";
            // 
            // textBoxStorySummary
            // 
            this.textBoxStorySummary.Location = new System.Drawing.Point(30, 333);
            this.textBoxStorySummary.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxStorySummary.Multiline = true;
            this.textBoxStorySummary.Name = "textBoxStorySummary";
            this.textBoxStorySummary.Size = new System.Drawing.Size(444, 73);
            this.textBoxStorySummary.TabIndex = 6;
            // 
            // pictureBoxStoryImg
            // 
            this.pictureBoxStoryImg.Image = global::ARventure_Path.Properties.Resources.Login_Aventuras;
            this.pictureBoxStoryImg.Location = new System.Drawing.Point(30, 94);
            this.pictureBoxStoryImg.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxStoryImg.Name = "pictureBoxStoryImg";
            this.pictureBoxStoryImg.Size = new System.Drawing.Size(448, 181);
            this.pictureBoxStoryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStoryImg.TabIndex = 4;
            this.pictureBoxStoryImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resumen";
            // 
            // buttonCreateArventure
            // 
            this.buttonCreateArventure.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateArventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateArventure.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateArventure.Location = new System.Drawing.Point(824, 1098);
            this.buttonCreateArventure.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreateArventure.Name = "buttonCreateArventure";
            this.buttonCreateArventure.Size = new System.Drawing.Size(150, 44);
            this.buttonCreateArventure.TabIndex = 8;
            this.buttonCreateArventure.Text = "Crear";
            this.buttonCreateArventure.UseVisualStyleBackColor = false;
            this.buttonCreateArventure.Click += new System.EventHandler(this.buttonCreateArventure_Click);
            // 
            // buttonCancelArventure
            // 
            this.buttonCancelArventure.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelArventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelArventure.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelArventure.Location = new System.Drawing.Point(1042, 1098);
            this.buttonCancelArventure.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancelArventure.Name = "buttonCancelArventure";
            this.buttonCancelArventure.Size = new System.Drawing.Size(150, 44);
            this.buttonCancelArventure.TabIndex = 9;
            this.buttonCancelArventure.Text = "Cancelar";
            this.buttonCancelArventure.UseVisualStyleBackColor = false;
            this.buttonCancelArventure.Click += new System.EventHandler(this.buttonCancelArventure_Click);
            // 
            // ARventureCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1928, 1175);
            this.Controls.Add(this.buttonCancelArventure);
            this.Controls.Add(this.buttonCreateArventure);
            this.Controls.Add(this.groupBoxArventure);
            this.Controls.Add(this.groupBoxRoutes);
            this.Controls.Add(this.groupBoxHappening);
            this.Controls.Add(this.groupBoxStory);
            this.Controls.Add(this.comboBoxSelectArventure);
            this.Controls.Add(this.labelSelectArventure);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ARventureCreationForm";
            this.Text = "Creación de aventura";
            this.Load += new System.EventHandler(this.ARventureCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArventure)).EndInit();
            this.groupBoxStory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.groupBoxRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).EndInit();
            this.groupBoxHappening.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHappening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappening)).EndInit();
            this.groupBoxArventure.ResumeLayout(false);
            this.groupBoxArventure.PerformLayout();
            this.groupBoxHappenings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoryImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectArventure;
        private System.Windows.Forms.ComboBox comboBoxSelectArventure;
        private System.Windows.Forms.GroupBox groupBoxStory;
        private System.Windows.Forms.ListBox listBoxStories;
        private System.Windows.Forms.GroupBox groupBoxRoutes;
        private System.Windows.Forms.GroupBox groupBoxHappening;
        private System.Windows.Forms.Button buttonSeeDetailStory;
        private System.Windows.Forms.Button buttonSelectStory;
        private System.Windows.Forms.Button buttonSeeDetailRoute;
        private System.Windows.Forms.Button buttonSelectRoute;
        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.Button buttonSeeDetailEvent;
        private System.Windows.Forms.Button buttonSelectEvent;
        private System.Windows.Forms.GroupBox groupBoxArventure;
        private System.Windows.Forms.Button buttonCreateArventure;
        private System.Windows.Forms.Button buttonCancelArventure;
        private System.Windows.Forms.TextBox textBoxStorySummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStoryImg;
        private System.Windows.Forms.Label labelStoryTitle;
        private System.Windows.Forms.GroupBox groupBoxHappenings;
        private System.Windows.Forms.Button buttonRemoveEvent;
        private System.Windows.Forms.ListBox listBoxSelectEvents;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelRouteName;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.TextBox textBoxTitleArventure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxRouteStops;
        private System.Windows.Forms.Label labelTimeRoute;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDistanceRoute;
        private System.Windows.Forms.BindingSource bindingSourceStory;
        private System.Windows.Forms.BindingSource bindingSourceArventure;
        private System.Windows.Forms.BindingSource bindingSourceRoute;
        private System.Windows.Forms.DataGridView dataGridViewHappening;
        private System.Windows.Forms.BindingSource bindingSourceHappening;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}