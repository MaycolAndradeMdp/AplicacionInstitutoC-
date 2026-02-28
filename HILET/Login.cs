using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HILET
{
    public partial class Login : Form
    {
        // Variable booleana para posteriormente usar al momento de ocultar o no la contraseña
        bool ocultar = true;
        bool error = false;


        private ConexionBBDD conectar;

        public Login()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            conectar.Abrir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            conectar.Cerrar();
            this.Close();

        }

        private async void btnAcceder_Click(object sender, EventArgs e)
        {

            String Usuario = txtUsuario.Text;
            String Contraseña = txtContraseña.Text;

            // Condiciones
            if (Usuario != "" && Contraseña != "")
            {
                string consulta = "BuscarPerfil";
                using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@contrasena", txtContraseña.Text);
                    SqlParameter paramSalida = new SqlParameter("@id_perfil", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    comando.Parameters.Add(paramSalida);

                    comando.ExecuteNonQuery();

                    if (paramSalida.Value != DBNull.Value)
                    {
                        int idPerfil = (int)paramSalida.Value;


                        switch (idPerfil)
                        {
                            case 1:
                                FormInicio frmAlumno = new FormInicio(Usuario, Contraseña);
                                this.Hide();
                                frmAlumno.Show();
                                break;
                            case 2:
                                 frmProfesores frmProfesores = new frmProfesores(Usuario, Contraseña);
                                this.Hide();
                                DialogResult result = frmProfesores.ShowDialog();
                                break;
                            case 3:
                                frmPersonalAdministrativo frmPersonal = new frmPersonalAdministrativo(Usuario, Contraseña);
                                this.Hide();
                                frmPersonal.Show();
                                break;
                            case 4:
                                Administrador frmAdmin = new Administrador(Usuario);
                                this.Hide();
                                frmAdmin.Show();
                                break;
                        }
                    }
                    else
                    {

                        MessageBox.Show("No se encontró un perfil con ese usuario/contraseña.");
                    }
                }
            }

            if (Usuario == "")
            {
                error1.SetError(txtUsuario, "El campo Usuario no puede estar vacío");
                error = true;
            }

            if (Contraseña == "")
            {
                error1.SetError(txtContraseña, "El campo Contraseña no puede estar vacío");
                error = true;
            }

            if (Usuario == "" && Contraseña == "")
            {
                error1.SetError(txtUsuario, "El campo Usuario no puede estar vacío");
                error1.SetError(txtContraseña, "El campo Contraseña no puede estar vacío");
                error = true;
            }

            if (error)
            {
                // Esperar 5 segundos antes de limpiar los errores
                await Task.Delay(5000);
                error1.Clear();
                return;
            }
        }

        private void pbOjo_Click(object sender, EventArgs e)
        {
            if (ocultar)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
            ocultar = !ocultar;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacte con un administrador.");
        }
    }
}
