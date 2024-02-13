namespace ARventure_Path
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aventuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoDeImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoDeSonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(965, 590);
            this.panelMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdToolStripMenuItem,
            this.rutaToolStripMenuItem,
            this.aventuraToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.cerrar;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.asdasdToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.historia;
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asdasdToolStripMenuItem.Text = "Historia";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearHistoriaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.borrarToolStripMenuItem1});
            this.rutaToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.ruta;
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rutaToolStripMenuItem.Text = "Ruta";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearRutaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem1.Text = "Modificar";
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            // 
            // aventuraToolStripMenuItem
            // 
            this.aventuraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem2,
            this.modificarToolStripMenuItem1,
            this.borrarToolStripMenuItem2});
            this.aventuraToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.aventura;
            this.aventuraToolStripMenuItem.Name = "aventuraToolStripMenuItem";
            this.aventuraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aventuraToolStripMenuItem.Text = "Aventura";
            // 
            // crearToolStripMenuItem2
            // 
            this.crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            this.crearToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.crearToolStripMenuItem2.Text = "Crear";
            this.crearToolStripMenuItem2.Click += new System.EventHandler(this.crearAventuraToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // borrarToolStripMenuItem2
            // 
            this.borrarToolStripMenuItem2.Name = "borrarToolStripMenuItem2";
            this.borrarToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.borrarToolStripMenuItem2.Text = "Borrar";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.eventoDeImagenToolStripMenuItem,
            this.eventoDeSonidoToolStripMenuItem});
            this.eventosToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.evento;
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eToolStripMenuItem.Text = "Evento de texto";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eventoDeTextoToolStripMenuItem_Click);
            // 
            // eventoDeImagenToolStripMenuItem
            // 
            this.eventoDeImagenToolStripMenuItem.Name = "eventoDeImagenToolStripMenuItem";
            this.eventoDeImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventoDeImagenToolStripMenuItem.Text = "Evento de imagen";
            this.eventoDeImagenToolStripMenuItem.Click += new System.EventHandler(this.eventoDeImagenToolStripMenuItem_Click);
            // 
            // eventoDeSonidoToolStripMenuItem
            // 
            this.eventoDeSonidoToolStripMenuItem.Name = "eventoDeSonidoToolStripMenuItem";
            this.eventoDeSonidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventoDeSonidoToolStripMenuItem.Text = "Evento de sonido";
            this.eventoDeSonidoToolStripMenuItem.Click += new System.EventHandler(this.eventoDeSonidoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ARventure Path";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aventuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoDeImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoDeSonidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

