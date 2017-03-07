using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReportV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }


    /*
    CrystalDecisions.CrystalReports.Engine.ReportDocument crReporteDocument;
    if (hayError) { 
                crReporteDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                //crReporteDocument.Load(@"szmMovimientoTierra\reportes\crpDiario.rpt");
                crReporteDocument.Load(@"szmMovimientoTierra\reportes\crpReporteDiarioIntegrado.rpt");
               
                crReporteDocument.SetDataSource(objDatosDiario.Almacen);

                crReporteDocument.SetParameterValue("Fecha", dtpFecha.Text);
                string Turno = "";
                if (chkResumen.IsChecked == true)
                {
                    int itemSelect = cmbTurno.SelectedIndex;
                    for (int i = 0; i <= itemSelect; i++)
                    {
                        cmbTurno.SelectedIndex = i;
                        Turno = Turno + " | " + cmbTurno.Text;
                    }
                    cmbTurno.SelectedIndex = itemSelect;
                }
                else
                {
                    Turno = cmbTurno.Text;
                }

                crReporteDocument.SetParameterValue("De", Turno);
                if (chkResumen.IsChecked == true)
                    crReporteDocument.SetParameterValue("Tipo", "Acumulado");
                else
                    crReporteDocument.SetParameterValue("Tipo", "Normal");

                crReporteDocument.SetParameterValue("Folios", this.Folios);

                this.crtReporte.ViewerCore.ReportSource = crReporteDocument;
                btnExportar.IsEnabled = true;
            }
    */
}
