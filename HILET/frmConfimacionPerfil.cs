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
    public partial class frmConfimacionPerfil : Form
    {
        bool ocultar = true;
        bool error = false;
        string UsuarioNuevo;
        string ContraseñaNueva;
        private ConexionBBDD conectar;
        string ContraseñaPersonal;
        public frmConfimacionPerfil(string Contraseña)
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            ContraseñaPersonal = Contraseña;
        }

        private void pbOjo_Click_1(object sender, EventArgs e)
        {
            if (ocultar)
            {
                txtContraseñaNueva.PasswordChar = '\0';
            }
            else
            {
                txtContraseñaNueva.PasswordChar = '*';
            }
            ocultar = !ocultar;
        }

        private async void btnGuardarPerfil_Click(object sender, EventArgs e)
        {
            UsuarioNuevo = txtUsuarioNuevo.Text;
            ContraseñaNueva = txtContraseñaNueva.Text;



            if (UsuarioNuevo == "")
            {
                error1.SetError(txtUsuarioNuevo, "El campo Usuario no puede estar vacío");
                error = true;
            }

            if (ContraseñaNueva == "")
            {
                error1.SetError(txtContraseñaNueva, "El campo Contraseña no puede estar vacío");
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
                string consulta = "ModificarUsuarioPersonal";

                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@usuarioNuevo", UsuarioNuevo);
                    comando.Parameters.AddWithValue("@contraseñaNueva", ContraseñaNueva);
                    comando.Parameters.AddWithValue("@ContraseñaPersonal", ContraseñaPersonal);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Usuario modificado exitosamente");

                }
                conectar.Cerrar();
                this.Close();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
                this.Close();
            }


        }

    }
}

