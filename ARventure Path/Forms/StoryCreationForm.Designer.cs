namespace ARventure_Path.Forms
{
    partial class StoryCreationForm
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
            this.labelSelectStory = new System.Windows.Forms.Label();
            this.comboBoxSelectStory = new System.Windows.Forms.ComboBox();
            this.bindingSourceStory = new System.Windows.Forms.BindingSource(this.components);
            this.gbGenerateForIA = new System.Windows.Forms.GroupBox();
            this.labelKeyWord = new System.Windows.Forms.Label();
            this.lblFragments = new System.Windows.Forms.Label();
            this.textBoxFragmentsIA = new System.Windows.Forms.TextBox();
            this.buttonGenerateStory = new System.Windows.Forms.Button();
            this.buttonGenerateImage = new System.Windows.Forms.Button();
            this.textBoxGenerateStoryAI = new System.Windows.Forms.TextBox();
            this.gbStory = new System.Windows.Forms.GroupBox();
            this.gbFragments = new System.Windows.Forms.GroupBox();
            this.btnModifyFragment = new System.Windows.Forms.Button();
            this.dataGridViewFragments = new System.Windows.Forms.DataGridView();
            this.ordinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFragments = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddNewFragment = new System.Windows.Forms.Button();
            this.textBoxFragmentQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantityFrag = new System.Windows.Forms.Label();
            this.buttonSearchImage = new System.Windows.Forms.Button();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.textBoxImageStory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxStory = new System.Windows.Forms.PictureBox();
            this.textBoxStoryTitle = new System.Windows.Forms.TextBox();
            this.labelStoryTitle = new System.Windows.Forms.Label();
            this.buttonCreateStory = new System.Windows.Forms.Button();
            this.buttonCancelStory = new System.Windows.Forms.Button();
            this.labelStyle = new System.Windows.Forms.Label();
            this.textBoxStyle = new System.Windows.Forms.TextBox();
            this.groupBoxIAStory = new System.Windows.Forms.GroupBox();
            this.groupBoxIAImage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).BeginInit();
            this.gbGenerateForIA.SuspendLayout();
            this.gbStory.SuspendLayout();
            this.gbFragments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFragments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStory)).BeginInit();
            this.groupBoxIAStory.SuspendLayout();
            this.groupBoxIAImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectStory
            // 
            this.labelSelectStory.AutoSize = true;
            this.labelSelectStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectStory.Location = new System.Drawing.Point(28, 18);
            this.labelSelectStory.Name = "labelSelectStory";
            this.labelSelectStory.Size = new System.Drawing.Size(147, 16);
            this.labelSelectStory.TabIndex = 0;
            this.labelSelectStory.Text = "Seleccionar Historia";
            // 
            // comboBoxSelectStory
            // 
            this.comboBoxSelectStory.DataSource = this.bindingSourceStory;
            this.comboBoxSelectStory.DisplayMember = "name";
            this.comboBoxSelectStory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectStory.FormattingEnabled = true;
            this.comboBoxSelectStory.Location = new System.Drawing.Point(181, 17);
            this.comboBoxSelectStory.Name = "comboBoxSelectStory";
            this.comboBoxSelectStory.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSelectStory.TabIndex = 0;
            this.comboBoxSelectStory.ValueMember = "id";
            this.comboBoxSelectStory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectStory_SelectedIndexChanged);
            // 
            // bindingSourceStory
            // 
            this.bindingSourceStory.DataSource = typeof(ARventure_Path.Models.story);
            // 
            // gbGenerateForIA
            // 
            this.gbGenerateForIA.Controls.Add(this.groupBoxIAImage);
            this.gbGenerateForIA.Controls.Add(this.groupBoxIAStory);
            this.gbGenerateForIA.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerateForIA.Location = new System.Drawing.Point(31, 47);
            this.gbGenerateForIA.Name = "gbGenerateForIA";
            this.gbGenerateForIA.Size = new System.Drawing.Size(898, 91);
            this.gbGenerateForIA.TabIndex = 1;
            this.gbGenerateForIA.TabStop = false;
            this.gbGenerateForIA.Text = "Generar por IA";
            // 
            // labelKeyWord
            // 
            this.labelKeyWord.AutoSize = true;
            this.labelKeyWord.Location = new System.Drawing.Point(100, 19);
            this.labelKeyWord.Name = "labelKeyWord";
            this.labelKeyWord.Size = new System.Drawing.Size(83, 15);
            this.labelKeyWord.TabIndex = 5;
            this.labelKeyWord.Text = "Palabra/s clave";
            // 
            // lblFragments
            // 
            this.lblFragments.AutoSize = true;
            this.lblFragments.Location = new System.Drawing.Point(100, 47);
            this.lblFragments.Name = "lblFragments";
            this.lblFragments.Size = new System.Drawing.Size(130, 15);
            this.lblFragments.TabIndex = 4;
            this.lblFragments.Text = "Cantidad de fragmentos";
            // 
            // textBoxFragmentsIA
            // 
            this.textBoxFragmentsIA.Location = new System.Drawing.Point(236, 41);
            this.textBoxFragmentsIA.Name = "textBoxFragmentsIA";
            this.textBoxFragmentsIA.Size = new System.Drawing.Size(90, 21);
            this.textBoxFragmentsIA.TabIndex = 3;
            this.textBoxFragmentsIA.TextChanged += new System.EventHandler(this.textBoxFragmentsIA_TextChanged);
            // 
            // buttonGenerateStory
            // 
            this.buttonGenerateStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateStory.Location = new System.Drawing.Point(359, 26);
            this.buttonGenerateStory.Name = "buttonGenerateStory";
            this.buttonGenerateStory.Size = new System.Drawing.Size(102, 23);
            this.buttonGenerateStory.TabIndex = 2;
            this.buttonGenerateStory.Text = "Generar historia";
            this.buttonGenerateStory.UseVisualStyleBackColor = false;
            this.buttonGenerateStory.Click += new System.EventHandler(this.buttonGenerateStory_Click);
            // 
            // buttonGenerateImage
            // 
            this.buttonGenerateImage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerateImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateImage.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGenerateImage.Location = new System.Drawing.Point(251, 26);
            this.buttonGenerateImage.Name = "buttonGenerateImage";
            this.buttonGenerateImage.Size = new System.Drawing.Size(103, 23);
            this.buttonGenerateImage.TabIndex = 1;
            this.buttonGenerateImage.Text = "Generar imagen";
            this.buttonGenerateImage.UseVisualStyleBackColor = false;
            this.buttonGenerateImage.Click += new System.EventHandler(this.buttonGenerateImage_Click);
            // 
            // textBoxGenerateStoryAI
            // 
            this.textBoxGenerateStoryAI.Location = new System.Drawing.Point(189, 16);
            this.textBoxGenerateStoryAI.Name = "textBoxGenerateStoryAI";
            this.textBoxGenerateStoryAI.Size = new System.Drawing.Size(137, 21);
            this.textBoxGenerateStoryAI.TabIndex = 0;
            // 
            // gbStory
            // 
            this.gbStory.Controls.Add(this.gbFragments);
            this.gbStory.Controls.Add(this.buttonSearchImage);
            this.gbStory.Controls.Add(this.textBoxSummary);
            this.gbStory.Controls.Add(this.labelSummary);
            this.gbStory.Controls.Add(this.textBoxImageStory);
            this.gbStory.Controls.Add(this.label1);
            this.gbStory.Controls.Add(this.pictureBoxStory);
            this.gbStory.Controls.Add(this.textBoxStoryTitle);
            this.gbStory.Controls.Add(this.labelStoryTitle);
            this.gbStory.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStory.Location = new System.Drawing.Point(36, 157);
            this.gbStory.Name = "gbStory";
            this.gbStory.Size = new System.Drawing.Size(893, 372);
            this.gbStory.TabIndex = 2;
            this.gbStory.TabStop = false;
            this.gbStory.Text = "Historia";
            // 
            // gbFragments
            // 
            this.gbFragments.Controls.Add(this.btnModifyFragment);
            this.gbFragments.Controls.Add(this.dataGridViewFragments);
            this.gbFragments.Controls.Add(this.buttonDelete);
            this.gbFragments.Controls.Add(this.buttonAddNewFragment);
            this.gbFragments.Controls.Add(this.textBoxFragmentQuantity);
            this.gbFragments.Controls.Add(this.labelQuantityFrag);
            this.gbFragments.Location = new System.Drawing.Point(496, 19);
            this.gbFragments.Name = "gbFragments";
            this.gbFragments.Size = new System.Drawing.Size(380, 338);
            this.gbFragments.TabIndex = 4;
            this.gbFragments.TabStop = false;
            this.gbFragments.Text = "Fragmentos";
            // 
            // btnModifyFragment
            // 
            this.btnModifyFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModifyFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifyFragment.Location = new System.Drawing.Point(223, 33);
            this.btnModifyFragment.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyFragment.Name = "btnModifyFragment";
            this.btnModifyFragment.Size = new System.Drawing.Size(72, 23);
            this.btnModifyFragment.TabIndex = 5;
            this.btnModifyFragment.Text = "Modificar";
            this.btnModifyFragment.UseVisualStyleBackColor = false;
            this.btnModifyFragment.Click += new System.EventHandler(this.btnModifyFragment_Click);
            // 
            // dataGridViewFragments
            // 
            this.dataGridViewFragments.AllowUserToAddRows = false;
            this.dataGridViewFragments.AllowUserToDeleteRows = false;
            this.dataGridViewFragments.AllowUserToResizeRows = false;
            this.dataGridViewFragments.AutoGenerateColumns = false;
            this.dataGridViewFragments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFragments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFragments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordinalDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn});
            this.dataGridViewFragments.DataSource = this.bindingSourceFragments;
            this.dataGridViewFragments.Location = new System.Drawing.Point(6, 104);
            this.dataGridViewFragments.MultiSelect = false;
            this.dataGridViewFragments.Name = "dataGridViewFragments";
            this.dataGridViewFragments.ReadOnly = true;
            this.dataGridViewFragments.RowHeadersVisible = false;
            this.dataGridViewFragments.RowHeadersWidth = 82;
            this.dataGridViewFragments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFragments.Size = new System.Drawing.Size(368, 228);
            this.dataGridViewFragments.TabIndex = 4;
            this.dataGridViewFragments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewFragments_KeyDown);
            // 
            // ordinalDataGridViewTextBoxColumn
            // 
            this.ordinalDataGridViewTextBoxColumn.DataPropertyName = "ordinal";
            this.ordinalDataGridViewTextBoxColumn.FillWeight = 50F;
            this.ordinalDataGridViewTextBoxColumn.HeaderText = "ordinal";
            this.ordinalDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ordinalDataGridViewTextBoxColumn.Name = "ordinalDataGridViewTextBoxColumn";
            this.ordinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "content";
            this.contentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceFragments
            // 
            this.bindingSourceFragments.DataSource = typeof(ARventure_Path.Models.fragment);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.Location = new System.Drawing.Point(14, 33);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Borrar seleccionado";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddNewFragment
            // 
            this.buttonAddNewFragment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddNewFragment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewFragment.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddNewFragment.Location = new System.Drawing.Point(118, 33);
            this.buttonAddNewFragment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNewFragment.Name = "buttonAddNewFragment";
            this.buttonAddNewFragment.Size = new System.Drawing.Size(95, 23);
            this.buttonAddNewFragment.TabIndex = 1;
            this.buttonAddNewFragment.Text = "Añadir nuevo";
            this.buttonAddNewFragment.UseVisualStyleBackColor = false;
            this.buttonAddNewFragment.Click += new System.EventHandler(this.buttonAddNewFragment_Click);
            // 
            // textBoxFragmentQuantity
            // 
            this.textBoxFragmentQuantity.Enabled = false;
            this.textBoxFragmentQuantity.Location = new System.Drawing.Point(328, 35);
            this.textBoxFragmentQuantity.Name = "textBoxFragmentQuantity";
            this.textBoxFragmentQuantity.Size = new System.Drawing.Size(35, 21);
            this.textBoxFragmentQuantity.TabIndex = 0;
            // 
            // labelQuantityFrag
            // 
            this.labelQuantityFrag.AutoSize = true;
            this.labelQuantityFrag.Location = new System.Drawing.Point(248, 16);
            this.labelQuantityFrag.Name = "labelQuantityFrag";
            this.labelQuantityFrag.Size = new System.Drawing.Size(130, 15);
            this.labelQuantityFrag.TabIndex = 0;
            this.labelQuantityFrag.Text = "Cantidad de fragmentos";
            // 
            // buttonSearchImage
            // 
            this.buttonSearchImage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchImage.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchImage.Location = new System.Drawing.Point(360, 239);
            this.buttonSearchImage.Name = "buttonSearchImage";
            this.buttonSearchImage.Size = new System.Drawing.Size(93, 23);
            this.buttonSearchImage.TabIndex = 2;
            this.buttonSearchImage.Text = "Buscar imagen";
            this.buttonSearchImage.UseVisualStyleBackColor = false;
            this.buttonSearchImage.Click += new System.EventHandler(this.buttonSearchImage_Click);
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(13, 299);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(440, 58);
            this.textBoxSummary.TabIndex = 3;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(10, 277);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(56, 15);
            this.labelSummary.TabIndex = 5;
            this.labelSummary.Text = "Resumen";
            // 
            // textBoxImageStory
            // 
            this.textBoxImageStory.Enabled = false;
            this.textBoxImageStory.Location = new System.Drawing.Point(13, 242);
            this.textBoxImageStory.Name = "textBoxImageStory";
            this.textBoxImageStory.Size = new System.Drawing.Size(341, 21);
            this.textBoxImageStory.TabIndex = 1;
            this.textBoxImageStory.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta imagen";
            // 
            // pictureBoxStory
            // 
            this.pictureBoxStory.Location = new System.Drawing.Point(13, 50);
            this.pictureBoxStory.Name = "pictureBoxStory";
            this.pictureBoxStory.Size = new System.Drawing.Size(440, 166);
            this.pictureBoxStory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStory.TabIndex = 2;
            this.pictureBoxStory.TabStop = false;
            // 
            // textBoxStoryTitle
            // 
            this.textBoxStoryTitle.Location = new System.Drawing.Point(52, 23);
            this.textBoxStoryTitle.Name = "textBoxStoryTitle";
            this.textBoxStoryTitle.Size = new System.Drawing.Size(401, 21);
            this.textBoxStoryTitle.TabIndex = 0;
            // 
            // labelStoryTitle
            // 
            this.labelStoryTitle.AutoSize = true;
            this.labelStoryTitle.Location = new System.Drawing.Point(10, 26);
            this.labelStoryTitle.Name = "labelStoryTitle";
            this.labelStoryTitle.Size = new System.Drawing.Size(37, 15);
            this.labelStoryTitle.TabIndex = 0;
            this.labelStoryTitle.Text = "Titulo";
            // 
            // buttonCreateStory
            // 
            this.buttonCreateStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateStory.Location = new System.Drawing.Point(430, 556);
            this.buttonCreateStory.Name = "buttonCreateStory";
            this.buttonCreateStory.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateStory.TabIndex = 3;
            this.buttonCreateStory.Text = "Crear";
            this.buttonCreateStory.UseVisualStyleBackColor = false;
            this.buttonCreateStory.Click += new System.EventHandler(this.buttonCreateStory_Click);
            // 
            // buttonCancelStory
            // 
            this.buttonCancelStory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancelStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelStory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelStory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelStory.Location = new System.Drawing.Point(532, 556);
            this.buttonCancelStory.Name = "buttonCancelStory";
            this.buttonCancelStory.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelStory.TabIndex = 4;
            this.buttonCancelStory.Text = "Cancelar";
            this.buttonCancelStory.UseVisualStyleBackColor = false;
            this.buttonCancelStory.Click += new System.EventHandler(this.buttonCancelStory_Click);
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.Location = new System.Drawing.Point(34, 31);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(44, 15);
            this.labelStyle.TabIndex = 6;
            this.labelStyle.Text = "Estilo/s";
            // 
            // textBoxStyle
            // 
            this.textBoxStyle.Location = new System.Drawing.Point(91, 28);
            this.textBoxStyle.Name = "textBoxStyle";
            this.textBoxStyle.Size = new System.Drawing.Size(137, 21);
            this.textBoxStyle.TabIndex = 7;
            // 
            // groupBoxIAStory
            // 
            this.groupBoxIAStory.Controls.Add(this.lblFragments);
            this.groupBoxIAStory.Controls.Add(this.textBoxFragmentsIA);
            this.groupBoxIAStory.Controls.Add(this.textBoxGenerateStoryAI);
            this.groupBoxIAStory.Controls.Add(this.buttonGenerateStory);
            this.groupBoxIAStory.Controls.Add(this.labelKeyWord);
            this.groupBoxIAStory.Location = new System.Drawing.Point(6, 17);
            this.groupBoxIAStory.Name = "groupBoxIAStory";
            this.groupBoxIAStory.Size = new System.Drawing.Size(481, 68);
            this.groupBoxIAStory.TabIndex = 8;
            this.groupBoxIAStory.TabStop = false;
            this.groupBoxIAStory.Text = "Generar historia";
            // 
            // groupBoxIAImage
            // 
            this.groupBoxIAImage.Controls.Add(this.buttonGenerateImage);
            this.groupBoxIAImage.Controls.Add(this.textBoxStyle);
            this.groupBoxIAImage.Controls.Add(this.labelStyle);
            this.groupBoxIAImage.Location = new System.Drawing.Point(501, 17);
            this.groupBoxIAImage.Name = "groupBoxIAImage";
            this.groupBoxIAImage.Size = new System.Drawing.Size(391, 68);
            this.groupBoxIAImage.TabIndex = 9;
            this.groupBoxIAImage.TabStop = false;
            this.groupBoxIAImage.Text = "Generar imagen";
            // 
            // StoryCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(959, 612);
            this.Controls.Add(this.buttonCancelStory);
            this.Controls.Add(this.buttonCreateStory);
            this.Controls.Add(this.gbStory);
            this.Controls.Add(this.gbGenerateForIA);
            this.Controls.Add(this.comboBoxSelectStory);
            this.Controls.Add(this.labelSelectStory);
            this.Name = "StoryCreationForm";
            this.Text = "Creación de historia";
            this.Load += new System.EventHandler(this.StoryCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStory)).EndInit();
            this.gbGenerateForIA.ResumeLayout(false);
            this.gbStory.ResumeLayout(false);
            this.gbStory.PerformLayout();
            this.gbFragments.ResumeLayout(false);
            this.gbFragments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFragments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStory)).EndInit();
            this.groupBoxIAStory.ResumeLayout(false);
            this.groupBoxIAStory.PerformLayout();
            this.groupBoxIAImage.ResumeLayout(false);
            this.groupBoxIAImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectStory;
        private System.Windows.Forms.ComboBox comboBoxSelectStory;
        private System.Windows.Forms.GroupBox gbGenerateForIA;
        private System.Windows.Forms.TextBox textBoxGenerateStoryAI;
        private System.Windows.Forms.Button buttonGenerateStory;
        private System.Windows.Forms.Button buttonGenerateImage;
        private System.Windows.Forms.GroupBox gbStory;
        private System.Windows.Forms.Label labelStoryTitle;
        private System.Windows.Forms.TextBox textBoxStoryTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStory;
        private System.Windows.Forms.Button buttonSearchImage;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox textBoxImageStory;
        private System.Windows.Forms.GroupBox gbFragments;
        private System.Windows.Forms.TextBox textBoxFragmentQuantity;
        private System.Windows.Forms.Label labelQuantityFrag;
        private System.Windows.Forms.Button buttonAddNewFragment;
        private System.Windows.Forms.Button buttonCreateStory;
        private System.Windows.Forms.Button buttonCancelStory;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource bindingSourceStory;
        private System.Windows.Forms.BindingSource bindingSourceFragments;
        private System.Windows.Forms.DataGridView dataGridViewFragments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblFragments;
        private System.Windows.Forms.TextBox textBoxFragmentsIA;
        private System.Windows.Forms.Button btnModifyFragment;
        private System.Windows.Forms.Label labelKeyWord;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.GroupBox groupBoxIAImage;
        private System.Windows.Forms.TextBox textBoxStyle;
        private System.Windows.Forms.GroupBox groupBoxIAStory;
    }
}