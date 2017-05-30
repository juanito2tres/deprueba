namespace EJEMPLOREPORTE
{
    partial class Prueba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.J014UsuarioPrivilegioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetprincipal1 = new EJEMPLOREPORTE.datasetprincipal1();
            this.tInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.J014UsuarioPrivilegioTableAdapter = new EJEMPLOREPORTE.datasetprincipal1TableAdapters.J014UsuarioPrivilegioTableAdapter();
            this.tInventarioTableAdapter = new EJEMPLOREPORTE.datasetprincipal1TableAdapters.tInventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.J014UsuarioPrivilegioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetprincipal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // J014UsuarioPrivilegioBindingSource
            // 
            this.J014UsuarioPrivilegioBindingSource.DataMember = "J014UsuarioPrivilegio";
            this.J014UsuarioPrivilegioBindingSource.DataSource = this.datasetprincipal1;
            // 
            // datasetprincipal1
            // 
            this.datasetprincipal1.DataSetName = "datasetprincipal1";
            this.datasetprincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tInventarioBindingSource
            // 
            this.tInventarioBindingSource.DataMember = "tInventario";
            this.tInventarioBindingSource.DataSource = this.datasetprincipal1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datax";
            reportDataSource1.Value = this.tInventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EJEMPLOREPORTE.prueba.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(769, 355);
            this.reportViewer1.TabIndex = 0;
            // 
            // J014UsuarioPrivilegioTableAdapter
            // 
            this.J014UsuarioPrivilegioTableAdapter.ClearBeforeFill = true;
            // 
            // tInventarioTableAdapter
            // 
            this.tInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 355);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.J014UsuarioPrivilegioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetprincipal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tInventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private datasetprincipal1 datasetprincipal1;
        private System.Windows.Forms.BindingSource J014UsuarioPrivilegioBindingSource;
        private datasetprincipal1TableAdapters.J014UsuarioPrivilegioTableAdapter J014UsuarioPrivilegioTableAdapter;
        private System.Windows.Forms.BindingSource tInventarioBindingSource;
        private datasetprincipal1TableAdapters.tInventarioTableAdapter tInventarioTableAdapter;
    }
}