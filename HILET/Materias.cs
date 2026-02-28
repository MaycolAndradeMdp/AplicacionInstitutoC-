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
    public partial class Materias : Form
    {
        private ConexionBBDD conectar;
        private string usuario;
        private string contraseña;
        public Materias(string usuario, string contraseña)
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            this.usuario = usuario;
            this.contraseña = contraseña;
            CargarTablaMateriaxAlumno();
        }

        public void CargarTablaMateriaxAlumno()
        {
            string consulta = @$"
                           SELECT DISTINCT
                                    m.nombre, h.dia, h.hora
                                FROM 
                                    Materias AS m
                                INNER JOIN 
                                    Horarios AS h ON m.id_materia = h.id_materia
                                INNER JOIN 
                                    MateriaxAlumno AS mxa ON m.id_materia = mxa.id_materia
                                INNER JOIN 
                                    Alumnos AS a ON mxa.matricula = a.matricula
                                WHERE
                                    a.usuario = '{usuario}';";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgMaterias.DataSource = dt;
        }

        private void dtgMaterias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            FormInicio inicio = new FormInicio(usuario, contraseña);
            this.Hide();
            inicio.ShowDialog();

        }

        private void FormMaterias_FormClosing_1(object sender, FormClosingEventArgs e)
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
                Paragraph title = new Paragraph("Materias", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(dtgMaterias.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[dtgMaterias.Columns.Count];
                for (int i = 0; i < dtgMaterias.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in dtgMaterias.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in dtgMaterias.Rows)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
