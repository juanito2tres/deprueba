using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace EJEMPLOREPORTE
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetprincipal1.J014UsuarioPrivilegio' table. You can move, or remove it, as needed.
      //--      this.J014UsuarioPrivilegioTableAdapter.Fill(this.datasetprincipal1.J014UsuarioPrivilegio);
            // TODO: This line of code loads data into the 'datasetprincipal1.tInventario' table. You can move, or remove it, as needed.
       // --    this.tInventarioTableAdapter.Fill(this.datasetprincipal1.tInventario);
            // TODO: This line of code loads data into the 'datasetprincipal1.J014UsuarioPrivilegio' table. You can move, or remove it, as needed.
           // this.J014UsuarioPrivilegioTableAdapter.Fill(this.datasetprincipal1.J014UsuarioPrivilegio);
            // TODO: This line of code loads data into the 'datasetprincipal1.tInventario' table. You can move, or remove it, as needed.
            //this.tInventarioTableAdapter.Fill(this.datasetprincipal1.tInventario);
            // TODO: This line of code loads data into the 'datasetprincipal1.J014UsuarioPrivilegio' table. You can move, or remove it, as needed.
          //  this.J014UsuarioPrivilegioTableAdapter.Fill(this.datasetprincipal1.J014UsuarioPrivilegio);
            // TODO: This line of code loads data into the 'datasetprincipal1.materialxxx' table. You can move, or remove it, as needed.
           // this.materialxxxTableAdapter.Fill(this.datasetprincipal1.materialxxx);

            //this.J014UsuarioPrivilegioTableAdapter.Fill(this.datasetprincipal1.J014UsuarioPrivilegio);

           this.reportViewer1.RefreshReport();
           DataSet dataset = new DataSet();
           DataTable table = new DataTable();
           table = this.tInventarioTableAdapter.GetData();
           // this.tinve .Fill(this.datasetprincipal1.tInventario);
           dataset.Tables.Add(table);


           this.reportViewer1.Reset();
           this.reportViewer1.ProcessingMode = ProcessingMode.Local;
           this.reportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "prueba.rdlc";
           ReportDataSource reportDataSource = new ReportDataSource();
           // Must match the DataSet in the RDLC
           reportDataSource.Name = "datax";
           reportDataSource.Value = dataset.Tables[0];
           this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
           this.reportViewer1.LocalReport.Render("PDF");
           Byte[] mybytes = this.reportViewer1.LocalReport.Render("PDF");//report.Render("WORD");
           //Byte[] mybytes = report.Render("PDF"); for exporting to PDF
           using (FileStream fs = File.Create(@"G:\SalSlip.pdf"))
           {
               fs.Write(mybytes, 0, mybytes.Length);
           }
           this.reportViewer1.RefreshReport();
        }
    }
}
