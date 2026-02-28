using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HILET
{
    internal class ConexionBBDD
    {
       //string cadena = "Data Source = maycol\\SQLEXPRESS; Initial Catalog = TPFinal ; Integrated Security = true;";
       string cadena = "Data Source = 192.168.0.100; Database=u23; User Id = u23; Password=u23";

        public SqlConnection conectar = new SqlConnection();

        public ConexionBBDD()
        {
            conectar.ConnectionString = this.cadena;
        }


        public SqlConnection Conexion
        {
            get { return conectar; }
        }


         public void Abrir()
         {
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar a la base de datos");
            }
         }

        public void Cerrar()
        {
            conectar.Close();
        }
    }
}
