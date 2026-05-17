namespace PregatireTest1
{
    partial class Form1
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
            this.adaugaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareFacturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculSumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaFacturaToolStripMenuItem,
            this.afisareFacturiToolStripMenuItem,
            this.calculSumaToolStripMenuItem,
            this.salveazaDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaFacturaToolStripMenuItem
            // 
            this.adaugaFacturaToolStripMenuItem.Name = "adaugaFacturaToolStripMenuItem";
            this.adaugaFacturaToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.adaugaFacturaToolStripMenuItem.Text = "Adauga Factura";
            this.adaugaFacturaToolStripMenuItem.Click += new System.EventHandler(this.adaugaFacturaToolStripMenuItem_Click);
            // 
            // afisareFacturiToolStripMenuItem
            // 
            this.afisareFacturiToolStripMenuItem.Name = "afisareFacturiToolStripMenuItem";
            this.afisareFacturiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.afisareFacturiToolStripMenuItem.Text = "Afisare Facturi";
            this.afisareFacturiToolStripMenuItem.Click += new System.EventHandler(this.afisareFacturiToolStripMenuItem_Click);
            // 
            // calculSumaToolStripMenuItem
            // 
            this.calculSumaToolStripMenuItem.Name = "calculSumaToolStripMenuItem";
            this.calculSumaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.calculSumaToolStripMenuItem.Text = "Calcul Suma";
            // 
            // salveazaDateToolStripMenuItem
            // 
            this.salveazaDateToolStripMenuItem.Name = "salveazaDateToolStripMenuItem";
            this.salveazaDateToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.salveazaDateToolStripMenuItem.Text = "Salveaza Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareFacturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculSumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaDateToolStripMenuItem;
    }
}

