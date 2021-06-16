using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace veterianaria
{
    class Conexion_PostgreSQL
    {
        // Creamos connexión
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = 54321; Database = chucholandia");

        // Metodo para conectar a la base de datos
        public void Conectar()
        {
            conn.Open();
        }

        // Metodo para desconectar de la base de datos
        public void Desconectar()
        {
            conn.Close();
        }

        // Metodo para consultar todos los atributos de cierta tabla
        public DataTable Consultar(string nombre_tabla)
        {
            string query = "select * from " + nombre_tabla; // Creamos query que ejecutará
            NpgsqlCommand conector = new NpgsqlCommand(query, conn); // Mandamos query y connexion y almacenamos
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector); // Guardamos los datos recolectados
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
    }
}
