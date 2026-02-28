using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HILET
{
    public partial class examenes : Form
    {
        private string usuario;
        private string contraseña;
        private ConexionBBDD conectar;
        public examenes(string usuario, string contraseña)
        {
            this.usuario = usuario;
            InitializeComponent();
            conectar = new ConexionBBDD();
            conectar.Abrir();
            string consulta = "Notas_Por_Alumno";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgExamenes.DataSource = dt;
            conectar.Cerrar();

            //la grilla se ordena por la fecha (mas recientes arriba)
            dtgExamenes.Sort(dtgExamenes.Columns["fecha"], ListSortDirection.Descending);
            this.contraseña = contraseña;
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            FormInicio inicio = new FormInicio(usuario, contraseña);
            this.Hide();
            inicio.ShowDialog();

        }

        private void examenes_FormClosing_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnInicio_Click_1(sender, e);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (.pdf)|.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crear el documento y establecer el escritor
                iTextSharp.text.Document document = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();

                // Agregar título
                Paragraph title = new Paragraph("Notas", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(dtgExamenes.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[dtgExamenes.Columns.Count];
                for (int i = 0; i < dtgExamenes.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in dtgExamenes.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in dtgExamenes.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string cellText = cell.Value?.ToString() ?? string.Empty;
                        PdfPCell dataCell = new PdfPCell(new Phrase(cellText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8)));
                        dataCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        dataCell.Padding = 5f; // Añadir espacio interno en la celda de datos
                        table.AddCell(dataCell);
                    }
                }

                // Agregar la tabla al documento
                document.Add(table);
                document.Close();
                writer.Close();
            }
        }

        private void exportarAPDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnPdf_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void examenes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnInicio_Click_1(sender, e);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPdf_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
