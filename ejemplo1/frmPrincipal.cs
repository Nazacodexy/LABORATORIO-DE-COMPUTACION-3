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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form1))
                {
                
                    return;
                }
            }

            Form1 windowPerfilPersona = new Form1();
            windowPerfilPersona.MdiParent = this;
            windowPerfilPersona.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form1))
                {

                    return;
                }
            }
            Form1 windowPerfilPersona = new Form1();
            windowPerfilPersona.ShowDialog();

        }
    }
}
