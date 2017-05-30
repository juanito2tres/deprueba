using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EJEMPLOREPORTE
{
    public partial class MostrarReporte : Form
    {
        public MostrarReporte()
        {
            InitializeComponent();
        }

        public DateTime fecha { set; get; }
        private void MostrarReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetprincipal1.J014UsuarioPrivilegio' table. You can move, or remove it, as needed.
            this.J014UsuarioPrivilegioTableAdapter.Fill(this.datasetprincipal1.J014UsuarioPrivilegio);
            // TODO: This line of code loads data into the 'datasetprincipal1.residente' table. You can move, or remove it, as needed.
            this.residenteTableAdapter.Fill(this.datasetprincipal1.residente,fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
