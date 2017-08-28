using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

        }

        private void tsbAgregarD_Click(object sender, EventArgs e)
        {
            frmNuevoDueno ndueno = new frmNuevoDueno();
            ndueno.MdiParent = this;
            ndueno.Show();
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListarDueno listar = new frmListarDueno();
            listar.MdiParent = this;
            listar.Show();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
           DialogResult x= MessageBox.Show("Desea Salir", "Salir del Sistema", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (x.ToString().Equals("OK"))
            {
               
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No desea salir");
            }
        }
    }
}
