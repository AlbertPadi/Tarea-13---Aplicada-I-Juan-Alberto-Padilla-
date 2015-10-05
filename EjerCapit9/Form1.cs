using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerCapit9
{
    public partial class EjerciciosCapitulo9 : Form
    {
        public EjerciciosCapitulo9()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosDeTienda pt = new ProductosDeTienda();
            pt.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaBanc cb = new CuentaBanc();
            cb.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfMascotayDueno inf = new InfMascotayDueno();
            inf.Show();
        }
    }
}
