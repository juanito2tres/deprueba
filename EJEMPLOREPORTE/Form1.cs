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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarReporte m = new MostrarReporte();
            m.fecha = dateTimePicker1.Value.Date;
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
            mostrarplanilla m = new mostrarplanilla();
            m.proyectp = Convert.ToInt32(textBox1.Text);
            m.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //usuarios u = new usuarios();
            //   u.ShowDialog();
            Prueba p = new Prueba();
            p.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mostrarplanilla m = new mostrarplanilla();
            m.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportViewer rpt = new ReportViewer(); ;//=null;
            
            string _sPathFilePDF = String.Empty;
            String v_mimetype;
            String v_encoding;
            String v_filename_extension;
            String[] v_streamids;
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string _sSuggestedName = String.Empty;

            Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
            Microsoft.Reporting.WinForms.LocalReport objRDLC = new Microsoft.Reporting.WinForms.LocalReport();
            rpt.LocalReport.ReportEmbeddedResource = "prueba.rdlc";
            rpt.LocalReport.DisplayName = _sSuggestedName;
            
            objRDLC.DataSources.Clear();
            byte[] byteViewer =rpt.LocalReport.Render("PDF", null, out v_mimetype, out v_encoding, out v_filename_extension, out v_streamids, out warnings);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = _sSuggestedName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream newFile = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                newFile.Write(byteViewer, 0, byteViewer.Length);
                newFile.Close();
            }
        }
    }
}
