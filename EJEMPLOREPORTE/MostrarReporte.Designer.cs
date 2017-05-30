namespace EJEMPLOREPORTE
{
    partial class MostrarReporte
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
            this.residenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetprincipal1 = new EJEMPLOREPORTE.datasetprincipal1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.residenteTableAdapter = new EJEMPLOREPORTE.datasetprincipal1TableAdapters.residenteTableAdapter();
            this.J014UsuarioPrivilegioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.J014UsuarioPrivilegioTableAdapter = new EJEMPLOREPORTE.datasetprincipal1TableAdapters.J014UsuarioPrivilegioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.residenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetprincipal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.J014UsuarioPrivilegioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // residenteBindingSource
            // 
            this.residenteBindingSource.DataMember = "residente";
            this.residenteBindingSource.DataSource = this.datasetprincipal1;
            // 
            // datasetprincipal1
            // 
            this.datasetprincipal1.DataSetName = "datasetprincipal1";
            this.datasetprincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.J014UsuarioPrivilegioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EJEMPLOREPORTE.usuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(584, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // residenteTableAdapter
            // 
            this.residenteTableAdapter.ClearBeforeFill = true;
            // 
            // J014UsuarioPrivilegioBindingSource
            // 
            this.J014UsuarioPrivilegioBindingSource.DataMember = "J014UsuarioPrivilegio";
            this.J014UsuarioPrivilegioBindingSource.DataSource = this.datasetprincipal1;
            // 
            // J014UsuarioPrivilegioTableAdapter
            // 
            this.J014UsuarioPrivilegioTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarReporte";
            this.Text = "MostrarReporte";
            this.Load += new System.EventHandler(this.MostrarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.residenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetprincipal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.J014UsuarioPrivilegioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource residenteBindingSource;
        private datasetprincipal1 datasetprincipal1;
        private datasetprincipal1TableAdapters.residenteTableAdapter residenteTableAdapter;
        private System.Windows.Forms.BindingSource J014UsuarioPrivilegioBindingSource;
        private datasetprincipal1TableAdapters.J014UsuarioPrivilegioTableAdapter J014UsuarioPrivilegioTableAdapter;
    }
}