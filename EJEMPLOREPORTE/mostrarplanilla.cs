using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EJEMPLOREPORTE
{
    public partial class mostrarplanilla : Form
    {
        public mostrarplanilla()
        {

                
            InitializeComponent();
        }
         
        public int proyectp { set; get; }
        public int proyectpp { set; get; }
        private void mostrarplanilla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetprincipal1.materialxxx' table. You can move, or remove it, as needed.
            
            this.reportViewer1.RefreshReport();
            

           //ReportParameter proy = new ReportParameter();
           // proy.Name = "proyecto";

           //string proyy = "55";
           // proy.Values.Add(proyy);

           
           // LocalReport local = new LocalReport();
           // local.SetParameters(new ReportParameter[] { proy });

            // TODO: This line of code loads data into the 'datasetprincipal1.planill' table. You can move, or remove it, as needed.
           //this.planillTableAdapter.Fill(this.datasetprincipal1.planill,proyectpp);

           // this.reportViewer1.RefreshReport();

           
            

        }
    }
}
