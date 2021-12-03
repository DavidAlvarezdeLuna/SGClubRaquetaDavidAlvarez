
namespace SGClubRaquetaDavidAlvarez
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.strip_administrar = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_socios = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_pistas = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_reservas = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_informes = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_administrar,
            this.strip_reservas,
            this.strip_informes,
            this.strip_salir});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // strip_administrar
            // 
            this.strip_administrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_socios,
            this.strip_pistas});
            this.strip_administrar.Name = "strip_administrar";
            this.strip_administrar.Size = new System.Drawing.Size(110, 26);
            this.strip_administrar.Text = "ADMINISTAR";
            // 
            // strip_socios
            // 
            this.strip_socios.Name = "strip_socios";
            this.strip_socios.Size = new System.Drawing.Size(135, 26);
            this.strip_socios.Text = "Socios";
            this.strip_socios.Click += new System.EventHandler(this.strip_socios_Click);
            // 
            // strip_pistas
            // 
            this.strip_pistas.Name = "strip_pistas";
            this.strip_pistas.Size = new System.Drawing.Size(135, 26);
            this.strip_pistas.Text = "Pistas";
            this.strip_pistas.Click += new System.EventHandler(this.strip_pistas_Click);
            // 
            // strip_reservas
            // 
            this.strip_reservas.Name = "strip_reservas";
            this.strip_reservas.Size = new System.Drawing.Size(91, 26);
            this.strip_reservas.Text = "RESERVAS";
            this.strip_reservas.Click += new System.EventHandler(this.strip_reservas_Click);
            // 
            // strip_informes
            // 
            this.strip_informes.Name = "strip_informes";
            this.strip_informes.Size = new System.Drawing.Size(94, 26);
            this.strip_informes.Text = "INFORMES";
            // 
            // strip_salir
            // 
            this.strip_salir.Name = "strip_salir";
            this.strip_salir.Size = new System.Drawing.Size(61, 26);
            this.strip_salir.Text = "SALIR";
            this.strip_salir.Click += new System.EventHandler(this.strip_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem strip_administrar;
        private System.Windows.Forms.ToolStripMenuItem strip_socios;
        private System.Windows.Forms.ToolStripMenuItem strip_pistas;
        private System.Windows.Forms.ToolStripMenuItem strip_reservas;
        private System.Windows.Forms.ToolStripMenuItem strip_informes;
        private System.Windows.Forms.ToolStripMenuItem strip_salir;
    }
}

