namespace EJEMPLOREPORTE
{
    partial class mostrarplanilla
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
            this.planillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetprincipal1 = new EJEMPLOREPORTE.datasetprincipal1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.planillTableAdapter = new EJEMPLOREPORTE.datasetprincipal1TableAdapters.planillTableAdapter();
            this.materialxxxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.planillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetprincipal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialxxxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planillBindingSource
            // 
            this.planillBindingSource.DataMember = "planill";
            this.planillBindingSource.DataSource = this.datasetprincipal1;
            // 
            // datasetprincipal1
            // 
            this.datasetprincipal1.DataSetName = "datasetprincipal1";
            this.datasetprincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MATERIAL";
            reportDataSource1.Value = this.materialxxxBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EJEMPLOREPORTE.MATERIAL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(560, 357);
            this.reportViewer1.TabIndex = 0;
            // 
            // planillTableAdapter
            // 
            this.planillTableAdapter.ClearBeforeFill = true;
            // 
            // materialxxxBindingSource
            // 
            this.materialxxxBindingSource.DataMember = "materialxxx";
            this.materialxxxBindingSource.DataSource = this.datasetprincipal1;
            
            // mostrarplanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 357);
            this.Controls.Add(this.reportViewer1);
            this.Name = "mostrarplanilla";
            this.Text = "mostrarplanilla";
            this.Load += new System.EventHandler(this.mostrarplanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetprincipal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialxxxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource planillBindingSource;
        private datasetprincipal1 datasetprincipal1;
        private datasetprincipal1TableAdapters.planillTableAdapter planillTableAdapter;
        private System.Windows.Forms.BindingSource materialxxxBindingSource;
    }
}