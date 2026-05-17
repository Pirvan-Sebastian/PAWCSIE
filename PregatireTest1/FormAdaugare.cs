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
    public partial class FormAdaugare : Form
    {
        public Factura FacturaCreata { get; private set; }// Propietate a clasei FormAdaugare cu setter privat(doar in clasa)
        public FormAdaugare()
        {
            InitializeComponent();
        }
        

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            //daca data scadenta e mai devreme decat data emitere + 7 zile
            if(dtpScadenta.Value.Date < dtpEmitere.Value.Date.AddDays(7) )
            {
                MessageBox.Show("Daca Scadenta trebuie sa fie la minim 7 zile dupa emitere!");
                return;
            }

            FacturaCreata = new Factura
            {
                DataEmitere = dtpEmitere.Value,
                DataScadenta = dtpScadenta.Value,
                Serie = txtSerie.Text,
                Suma = decimal.Parse(txtSuma.Text),
                Status = StatusFactura.Emis
            };
            //e ok a mers
            this.DialogResult= DialogResult.OK;


        }



        //asta nu trebuia sa fie aici, din greseala amfacut dublu click acum trebuie sa existe
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
