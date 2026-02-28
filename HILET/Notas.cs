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
    public partial class Notas : Form
    {
        private ConexionBBDD conectar;
        private string usuario;
        private string contraseña;
        bool error = false;
        public Notas(string usuario, string contraseña)
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            this.usuario = usuario;
            this.contraseña = contraseña;
            CargarTabla();

        }
        //---------- Metodos ----------//

        public bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNota.Text) || !double.TryParse(txtNota.Text, out double nota) || nota <= 0 || nota > 10)
            {
                error1.SetError(txtNota, "La nota ingresada debe estar entre 1 y 10.");
                error = true;
            }

            if (CmbMateria.SelectedIndex == -1)
            {
                error1.SetError(CmbMateria, "Tiene que ingresar una materia");
                error = true;
            }

            if (cmbInstancia.SelectedIndex == -1)
            {
                error1.SetError(cmbInstancia, "Tiene que ingresar una instancia");
                error = true;
            }

            if (string.IsNullOrEmpty(txtMatriculaNota.Text) || !int.TryParse(txtMatriculaNota.Text, out _))
            {
                error1.SetError(txtMatriculaNota, "ingresó una matricula invalida");
                error = true;
            }

            return error;
        }

        public void CargarTabla()
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
            dtgNotas.DataSource = dt;
        }

        //---------- Botones ----------//
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            conectar.Cerrar();
            Application.Exit();
        }
        private async void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }

            if (Convert.ToInt32(cmbInstancia.SelectedValue) != 5)
            {
                txtLibro.Enabled = false;
                txtFolio.Enabled = false;
            }
            else
            {
                txtLibro.Enabled = true;
                txtFolio.Enabled = true;
            }

            if (ValidarCampos())
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }

            string consulta = "AgregaNota";
            SqlCommand command = new SqlCommand(consulta, conectar.Conexion);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.AddWithValue("@nota", txtNota.Text);
            command.Parameters.AddWithValue("@fecha", DateTime.Now);
            command.Parameters.AddWithValue("@folio", txtFolio.Text);
            command.Parameters.AddWithValue("@libro", txtLibro.Text);
            command.Parameters.AddWithValue("@instancia", cmbInstancia.SelectedValue == null ? MessageBox.Show("Error") : cmbInstancia.SelectedValue);
            command.Parameters.AddWithValue("@materia", CmbMateria.SelectedValue == null ? MessageBox.Show("Error") : CmbMateria.SelectedValue);
            if (string.IsNullOrEmpty(txtMatriculaNota.Text))
            {
                command.Parameters.AddWithValue("@matricula", DBNull.Value);
            }
            else
            {
                if (int.TryParse(txtMatriculaNota.Text, out int matricula))
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


            CargarTabla();


        }
        private void btnBuscarNota_Click_1(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }


            if (txtMatriculaNota.Text.Length == 0 && txtApellidoNotaBuscar.Text.Length == 0 && txtDniNotaBuscar.Text.Length == 0 && txtNombrenotasBuscar.Text.Length == 0)
            {
                MessageBox.Show("No hay datos para buscar");
            }
            else
            {

                string consulta = "BuscarAlumno";
                SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombrenotasBuscar.Text) ? (object)DBNull.Value : txtNombrenotasBuscar.Text);
                comando.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellidoNotaBuscar.Text) ? (object)DBNull.Value : txtApellidoNotaBuscar.Text);
                comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDniNotaBuscar.Text) ? (object)DBNull.Value : txtDniNotaBuscar.Text);


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

                    dtgNotas.DataSource = dt;
                }

                txtApellidoNotaBuscar.Clear();
                txtDniNotaBuscar.Clear();
                txtMatriculaNota.Clear();
                txtNombrenotasBuscar.Clear();
            }

            if (conectar.Conexion.State == ConnectionState.Open)
            {
                conectar.Cerrar();
            }

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("No ingresó la nota");
                return;
            }

            if (string.IsNullOrEmpty(txtMatriculaNota.Text))
            {
                MessageBox.Show("No ingreso la matricula");
                return;
            }

            if (Convert.ToInt32(cmbInstancia.SelectedValue) != 5)
            {
                txtLibro.Enabled = false;
                txtFolio.Enabled = false;
            }
            else
            {
                txtLibro.Enabled = true;
                txtFolio.Enabled = true;
            }

            if (ValidarCampos())
            {
                error = false;
                await Task.Delay(5000);
                error1.Clear();
                return;
            }


            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }
            int notaxalumno = 0;

            string consulta = "ObtenerIdNotasxAlumno";
            using (SqlCommand command1 = new SqlCommand(consulta, conectar.Conexion))
            {
                command1.CommandType = CommandType.StoredProcedure;



                if (string.IsNullOrEmpty(txtMatriculaNota.Text))
                {
                    command1.Parameters.AddWithValue("@matricula", DBNull.Value);
                }
                else
                {
                    if (int.TryParse(txtMatriculaNota.Text, out int matricula))
                    {
                        command1.Parameters.AddWithValue("@matricula", matricula);

                    }
                    else
                    {
                        MessageBox.Show("Matricula debe ser un numero valido.");
                        return;
                    }
                }
                command1.Parameters.AddWithValue("@id_materia", materia);
                command1.Parameters.AddWithValue("@id_instancia", instancia);


                SqlParameter paramSalida = new SqlParameter("@id_notasxalumno", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command1.Parameters.Add(paramSalida);

                command1.ExecuteNonQuery();

                notaxalumno = (int)paramSalida.Value;
            }

            string consulta2 = "ModificarNota";
            using (SqlCommand command = new SqlCommand(consulta2, conectar.Conexion))
            {

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nota", txtNota.Text);
                command.Parameters.AddWithValue("@libro", string.IsNullOrEmpty(txtLibro.Text) ? (object)DBNull.Value : txtLibro.Text);
                command.Parameters.AddWithValue("@folio", string.IsNullOrEmpty(txtFolio.Text) ? (object)DBNull.Value : txtFolio.Text);
                command.Parameters.AddWithValue("id_materia", materia);
                command.Parameters.AddWithValue("id_instancia", instancia);
                command.Parameters.AddWithValue("id_notasxalumno", notaxalumno);

                command.ExecuteNonQuery();


            }
            CargarTabla();

        }

        //---------- Combobox ----------//
        private void CmbMateria_DropDown_1(object sender, EventArgs e)
        {
            string consulta = "SELECT id_materia, nombre FROM Materias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CmbMateria.DataSource = dt;
            CmbMateria.DisplayMember = "nombre";
            CmbMateria.ValueMember = "id_materia";

        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string consulta = "SELECT id_instancia, nombre FROM Instancias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbInstancia.DataSource = dt;
            cmbInstancia.DisplayMember = "nombre";
            cmbInstancia.ValueMember = "id_instancia";

        }


        //---------- DataGrid ----------//
        int instancia = 0;
        int materia = 0;
        private void dtgNotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNota.Text = dtgNotas.CurrentRow.Cells[0].Value.ToString();
            txtLibro.Text = dtgNotas.CurrentRow.Cells[2].Value.ToString();
            txtFolio.Text = dtgNotas.CurrentRow.Cells[3].Value.ToString();
            if (dtgNotas.CurrentRow != null)
            {

                string valorMateria = dtgNotas.CurrentRow.Cells[4].Value.ToString();


                string consulta = "SELECT id_materia, nombre FROM Materias";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
                DataTable dtMaterias = new DataTable();
                adapter.Fill(dtMaterias);

                DataRow[] filasMateria = dtMaterias.Select($"nombre = '{valorMateria}'");

                if (filasMateria.Length > 0)
                {

                    int idMateria = (int)filasMateria[0]["id_materia"];
                    CmbMateria.SelectedValue = idMateria;
                    materia = idMateria;
                }
                else
                {
                    MessageBox.Show("Materia no encontrada.");
                }
            }
            if (dtgNotas.CurrentRow != null)
            {

                string valorInstancia = dtgNotas.CurrentRow.Cells[5].Value.ToString();


                string consulta = "SELECT id_instancia, nombre FROM Instancias";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
                DataTable dtInstancias = new DataTable();
                adapter.Fill(dtInstancias);


                DataRow[] filasInstancia = dtInstancias.Select($"nombre = '{valorInstancia}'");

                if (filasInstancia.Length > 0)
                {

                    int idInstancia = (int)filasInstancia[0]["id_instancia"];
                    cmbInstancia.SelectedValue = idInstancia;
                    instancia = idInstancia;
                }

            }
            cmbInstancia.Text = dtgNotas.CurrentRow.Cells[5].Value.ToString();
            CmbMateria.Text = dtgNotas.CurrentRow.Cells[4].Value.ToString();
            txtMatriculaNota.Text = dtgNotas.CurrentRow.Cells[8].Value.ToString();
            txtApellidoNotaBuscar.Text = dtgNotas.CurrentRow.Cells[7].Value.ToString();
            txtNombrenotasBuscar.Text = dtgNotas.CurrentRow.Cells[6].Value.ToString();
        }


        //---------- MenuStrip ----------//

        private void visualizarAlumnosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Alumnos formAlumnos = new Alumnos(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formAlumnos.ShowDialog();
        }


        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos formAlumnos = new Alumnos(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formAlumnos.ShowDialog();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes formReportes = new Reportes(this.usuario);
            this.Hide();
            DialogResult resultado = formReportes.ShowDialog();
        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Notas formNotas = new Notas(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formNotas.ShowDialog();
        }

        private void volverToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProfesores frm1 = new frmProfesores(usuario, contraseña);
            this.Hide();
            DialogResult resultado = frm1.ShowDialog();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmacionPerfilProfesores formModUsuario = new frmConfirmacionPerfilProfesores(this.contraseña);
            if (formModUsuario.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
