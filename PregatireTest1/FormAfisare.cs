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
    public partial class FormAfisare : Form
    {
        public FormAfisare(List<Factura> datePrimite)
        {
            InitializeComponent();

            var listaSortata = datePrimite.OrderBy(factura => factura.DataScadenta).ToList(); //LINQ

            dataGridView1.DataSource= listaSortata;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Estetică nu conteaza
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
