using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerCapit9
{
    public partial class ProductosDeTienda : Form
    {
        ArrayList arreglo;
        public struct Tienda
        {
            public String descripcion;
            public int cantidad;

            public Tienda(string descripcion, int cantidad)
            {
                this.descripcion = descripcion;
                this.cantidad = cantidad;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} {1}", descripcion, cantidad);
                return sb.ToString();


            }
        }

        public ProductosDeTienda()
        {
            InitializeComponent();
            arreglo = new ArrayList();
        }
        Tienda t;
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            t = new Tienda(textBoxDescripcion.Text, Convert.ToInt32(textBoxCantidad.Text));
            arreglo.Add(t.ToString());
            textBoxDescripcion.Text = "";
            textBoxCantidad.Text = "";
        }

        private void ProductosDeTienda_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach (string item in arreglo)
            {
                richTextBoxArticulos.Text += item + "\n";
            }
        }
    }
}
