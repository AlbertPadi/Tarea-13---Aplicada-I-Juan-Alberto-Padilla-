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
    public partial class CuentaBanc : Form
    {
        ArrayList lista;
        public struct CuentaBa
        {
            public string nombre;
            public int id;
            public int fechaDepo;
            public int numero;
            public double cantidad;

            public CuentaBa(string n, int iD, int fe, int num, double can)
            {
                this.nombre = n;
                this.id = iD;
                this.fechaDepo = fe;
                this.numero = num;
                this.cantidad = can;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} {1} {2} {3} {4}", nombre, id, fechaDepo, numero, cantidad);
                return sb.ToString();


            }
        }

        public CuentaBanc()
        {
            InitializeComponent();
            lista = new ArrayList();
        }

        private void CuentaBanc_Load(object sender, EventArgs e)
        {

        }
        CuentaBa cb;
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach (string item in lista)
            {
                richTextBoxDatos.Text += item + "\n";
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            cb = new CuentaBa(textBoxnombre.Text, Convert.ToInt32(textBoxId.Text), Convert.ToInt32(textBoxFechaDep.Text), Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxCantidad.Text));
            lista.Add(cb.ToString());

            textBoxnombre.Text = "";
            textBoxId.Text = "";
            textBoxFechaDep.Text = "";
            textBoxNumero.Text = "";
            textBoxCantidad.Text = "";
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            {
                richTextBoxDatos.Text = "";
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxnombre.Text = "";
            textBoxId.Text = "";
            textBoxFechaDep.Text = "";
            textBoxNumero.Text = "";
            textBoxCantidad.Text = "";
        }
    }
}
