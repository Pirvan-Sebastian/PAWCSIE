using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PregatireTest1
{
    public partial class Form1 : Form
    {
        public List<Factura> listaFacturi = new List<Factura>();
        public Form1()
        {
            InitializeComponent();

            listaFacturi.Add
                (
                new Factura { Serie = "F123",
                    Suma = 100,
                    DataEmitere = DateTime.Now.AddDays(-30),
                    DataScadenta = DateTime.Now.AddDays(-10),
                    Status = StatusFactura.Emis }
                );
            listaFacturi.Add(new Factura { Serie = "K456", Suma = 200, DataEmitere = DateTime.Now.AddDays(-20), DataScadenta = DateTime.Now.AddDays(-5), Status = StatusFactura.Platita });
            listaFacturi.Add(new Factura { Serie = "X789", Suma = 1000, DataEmitere = DateTime.Now.AddDays(-15), DataScadenta = DateTime.Now.AddDays(-2), Status = StatusFactura.Emis });
        }

        private void adaugaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {   //using curata memoria la final
            using (FormAdaugare formular = new FormAdaugare()) //legare FormAdaugare cu functia butonului asta
            {
                if(formular.ShowDialog() == DialogResult.OK)//daca a salvat userul ->apasat pe buton save
                {
                    listaFacturi.Add(formular.FacturaCreata);
                }
            }

        }

        private void afisareFacturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfisare formular = new FormAfisare(listaFacturi);
            formular.MdiParent = this;
            formular.Show();
        }
    }
}
