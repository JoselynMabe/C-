using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Controlador;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Vista
{
    public partial class frmNuevoDueno : Form
    {
        public frmNuevoDueno()
        {
            InitializeComponent();
            cbSexo.DataSource = Enum.GetValues(typeof(TipoSexo));
        }

        private void frmNuevoDueno_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DAODueno dao = new DAODueno();
                Dueno d = new Dueno();

                d.Rut = txtRut.Text;
                d.Nombre = txtNombre.Text;
                d.Sexo = (TipoSexo)cbSexo.SelectedIndex;
                bool resp = dao.Agregar(d);

                toolStripStatusLabel1.Text = (resp ? "Grabo Nuevo Dueño" : "No Grabo nuevo Dueño");
            }
            catch (Exception ex)
            {

                Log.Mensaje(ex.Message);
                statusStrip1.Text = ex.Message;
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
