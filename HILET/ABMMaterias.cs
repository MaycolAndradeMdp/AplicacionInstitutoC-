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
    public partial class ABMMaterias : Form
    {
        private ConexionBBDD conectar;
        bool error = false;
        public ABMMaterias()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            CargarTablas();

        }

        public void CargarTablaMaterias()
        {
            string consulta = @"select
                                    m.id_materia,
                                    m.nombre,
                                    m.año,
                                    m.id_carreras,
                                    m.id_profesor,
                                    p.nombre,
                                    p.apellido
                                From Materias as m
                                inner join ProfesorxMateria as pxm on m.id_materia = pxm.id_materia
                                inner join Profesores as p on p.id_profesor = pxm.id_profesor";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaMaterias.DataSource = dt;
        }

        public void CargarTablaProfesores()
        {
            string consulta = @"select
                                    id_profesor,
                                    nombre,
                                    apellido
                                From Profesores ";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaProfesores.DataSource = dt;
        }

        public void CargarTablaCarreras()
        {
            string consulta = @"select
                                    id_carrera,
                                    nombre
                                From Carreras";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaCarreras.DataSource = dt;
        }

        public void CargarTablas()
        {
            CargarTablaCarreras();
            CargarTablaMaterias();
            CargarTablaProfesores();
        }

        public bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreMateria.Text))
            {
                error1.SetError(txtNombreMateria, "Ingreso un nombre invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtAñoCursadaMateria.Text) || !int.TryParse(txtAñoCursadaMateria.Text, out _))
            {
                error1.SetError(txtAñoCursadaMateria, "Ingreso un año invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtIdCarreraxMateria.Text) || !int.TryParse(txtIdCarreraxMateria.Text, out _))
            {
                error1.SetError(txtIdCarreraxMateria, "Ingreso un ID invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtIdProfesor.Text) || !int.TryParse(txtIdProfesor.Text, out _))
            {
                error1.SetError(txtIdProfesor, "Ingreso un ID invalido");
                error = true;
            }

            return error;
        }

        private void grillaMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcABMMaterias.SelectedTab = tpABMMaterias;

            // Obtiene la fila seleccionada actualmente
            DataGridViewRow filaSeleccionada = grillaMaterias.CurrentRow;

            // Asigna los valores de la fila seleccionada a los campos correspondientes
            txtIdMateria.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtNombreMateria.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtAñoCursadaMateria.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtIdCarreraxMateria.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtIdProfesor.Text = filaSeleccionada.Cells[4].Value.ToString();
        }

        private async void btnAgregarMaterias_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdMateria.Text))
            {
                error1.SetError(txtIdMateria, "El ID tiene que estar vacio");
                error = true;
            }

            if (ValidarCampos() || error == true)
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
                string consulta = "AgregarMaterias";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_carreras", Convert.ToInt32(txtIdCarreraxMateria.Text));
                    comando.Parameters.AddWithValue("@nombre", txtNombreMateria.Text);
                    comando.Parameters.AddWithValue("@año", Convert.ToInt32(txtAñoCursadaMateria.Text));
                    comando.Parameters.AddWithValue("@id_profesor", Convert.ToInt32(txtIdProfesor.Text));

                    comando.ExecuteNonQuery();


                    MessageBox.Show("Materia agregada exitosamente");
                    CargarTablas();
                    btnLimpiar_Click(sender, e);
                }
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAñoCursadaMateria.Clear();
            txtIdCarreraxMateria.Clear();
            txtIdMateria.Clear();
            txtIdProfesor.Clear();
            txtNombreMateria.Clear();
        }

        private async void btnModificarMaterias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdMateria.Text) || !int.TryParse(txtIdMateria.Text, out _))
            {
                error1.SetError(txtIdMateria, "El ID no puede estar vacio");
                error = true;
            }

            if (ValidarCampos() || error == true)
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
                string consulta = "ModificarMateria";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_materia", Convert.ToInt32(txtIdMateria.Text));
                    comando.Parameters.AddWithValue("@id_carreras", Convert.ToInt32(txtIdCarreraxMateria.Text));
                    comando.Parameters.AddWithValue("@nombre", txtNombreMateria.Text);
                    comando.Parameters.AddWithValue("@año", Convert.ToInt32(txtAñoCursadaMateria.Text));
                    comando.Parameters.AddWithValue("@id_profesor", Convert.ToInt32(txtIdProfesor.Text));

                    comando.ExecuteNonQuery();


                    MessageBox.Show("Materia modificada exitosamente");
                    CargarTablas();
                    btnLimpiar_Click(sender, e);
                }
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private async void btnEliminarMaterias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdMateria.Text) || !int.TryParse(txtIdMateria.Text, out _))
            {
                error1.SetError(txtIdMateria, "El ID no puede estar vacio");
                error = true;
            }

            if (ValidarCampos() || error == true)
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

                string consulta = @$"delete from Materias where id_materia = {txtIdMateria.Text}";
                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Materia eliminada exitosamente");
                CargarTablas();
                btnLimpiar_Click(sender, e);
                conectar.Cerrar();

            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void btnReporteMaterias_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("MATERIAS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(grillaMaterias.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[grillaMaterias.Columns.Count];
                for (int i = 0; i < grillaMaterias.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in grillaMaterias.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in grillaMaterias.Rows)
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
