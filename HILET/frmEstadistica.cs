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
    public partial class frmEstadistica : Form
    {
        private ConexionBBDD conectar;

        public frmEstadistica()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            conectar.Abrir();
            string consulta = "ObtenerEstadisticasGenerales";
            using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paramAlumnos = new SqlParameter("@TotalAlumnos", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                SqlParameter paramCarreras = new SqlParameter("@TotalCarreras", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                SqlParameter paramMaterias = new SqlParameter("@TotalMaterias", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                comando.Parameters.Add(paramAlumnos);
                comando.Parameters.Add(paramCarreras);
                comando.Parameters.Add(paramMaterias);

                comando.ExecuteNonQuery();

                lblAlumnos.Text = paramAlumnos.Value.ToString();
                lblCarreras.Text = paramCarreras.Value.ToString();
                lblMaterias.Text = paramMaterias.Value.ToString();
                conectar.Cerrar();
            }
        }
    }
}
