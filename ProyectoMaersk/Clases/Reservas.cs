using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //para que ponga en rojo los datos no ingresados

namespace ProyectoMaersk.Clases
{
    public class Reserva
    {
        //id, codigo, contraseña y total de factura no requeridos por ser generada automáticamente
        public int Id { get; set; }
        public String Codigo { get; set; }

        [Required] //datos obligatorios
        public String Empresa { get; set; }

        [Required]
        public String Nit { get; set; }
        
        [Required]
        public String Direccion { get; set; }

        [Required]
        public String Puerto_Origen { get; set; }
        
        public String Nombre_Puerto_Origen { get; set; }

        [Required]
        public String Pais_Origen { get; set; }

        [Required]
        public String Hora_Salida { get; set; }

        [Required]
        public String Puerto_Destino { get; set; }
        public String Nombre_Puerto_Destino { get; set; }

        [Required]
        public String Pais_Destino { get; set; }

        [Required]
        public String Hora_Llegada { get; set; }

        [Required]
        public String Receptor { get; set; } 
        
        public String Contraseña_Recepcion { get; set; }

        [Required]
        public String Tipo_Carga { get; set; }

        [Required]
        public String Descripcion { get; set; }

        [Required]
        public String Peso { get; set; }

        [Required]
        public String Valor { get; set; }
        
        [Required]
        public String Tipo_Contenedor { get; set; }
        
        public String Total_Factura { get; set; }
    }
}
