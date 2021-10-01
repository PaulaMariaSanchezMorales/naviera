using Microsoft.AspNetCore.Identity;
using System;

namespace ProyectoMaersk.Clases
{
    public class UsuarioIdentity : IdentityUser
    {
        public String Tipo_Empleado { get; set; }
        public String Codigo { get; set; }

        public String Nombre { get; set; }

        public String Puerto { get; set; }

        public String Nombre_Puerto { get; set; }

        public String Pais { get; set; }

        public String Nombre_Pais { get; set; }
    }

    public class UsuarioEditar
    {
        public String Id { get; set; }
        public String Tipo_Empleado { get; set; }
        public String Codigo { get; set; }

        public String Nombre { get; set; }

        public String Contraseña { get; set; }

        public String Puerto { get; set; }

        public String Nombre_Puerto { get; set; }

        public String Pais { get; set; }

        public String Nombre_Pais { get; set; }
    }
}
