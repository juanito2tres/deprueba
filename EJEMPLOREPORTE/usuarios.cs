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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }
        public DataSet usux()
        {
           DataTable t=new DataTable();
            DataSet ds = new DataSet();
            ds = datasetprincipal1;
            
            return ds ;
        }
        private void usuarios_Load1(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            DataTable table = new DataTable();
            table = this.J014UsuarioPrivilegioTableAdapter.GetData();
            dataset.Tables.Add(table);
            // If your report needs parameters, they need to be set ...

            ReportDataSource reportDataSource = new ReportDataSource();
            // Must match the DataSource in the RDLC
            reportDataSource.Name = "ReportData";
            reportDataSource.Value = table;

            // Add any parameters to the collection
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            
            this.reportViewer1.RefreshReport();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            DataTable table = new DataTable();
            table = this.J014UsuarioPrivilegioTableAdapter.GetData();
            dataset.Tables.Add(table);
          

            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "prueba.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            // Must match the DataSet in the RDLC
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = dataset.Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void usuarios_Loadmal(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetprincipal1.J014UsuarioPrivilegio' table. You can move, or remove it, as needed.
            //this.J014UsuarioPrivilegioTableAdapter.Fill(this.datasetprincipal1.J014UsuarioPrivilegio);
            //this.reportViewer1.RefreshReport();




            //this.reportViewer1.RefreshReport();

            
            this.reportViewer1.LocalReport.DataSources.Clear();
           // reportViewer1.Reset();
            //reportViewer1.LocalReport.ReportEmbeddedResource = "usuarios.rdlc";
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Connection";
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select * from YourTableName";
            //DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader());
            //con.Close();
            //ReportDataSource rprtDTSource = new ReportDataSource();
            //rprtDTSource.Name = "reportDataSetName";
            //rprtDTSource.Value = dt;
            //this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            //this.reportViewer1.RefreshReport();

            //reportViewer1.ProcessingMode = ProcessingMode.Local;

            //LocalReport localReport = reportViewer1.LocalReport;
            //localReport.ReportPath = "usuarios.rdlc";

            DataSet dataset = new DataSet();
            DataTable table = new DataTable();

            //table.Load(this.J014UsuarioPrivilegioTableAdapter.Fill(this.datasetprincipal1.J014UsuarioPrivilegio));

            // Get the sales order data  
            //dataset = this.datasetprincipal1;//usux(); //Ncls.GetSalesOrderData(Nro);
            table = this.J014UsuarioPrivilegioTableAdapter.GetData();
            dataset.Tables.Add(table);
            // Create a report data source for the sales order data  
            // DateTime x = System.DateTime.Now;
            /**************************************/
            ReportDataSource dsSalesOrder = new ReportDataSource();
            //dsSalesOrder.Name = "id";
            //dsSalesOrder.Value = dataset.Tables[0];
            dsSalesOrder.Value = table.Locale;
            this.reportViewer1.LocalReport.DataSources.Add(dsSalesOrder);
            this.reportViewer1.LocalReport.Refresh();// RefreshReport();
            //this.reportViewer1.LocalReport.DataSources.Add dsSalesOrder;
            //foreach (DataRow item in dataset.Tables[0].Rows)
            //{
            //    dsSalesOrder.Value (item["id"].ToString());
            //}

           // rpSalesOrderNumber.Name = "parametro";
            //rpSalesOrderNumber.Values = dataset.Tables[0].;
            
            //ReportParameter rpusuario = new ReportParameter();
            //rpusuario.Name = "usuario";
            //rpusuario.Values.Add(dsSalesOrder.Value.ToString());
            //foreach (DataRow item in dataset.Tables[0].Rows)
            //{
            //    rpusuario.Values.Add(item["Usuario"].ToString());
            //}
            //rpusuario.Values.Add= (dataset.Tables[0].Columns["Nombre"].ToString());

            //ReportParameter rfecha = new ReportParameter();
            //rfecha.Name = "fecha";


            //this.reportViewer1.LocalReport.DataSources.Add(dsSalesOrder); 

            //string Nombre = "CONSTRUCTORA " + Ncls.ObtenerNombreEmpresa1(m_parent.id_empresa) + " S.R.L.";
            //rpSalesOrderNumber.Values.Add(Nombre);

            //string usuario1 = m_parent.id_User;
            //rpusuario.Values.Add(usuario1);

            //string fecha = Convert.ToString(m_parent.GetSqlDateTime());
            //rfecha.Values.Add(fecha);

            //localReport.SetParameters(
            //     new ReportParameter[] {  rpusuario, rfecha });
            //localReport.SetParameters(
            //  new ReportParameter[] { rpusuario });
            //localReport.SetParameters(
            //  new ReportParameter[] { rfecha });
           
            //this.reportViewer1.LocalReport.Refresh();     //  localReport.DataSources.Add(dsSalesOrder);
            /********************************************/
            // Get the sales order detail data  
            /// GetSalesOrderDetailData(salesOrderNumber, ref dataset);ver

            // Create a report data source for the sales order detail   
            // data  
            ////ReportDataSource dsSalesOrderDetail =
            ////    new ReportDataSource();
            ////dsSalesOrderDetail.Name = "SalesOrderDetail";
            ////dsSalesOrderDetail.Value =   ver
            ////    dataset.Tables["SalesOrderDetail"];

            ////localReport.DataSources.Add(dsSalesOrderDetail);

            // Create a report parameter for the sales order number   

            /*ReportParameter rpSalesOrderNumber = new ReportParameter();
            rpSalesOrderNumber.Name = "parametro";
            ReportParameter rpusuario = new ReportParameter();
            rpusuario.Name = "usuario";

            ReportParameter rfecha = new ReportParameter();
            rfecha.Name = "fecha";

            string Nombre = "CONSTRUCTORA " + Ncls.ObtenerNombreEmpresa1(m_parent.id_empresa) + " S.R.L.";
            rpSalesOrderNumber.Values.Add(Nombre);

            string usuario1 = m_parent.id_User;
            rpusuario.Values.Add(usuario1);

            string fecha = Convert.ToString(m_parent.GetSqlDateTime());
            rfecha.Values.Add(fecha);

            localReport.SetParameters(
                 new ReportParameter[] { rpSalesOrderNumber, rpusuario, rfecha });*/
            //localReport.SetParameters(
            //  new ReportParameter[] { rpusuario });
            //localReport.SetParameters(
            //  new ReportParameter[] { rfecha });

            // Refresh the report  
        
           
           // reportViewer1.RefreshReport(); 
        }
    }
}
