namespace PregatireTest1
{
    partial class FormAdaugare
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
            this.dtpEmitere = new System.Windows.Forms.DateTimePicker();
            this.dtpScadenta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.epSuma = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEmitere
            // 
            this.dtpEmitere.Location = new System.Drawing.Point(119, 38);
            this.dtpEmitere.Name = "dtpEmitere";
            this.dtpEmitere.Size = new System.Drawing.Size(200, 22);
            this.dtpEmitere.TabIndex = 0;
            this.dtpEmitere.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpScadenta
            // 
            this.dtpScadenta.Location = new System.Drawing.Point(119, 84);
            this.dtpScadenta.Name = "dtpScadenta";
            this.dtpScadenta.Size = new System.Drawing.Size(200, 22);
            this.dtpScadenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Emiterii:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Scadenta:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(119, 131);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(200, 22);
            this.txtSerie.TabIndex = 4;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(119, 178);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(200, 22);
            this.txtSuma.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Suma:";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(77, 224);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(118, 47);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // epSuma
            // 
            this.epSuma.ContainerControl = this;
            // 
            // FormAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpScadenta);
            this.Controls.Add(this.dtpEmitere);
            this.Name = "FormAdaugare";
            this.Text = "FormAdaugare";
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEmitere;
        private System.Windows.Forms.DateTimePicker dtpScadenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ErrorProvider epSuma;
    }
}