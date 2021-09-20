using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //para que ponga en rojo los datos no ingresados

namespace ProyectoMaersk.Clases
{
    public class Usuarios
    {
        //id y codigo no requeridos por ser generados automáticamente
        public int Id { get; set; }

        [Required] //campos requeridos
        public String Tipo { get; set; }

        [Required]
        public String Contraseña { get; set; }

        public String Codigo { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        public String Puerto { get; set; }

        public String Nombre_Puerto { get; set; }

        [Required]
        public String Pais { get; set; }

        public String Nombre_Pais { get; set; }
    }
}
