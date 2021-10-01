using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaersk.Clases
{
    public class LeeUsuario
    {
        public string Nombre = "";
        public string Codigo = "";
        public bool EsAdministrador = false;

        public void Leer(string username, string connString)
        {
            using var connection = new MySqlConnection(connString); //variable de conexíón a la base
            {
                connection.Open(); //abriendo la conección a la base de datos, si xampp no está abierto no funciona
                string q = "SELECT * FROM AspNetUsers where UserName = '" + username + "'";
                using var command = new MySqlCommand(q, connection);
                using var reader = command.ExecuteReader(); //devuelve un objeto para poder hacer consultas, en este caso q. Comienza a leer la data
                if (reader.Read())
                {
                    Codigo = reader["Codigo"].ToString();
                    Nombre = reader["Nombre"].ToString();
                    string tipo = reader["Tipo_Empleado"].ToString();
                    if (tipo == "Administrador")
                        EsAdministrador = true;
                    else
                        EsAdministrador = false;
                }
            }
        }
    }
}
