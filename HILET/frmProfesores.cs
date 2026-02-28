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
    public partial class frmProfesores : Form
    {
        private ConexionBBDD conectar;
        private string usuario;
        private string contraseña;
        public frmProfesores(string Usuario, string Contraseña)
        {

            InitializeComponent();
            conectar = new ConexionBBDD();
            this.usuario = Usuario;
            this.contraseña = Contraseña;
            this.Load += new EventHandler(label4_Click);
            this.Load += new EventHandler(label5_Click);

            if (Usuario == contraseña)
            {
                MessageBox.Show("Tiene el mismo usuario y contraseña. Por seguridad vaya a 'Ajustes' y modifique su Usuario");
            }
            CargarTabla();

            Conectarbbdd();
        }

        //---------- Metodos ----------//
        public void Conectarbbdd()
        {
            conectar.Abrir();
        }

        public void CargarTabla()
        {
            //llenado de datagrid
            string consulta = "Profesor_Y_Materia";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", this.usuario);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtg_Pofesorxmateria.DataSource = dt;
            // ajuste de datagrid
            dtg_Pofesorxmateria.Columns[0].HeaderText = "Nombre";


        }

        //---------- Botones ----------//


        private void btn_redireccionAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos formAlumnos = new Alumnos(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formAlumnos.ShowDialog();
        }

        private void btn_redireccionNotas_Click(object sender, EventArgs e)
        {
            Notas formNotas = new Notas(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formNotas.ShowDialog();
        }

        //---------- Label ----------//
        private void label4_Click(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblNota.Text = DateTime.Now.ToString("t");
        }

        //---------- MenuStrip ----------//



        private void visualizarAlumnosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Alumnos formAlumnos = new Alumnos(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formAlumnos.ShowDialog();
        }


        private void buscarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos formAlumnos = new Alumnos(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formAlumnos.ShowDialog();
        }

        private void modificarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas formNotas = new Notas(this.usuario, this.contraseña);
            this.Hide();
            DialogResult resultado = formNotas.ShowDialog();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes formReportes = new Reportes(this.usuario);
            this.Hide();
            DialogResult resultado = formReportes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmacionPerfilProfesores formModUsuario = new frmConfirmacionPerfilProfesores(this.contraseña);
            if (formModUsuario.ShowDialog() == DialogResult.OK)
            {
            }
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
