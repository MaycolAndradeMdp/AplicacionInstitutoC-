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
    public partial class Administrador : Form
    {
        private ConexionBBDD conectar;
        private string usuario;
        int instancia = 0;
        int materia = 0;
        bool error = false;
        public Administrador(string Usuario)
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            usuario = Usuario;
            CargarTablas();
        }

        public bool ValidarCamposMateria()
        {
            if (string.IsNullOrEmpty(txtNombreMateria.Text))
            {
                error1.SetError(txtNombreMateria, "Ingreso un nombre invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtAño.Text) || !int.TryParse(txtAño.Text, out _))
            {
                error1.SetError(txtAño, "Ingreso un año invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtIDmateria.Text) || !int.TryParse(txtIDmateria.Text, out _))
            {
                error1.SetError(txtIDmateria, "Ingreso un ID invalido");
                error = true;
            }

            return error;
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
            if (string.IsNullOrEmpty(txtDNIalumno.Text) || !int.TryParse(txtDNIalumno.Text, out _) || txtDNIalumno.Text.Length != 8)
            {
                error1.SetError(txtDNIalumno, "ingresó un DNI invalido");
                error = true;
            }

            // Validación del campo Telefono
            if (string.IsNullOrEmpty(txtTelefonAlumno.Text) || !int.TryParse(txtTelefonAlumno.Text, out _))
            {
                error1.SetError(txtTelefonAlumno, "ingresó un telefono invalido");
                error = true;
            }

            // Validación del campo Email
            if (string.IsNullOrEmpty(txtEmailAlumno.Text))
            {
                error1.SetError(txtEmailAlumno, "ingresó un gmail invalido");
                error = true;
            }

            // Validación del campo Domicilio Calle
            if (string.IsNullOrEmpty(txtDomiciloAlumno.Text) || int.TryParse(txtDomiciloAlumno.Text, out _))
            {
                error1.SetError(txtDomiciloAlumno, "ingresó una calle invalida");
                error = true;
            }

            // Validación del campo Numero Calle
            if (string.IsNullOrEmpty(txtDomiciloAlumno.Text) || !int.TryParse(txtDomiciloAlumno.Text, out _))
            {
                error1.SetError(txtDomiciloAlumno, "ingreso un numero invalido");
                error = true;
            }

            return error;
        }

        public bool ValidarCamposProfesor()
        {
            // Validación del campo apellido
            if (string.IsNullOrEmpty(txtNombreProfesor.Text) || int.TryParse(txtNombreProfesor.Text, out _))
            {
                error1.SetError(txtNombreProfesor, "ingresó un nombre invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtApellidoProfesor.Text) || int.TryParse(txtApellidoProfesor.Text, out _))
            {
                error1.SetError(txtApellidoProfesor, "ingresó un apellido invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDNIprofesor.Text) || !int.TryParse(txtDNIprofesor.Text, out _) || txtDNIprofesor.Text.Length != 8)
            {
                error1.SetError(txtDNIprofesor, "ingresó un DNI invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDomicilioProfesor.Text) || int.TryParse(txtDomicilioProfesor.Text, out _))
            {
                error1.SetError(txtDomicilioProfesor, "ingresó un domicilio invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDomicilioAlturaProfesor.Text) || !int.TryParse(txtDomicilioAlturaProfesor.Text, out _))
            {
                error1.SetError(txtDomicilioAlturaProfesor, "ingresó un numero de domicilio invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtTelefonoProfesor.Text) || !int.TryParse(txtTelefonoProfesor.Text, out _))
            {
                error1.SetError(txtTelefonoProfesor, "ingresó un telefono invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtEmailProfesor.Text) || int.TryParse(txtEmailProfesor.Text, out _))
            {
                error1.SetError(txtEmailProfesor, "ingresó un email invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtUsuarioProfesor.Text))
            {
                error1.SetError(txtUsuarioProfesor, "ingresó un usuario invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtContraseñaProfesor.Text))
            {
                error1.SetError(txtContraseñaProfesor, "ingresó una contraseña invalida");
                error = true;
            }

            return error;
        }

        public bool ValidarCamposPersonal()
        {
            // Validación del campo apellido
            if (string.IsNullOrEmpty(txtNombrePersonal.Text) || int.TryParse(txtNombrePersonal.Text, out _))
            {
                error1.SetError(txtNombrePersonal, "ingresó un nombre invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtApellidoPersonal.Text) || int.TryParse(txtApellidoPersonal.Text, out _))
            {
                error1.SetError(txtApellidoPersonal, "ingresó un apellido invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDNIpersnal.Text) || !int.TryParse(txtDNIpersnal.Text, out _) || txtDNIpersnal.Text.Length != 8)
            {
                error1.SetError(txtDNIpersnal, "ingresó un DNI invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDomicilioCallePersonal.Text) || int.TryParse(txtDomicilioCallePersonal.Text, out _))
            {
                error1.SetError(txtDomicilioCallePersonal, "ingresó un domicilio invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDomicilioNumeroPersnonal.Text) || !int.TryParse(txtDomicilioNumeroPersnonal.Text, out _))
            {
                error1.SetError(txtDomicilioNumeroPersnonal, "ingresó un numero de domicilio invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtTelefonoPersonal.Text) || !int.TryParse(txtTelefonoPersonal.Text, out _))
            {
                error1.SetError(txtTelefonoPersonal, "ingresó un telefono invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtEmailPersonal.Text) || int.TryParse(txtEmailPersonal.Text, out _))
            {
                error1.SetError(txtEmailPersonal, "ingresó un email invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtUsuarioPersonal.Text))
            {
                error1.SetError(txtUsuarioPersonal, "ingresó un usuario invalido");
                error = true;
            }

            if (string.IsNullOrEmpty(txtContraseñaPersonal.Text))
            {
                error1.SetError(txtContraseñaPersonal, "ingresó una contraseña invalida");
                error = true;
            }

            return error;
        }

        void cargarTablaPersonal()
        {
            string consulta = @"select 
                                    id_personal,
                                    nombre,
                                    apellido,
                                    dni,
                                    domicilioCalle,
                                    domicilioNumero,
                                    telefono,
                                    email,
                                    fechaInscripcion,
                                    fechaBaja,
                                    usuario,
                                    contraseña
                                from Personal";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgPersonalAdministrativo.DataSource = dt;
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
            dtgCarrera.DataSource = dt;
        }

        public void CargarTablaCarreras()
        {
            string consulta = "select * From Carreras";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgCarrera.DataSource = dt;
        }

        public void CargarTabla()
        {
            string consulta = "Select * from Profesores";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgProfesores.DataSource = dt;
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
            dtgAlumnos.DataSource = dt;
        }

        public void CargarTablaExamenes()
        {
            string consulta = @"SELECT     
                                nxm.nota AS Nota,
                                nxm.fecha AS Fecha,
                                nxm.libro AS Libro,
                                nxm.folio AS Folio,
                                m.nombre AS Materia,
                                i.nombre AS Insatancia,
                                al.nombre AS Nombre,
                                al.apellido AS Apellido,
                                al.matricula AS Matricula
                                FROM
                                NotasxAlumno AS nxm
                                INNER JOIN Alumnos AS al ON al.matricula = nxm.matricula
                                INNER JOIN Materias AS m ON m.id_materia = nxm.id_materia
                                INNER JOIN Instancias AS i ON i.id_instancia = nxm.id_instancia";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgNotasAdmin.DataSource = dt;
        }

        public void CargarTablas()
        {
            CargarTabla();
            CargarTablaAlumnos();
            CargarTablaCarreras();
            CargarTablaExamenes();
            CargarTablaMaterias();
            cargarTablaPersonal();
        }

        private async void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            if (!string.IsNullOrEmpty(txtIDProfesor.Text))
            {
                error1.SetError(txtIDProfesor, "El ID tiene que estar vacio");
                error = true;
            }

            if (ValidarCamposAlumno() || error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            string consulta = "AgregarProfesor";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombreProfesor.Text) ? DBNull.Value : txtNombreProfesor.Text);
            comando.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoProfesor.Text) ? DBNull.Value : txtApellidoProfesor.Text);
            comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDNIprofesor.Text) ? DBNull.Value : Convert.ToInt64(txtDNIprofesor.Text));
            comando.Parameters.AddWithValue("@domicilioCalle", string.IsNullOrEmpty(txtDomicilioAlturaProfesor.Text) ? DBNull.Value : txtDomicilioAlturaProfesor.Text);
            comando.Parameters.AddWithValue("@domicilioNumero", string.IsNullOrEmpty(txtDomicilioAlturaProfesor.Text) ? DBNull.Value : Convert.ToInt64(txtDomicilioAlturaProfesor.Text));
            comando.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(txtTelefonoProfesor.Text) ? DBNull.Value : txtTelefonoProfesor.Text);
            comando.Parameters.AddWithValue("@email", string.IsNullOrEmpty(txtEmailProfesor.Text) ? DBNull.Value : txtEmailProfesor.Text);
            comando.Parameters.AddWithValue("@fechaInscripcion", DateTime.Now);
            comando.Parameters.AddWithValue("@fechaBaja", DBNull.Value);
            comando.Parameters.AddWithValue("@usuario", string.IsNullOrEmpty(txtUsuarioProfesor.Text) ? DBNull.Value : txtUsuarioProfesor.Text);
            comando.Parameters.AddWithValue("@contraseña", string.IsNullOrEmpty(txtEmailProfesor.Text) ? DBNull.Value : txtEmailProfesor.Text);
            comando.Parameters.AddWithValue("@id_perfil", 2);

            comando.ExecuteNonQuery();
            conectar.Cerrar();
            CargarTablas();
        }

        private async void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            conectar.Abrir();

            if (string.IsNullOrEmpty(txtIDProfesor.Text) || !int.TryParse(txtIDProfesor.Text, out _))
            {
                error1.SetError(txtIDProfesor, "Ingreso un ID invalido");
                error = true;
            }

            if (ValidarCamposAlumno() || error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            string consulta = "ModificarProfesor";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombreProfesor.Text) ? DBNull.Value : txtNombreProfesor.Text);
            comando.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoProfesor.Text) ? DBNull.Value : txtApellidoProfesor.Text);
            comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDNIprofesor.Text) ? DBNull.Value : Convert.ToInt64(txtDNIprofesor.Text));
            comando.Parameters.AddWithValue("@domicilioCalle", string.IsNullOrEmpty(txtDomicilioProfesor.Text) ? DBNull.Value : txtDomicilioProfesor.Text);
            comando.Parameters.AddWithValue("@domicilioNumero", string.IsNullOrEmpty(txtDomicilioAlturaProfesor.Text) ? DBNull.Value : Convert.ToInt64(txtDomicilioAlturaProfesor.Text));
            comando.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(txtTelefonoProfesor.Text) ? DBNull.Value : txtTelefonoProfesor.Text);
            comando.Parameters.AddWithValue("@email", string.IsNullOrEmpty(txtEmailProfesor.Text) ? DBNull.Value : txtEmailProfesor.Text);
            comando.Parameters.AddWithValue("@usuario", string.IsNullOrEmpty(txtUsuarioProfesor.Text) ? DBNull.Value : txtUsuarioProfesor.Text);
            comando.Parameters.AddWithValue("@contraseña", string.IsNullOrEmpty(txtEmailProfesor.Text) ? DBNull.Value : txtEmailProfesor.Text);

            comando.ExecuteNonQuery();
            CargarTablas();
            conectar.Cerrar();
        }

        private async void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            conectar.Abrir();

            if (string.IsNullOrEmpty(txtIDProfesor.Text) || !int.TryParse(txtIDProfesor.Text, out _))
            {
                error1.SetError(txtIDProfesor, "Ingreso un ID invalido");
                error = true;
            }

            if (ValidarCamposAlumno() || error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            string consulta = "EliminarProfesor";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDNIprofesor.Text) ? MessageBox.Show("El campo esta vacio") : Convert.ToInt64(txtDNIprofesor.Text));

            comando.ExecuteNonQuery();
            CargarTabla();
            conectar.Cerrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();

            string consulta = "BuscarProfesor";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombreProfesor.Text) ? DBNull.Value : txtNombreProfesor.Text);
            comando.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoProfesor.Text) ? DBNull.Value : txtApellidoProfesor.Text);
            comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDNIprofesor.Text) ? DBNull.Value : Convert.ToInt64(txtDNIprofesor.Text));

            comando.ExecuteNonQuery();


            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgProfesores.DataSource = dt;

            conectar.Cerrar();
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }

            string consulta = "AgregaNota";
            SqlCommand command = new SqlCommand(consulta, conectar.Conexion);
            command.CommandType = CommandType.StoredProcedure;

            if (string.IsNullOrEmpty(txtNota.Text))
            {
                error1.SetError(txtNota, "el campo esta vacio");
            }
            else
            {
                if (int.TryParse(txtNota.Text, out int nota))
                {
                    command.Parameters.AddWithValue("@nota", nota <= 10 && nota > 0 ? nota : MessageBox.Show("Numero invalido"));
                }

            }
            command.Parameters.AddWithValue("@fecha", DateTime.Now);
            command.Parameters.AddWithValue("@folio", txtFolio.Text);
            command.Parameters.AddWithValue("@libro", txtLibro.Text);
            command.Parameters.AddWithValue("@instancia", cmbInstanciaExamenes.SelectedValue == null ? MessageBox.Show("Error") : cmbInstanciaExamenes.SelectedValue);
            command.Parameters.AddWithValue("@materia", cmbMateriaExamenes.SelectedValue == null ? MessageBox.Show("Error") : cmbMateriaExamenes.SelectedValue);
            if (string.IsNullOrEmpty(txtMatriculaExamenes.Text))
            {
                command.Parameters.AddWithValue("@matricula", DBNull.Value);
            }
            else
            {
                if (int.TryParse(txtMatriculaExamenes.Text, out int matricula))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                }
                else
                {
                    MessageBox.Show("Matricula debe ser un numero valido.");
                    return;
                }
            }
            command.ExecuteNonQuery();

            CargarTablas();
        }

        private void cmbMateriaExamenes_DropDown(object sender, EventArgs e)
        {
            string consulta = "SELECT id_materia, nombre FROM Materias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbMateriaExamenes.DataSource = dt;
            cmbMateriaExamenes.DisplayMember = "nombre";
            cmbMateriaExamenes.ValueMember = "id_materia";
        }

        private void cmbInstanciaExamenes_DropDown(object sender, EventArgs e)
        {
            string consulta = "SELECT id_instancia, nombre FROM Instancias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbInstanciaExamenes.DataSource = dt;
            cmbInstanciaExamenes.DisplayMember = "nombre";
            cmbInstanciaExamenes.ValueMember = "id_instancia";
        }

        private void dtgNotasAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNota.Text = dtgNotasAdmin.CurrentRow.Cells[0].Value.ToString();
            txtLibro.Text = dtgNotasAdmin.CurrentRow.Cells[2].Value.ToString();
            txtFolio.Text = dtgNotasAdmin.CurrentRow.Cells[3].Value.ToString();
            if (dtgNotasAdmin.CurrentRow != null)
            {

                string valorMateria = dtgNotasAdmin.CurrentRow.Cells[4].Value.ToString();


                string consulta = "SELECT id_materia, nombre FROM Materias";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
                DataTable dtMaterias = new DataTable();
                adapter.Fill(dtMaterias);

                DataRow[] filasMateria = dtMaterias.Select($"nombre = '{valorMateria}'");

                if (filasMateria.Length > 0)
                {

                    int idMateria = (int)filasMateria[0]["id_materia"];
                    cmbMateriaExamenes.SelectedValue = idMateria;
                    materia = idMateria;
                }
                else
                {
                    MessageBox.Show("Materia no encontrada.");
                }
            }
            if (dtgNotasAdmin.CurrentRow != null)
            {

                string valorInstancia = dtgNotasAdmin.CurrentRow.Cells[5].Value.ToString();


                string consulta = "SELECT id_instancia, nombre FROM Instancias";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
                DataTable dtInstancias = new DataTable();
                adapter.Fill(dtInstancias);


                DataRow[] filasInstancia = dtInstancias.Select($"nombre = '{valorInstancia}'");

                if (filasInstancia.Length > 0)
                {

                    int idInstancia = (int)filasInstancia[0]["id_instancia"];
                    cmbInstanciaExamenes.SelectedValue = idInstancia;
                    instancia = idInstancia;
                }

            }
            cmbInstanciaExamenes.Text = dtgNotasAdmin.CurrentRow.Cells[5].Value.ToString();
            cmbMateriaExamenes.Text = dtgNotasAdmin.CurrentRow.Cells[4].Value.ToString();
            txtMatriculaExamenes.Text = dtgNotasAdmin.CurrentRow.Cells[8].Value.ToString();
            txtApellidoNota.Text = dtgNotasAdmin.CurrentRow.Cells[7].Value.ToString();
            txtNombreNota.Text = dtgNotasAdmin.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }

            string consulta2 = "ModificarNota";
            using (SqlCommand command = new SqlCommand(consulta2, conectar.Conexion))
            {

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nota", string.IsNullOrEmpty(txtNota.Text) ? MessageBox.Show("No ingreso la nota") : Convert.ToInt64(txtNota.Text));
                command.Parameters.AddWithValue("@libro", string.IsNullOrEmpty(txtLibro.Text) ? (object)DBNull.Value : txtLibro.Text);
                command.Parameters.AddWithValue("@folio", string.IsNullOrEmpty(txtFolio.Text) ? (object)DBNull.Value : txtFolio.Text);
                command.Parameters.AddWithValue("id_materia", materia);
                command.Parameters.AddWithValue("id_instancia", instancia);
                command.Parameters.AddWithValue("@matricula", string.IsNullOrEmpty(txtMatriculaExamenes.Text) ? MessageBox.Show("No ingreso la matricula") : Convert.ToInt64(txtMatriculaExamenes.Text));

                command.ExecuteNonQuery();


            }
            CargarTablas();
        }

        private void btnBuscarNota_Click(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }


            if (txtMatriculaNota.Text.Length == 0 && txtApellidoNota.Text.Length == 0 && txtDniNotaAdmin.Text.Length == 0 && txtNombreNota.Text.Length == 0)
            {
                MessageBox.Show("No hay datos para buscar");
            }
            else
            {

                string consulta = "BuscarAlumno";
                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombreNota.Text) ? (object)DBNull.Value : txtNombreNota.Text);
                comando.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoNota.Text) ? (object)DBNull.Value : txtApellidoNota.Text);
                comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDniNotaAdmin.Text) ? (object)DBNull.Value : txtDniNotaAdmin.Text);


                if (string.IsNullOrEmpty(txtMatriculaNota.Text))
                {
                    comando.Parameters.AddWithValue("@matricula", DBNull.Value);
                }
                else
                {
                    if (int.TryParse(txtMatriculaNota.Text, out int matricula))
                    {
                        comando.Parameters.AddWithValue("@matricula", matricula);

                    }
                    else
                    {
                        MessageBox.Show("Matricula debe ser un numero valido.");
                        return;
                    }
                }
                comando.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron alumnos con los datos proporcionados.");
                }
                else
                {

                    dtgNotasAdmin.DataSource = dt;
                }

                txtApellidoNota.Clear();
                txtDniNotaAdmin.Clear();
                txtMatriculaNota.Clear();
                txtNombreNota.Clear();
            }

            if (conectar.Conexion.State == ConnectionState.Open)
            {
                conectar.Cerrar();
            }
        }

        private async void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            // Validamos el campo Matricula
            if (!string.IsNullOrEmpty(txtMatriculaAlumnos.Text))
            {
                error1.SetError(txtMatriculaAlumnos, "La matricula tiene que estar vacia");
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
                    comando.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDNIalumno.Text));
                    comando.Parameters.AddWithValue("@domicilioCalle", txtDomiciloAlumno.Text);
                    comando.Parameters.AddWithValue("@domicilioNumero", Convert.ToInt32(txtDomiciloAltAlumno.Text));
                    comando.Parameters.AddWithValue("@telefono", txtTelefonAlumno.Text);
                    comando.Parameters.AddWithValue("@email", txtEmailAlumno.Text);
                    comando.Parameters.AddWithValue("@fechaInscripcion", DateTime.Now);
                    comando.Parameters.AddWithValue("@fechaBaja", DBNull.Value);
                    comando.Parameters.AddWithValue("@usuario", txtUsuarioAlumno.Text);
                    comando.Parameters.AddWithValue("@contraseña", txtContraseñaAlumno.Text);
                    comando.Parameters.AddWithValue("@id_perfil", 1);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Alumno agregado exitosamente");
                    CargarTablas();
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
            if (string.IsNullOrEmpty(txtMatriculaAlumnos.Text) || !int.TryParse(txtMatriculaAlumnos.Text, out _))
            {
                error1.SetError(txtMatriculaAlumnos, "Matricula invalida");
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
                    comando.Parameters.AddWithValue("@matricula", txtMatriculaAlumnos.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text);
                    comando.Parameters.AddWithValue("@apellido", txtApellidoAlumno.Text);
                    comando.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDNIalumno.Text));
                    comando.Parameters.AddWithValue("@domicilioCalle", txtDomiciloAlumno.Text);
                    comando.Parameters.AddWithValue("@domicilioNumero", Convert.ToInt32(txtDomiciloAltAlumno.Text));
                    comando.Parameters.AddWithValue("@telefono", txtTelefonAlumno.Text);
                    comando.Parameters.AddWithValue("@email", txtEmailAlumno.Text);
                    comando.Parameters.AddWithValue("@fechaInscripcion", DateTime.Now);
                    comando.Parameters.AddWithValue("@fechaBaja", DBNull.Value);
                    comando.Parameters.AddWithValue("@usuario", txtUsuarioAlumno.Text);
                    comando.Parameters.AddWithValue("@contraseña", txtContraseñaAlumno.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alumno modificado exitosamente");
                    CargarTablas();
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
            if (string.IsNullOrEmpty(txtMatriculaAlumnos.Text) || !int.TryParse(txtMatriculaAlumnos.Text, out _))
            {
                error1.SetError(txtMatriculaAlumnos, "Matricula invalida");
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
                    comando.Parameters.AddWithValue("@matricula", Convert.ToInt32(txtMatriculaAlumnos.Text));
                    comando.Parameters.AddWithValue("@fechaBaja", DateTime.Now);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alumno dado de baja exitosamente");
                    CargarTablas();
                }

                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private async void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarreraNombre.Text))
            {
                error1.SetError(txtCarreraNombre, "El nombre no puede estar vacia");
                error = true;
            }

            if (string.IsNullOrEmpty(txtDuracion.Text) || !int.TryParse(txtDuracion.Text, out _))
            {
                error1.SetError(txtDuracion, "Ingrese una duracion valida");
                error = true;
            }

            if (string.IsNullOrEmpty(txtResolucion.Text))
            {
                error1.SetError(txtResolucion, "La resolucion no puede estar vacia");
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
                                ('{txtCarreraNombre.Text}', {Convert.ToInt32(txtDuracion.Text)}, '{txtResolucion.Text}');";

                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Carrera añadida");
                CargarTablas();
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private async void btnEliminarCarrera_Click(object sender, EventArgs e)
        {
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

                string consulta = @$"delete from Carreras where id_carrera = {cmbCarrera.SelectedValue}";
                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Carrera eliminada exitosamente");
                CargarTablas();
                conectar.Cerrar();

            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private async void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDmateria.Text))
            {
                error1.SetError(txtIDmateria, "El ID tiene que estar vacio");
                error = true;
            }

            if (ValidarCamposMateria() || error == true)
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
                    comando.Parameters.AddWithValue("@id_carreras", Convert.ToInt32(cmbCarrera.SelectedValue));
                    comando.Parameters.AddWithValue("@nombre", txtNombreMateria.Text);
                    comando.Parameters.AddWithValue("@año", Convert.ToInt32(txtAño.Text));
                    comando.Parameters.AddWithValue("@id_profesor", Convert.ToInt32(cmbProfesor.SelectedValue));

                    comando.ExecuteNonQuery();


                    MessageBox.Show("Materia agregada exitosamente");
                    CargarTablas();
                }
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void cmbCarrera_DropDown(object sender, EventArgs e)
        {
            string consulta = "SELECT id_carreras, nombre FROM Carreras";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbCarrera.DataSource = dt;
            cmbCarrera.DisplayMember = "nombre";
            cmbCarrera.ValueMember = "id_materia";
        }

        private void cmbProfesor_DropDown(object sender, EventArgs e)
        {
            string consulta = "SELECT id_profesor, nombre FROM Profesores";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbProfesor.DataSource = dt;
            cmbProfesor.DisplayMember = "nombre";
            cmbProfesor.ValueMember = "id_materia";
        }

        private async void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDmateria.Text) || !int.TryParse(txtIDmateria.Text, out _))
            {
                error1.SetError(txtIDmateria, "El ID no puede estar vacio");
                error = true;
            }

            if (ValidarCamposMateria() || error == true)
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
                    comando.Parameters.AddWithValue("@id_materia", Convert.ToInt32(txtIDmateria.Text));
                    comando.Parameters.AddWithValue("@id_carreras", Convert.ToInt32(cmbCarrera.SelectedValue));
                    comando.Parameters.AddWithValue("@nombre", txtNombreMateria.Text);
                    comando.Parameters.AddWithValue("@año", Convert.ToInt32(txtAño.Text));
                    comando.Parameters.AddWithValue("@id_profesor", Convert.ToInt32(cmbProfesor.SelectedValue));

                    comando.ExecuteNonQuery();


                    MessageBox.Show("Materia modificada exitosamente");
                    CargarTablas();
                }
                conectar.Cerrar();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private async void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDmateria.Text) || !int.TryParse(txtIDmateria.Text, out _))
            {
                error1.SetError(txtIDmateria, "El ID no puede estar vacio");
                error = true;
            }

            if (ValidarCamposMateria() || error == true)
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

                string consulta = @$"delete from Materias where id_materia = {txtIDmateria.Text}";
                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Materia eliminada exitosamente");
                CargarTablas();
                conectar.Cerrar();

            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void btnBuscarCarreras_Click(object sender, EventArgs e)
        {
            conectar.Abrir();

            string consulta = "ObtenerMateriasPorCarrera";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_carrera", cmbCarrera.SelectedValue);

            comando.ExecuteNonQuery();

            conectar.Cerrar();
        }

        private async void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }

            if (!string.IsNullOrEmpty(txtIDpersonal.Text))
            {
                error1.SetError(txtIDpersonal, "El ID tiene que estar vacia");
                error = true;
            }


            // Validamos los demás campos
            if (ValidarCamposPersonal() || error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            string consulta = "AgregarPersonal";
            SqlCommand command = new SqlCommand(consulta, conectar.Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text);
            command.Parameters.AddWithValue("@apellido", txtApellidoAlumno.Text);
            command.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDNIpersnal.Text));
            command.Parameters.AddWithValue("@domicilioCalle", txtDomicilioCallePersonal.Text);
            command.Parameters.AddWithValue("@domicilioNumero", Convert.ToInt32(txtDomicilioNumeroPersnonal.Text));
            command.Parameters.AddWithValue("@telefono", txtTelefonoPersonal.Text);
            command.Parameters.AddWithValue("@email", txtEmailPersonal.Text);
            command.Parameters.AddWithValue("@fechaInscripcion", DateTime.Now);
            command.Parameters.AddWithValue("@fechaBaja", DBNull.Value);
            command.Parameters.AddWithValue("@usuario", txtUsuarioPersonal.Text);
            command.Parameters.AddWithValue("@contraseña", txtContraseñaPersonal.Text);
            command.Parameters.AddWithValue("id_perfil", 3);

            command.ExecuteNonQuery();

            CargarTablas();
            conectar.Cerrar();
        }

        private async void btnModificarPersonal_Click(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }

            if (string.IsNullOrEmpty(txtIDpersonal.Text) || !int.TryParse(txtIDpersonal.Text, out _))
            {
                error1.SetError(txtIDpersonal, "El ID no puede estar vacio");
                error = true;
            }


            // Validamos los demás campos
            if (ValidarCamposPersonal() || error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            string consulta = "ModificarPersonal";

            using (SqlCommand command = new SqlCommand(consulta, conectar.Conexion))
            {
                command.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text);
                command.Parameters.AddWithValue("@apellido", txtApellidoAlumno.Text);
                command.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDNIpersnal.Text));
                command.Parameters.AddWithValue("@domicilioCalle", txtDomicilioCallePersonal.Text);
                command.Parameters.AddWithValue("@domicilioNumero", Convert.ToInt32(txtDomicilioNumeroPersnonal.Text));
                command.Parameters.AddWithValue("@telefono", txtTelefonoPersonal.Text);
                command.Parameters.AddWithValue("@email", txtEmailPersonal.Text);
                command.Parameters.AddWithValue("@fechaInscripcion", DateTime.Now);
                command.Parameters.AddWithValue("@fechaBaja", DBNull.Value);
                command.Parameters.AddWithValue("@usuario", txtUsuarioPersonal.Text);
                command.Parameters.AddWithValue("@contraseña", txtContraseñaPersonal.Text);
                command.Parameters.AddWithValue("id_perfil", 3);

                command.ExecuteNonQuery();

                CargarTablas();
                conectar.Cerrar();
            }
        }

        private async void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }


            if (string.IsNullOrEmpty(txtIDpersonal.Text) || !int.TryParse(txtIDpersonal.Text, out _))
            {
                error1.SetError(txtIDpersonal, "El ID no puede estar vacio");
                error = true;
            }


            // Validamos los demás campos
            if (ValidarCamposPersonal() || error == true)
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            string consulta = "EliminarPersonal";

            using (SqlCommand command = new SqlCommand(consulta, conectar.Conexion))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id_personal", Convert.ToInt32(txtIDpersonal.Text));

                command.ExecuteNonQuery();


            }
            CargarTablas();
        }

        private void btnBuscarAdmin_Click(object sender, EventArgs e)
        {
            conectar.Abrir();

            string consulta = "BuscarPersonal";
            using (SqlCommand command = new SqlCommand(consulta, conectar.Conexion))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombrePersonal.Text) ? DBNull.Value : txtNombrePersonal.Text);
                command.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoPersonal.Text) ? DBNull.Value : txtApellidoPersonal.Text);
                command.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDNIpersnal.Text) ? DBNull.Value : Convert.ToInt32(txtDNIpersnal.Text));

                command.ExecuteNonQuery();

            }

            conectar.Cerrar();
        }

        private void btnReporteProfesores_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("PROFESORES", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(dtgProfesores.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[dtgProfesores.Columns.Count];
                for (int i = 0; i < dtgProfesores.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in dtgProfesores.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in dtgProfesores.Rows)
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

        private void btnReporteAlumno_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("ALUMNO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(dtgAlumnos.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[dtgAlumnos.Columns.Count];
                for (int i = 0; i < dtgAlumnos.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in dtgAlumnos.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in dtgAlumnos.Rows)
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

        private void btnReportePersonalAdmin_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("PERSONAL ADMINISTRATIVO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(dtgPersonalAdministrativo.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[dtgPersonalAdministrativo.Columns.Count];
                for (int i = 0; i < dtgPersonalAdministrativo.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in dtgPersonalAdministrativo.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in dtgPersonalAdministrativo.Rows)
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

        private void btnReporteCarrera_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("Carreras", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(dtgCarrera.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[dtgCarrera.Columns.Count];
                for (int i = 0; i < dtgCarrera.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in dtgCarrera.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in dtgCarrera.Rows)
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

        private void btnReportesExamenes_Click(object sender, EventArgs e)
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
                Paragraph title = new Paragraph("Examenes", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // Espacio debajo del título
                document.Add(title);

                // Crear tabla con el número de columnas del DataGridView
                PdfPTable table = new PdfPTable(dtgNotasAdmin.Columns.Count);
                table.WidthPercentage = 100; // Ocupa el 100% del ancho de la página

                // Definir anchos proporcionales de las columnas
                float[] columnWidths = new float[dtgNotasAdmin.Columns.Count];
                for (int i = 0; i < dtgNotasAdmin.Columns.Count; i++)
                {
                    columnWidths[i] = 5f; // Aumenta este valor para dar más anchura, ajusta según sea necesario
                }
                table.SetWidths(columnWidths);

                // Agregar encabezados de las columnas con formato
                foreach (DataGridViewColumn column in dtgNotasAdmin.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(215, 215, 238); // Color de fondo de encabezado
                    headerCell.Padding = 5f; // Añadir un poco de espacio interno en la celda
                    table.AddCell(headerCell);
                }

                // Agregar las filas de datos
                foreach (DataGridViewRow row in dtgNotasAdmin.Rows)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            conectar.Abrir();

            string consulta = "BuscarAlumno";
            SqlCommand command = new SqlCommand(consulta, conectar.Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombreAlumno.Text) ? DBNull.Value : txtNombreAlumno.Text);
            command.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoAlumno.Text) ? DBNull.Value : txtApellidoAlumno.Text);
            command.Parameters.AddWithValue("@matricula", string.IsNullOrEmpty(txtMatriculaAlumnos.Text) ? DBNull.Value : Convert.ToInt32(txtMatriculaAlumnos.Text));
            command.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDNIalumno.Text) ? DBNull.Value : Convert.ToInt32(txtDNIalumno.Text));

            command.ExecuteNonQuery();

            conectar.Cerrar();
        }

        private void cmbFiltroAlumnos_DropDown(object sender, EventArgs e)
        {
            cmbFiltroAlumnos.Items.Add("Alumnos inscriptos");
            cmbFiltroAlumnos.Items.Add("Alumnos dados de baja");
            cmbFiltroAlumnos.SelectedIndex = 0;
        }

        private void dtgAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dtgAlumnos.CurrentRow;

            // Asigna los valores de la fila seleccionada a los campos correspondientes

            txtMatriculaAlumnos.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtNombreAlumno.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtApellidoAlumno.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtDNIalumno.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtDomiciloAlumno.Text = filaSeleccionada.Cells[4].Value.ToString();
            txtDomiciloAltAlumno.Text = filaSeleccionada.Cells[5].Value.ToString();
            txtTelefonAlumno.Text = filaSeleccionada.Cells[6].Value.ToString();
            txtEmailAlumno.Text = filaSeleccionada.Cells[7].Value.ToString();
            txtUsuarioAlumno.Text = filaSeleccionada.Cells[11].Value.ToString();
            txtContraseñaAlumno.Text = filaSeleccionada.Cells[12].Value.ToString();

        }

        private void dtgPersonalAdministrativo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dtgPersonalAdministrativo.CurrentRow;

            // Asigna los valores de la fila seleccionada a los campos correspondientes

            txtIDpersonal.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtNombrePersonal.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtApellidoPersonal.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtDNIpersnal.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtDomicilioNumeroPersnonal.Text = filaSeleccionada.Cells[4].Value.ToString();
            txtDomicilioCallePersonal.Text = filaSeleccionada.Cells[5].Value.ToString();
            txtTelefonoPersonal.Text = filaSeleccionada.Cells[6].Value.ToString();
            txtEmailPersonal.Text = filaSeleccionada.Cells[7].Value.ToString();
            txtUsuarioPersonal.Text = filaSeleccionada.Cells[10].Value.ToString();
            txtContraseñaPersonal.Text = filaSeleccionada.Cells[11].Value.ToString();
        }
    }
}
