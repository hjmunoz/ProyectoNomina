namespace Nomina._0._0._1
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobanteDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.informacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominaToolStripMenuItem,
            this.liquidacionToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nominaToolStripMenuItem.Text = "Creacion empleados";
            this.nominaToolStripMenuItem.Click += new System.EventHandler(this.nominaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // liquidacionToolStripMenuItem
            // 
            this.liquidacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominaTotalToolStripMenuItem,
            this.horasExtrasToolStripMenuItem,
            this.nominaEmpleadoToolStripMenuItem,
            this.comprobanteDePagoToolStripMenuItem});
            this.liquidacionToolStripMenuItem.Name = "liquidacionToolStripMenuItem";
            this.liquidacionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.liquidacionToolStripMenuItem.Text = "Liquidacion";
            // 
            // nominaTotalToolStripMenuItem
            // 
            this.nominaTotalToolStripMenuItem.Name = "nominaTotalToolStripMenuItem";
            this.nominaTotalToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.nominaTotalToolStripMenuItem.Text = "Nomina total";
            // 
            // horasExtrasToolStripMenuItem
            // 
            this.horasExtrasToolStripMenuItem.Name = "horasExtrasToolStripMenuItem";
            this.horasExtrasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.horasExtrasToolStripMenuItem.Text = "Horas extras";
            // 
            // nominaEmpleadoToolStripMenuItem
            // 
            this.nominaEmpleadoToolStripMenuItem.Name = "nominaEmpleadoToolStripMenuItem";
            this.nominaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.nominaEmpleadoToolStripMenuItem.Text = "Resumen nomina empleado";
            // 
            // comprobanteDePagoToolStripMenuItem
            // 
            this.comprobanteDePagoToolStripMenuItem.Name = "comprobanteDePagoToolStripMenuItem";
            this.comprobanteDePagoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.comprobanteDePagoToolStripMenuItem.Text = "Comprobante de pago";
            this.comprobanteDePagoToolStripMenuItem.Click += new System.EventHandler(this.comprobanteDePagoToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasExtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobanteDePagoToolStripMenuItem;
    }
}