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
    public partial class ABMExamenes : Form
    {
        private ConexionBBDD conectar;
        bool error = false;
        public ABMExamenes()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            CargarTablas();

            // Cargando ComboBox de Instancias
            string consulta = "SELECT id_instancia, nombre FROM Instancias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbInstancia.DataSource = dt;
            cmbInstancia.DisplayMember = "nombre";
            cmbInstancia.ValueMember = "id_instancia";


        }

        public void CargarTablaAnaliticos()
        {

            string consulta = @$"SELECT
                                    a.matricula,
                                    a.nombre AS NombreAlumno,
                                    a.apellido AS ApellidoAlumno,
                                    m.nombre AS NombreMateria,
                                    m.año AS AñoMateria, 
                                    i.nombre AS NombreInstancia,
                                    nxa.nota,
                                    nxa.fecha,
                                    nxa.libro,
                                    nxa.folio
                                FROM
                                    Alumnos a
                                INNER JOIN
                                    NotasxAlumno nxa ON a.matricula = nxa.matricula
                                INNER JOIN
                                    Materias m ON m.id_materia = nxa.id_materia
                                INNER JOIN
                                    Instancias i ON i.id_instancia = nxa.id_instancia
                                WHERE
                                    a.matricula ={txtMatricula.Text};";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaAnalitico.DataSource = dt;
        }

        public void CargarTablaFinales()
        {
            string consulta = @"select 
	                                a.Nombre,
	                                a.Apellido,
	                                nxa.nota,
	                                nxa.id_materia,
	                                i.id_instancia,
	                                nxa.folio,
	                                nxa.libro
                                from
	                                NotasxAlumno as nxa
	                                inner join Alumnos as a on a.matricula = nxa.matricula
	                                inner join Instancias as i on i.id_instancia = nxa. id_instancia
                                where
	                                i.id_instancia = 5;";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaFinales.DataSource = dt;
        }
        public void CargarTablaNotas()
        {
            string consulta = @"select * from NotasxAlumno";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaNotas.DataSource = dt;
        }

        public void CargarTablaInstancias()
        {
            string consulta = @"select 
	                                nombre,
                                    descripcion
                                from 
	                                Instancias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaInstancia.DataSource = dt;
        }

        public void CargarTablaMaterias()
        {
            string consulta = @"select
                                    id_materia,
                                    nombre
                                from 
                                    Materias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaMateria.DataSource = dt;
        }

        public void CargarTablas()
        {
            CargarTablaInstancias();
            CargarTablaMaterias();
            CargarTablaNotas();
            CargarTablaFinales();
        }

        public bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtIdMateriaxExamenes.Text) || !int.TryParse(txtIdMateriaxExamenes.Text, out _))
            {
                error1.SetError(txtIdMateriaxExamenes, "ID invalida");
                error = true;
            }

            if (cmbInstancia.SelectedIndex == -1)
            {
                error1.SetError(cmbInstancia, "Tiene que elegir una carrera");
                error = true;
            }

            if (string.IsNullOrEmpty(txtNota.Text) || !double.TryParse(txtNota.Text, out double nota) || nota <= 0 || nota > 10)
            {
                error1.SetError(txtNota, "La nota ingresada debe estar entre 1 y 10.");
                error = true;
            }


            if (string.IsNullOrEmpty(txtIdMatricula.Text) || !int.TryParse(txtIdMatricula.Text, out _))
            {
                error1.SetError(txtIdMatricula, "Ingrese una matricula valida");
                error = true;
            }

            return error;
        }

        private async void btnAgregarExamen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdExamenes.Text))
            {
                error1.SetError(txtIdExamenes, "El ID tiene que estar vacio");
                error = true;
            }

            if ((int)cmbInstancia.SelectedValue == 5)
            {
                if (string.IsNullOrEmpty(txtFolio.Text))
                {
                    error1.SetError(txtFolio, "Ingrese un folio");
                    error = true;
                }
 

                if (string.IsNullOrEmpty(txtLibro.Text))
                {
                    error1.SetError(txtLibro, "Ingrese un libro");
                    error = true;
                }
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
                string consulta = "AgregarExamen";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", txtIdMatricula.Text);
                    comando.Parameters.AddWithValue("@id_materia", Convert.ToInt32(txtIdMateriaxExamenes.Text));
                    comando.Parameters.AddWithValue("@id_instancia", cmbInstancia.SelectedValue);

                    DateTime fechaExamen = calendarioExamen.SelectionStart;
                    comando.Parameters.AddWithValue("@fecha", fechaExamen);

                    comando.Parameters.AddWithValue("@nota", Convert.ToDouble(txtNota.Text));
                    comando.Parameters.AddWithValue("@libro", txtLibro.Text);
                    comando.Parameters.AddWithValue("@folio", txtFolio.Text);

                    comando.ExecuteNonQuery();


                    MessageBox.Show("Nota agregada exitosamente");
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
            txtFolio.Clear();
            txtIdExamenes.Clear();
            txtIdMateriaxExamenes.Clear();
            txtIdMatricula.Clear();
            txtLibro.Clear();
            txtNota.Clear();
        }

        private async void btnModificarExamen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdExamenes.Text) || !int.TryParse(txtIdExamenes.Text, out _))
            {
                error1.SetError(txtIdExamenes, "ID invalida");
                error = true;
            }

            if ((int)cmbInstancia.SelectedValue == 5)
            {
                if (string.IsNullOrEmpty(txtFolio.Text))
                {
                    error1.SetError(txtFolio, "Ingrese un folio");
                    error = true;
                }


                if (string.IsNullOrEmpty(txtLibro.Text))
                {
                    error1.SetError(txtLibro, "Ingrese un libro");
                    error = true;
                }
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
                string consulta = "ModificarExamen";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_notasxalumno", txtIdExamenes.Text);
                    comando.Parameters.AddWithValue("@matricula", txtIdMatricula.Text);
                    comando.Parameters.AddWithValue("@id_materia", Convert.ToInt32(txtIdMateriaxExamenes.Text));
                    comando.Parameters.AddWithValue("@id_instancia", cmbInstancia.SelectedValue);

                    DateTime fechaExamen = calendarioExamen.SelectionStart;
                    comando.Parameters.AddWithValue("@fecha", fechaExamen);

                    comando.Parameters.AddWithValue("@nota", Convert.ToDouble(txtNota.Text));
                    comando.Parameters.AddWithValue("@libro", txtLibro.Text);
                    comando.Parameters.AddWithValue("@folio", txtFolio.Text);

                    comando.ExecuteNonQuery();


                    MessageBox.Show("Nota modificada exitosamente");
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

        private async void btnEliminarExamen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdExamenes.Text) || !int.TryParse(txtIdExamenes.Text, out _))
            {
                error1.SetError(txtIdExamenes, "ID invalida");
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
                string consulta = $"delete from NotasxAlumno where id_notasxalumno = {txtIdExamenes.Text}";


                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();

                MessageBox.Show("Eliminacion exitosa");

                CargarTablas();
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void grillaNotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcExamenes.SelectedTab = tpABMNotas;

            // Obtiene la fila seleccionada actualmente
            DataGridViewRow filaSeleccionada = grillaNotas.CurrentRow;

            // Asigna los valores de la fila seleccionada a los campos correspondientes
            txtIdExamenes.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtIdMatricula.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtIdMateriaxExamenes.Text = filaSeleccionada.Cells[2].Value.ToString();
            cmbInstancia.SelectedIndex = cmbInstancia.FindStringExact(filaSeleccionada.Cells[3].Value.ToString());
            txtNota.Text = filaSeleccionada.Cells[5].Value.ToString();
            txtLibro.Text = filaSeleccionada.Cells[6].Value.ToString();
            txtFolio.Text = filaSeleccionada.Cells[7].Value.ToString();
        }

        private void btnReporteNotas_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("NOTAS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(grillaNotas.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[grillaNotas.Columns.Count];
                for (int i = 0; i < grillaNotas.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in grillaNotas.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in grillaNotas.Rows)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();

            int matricula;
            if (!int.TryParse(txtMatricula.Text, out matricula))
            {
                MessageBox.Show("Por favor, ingrese una matrícula válida.");
                return;
            }

            string consulta = "BuscarMatricula";
            using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                SqlParameter paramSalida = new SqlParameter("@existe", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                comando.Parameters.Add(paramSalida);

                comando.ExecuteNonQuery();

                int existe = (int)paramSalida.Value;

                if (existe == 0)
                {
                    MessageBox.Show("No se encontró un alumno con esa matrícula.");
                }
                else
                {
                    CargarTablaAnaliticos();
                }
            }
            conectar.Cerrar();
        }

        private void btnReporteAnaliticos_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("ANALITICO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(grillaAnalitico.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[grillaAnalitico.Columns.Count];
                for (int i = 0; i < grillaAnalitico.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in grillaAnalitico.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in grillaAnalitico.Rows)
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
