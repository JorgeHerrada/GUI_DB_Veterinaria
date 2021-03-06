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
            DataTable tabla = new DataTable(); // Creamos objeto tabla
            datos.Fill(tabla); // Llenamos la tabla con los datos que recuperó el conector

            return tabla; // Retornamos la tabla
        }

        // Metodo para consultar todos los atributos de cierta tabla según el nombre
        // Funciona bien para todos menos visitas. Parcialmente Clientes y Personal
        public DataTable Consultar_Nombre(string nombre_tabla,string nombre)
        {
            string query = "select * from " + nombre_tabla + " where nombre like '%" + nombre + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        // Metodo para consultar todos los atributos de VISITAS segun nombre de mascota
        public DataTable Consultar_Nombre_Mascota(string nombre)
        {
            // QUERY con INNER JOIN de 3 tablas
            string query = "select v.id, m.nombre as mascota,c.nombre as cliente,v.id_servicio,"
                + "v.hora_entrada,v.hora_salida"
                + "from visitas as v"
                + "join mascotas as m"
                + "on v.id_mascota = m.id"
                + "join clientes as c"
                + "on v.id_cliente = c.id"
                + "where m.nombre like '%" + nombre + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        // Metodo para consultar todos los atributos de cierta tabla según el codigo
        public DataTable Consultar_Codigo(string nombre_tabla, string codigo)
        {
            string query = "select * from " + nombre_tabla + " where id = " + codigo;
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        // Metodo para insertar en tabla CLIENTES
        public void Insertar_CLIENTES(string nombre, string apellido, string telefono, string email, string direccion)
        {
            // declaramos el query
            string query = "INSERT into clientes(nombre,apellido,telefono,email,direccion)"
                + " VALUES('" + nombre + "','" + apellido + "','" + telefono + "','" + email + "','" + direccion + "')";

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("AGREGADO CORRECTAMENTE", "SUCCESSFULLY INSERTED");

        }

        // Metodo para hacer UPDATE en tabla CLIENTES
        public void Update_CLIENTES(int id,string nombre, string apellido, string telefono, string email, string direccion)
        {
            // declaramos el query
            string query = "UPDATE clientes set nombre = '" + nombre + "', apellido = '" + apellido +
                "', telefono ='" + telefono + "', email = '" + email + "', direccion = '" + direccion +
                "' where id = " + id;                

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("MODIFICADO CORRECTAMENTE", "SUCCESSFULLY UPDATED");

        }

        // Metodo para insertar en tabla MASCOTAS
        public void Insertar_MASCOTAS(int id_cliente, string nombre, string raza, string especie, int edad, double peso)
        {
            // declaramos el query
            string query = "INSERT into mascotas(id_cliente,nombre,raza,especie,edad,peso)"
                + " VALUES(" + id_cliente + ",'" + 
                nombre + "','" + raza + "','" + especie + "'," + 
                edad + "," + peso + ")";

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("AGREGADO CORRECTAMENTE", "SUCCESSFULLY INSERTED");
        }


        // Metodo para hacer UPDATE en tabla MASCOTAS
        public void Update_MASCOTAS(int id, int id_cliente, string nombre, string raza, string especie, int edad, double peso)
        {
            // declaramos el query
            string query = "UPDATE mascotas set id_cliente = " + id_cliente + ", nombre = '" + nombre +
                "', raza = '" + raza + "' especie = '" + especie + "', edad = " + edad + ", peso = " + peso +
                " where id = " + id;

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("MODIFICADO CORRECTAMENTE", "SUCCESSFULLY UPDATED");
        }


        // Metodo para insertar en tabla PERSONAL
        public void Insertar_PERSONAL(string nombre, string apellido, string telefono, string direccion, string email, string puesto, string estudios, int antiguedad, string horario, double salario)
        {
            // declaramos el query
            string query = "INSERT into personal(nombre,apellido,telefono,direccion,email,puesto,grado_estudios,antiguedad,horario,salario)"
                + " VALUES('" + nombre + "','" + apellido + "','" + telefono + "','" + direccion + "','" + email + "','" + 
                puesto + "','" + estudios + "'," + antiguedad + ",'" + horario + "'," + salario + ")";

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("AGREGADO CORRECTAMENTE", "SUCCESSFULLY INSERTED");
        }


        // Metodo para hacer UPDATE en tabla PERSONAL
        public void Update_PERSONAL(int id, string nombre, string apellido, string telefono, string direccion, string email, string puesto, string estudios, int antiguedad, string horario, double salario)
        {
            // declaramos el query
            string query = "UPDATE personal set nombre = '" + nombre + "', apellido = '" + apellido +
                "', telefono = '" + telefono + "', direccion ='" + direccion + "', email = '" + email +
                "', puesto ='" + puesto + "', grado_estudios = '" + estudios +
                "', antiguedad = " + antiguedad + ", horario = '" + horario + "', salario = " + salario +
                " where id =" + id;

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("MODIFICADO CORRECTAMENTE", "SUCCESSFULLY UPDATED");
        }


        // Metodo para insertar en tabla PRODUCTOS
        public void Insertar_PRODUCTOS(int proveedor, int servicio, string nombre, int precio_venta, int precio_compra, int existencias)
        {
            // declaramos el query
            string query = "INSERT into productos(id_proveedor,id_servicio,nombre,precio_venta,precio_compra,existencia)"
                + " VALUES(" + proveedor + "," + servicio + ",'" + nombre + "'," + precio_venta + "," + precio_compra + "," + existencias + ")";

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("AGREGADO CORRECTAMENTE", "SUCCESSFULLY INSERTED");
        }


        // Metodo para hacer UPDATE en tabla PRODUCTOS
        public void Update_PRODUCTOS(int id, int proveedor, int servicio, string nombre, int precio_venta, int precio_compra, int existencias)
        {
            // declaramos el query
            string query = "UPDATE productos set id_proveedor = " + proveedor +
                ", id_servicio =" + servicio + ", nombre = '" + nombre +
                "', precio_venta = " + precio_venta + ", precio_compra = " + precio_compra +
                ", existencias = " + existencias + " where id = " + id;
                

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery(); 

            System.Windows.Forms.MessageBox.Show("MODIFICADO CORRECTAMENTE", "SUCCESSFULLY UPDATED");
        }


        // Metodo para insertar en tabla PROVEEDORES
        public void Insertar_PROVEEDORES(string nombre, string direccion, string telefono, string email)
        {
            // declaramos el query
            string query = "INSERT into proveedores(nombre,direccion,telefono,email)"
                + " VALUES('" + nombre + "','" + direccion + "','" + telefono + "','" + email + "')";

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("AGREGADO CORRECTAMENTE", "SUCCESSFULLY INSERTED");
        }


        // Metodo para hacer UPDATE en tabla PROVEEDORES
        public void Update_PROVEEDORES(int id, string nombre, string direccion, string telefono, string email)
        {
            // declaramos el query
            string query = "UPDATE proveedores set nombre = '" + nombre + "', direccion ='" + direccion +
                "', telefono = '" + telefono + "', email = '" + email + "' where id = " + id;

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("MODIFICADO CORRECTAMENTE", "SUCCESSFULLY UPDATED");
        }


        // Metodo para insertar en tabla SERVICIOS
        public void Insertar_SERVICIOS(int codigo_empleado, int precio, string nombre)
        {
            // declaramos el query
            string query = "INSERT into servicios(id_empleado,precio,nombre)"
                + " VALUES(" + codigo_empleado + "," + precio + ",'" + nombre+ "')";

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn); 
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("AGREGADO CORRECTAMENTE", "SUCCESSFULLY INSERTED");
        }


        // Metodo para hacer UPDATE en tabla SERVICIOS
        public void Update_SERVICIOS(int id, int codigo_empleado, int precio, string nombre)
        {
            // declaramos el query
            string query = "UPDATE servicios set id_empleado = " + codigo_empleado + ", precio = " + precio +
                ", nombre = '" + nombre + "' where id = " + id;

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("MODIFICADO CORRECTAMENTE", "SUCCESSFULLY UPDATED");
        }


        // Metodo para insertar en tabla VISITAS
        public void Insertar_VISITAS(int id_servicio, int id_mascota, int id_cliente, string entrada, string salida)
        {
            // declaramos el query
            string query = "INSERT into visitas(id_servicio,id_mascota,id_cliente,hora_entrada,hora_salida)"
                + " VALUES(" + id_servicio + "," + id_mascota + "," + id_cliente + ",'" + entrada + "','" + salida + "')";

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("AGREGADO CORRECTAMENTE", "SUCCESSFULLY INSERTED");
        }

        // Metodo para hacer UPDATE en tabla VISITAS
        public void Update_VISITAS(int id, int id_servicio, int id_mascota, int id_cliente, string entrada, string salida)
        {
            // declaramos el query
            string query = "update visitas set id_servicio = " + id_servicio + ", id_mascota = " + id_mascota +
                ", id_cliente = " + id_cliente + ", hora_entrada = '" + entrada + "', hora_salida = '" + salida + 
                "' where id = " + id;

            // Ejecutamos comando, mandamos el query y la connexion
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("MODIFICADO CORRECTAMENTE", "SUCCESSFULLY UPDATED");
        }

        public void Eliminar(string nombre_tabla, int id)
        {
            string query = "delete from " + nombre_tabla + " where id = " + id;

            NpgsqlCommand ejecutor = new NpgsqlCommand(query,conn);
            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("ELIMINADO CORRECTAMENTE", "SUCCESSFULLY DELETED");

        }
    }
}
