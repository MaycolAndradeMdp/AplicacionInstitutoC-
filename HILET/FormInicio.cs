using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HILET
{
    public partial class FormInicio : Form
    {

        private string usuario;
        private string contraseña;
        public FormInicio(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;


            InitializeComponent();

            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            if (usuario == contraseña)
            {
                MessageBox.Show("Tiene el mismo usuario y contraseña. Por seguridad vaya a 'Ajustes' y modifique su Usuario");
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void btnMaterias_Click_1(object sender, EventArgs e)
        {
            Materias materias = new Materias(usuario, contraseña);
            this.Hide();
            DialogResult resultado = materias.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExamenes_Click_1(object sender, EventArgs e)
        {
            examenes formExamenes = new examenes(usuario, contraseña);
            this.Hide();
            DialogResult resultado = formExamenes.ShowDialog();

        }

        private void FormInicio_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void examenesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnExamenes_Click_1(sender, e);
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnSalir_Click(sender, e);
        }

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmacionAlumno frmConfirPerfil = new frmConfirmacionAlumno(usuario);

            DialogResult resultado = frmConfirPerfil.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
