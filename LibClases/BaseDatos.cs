using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public static class BaseDatos
    {
        
        public static void GuardarUsuario(List<Usuario> lista)
        {
            string usuarios = ParseUsuarioToCsv(lista);
            if (!File.Exists("Usuarios.csv"))
            {
                File.WriteAllText("Usuarios.csv", usuarios);
            }
            else
            {

                File.WriteAllText("Usuarios.csv", usuarios);
            }
        }
        public static void GuardarArchivoProducto(List<Producto> lista)
        {
            string producto = ParseProductoToCsv(lista);
            if (!File.Exists("Productos.csv"))
            {
                File.WriteAllText("Productos.csv", producto);
            }
            else
            {

                File.WriteAllText("Productos.csv", producto);
            }
        }
        public static void GuardarArchivoCliente(List<Cliente>lista)
        {
            string clientes = ParseClienteToCsv(lista);

            File.WriteAllText("Clientes.csv", clientes);
        }
        public static List<Cliente> CargarArchivoClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using StreamReader archivo = new StreamReader("Clientes.csv");

            string separador = ",";
            string? cliente;

            while((cliente = archivo.ReadLine()) != null)
            {
                string[] fila = cliente.Split(separador);
                string nombre = fila[0];
                string apellido = fila[1];
                double dni = Convert.ToDouble(fila[2]);
                int edad = Convert.ToInt16(fila[3]);
                string direccion = fila[4];
                string telefono = fila[5];
                string correo = fila[6];

                clientes.Add(new(nombre, apellido, dni, edad, direccion, telefono, correo));
            }
            return clientes;
        }
        public static List<Usuario> CargarArchivoUsuario()
        {
            List<Usuario> lista = new List<Usuario>();

            using StreamReader archivo = new StreamReader("Usuarios.csv");

            string separador = ",";
            string? usuario;

            while ((usuario = archivo.ReadLine()) != null)
            {
                string[] fila = usuario.Split(separador);
                string nombre = fila[0];
                string apellido = fila[1];
                string user = fila[2];
                string contraseña = fila[3];
                string rol = fila[4];
                string correo = fila[5];

                lista.Add(new(nombre, apellido, user, contraseña, ParsearRol(rol), correo));
            }

            return lista;
        }
        public static List<Producto> CargarArchivoProductos()
        {
            List<Producto> lista = new List<Producto>();

            using StreamReader archivo = new StreamReader("Productos.csv");

            string separador = ",";
            string? producto;

            while ((producto = archivo.ReadLine()) != null)
            {
                string[] fila = producto.Split(separador);
                string id = fila[0];
                string nombre = fila[1];
                string marca = fila[2];
                double precio = Convert.ToDouble(fila[3]);
                ECategoria categoria = ParsearCategoria(fila[4]);
                int stock = Convert.ToInt16(fila[5]);

                lista.Add(new(id, nombre, marca, precio, categoria,stock));
            }

            return lista;
        }
        public static ECategoria ParsearCategoria(string categoria)
        {
            switch(categoria)
            {
                case "Microprocesador":
                    return ECategoria.Microprocesador;
                case "Motherboard":
                    return ECategoria.Motherboard;
                case "MemoriaRam":
                    return ECategoria.MemoriaRam;
                case "Disco":
                    return ECategoria.Disco;
                case "GPU":
                    return ECategoria.GPU;
                case "Gabinete":
                    return ECategoria.Gabinete;
                case "Fuente":
                    return ECategoria.Fuente;
                case "Cooler":
                    return ECategoria.Cooler;    
                case "Mouse":
                    return ECategoria.Mouse;
                case "Teclado":
                    return ECategoria.Teclado;
                case "Auriculares":
                    return ECategoria.Auriculares;
                case "Parlantes":
                    return ECategoria.Parlantes;
                case "Microfono":
                    return ECategoria.Microfono;
                case "Monitor":
                    return ECategoria.Monitor;
                default:
                    return ECategoria.CamaraWeb;
            }
        }
        public static ERoles ParsearRol(string rol)
        {
            switch(rol)
            {
                case "Administrador":
                    return ERoles.Administrador;
                case "Gerente":
                    return ERoles.Gerente;
                case "Empleado":
                    return ERoles.Empleado;
                default:
                    return ERoles.Cliente;
            }
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
    }
}
