using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaersk.Clases
{
    public class Reserva
    {
        public int Id { get; set; }
        public String Codigo { get; set; } 
        public String Empresa { get; set; }
        public String Nit { get; set; }
        public String Direccion { get; set; }
        public String Puerto_Origen { get; set; }
        public String Pais_Origen { get; set; }
        public String Hora_Salida { get; set; }
        public String Puerto_Destino { get; set; }
        public String Pais_Destino { get; set; }
        public String Hora_Llegada { get; set; }
        public String Receptor { get; set; }
        public String Contraseña_Recepcion { get; set; }
        public String Tipo_Carga { get; set; }
        public String Descripcion { get; set; }
        public String Peso { get; set; }
        public String Valor { get; set; }
        public String Tipo_Contenedor { get; set; }
    }
}
