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
    public partial class InfMascotayDueno : Form
    {
        ArrayList list;
        public struct Persona
        {
            
            public string nombre;
            public string apellido;
            public string direccion;
            public Mascota mascota;

            public Persona(string n, string a, string d, string nom, string raz)
            {
                this.nombre = n;
                this.apellido = a;
                this.direccion = d;
                mascota = new Mascota(nom, raz);
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} {1} {2} {3}", nombre, apellido, direccion, mascota);
                return sb.ToString();


            }

        }

        public struct Mascota
        {
            public string nombrem;
            public string raza;

            public Mascota(string nm, string r)
            {
                this.nombrem = nm;
                this.raza = r;
            }
        }
        public InfMascotayDueno()
        {
            InitializeComponent();
            list = new ArrayList();
        }

        Persona p;

        private void InfMascotayDueno_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            p = new Persona(textBoxNombred.Text, textBoxApellido.Text,textBoxDireccion.Text, textBoxNombrem.Text, textBoxRaza.Text);
            list.Add(p.ToString ());
            
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach (string item in list)
            {
                richTextBoxDatos.Text += item + "\n";
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
