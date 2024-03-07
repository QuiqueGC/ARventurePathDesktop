namespace ARventure_Path.Forms
{
    partial class FragmentsDialog
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
            this.dataGridViewFragments = new System.Windows.Forms.DataGridView();
            this.ordinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFragments = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFragments)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewFragments.Location = new System.Drawing.Point(9, 25);
            this.dataGridViewFragments.MultiSelect = false;
            this.dataGridViewFragments.Name = "dataGridViewFragments";
            this.dataGridViewFragments.ReadOnly = true;
            this.dataGridViewFragments.RowHeadersVisible = false;
            this.dataGridViewFragments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFragments.Size = new System.Drawing.Size(442, 272);
            this.dataGridViewFragments.TabIndex = 5;
            // 
            // ordinalDataGridViewTextBoxColumn
            // 
            this.ordinalDataGridViewTextBoxColumn.DataPropertyName = "ordinal";
            this.ordinalDataGridViewTextBoxColumn.FillWeight = 50F;
            this.ordinalDataGridViewTextBoxColumn.HeaderText = "ordinal";
            this.ordinalDataGridViewTextBoxColumn.Name = "ordinalDataGridViewTextBoxColumn";
            this.ordinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceFragments
            // 
            this.bindingSourceFragments.DataSource = typeof(ARventure_Path.Models.fragment);
            // 
            // FragmentsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(463, 320);
            this.Controls.Add(this.dataGridViewFragments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FragmentsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FragmentsDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFragments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFragments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceFragments;
    }
}