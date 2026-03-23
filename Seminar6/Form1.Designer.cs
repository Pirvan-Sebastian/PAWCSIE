namespace Seminar6
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
            this.lvCarti = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvCarti
            // 
            this.lvCarti.HideSelection = false;
            this.lvCarti.Location = new System.Drawing.Point(0, 0);
            this.lvCarti.Name = "lvCarti";
            this.lvCarti.Size = new System.Drawing.Size(799, 398);
            this.lvCarti.TabIndex = 0;
            this.lvCarti.UseCompatibleStateImageBehavior = false;
            this.lvCarti.View = System.Windows.Forms.View.Details;
            this.lvCarti.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCarti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCarti;
    }
}

