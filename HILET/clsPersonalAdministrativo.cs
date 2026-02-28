using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Xml;

namespace HILET
{
    public class clsPersonalAdministrativo
    {
        public int Id_Personal { get; set; }
        public string Nombre {  get; set; }

        public string Apellido { get; set; }
        public int Id { get; set; }
        public string DomicilioCalle { get; set; }
        public int DomicilioNumero { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }
        public DateTime FechaInscripcion {  get; set; }

        public DateTime FechaBaja { get; set; }

        public string Usuario {  get; set; }

        public string Contraseña { get; set; }

        public int Id_Perfil { get; set; }

    }
}
