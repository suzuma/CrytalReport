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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystalReportV2
{
    public partial class frmReporte : Form
    {

        ReportDocument crpDocument;

        private void GenerarReporte() {
            crpDocument = new ReportDocument();
            crpDocument.Load(@"Reportes\rptProductos.rpt");
            crpDocument.SetDataSource(ProductoManager.getListado());
            //crpDocument.SetParameterValue("NombreParametros",valor);
            this.crpVReporte.ReportSource = crpDocument;

        }
            
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.GenerarReporte();
        }
    }
}
