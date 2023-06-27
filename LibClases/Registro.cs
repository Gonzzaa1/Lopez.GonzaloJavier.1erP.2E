using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public static class Registro
    {
        private static Queue<Usuario> solicitudMod = new Queue<Usuario>();
        public static Queue<Usuario> Solicitudes { get => solicitudMod!; }

        public static bool ConfirmarUsuario(string usuario, string contraseña)
        {
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(contraseña))
            {
                Usuario usuarioBuscado = BaseDatos.BuscarUsuario(usuario);

                if(usuarioBuscado.Contraseña == contraseña)
                {
                    return true;
                }
                throw new Exception("Usuario o Contraseña no valido");
            }
            throw new Exception("Usuario o Contraseña no valido");
        }
        private static bool BuscarUsuario(string user, string contra)
        {
            try
            {
                if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(contra))
                {
                    Usuario usuarioBuscado = BaseDatos.BuscarUsuario(user);
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public static Usuario VerificarUsuario(string nombre, string apellido, string usuario, string contraseña, string rol, string correo)
        {
            if (!BuscarUsuario(usuario, contraseña))
            {
                if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(correo) && !String.IsNullOrEmpty(rol))
                {
                    ERoles _rol = (ERoles)Enum.Parse(typeof(ERoles), rol, true);
                    Usuario nuevoUsuario = new(nombre, apellido, usuario, contraseña, _rol, correo);

                    return nuevoUsuario;
                }
                else
                    throw new Exception("Datos incompletos");
            }
            else
                throw new Exception("Usuario existente");
        }
        public static bool ValidarContraseña(string contraseña)
        {
            if (contraseña.Length >= 4)
                return true;

            return false;
        }
        public static void SolicitarMod (string usuario,string contraseña,string rol,string nombre,string apellido,string correo)
        {
            if(solicitudMod != null)
            {
                ERoles _rol = (ERoles)Enum.Parse(typeof(ERoles), rol, true);
                solicitudMod.Enqueue(new Usuario(nombre, apellido, usuario, contraseña, _rol, correo));
            }
        }
        public static string MostrarSolicitud()
        {
            Usuario auxUser = solicitudMod.Peek();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El usuario {auxUser.User.ToUpper()} solicito modificar los siguientes datos");
            sb.AppendLine($"Nombre = {auxUser.Nombre.ToUpper()}");
            sb.AppendLine($"Apellido = { auxUser.Apellido.ToUpper()}");
            sb.AppendLine($"Correo = {auxUser.Correo.ToUpper()}");

            return sb.ToString();
        }
        public static void ConfirmarSolicitudMod()
        {
            if(solicitudMod != null)
            {
                Usuario userMod = solicitudMod.Dequeue();
                BaseDatos.ModificarUsuario(userMod);
            }
        }
        public static void CancelarSolicitud()
        {
            solicitudMod.Dequeue();
        }
    }
}
