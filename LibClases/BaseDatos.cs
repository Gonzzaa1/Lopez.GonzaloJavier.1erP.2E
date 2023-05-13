using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public static class BaseDatos
    {

        public static void GuardarUsuario(List<Usuario> lista)
        {
            if (!File.Exists("Usuarios.csv"))
            {
                File.WriteAllText("Usuarios.csv", "Test");
            }
            else
            {
                string usuarios = ParseArchivoUsuarioToCsv(lista);

                File.WriteAllText("Usuarios.csv", usuarios);
            }
        }
        public static List<Usuario> CargarUsuario()
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
        private static string ParseArchivoUsuarioToCsv(List<Usuario> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Usuario user in lista)
            {
                sb.AppendLine(user.parseUsuario());
            }

            return sb.ToString();
        }
    }
}
