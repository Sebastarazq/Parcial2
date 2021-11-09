using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parcial2
{
    public partial class Parqueo : Form
    {
        public Parqueo()
        {
            InitializeComponent();
        }

        private void btnFH_Click(object sender, EventArgs e)
        {
            txtFH.Text = DateTime.Now.ToString("f");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtPlacas.Clear();
            txtFH.Clear();
        }

        private void txtPlacas_TextChanged(object sender, EventArgs e)
        {
            if (txtPlacas.Text == "")
            {
                errorProvider1.SetError(txtPlacas, "Debe introducir la placa");
            }
            else
            {
                errorProvider1.SetError(txtPlacas, "");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            rtxRegistrar.Text+=txtPlacas.Text+" "+txtFH.Text+"\f\n";
           
        }

        private void btnGuardarda_Click(object sender, EventArgs e)
        {
            FileStream Datos = new FileStream(@"C:\\Users\\Asus\\Desktop\\Datos.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.None);
            StreamWriter escribir = new StreamWriter(Datos);
            escribir.WriteLine(btnRegistrar.Text);
            escribir.Close();
            richTextBox2.Text = "Datos escritos en Datos.txt";
        }

        private void btnleerda_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader leer = new StreamReader("@C:\\Users\\Asus\\Desktop\\Datos.txt");
            btnGuardarda.Text = (leer.ReadToEnd());
            leer.Close();
        }
    }
}
