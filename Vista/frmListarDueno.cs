using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using Controlador;

namespace Vista
{
    public partial class frmListarDueno : Form
    {
        public frmListarDueno()
        {
            InitializeComponent();
            DAODueno d = new DAODueno();
            dataGridView1.DataSource = d.Listar();
        }
    }
}
