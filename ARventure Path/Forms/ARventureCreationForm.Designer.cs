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
            this.groupBoxStories = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchStory = new System.Windows.Forms.TextBox();
            this.listBoxStories = new System.Windows.Forms.ListBox();
            this.bindingSourceStory = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxRoutes = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.bindingSourceRoute = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearchRoute = new System.Windows.Forms.TextBox();
            this.groupBoxHappeningStory = new System.Windows.Forms.GroupBox();
            this.dataGridViewHappening = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHappening = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelectEvent = new System.Windows.Forms.Button();
            this.groupBoxArventure = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectedHappenings = new System.Windows.Forms.GroupBox();
            this.buttonRemoveEvent = new System.Windows.Forms.Button();
            this.listBoxSelectEvents = new System.Windows.Forms.ListBox();
            this.groupBoxSelectedRoute = new System.Windows.Forms.GroupBox();
            this.listBoxRouteStops = new System.Windows.Forms.ListBox();
            this.labelTimeRoute = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDistanceRoute = new System.Windows.Forms.Label();
            this.labelRouteName = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.textBoxTitleArventure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSelectedStory = new System.Windows.Forms.GroupBox();
            this.buttonFragments = new System.Windows.Forms.Button();
            this.labelStoryTitle = new System.Windows.Forms.Label();
            this.textBoxStorySummary = new System.Windows.Forms.TextBox();
            this.pictureBoxStoryImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateArventure = new System.Windows.Forms.Button();
            this.buttonCancelArventure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArventure)).BeginInit();
            this.groupBoxStories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.groupBoxRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).BeginInit();
            this.groupBoxHappeningStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHappening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappening)).BeginInit();
            this.groupBoxArventure.SuspendLayout();
            this.groupBoxSelectedHappenings.SuspendLayout();
            this.groupBoxSelectedRoute.SuspendLayout();
            this.groupBoxSelectedStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoryImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectArventure
            // 
            this.labelSelectArventure.AutoSize = true;
            this.labelSelectArventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectArventure.Location = new System.Drawing.Point(22, 18);
            this.labelSelectArventure.Name = "labelSelectArventure";
            this.labelSelectArventure.Size = new System.Drawing.Size(160, 16);
            this.labelSelectArventure.TabIndex = 2;
            this.labelSelectArventure.Text = "Seleccionar Arventure";
            // 
            // comboBoxSelectArventure
            // 
            this.comboBoxSelectArventure.DataSource = this.bindingSourceArventure;
            this.comboBoxSelectArventure.DisplayMember = "name";
            this.comboBoxSelectArventure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectArventure.FormattingEnabled = true;
            this.comboBoxSelectArventure.Location = new System.Drawing.Point(188, 17);
            this.comboBoxSelectArventure.Name = "comboBoxSelectArventure";
            this.comboBoxSelectArventure.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectArventure.TabIndex = 3;
            this.comboBoxSelectArventure.ValueMember = "id";
            this.comboBoxSelectArventure.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectArventure_SelectedIndexChanged);
            // 
            // bindingSourceArventure
            // 
            this.bindingSourceArventure.DataSource = typeof(ARventure_Path.Models.arventure);
            // 
            // groupBoxStories
            // 
            this.groupBoxStories.Controls.Add(this.label3);
            this.groupBoxStories.Controls.Add(this.textBoxSearchStory);
            this.groupBoxStories.Controls.Add(this.listBoxStories);
            this.groupBoxStories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStories.Location = new System.Drawing.Point(25, 48);
            this.groupBoxStories.Name = "groupBoxStories";
            this.groupBoxStories.Size = new System.Drawing.Size(269, 207);
            this.groupBoxStories.TabIndex = 4;
            this.groupBoxStories.TabStop = false;
            this.groupBoxStories.Text = "Historias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar";
            // 
            // textBoxSearchStory
            // 
            this.textBoxSearchStory.Location = new System.Drawing.Point(64, 178);
            this.textBoxSearchStory.Name = "textBoxSearchStory";
            this.textBoxSearchStory.Size = new System.Drawing.Size(196, 22);
            this.textBoxSearchStory.TabIndex = 1;
            this.textBoxSearchStory.TextChanged += new System.EventHandler(this.textBoxSearchStory_TextChanged);
            // 
            // listBoxStories
            // 
            this.listBoxStories.DataSource = this.bindingSourceStory;
            this.listBoxStories.DisplayMember = "name";
            this.listBoxStories.FormattingEnabled = true;
            this.listBoxStories.ItemHeight = 16;
            this.listBoxStories.Location = new System.Drawing.Point(12, 24);
            this.listBoxStories.Name = "listBoxStories";
            this.listBoxStories.Size = new System.Drawing.Size(248, 148);
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
            this.groupBoxRoutes.Controls.Add(this.label4);
            this.groupBoxRoutes.Controls.Add(this.listBoxRoutes);
            this.groupBoxRoutes.Controls.Add(this.textBoxSearchRoute);
            this.groupBoxRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoutes.Location = new System.Drawing.Point(336, 48);
            this.groupBoxRoutes.Name = "groupBoxRoutes";
            this.groupBoxRoutes.Size = new System.Drawing.Size(267, 207);
            this.groupBoxRoutes.TabIndex = 5;
            this.groupBoxRoutes.TabStop = false;
            this.groupBoxRoutes.Text = "Rutas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buscar";
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.DataSource = this.bindingSourceRoute;
            this.listBoxRoutes.DisplayMember = "name";
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.ItemHeight = 16;
            this.listBoxRoutes.Location = new System.Drawing.Point(8, 24);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(250, 148);
            this.listBoxRoutes.TabIndex = 1;
            this.listBoxRoutes.ValueMember = "id";
            this.listBoxRoutes.SelectedIndexChanged += new System.EventHandler(this.listBoxRoutes_SelectedIndexChanged);
            // 
            // bindingSourceRoute
            // 
            this.bindingSourceRoute.DataSource = typeof(ARventure_Path.Models.route);
            // 
            // textBoxSearchRoute
            // 
            this.textBoxSearchRoute.Location = new System.Drawing.Point(60, 178);
            this.textBoxSearchRoute.Name = "textBoxSearchRoute";
            this.textBoxSearchRoute.Size = new System.Drawing.Size(196, 22);
            this.textBoxSearchRoute.TabIndex = 3;
            this.textBoxSearchRoute.TextChanged += new System.EventHandler(this.textBoxSearchRoute_TextChanged);
            // 
            // groupBoxHappeningStory
            // 
            this.groupBoxHappeningStory.Controls.Add(this.dataGridViewHappening);
            this.groupBoxHappeningStory.Controls.Add(this.buttonSelectEvent);
            this.groupBoxHappeningStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHappeningStory.Location = new System.Drawing.Point(636, 48);
            this.groupBoxHappeningStory.Name = "groupBoxHappeningStory";
            this.groupBoxHappeningStory.Size = new System.Drawing.Size(293, 207);
            this.groupBoxHappeningStory.TabIndex = 6;
            this.groupBoxHappeningStory.TabStop = false;
            this.groupBoxHappeningStory.Text = "Eventos";
            // 
            // dataGridViewHappening
            // 
            this.dataGridViewHappening.AllowUserToAddRows = false;
            this.dataGridViewHappening.AllowUserToDeleteRows = false;
            this.dataGridViewHappening.AllowUserToResizeColumns = false;
            this.dataGridViewHappening.AllowUserToResizeRows = false;
            this.dataGridViewHappening.AutoGenerateColumns = false;
            this.dataGridViewHappening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHappening.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewHappening.DataSource = this.bindingSourceHappening;
            this.dataGridViewHappening.Location = new System.Drawing.Point(13, 23);
            this.dataGridViewHappening.MultiSelect = false;
            this.dataGridViewHappening.Name = "dataGridViewHappening";
            this.dataGridViewHappening.ReadOnly = true;
            this.dataGridViewHappening.RowHeadersVisible = false;
            this.dataGridViewHappening.RowHeadersWidth = 82;
            this.dataGridViewHappening.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHappening.Size = new System.Drawing.Size(270, 149);
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
            // buttonSelectEvent
            // 
            this.buttonSelectEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelectEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectEvent.Location = new System.Drawing.Point(97, 175);
            this.buttonSelectEvent.Name = "buttonSelectEvent";
            this.buttonSelectEvent.Size = new System.Drawing.Size(97, 23);
            this.buttonSelectEvent.TabIndex = 4;
            this.buttonSelectEvent.Text = "Añadir";
            this.buttonSelectEvent.UseVisualStyleBackColor = false;
            this.buttonSelectEvent.Click += new System.EventHandler(this.buttonSelectEvent_Click);
            // 
            // groupBoxArventure
            // 
            this.groupBoxArventure.Controls.Add(this.groupBoxSelectedHappenings);
            this.groupBoxArventure.Controls.Add(this.groupBoxSelectedRoute);
            this.groupBoxArventure.Controls.Add(this.textBoxTitleArventure);
            this.groupBoxArventure.Controls.Add(this.label2);
            this.groupBoxArventure.Controls.Add(this.groupBoxSelectedStory);
            this.groupBoxArventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxArventure.Location = new System.Drawing.Point(25, 261);
            this.groupBoxArventure.Name = "groupBoxArventure";
            this.groupBoxArventure.Size = new System.Drawing.Size(904, 299);
            this.groupBoxArventure.TabIndex = 7;
            this.groupBoxArventure.TabStop = false;
            this.groupBoxArventure.Text = "Aventura";
            // 
            // groupBoxSelectedHappenings
            // 
            this.groupBoxSelectedHappenings.Controls.Add(this.buttonRemoveEvent);
            this.groupBoxSelectedHappenings.Controls.Add(this.listBoxSelectEvents);
            this.groupBoxSelectedHappenings.Location = new System.Drawing.Point(611, 55);
            this.groupBoxSelectedHappenings.Name = "groupBoxSelectedHappenings";
            this.groupBoxSelectedHappenings.Size = new System.Drawing.Size(274, 238);
            this.groupBoxSelectedHappenings.TabIndex = 8;
            this.groupBoxSelectedHappenings.TabStop = false;
            this.groupBoxSelectedHappenings.Text = "Eventos";
            // 
            // buttonRemoveEvent
            // 
            this.buttonRemoveEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRemoveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveEvent.Location = new System.Drawing.Point(79, 209);
            this.buttonRemoveEvent.Name = "buttonRemoveEvent";
            this.buttonRemoveEvent.Size = new System.Drawing.Size(125, 23);
            this.buttonRemoveEvent.TabIndex = 8;
            this.buttonRemoveEvent.Text = "Eliminar evento";
            this.buttonRemoveEvent.UseVisualStyleBackColor = false;
            this.buttonRemoveEvent.Click += new System.EventHandler(this.buttonRemoveEvent_Click);
            // 
            // listBoxSelectEvents
            // 
            this.listBoxSelectEvents.FormattingEnabled = true;
            this.listBoxSelectEvents.ItemHeight = 16;
            this.listBoxSelectEvents.Location = new System.Drawing.Point(6, 22);
            this.listBoxSelectEvents.Name = "listBoxSelectEvents";
            this.listBoxSelectEvents.Size = new System.Drawing.Size(262, 180);
            this.listBoxSelectEvents.TabIndex = 7;
            // 
            // groupBoxSelectedRoute
            // 
            this.groupBoxSelectedRoute.Controls.Add(this.listBoxRouteStops);
            this.groupBoxSelectedRoute.Controls.Add(this.labelTimeRoute);
            this.groupBoxSelectedRoute.Controls.Add(this.labelTime);
            this.groupBoxSelectedRoute.Controls.Add(this.labelDistanceRoute);
            this.groupBoxSelectedRoute.Controls.Add(this.labelRouteName);
            this.groupBoxSelectedRoute.Controls.Add(this.labelDistance);
            this.groupBoxSelectedRoute.Location = new System.Drawing.Point(324, 55);
            this.groupBoxSelectedRoute.Name = "groupBoxSelectedRoute";
            this.groupBoxSelectedRoute.Size = new System.Drawing.Size(267, 238);
            this.groupBoxSelectedRoute.TabIndex = 8;
            this.groupBoxSelectedRoute.TabStop = false;
            this.groupBoxSelectedRoute.Text = "Ruta";
            // 
            // listBoxRouteStops
            // 
            this.listBoxRouteStops.FormattingEnabled = true;
            this.listBoxRouteStops.ItemHeight = 16;
            this.listBoxRouteStops.Location = new System.Drawing.Point(6, 81);
            this.listBoxRouteStops.Name = "listBoxRouteStops";
            this.listBoxRouteStops.Size = new System.Drawing.Size(255, 148);
            this.listBoxRouteStops.TabIndex = 9;
            // 
            // labelTimeRoute
            // 
            this.labelTimeRoute.AutoSize = true;
            this.labelTimeRoute.Location = new System.Drawing.Point(76, 61);
            this.labelTimeRoute.Name = "labelTimeRoute";
            this.labelTimeRoute.Size = new System.Drawing.Size(14, 16);
            this.labelTimeRoute.TabIndex = 8;
            this.labelTimeRoute.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(6, 61);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(54, 16);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Tiempo";
            // 
            // labelDistanceRoute
            // 
            this.labelDistanceRoute.AutoSize = true;
            this.labelDistanceRoute.Location = new System.Drawing.Point(76, 38);
            this.labelDistanceRoute.Name = "labelDistanceRoute";
            this.labelDistanceRoute.Size = new System.Drawing.Size(14, 16);
            this.labelDistanceRoute.TabIndex = 6;
            this.labelDistanceRoute.Text = "0";
            // 
            // labelRouteName
            // 
            this.labelRouteName.AutoSize = true;
            this.labelRouteName.Location = new System.Drawing.Point(75, 19);
            this.labelRouteName.Name = "labelRouteName";
            this.labelRouteName.Size = new System.Drawing.Size(114, 16);
            this.labelRouteName.TabIndex = 3;
            this.labelRouteName.Text = "Nombre de la ruta";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(6, 38);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(63, 16);
            this.labelDistance.TabIndex = 5;
            this.labelDistance.Text = "Distancia";
            // 
            // textBoxTitleArventure
            // 
            this.textBoxTitleArventure.Location = new System.Drawing.Point(373, 27);
            this.textBoxTitleArventure.Multiline = true;
            this.textBoxTitleArventure.Name = "textBoxTitleArventure";
            this.textBoxTitleArventure.Size = new System.Drawing.Size(288, 22);
            this.textBoxTitleArventure.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título de la Aventura";
            // 
            // groupBoxSelectedStory
            // 
            this.groupBoxSelectedStory.Controls.Add(this.buttonFragments);
            this.groupBoxSelectedStory.Controls.Add(this.labelStoryTitle);
            this.groupBoxSelectedStory.Controls.Add(this.textBoxStorySummary);
            this.groupBoxSelectedStory.Controls.Add(this.pictureBoxStoryImg);
            this.groupBoxSelectedStory.Controls.Add(this.label1);
            this.groupBoxSelectedStory.Location = new System.Drawing.Point(21, 55);
            this.groupBoxSelectedStory.Name = "groupBoxSelectedStory";
            this.groupBoxSelectedStory.Size = new System.Drawing.Size(265, 238);
            this.groupBoxSelectedStory.TabIndex = 7;
            this.groupBoxSelectedStory.TabStop = false;
            this.groupBoxSelectedStory.Text = "Historia";
            // 
            // buttonFragments
            // 
            this.buttonFragments.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonFragments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFragments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFragments.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFragments.Location = new System.Drawing.Point(162, 138);
            this.buttonFragments.Name = "buttonFragments";
            this.buttonFragments.Size = new System.Drawing.Size(97, 23);
            this.buttonFragments.TabIndex = 10;
            this.buttonFragments.Text = "Fragmentos";
            this.buttonFragments.UseVisualStyleBackColor = false;
            this.buttonFragments.Click += new System.EventHandler(this.buttonFragments_Click);
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(70, 13);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(119, 16);
            this.labelStoryTitle.TabIndex = 3;
            this.labelStoryTitle.Text = "Título de la historia";
            // 
            // textBoxStorySummary
            // 
            this.textBoxStorySummary.Enabled = false;
            this.textBoxStorySummary.Location = new System.Drawing.Point(11, 164);
            this.textBoxStorySummary.Multiline = true;
            this.textBoxStorySummary.Name = "textBoxStorySummary";
            this.textBoxStorySummary.Size = new System.Drawing.Size(248, 68);
            this.textBoxStorySummary.TabIndex = 6;
            // 
            // pictureBoxStoryImg
            // 
            this.pictureBoxStoryImg.Image = global::ARventure_Path.Properties.Resources.Login_Aventuras;
            this.pictureBoxStoryImg.Location = new System.Drawing.Point(11, 32);
            this.pictureBoxStoryImg.Name = "pictureBoxStoryImg";
            this.pictureBoxStoryImg.Size = new System.Drawing.Size(248, 100);
            this.pictureBoxStoryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStoryImg.TabIndex = 4;
            this.pictureBoxStoryImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resumen";
            // 
            // buttonCreateArventure
            // 
            this.buttonCreateArventure.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateArventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateArventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateArventure.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateArventure.Location = new System.Drawing.Point(412, 571);
            this.buttonCreateArventure.Name = "buttonCreateArventure";
            this.buttonCreateArventure.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateArventure.TabIndex = 8;
            this.buttonCreateArventure.Text = "Crear";
            this.buttonCreateArventure.UseVisualStyleBackColor = false;
            this.buttonCreateArventure.Click += new System.EventHandler(this.buttonCreateArventure_Click);
            // 
            // buttonCancelArventure
            // 
            this.buttonCancelArventure.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelArventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelArventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelArventure.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelArventure.Location = new System.Drawing.Point(521, 571);
            this.buttonCancelArventure.Name = "buttonCancelArventure";
            this.buttonCancelArventure.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelArventure.TabIndex = 9;
            this.buttonCancelArventure.Text = "Cancelar";
            this.buttonCancelArventure.UseVisualStyleBackColor = false;
            this.buttonCancelArventure.Click += new System.EventHandler(this.buttonCancelArventure_Click);
            // 
            // ARventureCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(942, 611);
            this.Controls.Add(this.buttonCancelArventure);
            this.Controls.Add(this.buttonCreateArventure);
            this.Controls.Add(this.groupBoxArventure);
            this.Controls.Add(this.groupBoxRoutes);
            this.Controls.Add(this.groupBoxHappeningStory);
            this.Controls.Add(this.groupBoxStories);
            this.Controls.Add(this.comboBoxSelectArventure);
            this.Controls.Add(this.labelSelectArventure);
            this.Name = "ARventureCreationForm";
            this.Text = "Creación de aventura";
            this.Load += new System.EventHandler(this.ARventureCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArventure)).EndInit();
            this.groupBoxStories.ResumeLayout(false);
            this.groupBoxStories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.groupBoxRoutes.ResumeLayout(false);
            this.groupBoxRoutes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).EndInit();
            this.groupBoxHappeningStory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHappening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappening)).EndInit();
            this.groupBoxArventure.ResumeLayout(false);
            this.groupBoxArventure.PerformLayout();
            this.groupBoxSelectedHappenings.ResumeLayout(false);
            this.groupBoxSelectedRoute.ResumeLayout(false);
            this.groupBoxSelectedRoute.PerformLayout();
            this.groupBoxSelectedStory.ResumeLayout(false);
            this.groupBoxSelectedStory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoryImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectArventure;
        private System.Windows.Forms.ComboBox comboBoxSelectArventure;
        private System.Windows.Forms.GroupBox groupBoxStories;
        private System.Windows.Forms.ListBox listBoxStories;
        private System.Windows.Forms.GroupBox groupBoxRoutes;
        private System.Windows.Forms.GroupBox groupBoxHappeningStory;
        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.Button buttonSelectEvent;
        private System.Windows.Forms.GroupBox groupBoxArventure;
        private System.Windows.Forms.Button buttonCreateArventure;
        private System.Windows.Forms.Button buttonCancelArventure;
        private System.Windows.Forms.TextBox textBoxStorySummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStoryImg;
        private System.Windows.Forms.Label labelStoryTitle;
        private System.Windows.Forms.GroupBox groupBoxSelectedHappenings;
        private System.Windows.Forms.Button buttonRemoveEvent;
        private System.Windows.Forms.ListBox listBoxSelectEvents;
        private System.Windows.Forms.GroupBox groupBoxSelectedRoute;
        private System.Windows.Forms.Label labelRouteName;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.TextBox textBoxTitleArventure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSelectedStory;
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
        private System.Windows.Forms.Button buttonFragments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchStory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearchRoute;
    }
}