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
    public partial class Reportes : Form
    {
        private ConexionBBDD conectar;
        private string usuario;
        public Reportes(string usuario)
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            this.usuario = usuario;
            CargarTabla();

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }


        public void CargarTabla()
        {
            string consulta = @"SELECT     
                                al.matricula as Matricula,
                                al.nombre AS Nombre,
                                al.apellido AS Apellido,
                                al.dni as DNI,
                                nxm.nota AS Nota,
                                nxm.libro AS Libro,
                                nxm.folio AS Folio,
                                m.nombre AS Materia,
                                i.nombre AS Insatancia
                                FROM
                                NotasxAlumno AS nxm
                                INNER JOIN Alumnos AS al ON al.matricula = nxm.matricula
                                INNER JOIN Materias AS m ON m.id_materia = nxm.id_materia
                                INNER JOIN Instancias AS i ON i.id_instancia = nxm.id_instancia";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtg_Reportes.DataSource = dt;
        }

        private void btn_buscarReportes_Click(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }
            string consulta = "PromedioNota";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombreReportes.Text) ? DBNull.Value : txtNombreReportes.Text);
            comando.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoReportes.Text) ? DBNull.Value : txtApellidoReportes.Text);
            comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDNIreportes.Text) ? DBNull.Value : txtDNIreportes.Text);
            comando.Parameters.AddWithValue("@matricula", string.IsNullOrEmpty(txtMatriculaReportes.Text) ? DBNull.Value : Convert.ToInt64(txtMatriculaReportes.Text));

            comando.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtg_Reportes.DataSource = dt;

        }

        private void btn_generarReporte_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar Archivo";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dtg_Reportes.Columns.Count);

                for (int i = 0; i < dtg_Reportes.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dtg_Reportes.Columns[i].HeaderText));
                }

                table.HeaderRows = 1;

                for (int i = 0; i < dtg_Reportes.Rows.Count; i++)
                {
                    for (int j = 0; j < dtg_Reportes.Columns.Count; j++)
                    {
                        if (dtg_Reportes.Rows[i].Cells[j].Value != null)
                        {
                            table.AddCell(new Phrase(dtg_Reportes.Rows[i].Cells[j].Value.ToString()));
                        }
                    }
                }

                document.Add(table);
                document.Close();
                writer.Close();
            }
        }

        private void dtg_Reportes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreReportes.Text = dtg_Reportes.CurrentRow.Cells[0].ToString();
            txtApellidoReportes.Text = dtg_Reportes.CurrentRow.Cells[1].ToString();
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
