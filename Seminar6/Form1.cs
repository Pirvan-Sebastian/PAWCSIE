using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var latime = lvCarti.ClientSize.Width;

            lvCarti.Columns.Add("Titlu", (int)(latime * 0.3));
            lvCarti.Columns.Add("Autor", (int)(latime * 0.3));
            lvCarti.Columns.Add("An", (int)(latime * 0.3));
            lvCarti.Columns.Add("Gen");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
