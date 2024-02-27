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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.crearToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoDeImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoDeSonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.achievementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(964, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.Visible = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdToolStripMenuItem,
            this.rutaToolStripMenuItem,
            this.aventuraToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.achievementToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.asdasdToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.historia;
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.asdasdToolStripMenuItem.Text = "Historia";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearHistoriaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarHistoriaToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarHistoriaToolStripMenuItem_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.borrarToolStripMenuItem1});
            this.rutaToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.ruta;
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.rutaToolStripMenuItem.Text = "Ruta";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearRutaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.toolStripMenuItem1.Text = "Modificar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.modificarRutaToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarRutaToolStripMenuItem_Click);
            // 
            // aventuraToolStripMenuItem
            // 
            this.aventuraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem2,
            this.modificarToolStripMenuItem1,
            this.borrarToolStripMenuItem2});
            this.aventuraToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.aventura;
            this.aventuraToolStripMenuItem.Name = "aventuraToolStripMenuItem";
            this.aventuraToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.aventuraToolStripMenuItem.Text = "Aventura";
            this.aventuraToolStripMenuItem.Click += new System.EventHandler(this.aventuraToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem2
            // 
            this.crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            this.crearToolStripMenuItem2.Size = new System.Drawing.Size(157, 24);
            this.crearToolStripMenuItem2.Text = "Crear";
            this.crearToolStripMenuItem2.Click += new System.EventHandler(this.crearAventuraToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarAventuraToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem2
            // 
            this.borrarToolStripMenuItem2.Name = "borrarToolStripMenuItem2";
            this.borrarToolStripMenuItem2.Size = new System.Drawing.Size(157, 24);
            this.borrarToolStripMenuItem2.Text = "Borrar";
            this.borrarToolStripMenuItem2.Click += new System.EventHandler(this.borrarAventuraToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.eventoDeImagenToolStripMenuItem,
            this.eventoDeSonidoToolStripMenuItem});
            this.eventosToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.evento;
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem3,
            this.modificarToolStripMenuItem2,
            this.borrarToolStripMenuItem3});
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.eToolStripMenuItem.Text = "Evento de texto";
            // 
            // crearToolStripMenuItem3
            // 
            this.crearToolStripMenuItem3.Name = "crearToolStripMenuItem3";
            this.crearToolStripMenuItem3.Size = new System.Drawing.Size(157, 24);
            this.crearToolStripMenuItem3.Text = "Crear";
            this.crearToolStripMenuItem3.Click += new System.EventHandler(this.crearEventoTextoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(157, 24);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            this.modificarToolStripMenuItem2.Click += new System.EventHandler(this.modificarEventoTextoToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem3
            // 
            this.borrarToolStripMenuItem3.Name = "borrarToolStripMenuItem3";
            this.borrarToolStripMenuItem3.Size = new System.Drawing.Size(157, 24);
            this.borrarToolStripMenuItem3.Text = "Borrar";
            this.borrarToolStripMenuItem3.Click += new System.EventHandler(this.borrarEventoTextoToolStripMenuItem_Click);
            // 
            // eventoDeImagenToolStripMenuItem
            // 
            this.eventoDeImagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem4,
            this.modificarToolStripMenuItem3,
            this.borrarToolStripMenuItem4});
            this.eventoDeImagenToolStripMenuItem.Name = "eventoDeImagenToolStripMenuItem";
            this.eventoDeImagenToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.eventoDeImagenToolStripMenuItem.Text = "Evento de imagen";
            // 
            // crearToolStripMenuItem4
            // 
            this.crearToolStripMenuItem4.Name = "crearToolStripMenuItem4";
            this.crearToolStripMenuItem4.Size = new System.Drawing.Size(157, 24);
            this.crearToolStripMenuItem4.Text = "Crear";
            this.crearToolStripMenuItem4.Click += new System.EventHandler(this.crearEventoImagenToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(157, 24);
            this.modificarToolStripMenuItem3.Text = "Modificar";
            this.modificarToolStripMenuItem3.Click += new System.EventHandler(this.modificarEventoImagenToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem4
            // 
            this.borrarToolStripMenuItem4.Name = "borrarToolStripMenuItem4";
            this.borrarToolStripMenuItem4.Size = new System.Drawing.Size(157, 24);
            this.borrarToolStripMenuItem4.Text = "Borrar";
            this.borrarToolStripMenuItem4.Click += new System.EventHandler(this.borrarEventoImagenToolStripMenuItem_Click);
            // 
            // eventoDeSonidoToolStripMenuItem
            // 
            this.eventoDeSonidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem5,
            this.modificarToolStripMenuItem4,
            this.borrarToolStripMenuItem5});
            this.eventoDeSonidoToolStripMenuItem.Name = "eventoDeSonidoToolStripMenuItem";
            this.eventoDeSonidoToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.eventoDeSonidoToolStripMenuItem.Text = "Evento de sonido";
            // 
            // crearToolStripMenuItem5
            // 
            this.crearToolStripMenuItem5.Name = "crearToolStripMenuItem5";
            this.crearToolStripMenuItem5.Size = new System.Drawing.Size(157, 24);
            this.crearToolStripMenuItem5.Text = "Crear";
            this.crearToolStripMenuItem5.Click += new System.EventHandler(this.crearEventoSonidoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem4
            // 
            this.modificarToolStripMenuItem4.Name = "modificarToolStripMenuItem4";
            this.modificarToolStripMenuItem4.Size = new System.Drawing.Size(157, 24);
            this.modificarToolStripMenuItem4.Text = "Modificar";
            this.modificarToolStripMenuItem4.Click += new System.EventHandler(this.modificarEventoSonidoToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem5
            // 
            this.borrarToolStripMenuItem5.Name = "borrarToolStripMenuItem5";
            this.borrarToolStripMenuItem5.Size = new System.Drawing.Size(157, 24);
            this.borrarToolStripMenuItem5.Text = "Borrar";
            this.borrarToolStripMenuItem5.Click += new System.EventHandler(this.borrarEventoSonidoToolStripMenuItem_Click);
            // 
            // achievementToolStripMenuItem
            // 
            this.achievementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem6,
            this.borrarToolStripMenuItem6});
            this.achievementToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.logro;
            this.achievementToolStripMenuItem.Name = "achievementToolStripMenuItem";
            this.achievementToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.achievementToolStripMenuItem.Text = "Logros";
            // 
            // crearToolStripMenuItem6
            // 
            this.crearToolStripMenuItem6.Name = "crearToolStripMenuItem6";
            this.crearToolStripMenuItem6.Size = new System.Drawing.Size(134, 24);
            this.crearToolStripMenuItem6.Text = "Crear";
            this.crearToolStripMenuItem6.Click += new System.EventHandler(this.crearToolStripMenuItem6_Click);
            // 
            // borrarToolStripMenuItem6
            // 
            this.borrarToolStripMenuItem6.Name = "borrarToolStripMenuItem6";
            this.borrarToolStripMenuItem6.Size = new System.Drawing.Size(134, 24);
            this.borrarToolStripMenuItem6.Text = "Borrar";
            this.borrarToolStripMenuItem6.Click += new System.EventHandler(this.borrarToolStripMenuItem6_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ARventure_Path.Properties.Resources.cerrar;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMain.BackgroundImage = global::ARventure_Path.Properties.Resources.ArventurePath;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(965, 616);
            this.panelMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARventure Path";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.MenuStrip menuStripMain;
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
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem achievementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem6;
    }
}

