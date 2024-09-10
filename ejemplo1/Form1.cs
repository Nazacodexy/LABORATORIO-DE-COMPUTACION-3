using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lvElementos.Items.Add(elemento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorfavorito.Items.Add("Rojo");
            cboColorfavorito.Items.Add("Verde");
            cboColorfavorito.Items.Add("Amarillo");

        }

        private void btnVerperfile_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechadenac.Value;
            string chocolate= chbTegustaelchocolate.Checked == true ? "LE GUSTA EL CHOCOLATE" : "NO LE GUSTA EL CHOCOLATE";
            string tipo;
            if (rbtWizard.Checked)
            {
                tipo = "Wizard";
            }
            else if (rbtSmuggle.Checked)
            {
                tipo = "Muggle";
            }
            else
            {
                tipo = "Squib";
            }
            string colorfavorito = cboColorfavorito.SelectedItem.ToString();
            string numerofavorito = nudNumFav.Value.ToString(); 

            string mensaje = "EL Nombre es: " + nombre + "\n" +
                "Fecha de Nacimiento: " + fechaNacimiento + "\n" +
               
                "Tipo: " + tipo + "\n" +
                "Color Favorito: " + colorfavorito + "\n" +
                "Numero Favorito: " + numerofavorito + "\n" +
                "y " + chocolate;
            MessageBox.Show(mensaje);




        }
    }
}
