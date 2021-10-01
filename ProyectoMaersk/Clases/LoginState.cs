using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaersk.Clases
{
    public class LoginState
    {
        public bool isLoggedIn { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public bool esAdministrador { get; set; } //verdadero o falso para verificar que sea admin
        public string error { get; set; }

    }
}
