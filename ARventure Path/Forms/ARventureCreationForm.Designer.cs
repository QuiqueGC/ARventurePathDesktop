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
            this.labelSelectRoute = new System.Windows.Forms.Label();
            this.comboBoxSelectRoute = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxStories = new System.Windows.Forms.ListBox();
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonSelectStory = new System.Windows.Forms.Button();
            this.buttonSeeDetailStory = new System.Windows.Forms.Button();
            this.buttonSelectRoute = new System.Windows.Forms.Button();
            this.buttonSelectEvent = new System.Windows.Forms.Button();
            this.buttonSeeDetailRoute = new System.Windows.Forms.Button();
            this.buttonSeeDetailEvent = new System.Windows.Forms.Button();
            this.groupBoxArventure = new System.Windows.Forms.GroupBox();
            this.buttonCreateArventure = new System.Windows.Forms.Button();
            this.buttonCancelArventure = new System.Windows.Forms.Button();
            this.labelStoryTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxSelectEvents = new System.Windows.Forms.ListBox();
            this.buttonRemoveEvent = new System.Windows.Forms.Button();
            this.labelDistanceRoute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTimeRoute = new System.Windows.Forms.Label();
            this.listBoxRouteStops = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxArventure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectRoute
            // 
            this.labelSelectRoute.AutoSize = true;
            this.labelSelectRoute.Location = new System.Drawing.Point(22, 18);
            this.labelSelectRoute.Name = "labelSelectRoute";
            this.labelSelectRoute.Size = new System.Drawing.Size(84, 13);
            this.labelSelectRoute.TabIndex = 2;
            this.labelSelectRoute.Text = "Seleccionar ruta";
            // 
            // comboBoxSelectRoute
            // 
            this.comboBoxSelectRoute.FormattingEnabled = true;
            this.comboBoxSelectRoute.Location = new System.Drawing.Point(124, 15);
            this.comboBoxSelectRoute.Name = "comboBoxSelectRoute";
            this.comboBoxSelectRoute.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectRoute.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSeeDetailStory);
            this.groupBox1.Controls.Add(this.buttonSelectStory);
            this.groupBox1.Controls.Add(this.listBoxStories);
            this.groupBox1.Location = new System.Drawing.Point(108, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historias";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSeeDetailRoute);
            this.groupBox2.Controls.Add(this.buttonSelectRoute);
            this.groupBox2.Controls.Add(this.listBoxRoutes);
            this.groupBox2.Location = new System.Drawing.Point(380, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 207);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rutas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSeeDetailEvent);
            this.groupBox3.Controls.Add(this.buttonSelectEvent);
            this.groupBox3.Controls.Add(this.listBoxEvents);
            this.groupBox3.Location = new System.Drawing.Point(647, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 207);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eventos";
            // 
            // listBoxStories
            // 
            this.listBoxStories.FormattingEnabled = true;
            this.listBoxStories.Location = new System.Drawing.Point(16, 19);
            this.listBoxStories.Name = "listBoxStories";
            this.listBoxStories.Size = new System.Drawing.Size(167, 134);
            this.listBoxStories.TabIndex = 0;
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.Location = new System.Drawing.Point(15, 19);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(167, 134);
            this.listBoxRoutes.TabIndex = 1;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(17, 19);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(167, 134);
            this.listBoxEvents.TabIndex = 2;
            // 
            // buttonSelectStory
            // 
            this.buttonSelectStory.Location = new System.Drawing.Point(16, 169);
            this.buttonSelectStory.Name = "buttonSelectStory";
            this.buttonSelectStory.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectStory.TabIndex = 1;
            this.buttonSelectStory.Text = "Seleccionar";
            this.buttonSelectStory.UseVisualStyleBackColor = true;
            // 
            // buttonSeeDetailStory
            // 
            this.buttonSeeDetailStory.Location = new System.Drawing.Point(108, 169);
            this.buttonSeeDetailStory.Name = "buttonSeeDetailStory";
            this.buttonSeeDetailStory.Size = new System.Drawing.Size(75, 23);
            this.buttonSeeDetailStory.TabIndex = 2;
            this.buttonSeeDetailStory.Text = "Ver detalles";
            this.buttonSeeDetailStory.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRoute
            // 
            this.buttonSelectRoute.Location = new System.Drawing.Point(15, 169);
            this.buttonSelectRoute.Name = "buttonSelectRoute";
            this.buttonSelectRoute.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectRoute.TabIndex = 3;
            this.buttonSelectRoute.Text = "Seleccionar";
            this.buttonSelectRoute.UseVisualStyleBackColor = true;
            // 
            // buttonSelectEvent
            // 
            this.buttonSelectEvent.Location = new System.Drawing.Point(17, 169);
            this.buttonSelectEvent.Name = "buttonSelectEvent";
            this.buttonSelectEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectEvent.TabIndex = 4;
            this.buttonSelectEvent.Text = "Seleccionar";
            this.buttonSelectEvent.UseVisualStyleBackColor = true;
            // 
            // buttonSeeDetailRoute
            // 
            this.buttonSeeDetailRoute.Location = new System.Drawing.Point(107, 169);
            this.buttonSeeDetailRoute.Name = "buttonSeeDetailRoute";
            this.buttonSeeDetailRoute.Size = new System.Drawing.Size(75, 23);
            this.buttonSeeDetailRoute.TabIndex = 3;
            this.buttonSeeDetailRoute.Text = "Ver detalles";
            this.buttonSeeDetailRoute.UseVisualStyleBackColor = true;
            // 
            // buttonSeeDetailEvent
            // 
            this.buttonSeeDetailEvent.Location = new System.Drawing.Point(109, 169);
            this.buttonSeeDetailEvent.Name = "buttonSeeDetailEvent";
            this.buttonSeeDetailEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonSeeDetailEvent.TabIndex = 4;
            this.buttonSeeDetailEvent.Text = "Ver detalles";
            this.buttonSeeDetailEvent.UseVisualStyleBackColor = true;
            // 
            // groupBoxArventure
            // 
            this.groupBoxArventure.Controls.Add(this.groupBox6);
            this.groupBoxArventure.Controls.Add(this.groupBox5);
            this.groupBoxArventure.Controls.Add(this.textBox2);
            this.groupBoxArventure.Controls.Add(this.label2);
            this.groupBoxArventure.Controls.Add(this.groupBox4);
            this.groupBoxArventure.Location = new System.Drawing.Point(25, 261);
            this.groupBoxArventure.Name = "groupBoxArventure";
            this.groupBoxArventure.Size = new System.Drawing.Size(904, 299);
            this.groupBoxArventure.TabIndex = 7;
            this.groupBoxArventure.TabStop = false;
            this.groupBoxArventure.Text = "Aventura";
            // 
            // buttonCreateArventure
            // 
            this.buttonCreateArventure.Location = new System.Drawing.Point(412, 571);
            this.buttonCreateArventure.Name = "buttonCreateArventure";
            this.buttonCreateArventure.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateArventure.TabIndex = 8;
            this.buttonCreateArventure.Text = "Crear";
            this.buttonCreateArventure.UseVisualStyleBackColor = true;
            // 
            // buttonCancelArventure
            // 
            this.buttonCancelArventure.Location = new System.Drawing.Point(521, 571);
            this.buttonCancelArventure.Name = "buttonCancelArventure";
            this.buttonCancelArventure.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelArventure.TabIndex = 9;
            this.buttonCancelArventure.Text = "Cancelar";
            this.buttonCancelArventure.UseVisualStyleBackColor = true;
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(93, 16);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(97, 13);
            this.labelStoryTitle.TabIndex = 3;
            this.labelStoryTitle.Text = "Título de la historia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARventure_Path.Properties.Resources.Login_Aventuras;
            this.pictureBox1.Location = new System.Drawing.Point(15, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resumen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 173);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 40);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelStoryTitle);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(21, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 226);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Historia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título de la Aventura";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 16);
            this.textBox2.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxRouteStops);
            this.groupBox5.Controls.Add(this.labelTimeRoute);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.labelDistanceRoute);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(329, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 226);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de la ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Distancia";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonRemoveEvent);
            this.groupBox6.Controls.Add(this.listBoxSelectEvents);
            this.groupBox6.Location = new System.Drawing.Point(623, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 226);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Eventos";
            // 
            // listBoxSelectEvents
            // 
            this.listBoxSelectEvents.FormattingEnabled = true;
            this.listBoxSelectEvents.Location = new System.Drawing.Point(13, 33);
            this.listBoxSelectEvents.Name = "listBoxSelectEvents";
            this.listBoxSelectEvents.Size = new System.Drawing.Size(240, 147);
            this.listBoxSelectEvents.TabIndex = 7;
            // 
            // buttonRemoveEvent
            // 
            this.buttonRemoveEvent.Location = new System.Drawing.Point(92, 190);
            this.buttonRemoveEvent.Name = "buttonRemoveEvent";
            this.buttonRemoveEvent.Size = new System.Drawing.Size(91, 23);
            this.buttonRemoveEvent.TabIndex = 8;
            this.buttonRemoveEvent.Text = "Quitar evento";
            this.buttonRemoveEvent.UseVisualStyleBackColor = true;
            // 
            // labelDistanceRoute
            // 
            this.labelDistanceRoute.AutoSize = true;
            this.labelDistanceRoute.Location = new System.Drawing.Point(93, 49);
            this.labelDistanceRoute.Name = "labelDistanceRoute";
            this.labelDistanceRoute.Size = new System.Drawing.Size(13, 13);
            this.labelDistanceRoute.TabIndex = 6;
            this.labelDistanceRoute.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tiempo";
            // 
            // labelTimeRoute
            // 
            this.labelTimeRoute.AutoSize = true;
            this.labelTimeRoute.Location = new System.Drawing.Point(93, 76);
            this.labelTimeRoute.Name = "labelTimeRoute";
            this.labelTimeRoute.Size = new System.Drawing.Size(13, 13);
            this.labelTimeRoute.TabIndex = 8;
            this.labelTimeRoute.Text = "0";
            // 
            // listBoxRouteStops
            // 
            this.listBoxRouteStops.FormattingEnabled = true;
            this.listBoxRouteStops.Location = new System.Drawing.Point(12, 105);
            this.listBoxRouteStops.Name = "listBoxRouteStops";
            this.listBoxRouteStops.Size = new System.Drawing.Size(238, 108);
            this.listBoxRouteStops.TabIndex = 9;
            // 
            // ARventureCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 601);
            this.Controls.Add(this.buttonCancelArventure);
            this.Controls.Add(this.buttonCreateArventure);
            this.Controls.Add(this.groupBoxArventure);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSelectRoute);
            this.Controls.Add(this.labelSelectRoute);
            this.Name = "ARventureCreationForm";
            this.Text = "Creación de aventura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxArventure.ResumeLayout(false);
            this.groupBoxArventure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectRoute;
        private System.Windows.Forms.ComboBox comboBoxSelectRoute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxStories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSeeDetailStory;
        private System.Windows.Forms.Button buttonSelectStory;
        private System.Windows.Forms.Button buttonSeeDetailRoute;
        private System.Windows.Forms.Button buttonSelectRoute;
        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.Button buttonSeeDetailEvent;
        private System.Windows.Forms.Button buttonSelectEvent;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.GroupBox groupBoxArventure;
        private System.Windows.Forms.Button buttonCreateArventure;
        private System.Windows.Forms.Button buttonCancelArventure;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStoryTitle;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonRemoveEvent;
        private System.Windows.Forms.ListBox listBoxSelectEvents;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxRouteStops;
        private System.Windows.Forms.Label labelTimeRoute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDistanceRoute;
    }
}