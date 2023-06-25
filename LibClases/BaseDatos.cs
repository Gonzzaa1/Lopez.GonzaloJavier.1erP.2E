using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public static class BaseDatos
    {
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string _connectionString;
        
        static BaseDatos()
        {
            _connectionString = @"Server = DESKTOP-U0AEOQ5; Database = PCMarkerDB; Trusted_Connection = True;";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
        }


        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Usuarios";

            SqlDataReader reader = _command.ExecuteReader();

            while(reader.Read())
            {
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1); 
                string usuario = reader.GetString(2);
                string contraseña = reader.GetString(3);
                ERoles rol = (ERoles) Enum.Parse(typeof(ERoles), reader.GetString(4), true);
                string correo = reader.GetString(5);

                lista.Add(new(nombre, apellido, usuario, contraseña, rol, correo));
            }

            if(_connection.State == ConnectionState.Open)
            {
                _connection.Close(); 
            }
            return lista;
        }
        public static  List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Productos";
            SqlDataReader reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetDecimal(0).ToString();
                string nombre = reader.GetString(1);
                string marca = reader.GetString(2);
                double precio = Convert.ToDouble(reader.GetDecimal(3));
                ECategoria categoria = (ECategoria)Enum.Parse(typeof(ECategoria), reader.GetString(4), true);
                int stock = reader.GetInt32(5);

                lista.Add(new(id, nombre, marca, precio, categoria, stock));
            }

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            return lista;
        }
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Clientes";
            SqlDataReader reader = _command.ExecuteReader();

            while (reader.Read())
            {
                
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                double dni = Convert.ToDouble(reader.GetDecimal(2));
                int edad = reader.GetInt32(3);
                string direccion = reader.GetString(4);
                string telefono = reader.GetString(5);
                string correo = reader.GetString(6);


                lista.Add(new(nombre,apellido,dni,edad,direccion,telefono,correo));
            }

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            return lista;
        }
        public static List<Presupuesto> ObtenerPresupuestos()
        {
            List<Presupuesto> lista = new List<Presupuesto>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Presupuestos";

            SqlDataReader reader = _command.ExecuteReader();

            while(reader.Read())
            {
                Presupuesto presupuestoActual;

                string id = reader.GetString(0);
                List<Producto> productos = ObtenerProductos(decimal.Parse(id));
                double precio = Convert.ToDouble(reader.GetDecimal(3));

                presupuestoActual = new(id, productos, precio);
                presupuestoActual.Estado = (EEstados)Enum.Parse(typeof(EEstados), reader.GetString(2), true);

                lista.Add(presupuestoActual);
            }

            return lista;
        }
        public static List<Producto> ObtenerProductos(decimal presupuestoID)
        {
            List<Producto> lista = new List<Producto>();

            _connection.Open();

            _command.CommandText = "SELECT * FROM Productos P" +
                                   "INNER JOIN PresupuestoProducto PP ON P.Producto_ID = PP.Producto_ID" +
                                   "WHERE PP.Presupuesto_ID = @Presupuesto_ID";

            _command.Parameters.AddWithValue("@Presupuesto_ID", presupuestoID);

            SqlDataReader reader = _command.ExecuteReader();

            while(reader.Read())
            {
                string id = reader.GetDecimal(0).ToString();
                string nombre = reader.GetString(1);
                string marca = reader.GetString(2);
                double precio = Convert.ToDouble(reader.GetDecimal(3));
                ECategoria categoria = (ECategoria)Enum.Parse(typeof(ECategoria), reader.GetString(4), true);
                int stock = reader.GetInt32(5);

                lista.Add(new(id, nombre, marca, precio, categoria, stock));
            }

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            return lista;
        }
        #region Aarchivo
        public static void GuardarUsuario(List<Usuario> lista)
        {
            string usuarios = ParseUsuarioToCsv(lista);
            if (!File.Exists("Usuarios.csv"))
            {
                using (StreamWriter sw = File.CreateText("Usuarios.csv"))
                    sw.WriteLine(usuarios);
            }
            else
            {
                File.WriteAllText("Usuarios.csv", usuarios);
            }
        }
        public static void GuardarArchivoVentas(List<Venta> lista)
        {
            string ventas = ParseVentastoToCsv(lista);
            if (!File.Exists("Ventas.csv"))
            {
                using (StreamWriter sw = File.CreateText("Ventas.csv"))
                    sw.WriteLine(ventas);
            }
            else
            {
                File.WriteAllText("Ventas.csv", ventas);
            }
        }
        public static void GuardarArchivoProducto(List<Producto> lista)
        {
            string producto = ParseProductoToCsv(lista);
            if (!File.Exists("Productos.csv"))
            {
                using (StreamWriter sw = File.CreateText("Productos.csv"))
                    sw.WriteLine(producto);
            }
            else
            {
                File.WriteAllText("Productos.csv", producto);
            }
        }
        public static void GuardarArchivoCliente(List<Cliente>lista)
        {
            string clientes = ParseClienteToCsv(lista);

            if (!File.Exists("Clientes.csv"))
            {
                using (StreamWriter sw = File.CreateText("Clientes.csv"))
                    sw.WriteLine(clientes);
            }
            else
            {
                File.WriteAllText("Clientes.csv", clientes);
            }
        }
        public static void GuardarArchivoPresupuesto(List<Presupuesto> lista)
        {
            string presupuesto = ParsePresupuestoToCsv(lista);

            if (!File.Exists("Presupuestos.csv"))
            {
                using (StreamWriter sw = File.CreateText("Presupuestos.csv"))
                    sw.WriteLine(presupuesto);
            }
            else
            {
                File.WriteAllText("Presupuestos.csv", presupuesto);
            }
        }
        //public static List<Presupuesto> CargarArchivoPresupuesto()
        //{
        //    List<Presupuesto> presupuesto = new List<Presupuesto>();
        //    using StreamReader archivo = new StreamReader("Presupuestos.csv");

        //    string separador = ",";
        //    string? _presupuesto;

        //    while ((_presupuesto = archivo.ReadLine()) != null)
        //    {

        //        string[] fila = _presupuesto.Split(separador);
        //        if(fila[0] != "")
        //        {
        //            List<Producto> productos = new List<Producto>();
        //            Presupuesto aux;
        //            string id = fila[0];
        //            string producto = fila[1];
        //            string estado = fila[2];
        //            double precio = Convert.ToDouble(fila[3]);

        //            string[] productosId = producto.Split(".");

        //            foreach (string _id in productosId)
        //            {
        //                if(_id != "")
        //                    productos.Add(PCMaker.BuscarProductoId(_id));
        //            }
        //            aux = new(id, productos,precio);
        //            aux.Estado = ParsearEstados(estado);

        //            presupuesto.Add(aux);
        //        }
                
        //    }
        //    return presupuesto;
        //}
        public static List<Venta> CargarArchivoVentas()
        {
            List<Venta> lista = new List<Venta>();

            using StreamReader archivo = new StreamReader("Ventas.csv");

            string separador = ",";
            string? ventas;

            while ((ventas = archivo.ReadLine()) != null)
            {
                string[] fila = ventas.Split(separador);
                if (fila[0] != "")
                {
                    string id = fila[0];
                    string cliente = fila[1];
                    string numeroTarjeta = fila[2];
                    string cuotas = fila[3];
                    string ganancia = fila[4];
                    string usuario = fila[5];

                    lista.Add(new(id, cliente, numeroTarjeta, cuotas, ganancia, usuario));
                }   
            }
            return lista;
        }
        private static string ParseUsuarioToCsv(List<Usuario> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Usuario user in lista)
            {
                sb.AppendLine(user.ParsearDatos());
            }

            return sb.ToString();
        }
        private static string ParseProductoToCsv(List<Producto>lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto producto in lista)
            {
                sb.AppendLine(producto.parseProducto());
            }

            return sb.ToString();
        }
        private static string ParseClienteToCsv(List<Cliente>lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente cliente in lista)
            {
                sb.AppendLine(cliente.ParsearDatos());
            }

            return sb.ToString();
        }
        private static string ParsePresupuestoToCsv(List<Presupuesto> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Presupuesto presupuesto in lista)
            {
                sb.AppendLine(presupuesto.ToString());
            }

            return sb.ToString();
        }
        private static string ParseVentastoToCsv(List<Venta> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Venta venta in lista)
            {
                sb.AppendLine(venta.ToString());
            }

            return sb.ToString();
        }
        #endregion
    }
}


