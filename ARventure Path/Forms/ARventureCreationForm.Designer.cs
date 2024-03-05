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
            this.groupBoxHappening = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bindingSourceRoute = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArventure)).BeginInit();
            this.groupBoxStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.groupBoxRoutes.SuspendLayout();
            this.groupBoxHappening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxArventure.SuspendLayout();
            this.groupBoxHappenings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoryImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectArventure
            // 
            this.labelSelectArventure.AutoSize = true;
            this.labelSelectArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // groupBoxStory
            // 
            this.groupBoxStory.Controls.Add(this.buttonSeeDetailStory);
            this.groupBoxStory.Controls.Add(this.buttonSelectStory);
            this.groupBoxStory.Controls.Add(this.listBoxStories);
            this.groupBoxStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStory.Location = new System.Drawing.Point(25, 48);
            this.groupBoxStory.Name = "groupBoxStory";
            this.groupBoxStory.Size = new System.Drawing.Size(269, 207);
            this.groupBoxStory.TabIndex = 4;
            this.groupBoxStory.TabStop = false;
            this.groupBoxStory.Text = "Historias";
            // 
            // buttonSeeDetailStory
            // 
            this.buttonSeeDetailStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSeeDetailStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeeDetailStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeDetailStory.Location = new System.Drawing.Point(145, 169);
            this.buttonSeeDetailStory.Name = "buttonSeeDetailStory";
            this.buttonSeeDetailStory.Size = new System.Drawing.Size(102, 23);
            this.buttonSeeDetailStory.TabIndex = 2;
            this.buttonSeeDetailStory.Text = "Ver detalles";
            this.buttonSeeDetailStory.UseVisualStyleBackColor = false;
            // 
            // buttonSelectStory
            // 
            this.buttonSelectStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelectStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectStory.Location = new System.Drawing.Point(21, 169);
            this.buttonSelectStory.Name = "buttonSelectStory";
            this.buttonSelectStory.Size = new System.Drawing.Size(108, 23);
            this.buttonSelectStory.TabIndex = 1;
            this.buttonSelectStory.Text = "Seleccionar";
            this.buttonSelectStory.UseVisualStyleBackColor = false;
            // 
            // listBoxStories
            // 
            this.listBoxStories.DataSource = this.bindingSourceStory;
            this.listBoxStories.DisplayMember = "name";
            this.listBoxStories.FormattingEnabled = true;
            this.listBoxStories.ItemHeight = 16;
            this.listBoxStories.Location = new System.Drawing.Point(12, 24);
            this.listBoxStories.Name = "listBoxStories";
            this.listBoxStories.Size = new System.Drawing.Size(248, 132);
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
            this.groupBoxRoutes.Location = new System.Drawing.Point(336, 48);
            this.groupBoxRoutes.Name = "groupBoxRoutes";
            this.groupBoxRoutes.Size = new System.Drawing.Size(260, 207);
            this.groupBoxRoutes.TabIndex = 5;
            this.groupBoxRoutes.TabStop = false;
            this.groupBoxRoutes.Text = "Rutas";
            // 
            // buttonSeeDetailRoute
            // 
            this.buttonSeeDetailRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSeeDetailRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeeDetailRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeDetailRoute.Location = new System.Drawing.Point(128, 169);
            this.buttonSeeDetailRoute.Name = "buttonSeeDetailRoute";
            this.buttonSeeDetailRoute.Size = new System.Drawing.Size(102, 23);
            this.buttonSeeDetailRoute.TabIndex = 3;
            this.buttonSeeDetailRoute.Text = "Ver detalles";
            this.buttonSeeDetailRoute.UseVisualStyleBackColor = false;
            // 
            // buttonSelectRoute
            // 
            this.buttonSelectRoute.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelectRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectRoute.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectRoute.Location = new System.Drawing.Point(30, 169);
            this.buttonSelectRoute.Name = "buttonSelectRoute";
            this.buttonSelectRoute.Size = new System.Drawing.Size(92, 23);
            this.buttonSelectRoute.TabIndex = 3;
            this.buttonSelectRoute.Text = "Seleccionar";
            this.buttonSelectRoute.UseVisualStyleBackColor = false;
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.DataSource = this.bindingSourceRoute;
            this.listBoxRoutes.DisplayMember = "name";
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.ItemHeight = 16;
            this.listBoxRoutes.Location = new System.Drawing.Point(13, 24);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(237, 132);
            this.listBoxRoutes.TabIndex = 1;
            this.listBoxRoutes.ValueMember = "id";
            // 
            // groupBoxHappening
            // 
            this.groupBoxHappening.Controls.Add(this.dataGridView1);
            this.groupBoxHappening.Controls.Add(this.buttonSeeDetailEvent);
            this.groupBoxHappening.Controls.Add(this.buttonSelectEvent);
            this.groupBoxHappening.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHappening.Location = new System.Drawing.Point(636, 48);
            this.groupBoxHappening.Name = "groupBoxHappening";
            this.groupBoxHappening.Size = new System.Drawing.Size(293, 207);
            this.groupBoxHappening.TabIndex = 6;
            this.groupBoxHappening.TabStop = false;
            this.groupBoxHappening.Text = "Eventos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(15, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(262, 134);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tipo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // buttonSeeDetailEvent
            // 
            this.buttonSeeDetailEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSeeDetailEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeeDetailEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeDetailEvent.Location = new System.Drawing.Point(157, 169);
            this.buttonSeeDetailEvent.Name = "buttonSeeDetailEvent";
            this.buttonSeeDetailEvent.Size = new System.Drawing.Size(98, 23);
            this.buttonSeeDetailEvent.TabIndex = 4;
            this.buttonSeeDetailEvent.Text = "Ver detalles";
            this.buttonSeeDetailEvent.UseVisualStyleBackColor = false;
            // 
            // buttonSelectEvent
            // 
            this.buttonSelectEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelectEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectEvent.Location = new System.Drawing.Point(41, 169);
            this.buttonSelectEvent.Name = "buttonSelectEvent";
            this.buttonSelectEvent.Size = new System.Drawing.Size(97, 23);
            this.buttonSelectEvent.TabIndex = 4;
            this.buttonSelectEvent.Text = "Seleccionar";
            this.buttonSelectEvent.UseVisualStyleBackColor = false;
            // 
            // groupBoxArventure
            // 
            this.groupBoxArventure.Controls.Add(this.groupBoxHappenings);
            this.groupBoxArventure.Controls.Add(this.groupBox5);
            this.groupBoxArventure.Controls.Add(this.textBoxTitleArventure);
            this.groupBoxArventure.Controls.Add(this.label2);
            this.groupBoxArventure.Controls.Add(this.groupBox4);
            this.groupBoxArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxArventure.Location = new System.Drawing.Point(25, 261);
            this.groupBoxArventure.Name = "groupBoxArventure";
            this.groupBoxArventure.Size = new System.Drawing.Size(904, 299);
            this.groupBoxArventure.TabIndex = 7;
            this.groupBoxArventure.TabStop = false;
            this.groupBoxArventure.Text = "Aventura";
            // 
            // groupBoxHappenings
            // 
            this.groupBoxHappenings.Controls.Add(this.buttonRemoveEvent);
            this.groupBoxHappenings.Controls.Add(this.listBoxSelectEvents);
            this.groupBoxHappenings.Location = new System.Drawing.Point(623, 55);
            this.groupBoxHappenings.Name = "groupBoxHappenings";
            this.groupBoxHappenings.Size = new System.Drawing.Size(262, 226);
            this.groupBoxHappenings.TabIndex = 8;
            this.groupBoxHappenings.TabStop = false;
            this.groupBoxHappenings.Text = "Eventos";
            // 
            // buttonRemoveEvent
            // 
            this.buttonRemoveEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRemoveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveEvent.Location = new System.Drawing.Point(74, 191);
            this.buttonRemoveEvent.Name = "buttonRemoveEvent";
            this.buttonRemoveEvent.Size = new System.Drawing.Size(125, 23);
            this.buttonRemoveEvent.TabIndex = 8;
            this.buttonRemoveEvent.Text = "Eliminar evento";
            this.buttonRemoveEvent.UseVisualStyleBackColor = false;
            // 
            // listBoxSelectEvents
            // 
            this.listBoxSelectEvents.FormattingEnabled = true;
            this.listBoxSelectEvents.ItemHeight = 16;
            this.listBoxSelectEvents.Location = new System.Drawing.Point(13, 33);
            this.listBoxSelectEvents.Name = "listBoxSelectEvents";
            this.listBoxSelectEvents.Size = new System.Drawing.Size(240, 148);
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
            this.groupBox5.Location = new System.Drawing.Point(329, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 226);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ruta";
            // 
            // listBoxRouteStops
            // 
            this.listBoxRouteStops.FormattingEnabled = true;
            this.listBoxRouteStops.ItemHeight = 16;
            this.listBoxRouteStops.Location = new System.Drawing.Point(12, 105);
            this.listBoxRouteStops.Name = "listBoxRouteStops";
            this.listBoxRouteStops.Size = new System.Drawing.Size(238, 100);
            this.listBoxRouteStops.TabIndex = 9;
            // 
            // labelTimeRoute
            // 
            this.labelTimeRoute.AutoSize = true;
            this.labelTimeRoute.Location = new System.Drawing.Point(93, 76);
            this.labelTimeRoute.Name = "labelTimeRoute";
            this.labelTimeRoute.Size = new System.Drawing.Size(14, 16);
            this.labelTimeRoute.TabIndex = 8;
            this.labelTimeRoute.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(23, 76);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 16);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Tiempo";
            // 
            // labelDistanceRoute
            // 
            this.labelDistanceRoute.AutoSize = true;
            this.labelDistanceRoute.Location = new System.Drawing.Point(93, 49);
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
            this.labelRouteName.Size = new System.Drawing.Size(117, 16);
            this.labelRouteName.TabIndex = 3;
            this.labelRouteName.Text = "Nombre de la ruta";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(23, 49);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(64, 16);
            this.labelDistance.TabIndex = 5;
            this.labelDistance.Text = "Distancia";
            // 
            // textBoxTitleArventure
            // 
            this.textBoxTitleArventure.Location = new System.Drawing.Point(384, 16);
            this.textBoxTitleArventure.Multiline = true;
            this.textBoxTitleArventure.Name = "textBoxTitleArventure";
            this.textBoxTitleArventure.Size = new System.Drawing.Size(288, 22);
            this.textBoxTitleArventure.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título de la Aventura";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelStoryTitle);
            this.groupBox4.Controls.Add(this.textBoxStorySummary);
            this.groupBox4.Controls.Add(this.pictureBoxStoryImg);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(21, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 226);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Historia";
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(70, 19);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(125, 16);
            this.labelStoryTitle.TabIndex = 3;
            this.labelStoryTitle.Text = "Título de la historia";
            // 
            // textBoxStorySummary
            // 
            this.textBoxStorySummary.Location = new System.Drawing.Point(15, 173);
            this.textBoxStorySummary.Multiline = true;
            this.textBoxStorySummary.Name = "textBoxStorySummary";
            this.textBoxStorySummary.Size = new System.Drawing.Size(224, 40);
            this.textBoxStorySummary.TabIndex = 6;
            // 
            // pictureBoxStoryImg
            // 
            this.pictureBoxStoryImg.Image = global::ARventure_Path.Properties.Resources.Login_Aventuras;
            this.pictureBoxStoryImg.Location = new System.Drawing.Point(15, 49);
            this.pictureBoxStoryImg.Name = "pictureBoxStoryImg";
            this.pictureBoxStoryImg.Size = new System.Drawing.Size(224, 94);
            this.pictureBoxStoryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStoryImg.TabIndex = 4;
            this.pictureBoxStoryImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resumen";
            // 
            // buttonCreateArventure
            // 
            this.buttonCreateArventure.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateArventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonCancelArventure.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelArventure.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelArventure.Location = new System.Drawing.Point(521, 571);
            this.buttonCancelArventure.Name = "buttonCancelArventure";
            this.buttonCancelArventure.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelArventure.TabIndex = 9;
            this.buttonCancelArventure.Text = "Cancelar";
            this.buttonCancelArventure.UseVisualStyleBackColor = false;
            this.buttonCancelArventure.Click += new System.EventHandler(this.buttonCancelArventure_Click);
            // 
            // bindingSourceRoute
            // 
            this.bindingSourceRoute.DataSource = typeof(ARventure_Path.Models.route);
            // 
            // ARventureCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.buttonCancelArventure);
            this.Controls.Add(this.buttonCreateArventure);
            this.Controls.Add(this.groupBoxArventure);
            this.Controls.Add(this.groupBoxRoutes);
            this.Controls.Add(this.groupBoxHappening);
            this.Controls.Add(this.groupBoxStory);
            this.Controls.Add(this.comboBoxSelectArventure);
            this.Controls.Add(this.labelSelectArventure);
            this.Name = "ARventureCreationForm";
            this.Text = "Creación de aventura";
            this.Load += new System.EventHandler(this.ARventureCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArventure)).EndInit();
            this.groupBoxStory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.groupBoxRoutes.ResumeLayout(false);
            this.groupBoxHappening.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxArventure.ResumeLayout(false);
            this.groupBoxArventure.PerformLayout();
            this.groupBoxHappenings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoryImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.BindingSource bindingSourceRoute;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}