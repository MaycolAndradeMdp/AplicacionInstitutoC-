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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HILET
{
    public partial class ABMCarreras : Form
    {
        private ConexionBBDD conectar;
        bool error = false;
        public ABMCarreras()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            CargarTablaCarreras();
        }

        public void CargarTablaCarreras()
        {
            string consulta = "select * From Carreras";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaCarreras.DataSource = dt;
        }

        public void LimpiarCampos()
        {
            txtIdCarrera.Text = string.Empty;
            txtCarreraNombre.Text = string.Empty;
            txtDuracionCarrera.Text = string.Empty;
            txtResolucionCarrera.Text = string.Empty;

        }

        private void grillaCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaCarreras.CurrentRow;

            txtIdCarrera.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtCarreraNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtDuracionCarrera.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtResolucionCarrera.Text = filaSeleccionada.Cells[3].Value.ToString();
        }

        private async void btnAgregarCarreras_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCarrera.Text))
            {
                error1.SetError(txtIdCarrera, "El id tiene que estar vacio");
                error = true;
            }

            if (string.IsNullOrEmpty(txtCarreraNombre.Text))
            {
                error1.SetError(txtCarreraNombre, "El nombre no puede estar vacia");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDuracionCarrera.Text) || !int.TryParse(txtDuracionCarrera.Text, out _))
            {
                error1.SetError(txtDuracionCarrera, "Ingrese una duracion valida");
                error = true;
            }

            if (string.IsNullOrEmpty(txtResolucionCarrera.Text))
            {
                error1.SetError(txtResolucionCarrera, "La resolucion no puede estar vacia");
                error = true;
            }


            if (error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            frmConfirmacion frmConf = new frmConfirmacion();

            DialogResult resultado = frmConf.ShowDialog();//abro de manera "modal"

            if (resultado == DialogResult.OK)
            {
                conectar.Abrir();

                string consulta = @$"
                               insert into Carreras (nombre, duracion, resolucion)
                                values 
                                ('{txtCarreraNombre.Text}', {Convert.ToInt32(txtDuracionCarrera.Text)}, '{txtResolucionCarrera.Text}');";

                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Carrera añadida");
                CargarTablaCarreras();
                LimpiarCampos();
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }

        }

        private async void btnModificarCarreras_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCarrera.Text) || !int.TryParse(txtIdCarrera.Text, out _))
            {
                error1.SetError(txtIdCarrera, "Ingrese un ID valido");
                error = true;
            }

            if (txtDuracionCarrera.Text != null && !int.TryParse(txtDuracionCarrera.Text, out _))
            {
                error1.SetError(txtDuracionCarrera, "Ingrese una duracion valida");
                error = true;
            }

            if (error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            frmConfirmacion frmConf = new frmConfirmacion();

            DialogResult resultado = frmConf.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                conectar.Abrir();
                string consulta = "ModificarCarrera";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdCarrera.Text));
                    comando.Parameters.AddWithValue("@nombre", txtCarreraNombre.Text);
                    comando.Parameters.AddWithValue("@duracion", Convert.ToInt32(txtDuracionCarrera.Text));
                    comando.Parameters.AddWithValue("@resolucion", txtResolucionCarrera.Text);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Carrera modificada exitosamente");
                    CargarTablaCarreras();
                    LimpiarCampos();
                }
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void grillaCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaCarreras.CurrentRow;

            txtIdCarrera.Text = filaSeleccionada.Cells[0].Value?.ToString();
            txtCarreraNombre.Text = filaSeleccionada.Cells[1].Value?.ToString();
            txtDuracionCarrera.Text = filaSeleccionada.Cells[2].Value?.ToString();
            txtResolucionCarrera.Text = filaSeleccionada.Cells[3].Value?.ToString();
        }

        private async void btnEliminarCarreras_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCarrera.Text) || !int.TryParse(txtIdCarrera.Text, out _))
            {
                error1.SetError(txtIdCarrera, "Matricula invalida");
                error = true;
            }

            if (error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            frmConfirmacion frmConf = new frmConfirmacion();

            DialogResult resultado = frmConf.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                conectar.Abrir();

                string consulta = @$"delete from Carreras where id_carrera = {txtIdCarrera.Text}";
                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Carrera eliminada exitosamente");
                CargarTablaCarreras();
                LimpiarCampos();
                conectar.Cerrar();

            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void btnReporteCarreras_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crear el documento y establecer el escritor
                iTextSharp.text.Document document = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();

                // Agregar título
                Paragraph title = new Paragraph("CARRERAS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(grillaCarreras.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[grillaCarreras.Columns.Count];
                for (int i = 0; i < grillaCarreras.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in grillaCarreras.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in grillaCarreras.Rows)
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
    }
}
