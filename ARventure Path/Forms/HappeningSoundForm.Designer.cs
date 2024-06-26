﻿namespace ARventure_Path.Forms
{
    partial class HappeningSoundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HappeningSoundForm));
            this.groupboxAudioHappening = new System.Windows.Forms.GroupBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.macTrackBarVolume = new XComponent.SliderBar.MACTrackBar();
            this.macTrackBarPlayer = new XComponent.SliderBar.MACTrackBar();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.Mp3Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.comboBoxHappenings = new System.Windows.Forms.ComboBox();
            this.bindingSourceHappenings = new System.Windows.Forms.BindingSource(this.components);
            this.labelSelectHappening = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxStories = new System.Windows.Forms.ComboBox();
            this.bindingSourceStory = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupboxAudioHappening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp3Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappenings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxAudioHappening
            // 
            this.groupboxAudioHappening.Controls.Add(this.labelDuration);
            this.groupboxAudioHappening.Controls.Add(this.pictureBox1);
            this.groupboxAudioHappening.Controls.Add(this.macTrackBarVolume);
            this.groupboxAudioHappening.Controls.Add(this.macTrackBarPlayer);
            this.groupboxAudioHappening.Controls.Add(this.btnStop);
            this.groupboxAudioHappening.Controls.Add(this.btnPlay);
            this.groupboxAudioHappening.Controls.Add(this.buttonSearch);
            this.groupboxAudioHappening.Controls.Add(this.textBoxUrl);
            this.groupboxAudioHappening.Controls.Add(this.lblUrl);
            this.groupboxAudioHappening.Controls.Add(this.textBoxName);
            this.groupboxAudioHappening.Controls.Add(this.lblName);
            this.groupboxAudioHappening.Font = new System.Drawing.Font("Century", 10F);
            this.groupboxAudioHappening.Location = new System.Drawing.Point(17, 64);
            this.groupboxAudioHappening.Name = "groupboxAudioHappening";
            this.groupboxAudioHappening.Size = new System.Drawing.Size(511, 224);
            this.groupboxAudioHappening.TabIndex = 3;
            this.groupboxAudioHappening.TabStop = false;
            this.groupboxAudioHappening.Text = "Evento de Audio";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(422, 96);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(36, 17);
            this.labelDuration.TabIndex = 22;
            this.labelDuration.Text = "0:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARventure_Path.Properties.Resources.volume;
            this.pictureBox1.Location = new System.Drawing.Point(264, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // macTrackBarVolume
            // 
            this.macTrackBarVolume.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarVolume.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBarVolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBarVolume.IndentHeight = 6;
            this.macTrackBarVolume.Location = new System.Drawing.Point(350, 145);
            this.macTrackBarVolume.Maximum = 100;
            this.macTrackBarVolume.Minimum = 0;
            this.macTrackBarVolume.Name = "macTrackBarVolume";
            this.macTrackBarVolume.Size = new System.Drawing.Size(83, 24);
            this.macTrackBarVolume.TabIndex = 20;
            this.macTrackBarVolume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarVolume.TickColor = System.Drawing.Color.DarkSlateBlue;
            this.macTrackBarVolume.TickHeight = 4;
            this.macTrackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarVolume.TrackerColor = System.Drawing.Color.DarkSlateBlue;
            this.macTrackBarVolume.TrackerSize = new System.Drawing.Size(12, 12);
            this.macTrackBarVolume.TrackLineColor = System.Drawing.Color.Silver;
            this.macTrackBarVolume.TrackLineHeight = 3;
            this.macTrackBarVolume.TrackLineSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.macTrackBarVolume.Value = 0;
            this.macTrackBarVolume.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBarVolume_ValueChanged);
            // 
            // macTrackBarPlayer
            // 
            this.macTrackBarPlayer.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarPlayer.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBarPlayer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBarPlayer.IndentHeight = 6;
            this.macTrackBarPlayer.Location = new System.Drawing.Point(38, 89);
            this.macTrackBarPlayer.Maximum = 100;
            this.macTrackBarPlayer.Minimum = 0;
            this.macTrackBarPlayer.Name = "macTrackBarPlayer";
            this.macTrackBarPlayer.Size = new System.Drawing.Size(365, 28);
            this.macTrackBarPlayer.TabIndex = 19;
            this.macTrackBarPlayer.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarPlayer.TickColor = System.Drawing.Color.DarkSlateBlue;
            this.macTrackBarPlayer.TickHeight = 4;
            this.macTrackBarPlayer.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarPlayer.TrackerColor = System.Drawing.Color.DarkSlateBlue;
            this.macTrackBarPlayer.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBarPlayer.TrackLineColor = System.Drawing.Color.Silver;
            this.macTrackBarPlayer.TrackLineHeight = 3;
            this.macTrackBarPlayer.TrackLineSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.macTrackBarPlayer.Value = 0;
            this.macTrackBarPlayer.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBarPlayer_ValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Image = global::ARventure_Path.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(159, 123);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 72);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 18;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::ARventure_Path.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(58, 123);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(77, 72);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 17;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Century", 10F);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Location = new System.Drawing.Point(430, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxUrl.Location = new System.Drawing.Point(195, 39);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.ReadOnly = true;
            this.textBoxUrl.Size = new System.Drawing.Size(229, 24);
            this.textBoxUrl.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(197, 23);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(111, 17);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Ruta de archivo";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 24);
            this.textBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // Mp3Player
            // 
            this.Mp3Player.Enabled = true;
            this.Mp3Player.Location = new System.Drawing.Point(29, 303);
            this.Mp3Player.Name = "Mp3Player";
            this.Mp3Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Mp3Player.OcxState")));
            this.Mp3Player.Size = new System.Drawing.Size(39, 35);
            this.Mp3Player.TabIndex = 16;
            this.Mp3Player.Visible = false;
            this.Mp3Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Mp3Player_PlayStateChange);
            // 
            // comboBoxHappenings
            // 
            this.comboBoxHappenings.DataSource = this.bindingSourceHappenings;
            this.comboBoxHappenings.DisplayMember = "name";
            this.comboBoxHappenings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHappenings.FormattingEnabled = true;
            this.comboBoxHappenings.Location = new System.Drawing.Point(215, 11);
            this.comboBoxHappenings.Name = "comboBoxHappenings";
            this.comboBoxHappenings.Size = new System.Drawing.Size(235, 21);
            this.comboBoxHappenings.TabIndex = 0;
            this.comboBoxHappenings.ValueMember = "id";
            this.comboBoxHappenings.SelectedIndexChanged += new System.EventHandler(this.comboBoxHappenings_SelectedIndexChanged);
            // 
            // bindingSourceHappenings
            // 
            this.bindingSourceHappenings.DataSource = typeof(ARventure_Path.Models.happening);
            // 
            // labelSelectHappening
            // 
            this.labelSelectHappening.AutoSize = true;
            this.labelSelectHappening.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectHappening.Location = new System.Drawing.Point(25, 9);
            this.labelSelectHappening.Name = "labelSelectHappening";
            this.labelSelectHappening.Size = new System.Drawing.Size(164, 20);
            this.labelSelectHappening.TabIndex = 4;
            this.labelSelectHappening.Text = "Seleccionar evento";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreate.Enabled = false;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreate.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreate.Location = new System.Drawing.Point(453, 303);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Crear";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Century", 10F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(372, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxStories
            // 
            this.comboBoxStories.DataSource = this.bindingSourceStory;
            this.comboBoxStories.DisplayMember = "name";
            this.comboBoxStories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStories.FormattingEnabled = true;
            this.comboBoxStories.Location = new System.Drawing.Point(215, 37);
            this.comboBoxStories.Name = "comboBoxStories";
            this.comboBoxStories.Size = new System.Drawing.Size(235, 21);
            this.comboBoxStories.TabIndex = 1;
            this.comboBoxStories.ValueMember = "id";
            // 
            // bindingSourceStory
            // 
            this.bindingSourceStory.DataSource = typeof(ARventure_Path.Models.story);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccionar historia";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HappeningSoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 338);
            this.Controls.Add(this.comboBoxStories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mp3Player);
            this.Controls.Add(this.groupboxAudioHappening);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxHappenings);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelSelectHappening);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HappeningSoundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de evento de audio                       ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HappeningSoundForm_FormClosed);
            this.Load += new System.EventHandler(this.HappeningSoundForm_Load);
            this.groupboxAudioHappening.ResumeLayout(false);
            this.groupboxAudioHappening.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp3Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHappenings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxAudioHappening;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboBoxHappenings;
        private System.Windows.Forms.Label labelSelectHappening;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxStories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceStory;
        private AxWMPLib.AxWindowsMediaPlayer Mp3Player;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private XComponent.SliderBar.MACTrackBar macTrackBarVolume;
        private XComponent.SliderBar.MACTrackBar macTrackBarPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSourceHappenings;
        private System.Windows.Forms.Label labelDuration;
    }
}