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
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace HILET
{
    public partial class ABMAlumnos : Form
    {
        private ConexionBBDD conectar;
        bool error = false;
        public ABMAlumnos()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            CargarTablas();

            // Cargando ComboBox de Carreras
            string consulta = "SELECT id_carrera, nombre FROM Carreras";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbCarreraAlumno.DataSource = dt;
            cmbCarreraAlumno.DisplayMember = "nombre";
            cmbCarreraAlumno.ValueMember = "id_carrera";

            // Cargando ComboBox filtros

            cmbFiltroAlumnos.Items.Add("Alumnos inscriptos");
            cmbFiltroAlumnos.Items.Add("Alumnos dados de baja");
            cmbFiltroAlumnos.SelectedIndex = 0;
        }

        public bool ValidarCamposAlumno()
        {

            // Validación del campo apellido
            if (string.IsNullOrEmpty(txtApellidoAlumno.Text) || int.TryParse(txtApellidoAlumno.Text, out _))
            {
                error1.SetError(txtApellidoAlumno, "ingresó un apellido invalido");
                error = true;
            }

            // Validación del campo nombre
            if (string.IsNullOrEmpty(txtNombreAlumno.Text) || int.TryParse(txtNombreAlumno.Text, out _))
            {
                error1.SetError(txtNombreAlumno, "ingresó un nombre invalido");
                error = true;
            }

            // Validación del campo DNI
            if (string.IsNullOrEmpty(txtDniAlumno.Text) || !int.TryParse(txtDniAlumno.Text, out _) || txtDniAlumno.Text.Length != 8)
            {
                error1.SetError(txtDniAlumno, "ingresó un DNI invalido");
                error = true;
            }

            // Validación del campo Telefono
            if (string.IsNullOrEmpty(txtTelefonoAlumno.Text) || !int.TryParse(txtTelefonoAlumno.Text, out _))
            {
                error1.SetError(txtTelefonoAlumno, "ingresó un telefono invalido");
                error = true;
            }

            // Validación del campo Email
            if (string.IsNullOrEmpty(txtEmailAlumno.Text))
            {
                error1.SetError(txtEmailAlumno, "ingresó un gmail invalido");
                error = true;
            }

            // Validación del campo Domicilio Calle
            if (string.IsNullOrEmpty(txtDomicilioCalleAlumno.Text) || int.TryParse(txtDomicilioCalleAlumno.Text, out _))
            {
                error1.SetError(txtDomicilioCalleAlumno, "ingresó una calle invalida");
                error = true;
            }

            // Validación del campo Numero Calle
            if (string.IsNullOrEmpty(txtNumeroCalleAlumno.Text) || !int.TryParse(txtNumeroCalleAlumno.Text, out _))
            {
                error1.SetError(txtNumeroCalleAlumno, "ingreso un numero invalido");
                error = true;
            }

            return error;
        }

        public void CargarTablas()
        {
            CargarTablaAlumnos();
            CargarTablaAlumxCarr();
        }

        public void CargarTablaAlumnos()
        {
            string consulta = @"
        SELECT 
            a.matricula, 
            a.nombre, 
            a.apellido, 
            a.dni, 
            a.email,
            a.telefono,
            a.domicilioCalle,
            a.domicilioNumero,
            a.usuario,
            a.contraseña,
            Cxa.Año_Cursada,
            C.nombre as Carrera,
            a.fechaInscripcion,
            a.fechaBaja
        FROM 
            Alumnos AS a
        LEFT JOIN 
            CarreraxAlumno AS Cxa ON a.matricula = Cxa.matricula
        LEFT JOIN 
            Carreras AS C ON C.id_carrera = Cxa.id_carrera";

            if (cmbFiltroAlumnos.SelectedIndex == 0)  
            {
                consulta += " WHERE a.fechaBaja IS NULL"; 
            }
            else if (cmbFiltroAlumnos.SelectedIndex == 1)  
            {
                consulta += " WHERE a.fechaBaja IS NOT NULL";  
            }

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaAlumnos.DataSource = dt;
        }

        public void CargarTablaAlumxCarr()
        {
            string consulta = @"
                            SELECT 
                                a.matricula, 
                                a.nombre, 
                                a.apellido, 
                                a.dni, 
                                Cxa.Año_Cursada,
                                C.nombre as Carrera
                            FROM 
                                Alumnos AS a
                            LEFT JOIN 
                                CarreraxAlumno AS Cxa ON a.matricula = Cxa.matricula
                            LEFT JOIN 
                                Carreras AS C ON C.id_carrera = Cxa.id_carrera
                            WHERE
                                a.fechaBaja IS NULL";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grillaAlumnosxCarrera.DataSource = dt;
        }


        private void grillaAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcABMAlumnos.SelectedTab = tpABMAlumnos;

            // Obtiene la fila seleccionada actualmente
            DataGridViewRow filaSeleccionada = grillaAlumnos.CurrentRow;

            // Asigna los valores de la fila seleccionada a los campos correspondientes
            txtMatricula.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtNombreAlumno.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtApellidoAlumno.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtDniAlumno.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtEmailAlumno.Text = filaSeleccionada.Cells[4].Value.ToString();
            txtTelefonoAlumno.Text = filaSeleccionada.Cells[5].Value.ToString();
            txtDomicilioCalleAlumno.Text = filaSeleccionada.Cells[6].Value.ToString();
            txtNumeroCalleAlumno.Text = filaSeleccionada.Cells[7].Value.ToString();
            txtUsuarioAlumno.Text = filaSeleccionada.Cells[8].Value.ToString();
            txtContraseñaAlumno.Text = filaSeleccionada.Cells[9].Value.ToString();
        }

        private async void btnAgregarAlumno_Click_1(object sender, EventArgs e)
        {
            // Validamos el campo Matricula
            if (!string.IsNullOrEmpty(txtMatricula.Text))
            {
                error1.SetError(txtMatricula, "La matricula tiene que estar vacia");
                error = true;
            }

            // Validamos el campo Usuario
            if (string.IsNullOrEmpty(txtUsuarioAlumno.Text))
            {
                error1.SetError(txtUsuarioAlumno, "El usuario no puede estar vacio");
                error = true;
            }

            // Validamos el campo contraseña
            if (string.IsNullOrEmpty(txtContraseñaAlumno.Text))
            {
                error1.SetError(txtContraseñaAlumno, "La contraseña no puede estar vacia");
                error = true;
            }
            // Validamos los demás campos
            if (ValidarCamposAlumno() || error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            // Abrimos el formulario "frmConfirmacion" de manera modal 
            frmConfirmacion frmConf = new frmConfirmacion();

            DialogResult resultado = frmConf.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                conectar.Abrir();
                string consulta = "AgregarAlumno";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text);
                    comando.Parameters.AddWithValue("@apellido", txtApellidoAlumno.Text);
                    comando.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDniAlumno.Text));
                    comando.Parameters.AddWithValue("@domicilioCalle", txtDomicilioCalleAlumno.Text);
                    comando.Parameters.AddWithValue("@domicilioNumero", Convert.ToInt32(txtNumeroCalleAlumno.Text));
                    comando.Parameters.AddWithValue("@telefono", txtTelefonoAlumno.Text);
                    comando.Parameters.AddWithValue("@email", txtEmailAlumno.Text);
                    comando.Parameters.AddWithValue("@fechaInscripcion", DateTime.Now);
                    comando.Parameters.AddWithValue("@fechaBaja", DBNull.Value);
                    comando.Parameters.AddWithValue("@usuario", txtUsuarioAlumno.Text);
                    comando.Parameters.AddWithValue("@contraseña", txtContraseñaAlumno.Text);
                    comando.Parameters.AddWithValue("@id_perfil", 1);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Alumno agregado exitosamente");
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

        private async void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            // Validamos el campo Matricula
            if (string.IsNullOrEmpty(txtMatricula.Text) || !int.TryParse(txtMatricula.Text, out _))
            {
                error1.SetError(txtMatricula, "Matricula invalida");
                error = true;
            }

            // Validamos los demás campos
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
                string consulta = "EliminarAlumno";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", Convert.ToInt32(txtMatricula.Text));
                    comando.Parameters.AddWithValue("@fechaBaja", DateTime.Now);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alumno dado de baja exitosamente");
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

        private async void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text) || !int.TryParse(txtMatricula.Text, out _))
            {
                error1.SetError(txtMatricula, "Matricula invalida");
                error = true;
            }

            // Validamos el campo Usuario
            if (string.IsNullOrEmpty(txtUsuarioAlumno.Text))
            {
                error1.SetError(txtUsuarioAlumno, "El usuario no tiene que estar vacio");
                error = true;
            }

            // Validamos el campo contraseña
            if (string.IsNullOrEmpty(txtContraseñaAlumno.Text))
            {
                error1.SetError(txtContraseñaAlumno, "La contraseña no tiene que estar vacia");
                error = true;
            }
            // Validamos los demás campos
            if (ValidarCamposAlumno() || error == true)
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
                string consulta = "ModificarAlumno";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text);
                    comando.Parameters.AddWithValue("@apellido", txtApellidoAlumno.Text);
                    comando.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDniAlumno.Text));
                    comando.Parameters.AddWithValue("@domicilioCalle", txtDomicilioCalleAlumno.Text);
                    comando.Parameters.AddWithValue("@domicilioNumero", Convert.ToInt32(txtNumeroCalleAlumno.Text));
                    comando.Parameters.AddWithValue("@telefono", txtTelefonoAlumno.Text);
                    comando.Parameters.AddWithValue("@email", txtEmailAlumno.Text);
                    comando.Parameters.AddWithValue("@fechaInscripcion", DateTime.Now);
                    comando.Parameters.AddWithValue("@fechaBaja", DBNull.Value);
                    comando.Parameters.AddWithValue("@usuario", txtUsuarioAlumno.Text);
                    comando.Parameters.AddWithValue("@contraseña", txtContraseñaAlumno.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alumno modificado exitosamente");
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

        private async void btnAgregarAlumnoCarrera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula2.Text) || !int.TryParse(txtMatricula2.Text, out _))
            {
                error1.SetError(txtMatricula2, "Matricula invalida");
                error = true;
            }

            if (cmbCarreraAlumno.SelectedIndex == -1)
            {
                error1.SetError(cmbCarreraAlumno, "Tiene que elegir una carrera");
                error = true;
            }

            if (string.IsNullOrEmpty(txtAñoCursadaAlumno.Text))
            {
                error1.SetError(txtAñoCursadaAlumno, "El año de cursada no puede estar vacia");
                error = true;
            }

            // Validamos los demás campos
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

                string consulta = @$"INSERT INTO CarreraxAlumno (Año_Cursada, matricula, id_carrera) 
                                    VALUES ({Convert.ToInt32(txtAñoCursadaAlumno.Text)},{Convert.ToInt32(txtMatricula2.Text)} ,{cmbCarreraAlumno.SelectedValue})";
                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();

                MessageBox.Show("Carrera añadida al alumno exitosamente");

                CargarTablas();
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }


        }

        private async void btnModificarAlumnoCarrera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula2.Text) || !int.TryParse(txtMatricula2.Text, out _))
            {
                error1.SetError(txtMatricula2, "La matricula no puede estar vacia");
                error = true;
            }

            if (string.IsNullOrEmpty(txtAñoCursadaAlumno.Text) && cmbCarreraAlumno.SelectedIndex == -1)
            {
                error1.SetError(btnModificarAlumnoCarrera, "Tiene que elegir modificar algo");

            }
            // Validamos los demás campos
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



                string consulta = @$"
                            UPDATE CarreraxAlumno
                            SET 
                                Año_Cursada = {txtAñoCursadaAlumno.Text} ,
                                id_carrera = {cmbCarreraAlumno.SelectedValue}
                             WHERE matricula = {txtMatricula2.Text}";

                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();

                MessageBox.Show("Modificacion exitosa");

                CargarTablas();
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = string.Empty;
            txtNombreAlumno.Text = string.Empty;
            txtApellidoAlumno.Text = string.Empty;
            txtDniAlumno.Text = string.Empty;
            txtTelefonoAlumno.Text = string.Empty;
            txtEmailAlumno.Text = string.Empty;
            txtDomicilioCalleAlumno.Text = string.Empty;
            txtNumeroCalleAlumno.Text = string.Empty;
            txtUsuarioAlumno.Text = string.Empty;
            txtContraseñaAlumno.Text = string.Empty;
        }

        private async void btnEliminarAlumnoCarrera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula2.Text))
            {
                error1.SetError(txtMatricula2, "La matricula no puede estar vacia");
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
                string consulta = $"delete from CarreraxAlumno where matricula = {txtMatricula2.Text}";


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

        private void grillaAlumnosxCarrera_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaAlumnosxCarrera.CurrentRow;

            txtMatricula2.Text = filaSeleccionada.Cells[0].Value.ToString();
            cmbCarreraAlumno.SelectedIndex = cmbCarreraAlumno.FindStringExact(filaSeleccionada.Cells[5].Value.ToString());
            txtAñoCursadaAlumno.Text = filaSeleccionada.Cells[4].Value.ToString();

        }

        private void cmbFiltroAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTablaAlumnos();
        }

        private void btnReporteAlumnos_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("ALUMNOS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(grillaAlumnos.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[grillaAlumnos.Columns.Count];
                for (int i = 0; i < grillaAlumnos.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in grillaAlumnos.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in grillaAlumnos.Rows)
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

