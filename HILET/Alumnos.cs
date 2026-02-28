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
    public partial class Alumnos : Form
    {
        private ConexionBBDD conectar;
        private string usuario;
        private string contraseña;
        public Alumnos(string usuario, string contraseña)
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            this.usuario = usuario;
            this.contraseña = contraseña;
            CargarTabla();

        }
        //---------- Metodos ---------------//
        public void CargarTabla()
        {

            string consulta = @"select nombre AS Nombre,
                                       apellido AS Apellido,
                                       dni AS DNI,
                                       telefono AS Telfono,
                                       email AS Email,
                                       fechaInscripcion AS Fechainscripcion,
                                       fechaBaja AS Fechabaja,
                                       matricula AS Matricula


                                        from Alumnos";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtg_verAlumnos.DataSource = dt;
            conectar.Cerrar();
        }
        //---------- MenuStrip ----------//
        private void volverToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProfesores frm1 = new frmProfesores(usuario, contraseña);
            this.Hide();
            DialogResult resultado = frm1.ShowDialog();
        }

        private void salirToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas formNotas = new Notas(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formNotas.ShowDialog();
        }

        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnReporteAlumno_Click_1(sender, e);
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes formReportes = new Reportes(this.usuario);
            this.Hide();
            DialogResult resultado = formReportes.ShowDialog();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmacionPerfilProfesores formModUsuario = new frmConfirmacionPerfilProfesores(this.contraseña);
            if (formModUsuario.ShowDialog() == DialogResult.OK)
            {
            }
        }
        //---------- Botones ----------//
        private void btnBuscarAlumno_Click_1(object sender, EventArgs e)
        {
            if (conectar.Conexion.State != ConnectionState.Open)
            {
                conectar.Abrir();
            }

            string consulta = "BuscarAlumnoGeneral";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(txtNombre.Text) ? (object)DBNull.Value : txtNombre.Text);
            comando.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(txtApellido.Text) ? (object)DBNull.Value : txtApellido.Text);
            comando.Parameters.AddWithValue("@dni", string.IsNullOrEmpty(txtDni.Text) ? (object)DBNull.Value : txtDni.Text);


            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                comando.Parameters.AddWithValue("@matricula", DBNull.Value);
            }
            else
            {
                if (int.TryParse(txtMatricula.Text, out int matricula))
                {
                    comando.Parameters.AddWithValue("@matricula", matricula);
                }
                else
                {
                    MessageBox.Show("Matricula debe ser un numero valido.");
                    return;
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron alumnos con notas cargadas.");
            }
            else
            {

                dtg_verAlumnos.DataSource = dt;
            }

            txtApellido.Clear();
            txtDni.Clear();
            txtMatricula.Clear();
            txtNombre.Clear();
        }

        private void btnReporteAlumno_Click_1(object sender, EventArgs e)
        {
            Reportes formReporte = new Reportes(this.usuario);
            if (formReporte.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void dtg_verAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dtg_verAlumnos.CurrentRow.Cells[0].ToString();
            txtApellido.Text = dtg_verAlumnos.CurrentRow.Cells[1].ToString();
            txtDni.Text = dtg_verAlumnos.CurrentRow.Cells[2].ToString();
            txtMatricula.Text = dtg_verAlumnos.CurrentRow.Cells[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar.Cerrar();
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
