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
    public partial class frmPersonalAdministrativo : Form
    {
        private ConexionBBDD conectar;
        string ContraseñaPersonal;
        public frmPersonalAdministrativo(string usuario, string contraseña)
        {
            InitializeComponent();
            lblBienvenida.Text = usuario;
            ContraseñaPersonal = contraseña;
            if (usuario == contraseña)
            {
                MessageBox.Show("Tiene el mismo usuario y contraseña. Por seguridad vaya a 'Ajustes' y modifique su Usuario");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormSecundario(object formSecundario)
        {
            // Verificamos si el panel Contenedor esta vacio, en caso contrario se elimina los controles.
            if (this.pnlContenido.Controls.Count > 0)
            {
                this.pnlContenido.Controls.RemoveAt(0);
                this.pnlContenido.Controls.Clear();
            }
            Form fs = formSecundario as Form;
            // Colocamos para que sea un formulario secundario y no superior
            fs.TopLevel = false;
            // Hacemos que el formulario se acople al formulario contenedor
            fs.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(fs);
            // Esto permite que puedas acceder a este formulario más adelante si es necesario
            this.pnlContenido.Tag = fs;
            fs.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new ABMAlumnos());
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new ABMCarreras());
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new ABMMaterias());
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new ABMExamenes());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (this.pnlContenido.Controls.Count > 0)
            {
                this.pnlContenido.Controls.RemoveAt(0);
                this.pnlContenido.Controls.Clear();
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAlumnos_Click(sender, e);
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCarreras_Click(sender, e);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMaterias_Click(sender, e);
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExamenes_Click(sender, e);
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // btnEstadistica_Click(sender, e);
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este perfil permite gestionar alumnos y carreras, sin modificar informacion de los usuarios");
        }

        private void cambiarUsuarioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfimacionPerfil frmConfirPerfil = new frmConfimacionPerfil(ContraseñaPersonal);

            DialogResult resultado = frmConfirPerfil.ShowDialog();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
           AbrirFormSecundario(new frmEstadistica());
        }
    }
}
