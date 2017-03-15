using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalReportV2.Controladores;

namespace CrystalReportV2
{
    public partial class frmReporte : Form
    {
        public void CargarDeptos() {
            List<String> deptos= ProductoManager.getListaDepartamentos();
            cmbDepartamento.DataSource = deptos;
        }

        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            CargarDeptos();
            cmbDepartamento.SelectedIndex = cmbDepartamento.Items.Count-1;
        }
    }
}
