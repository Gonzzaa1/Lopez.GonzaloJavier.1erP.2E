using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public static class Registro
    {
        private static List<Usuario> usuarios;

        static Registro()
        {
            usuarios = BaseDatos.CargarUsuario();
        }

        public static List<Usuario> Usuarios { get => usuarios; }

        public static bool ConfirmarUsuario(string usuario, string contraseña)
        {
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(contraseña))
            {
                foreach (Usuario user in usuarios)
                {
                    if (user.User == usuario)
                    {
                        if (user.Contraseña == contraseña)
                        {
                            return true;
                        }
                        throw new Exception("Usuario o Contraseña no valido");
                    }
                }
                throw new Exception("Usuario o Contraseña no valido");
            }
            return false;
        }
        public static bool BuscarAdmin(string usuarioIngresado)
        {
            if (!String.IsNullOrEmpty(usuarioIngresado))
            {
                foreach (Usuario user in usuarios)
                {
                    if (user.User == usuarioIngresado)
                    {
                        if (user.Rol == ERoles.Administrador)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static bool BuscarGerente(string usuarioIngresado)
        {
            if (!String.IsNullOrEmpty(usuarioIngresado))
            {
                foreach (Usuario user in usuarios)
                {
                    if (user.User == usuarioIngresado)
                    {
                        if (user.Rol == ERoles.Empleado)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static Usuario BuscarUsuario(string user)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.User == user)
                {
                    return usuario;
                }
            }
            throw new Exception("Usuario incorrecto");
        }
        private static bool BuscarUsuario(string user, string contra, ERoles rol)
        {
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(contra))
            {
                foreach (Usuario usuario in usuarios)
                {
                    if (usuario.User == user)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void CrearUsuario(string nombre, string apellido, string usuario, string contraseña, ERoles rol, string correo)
        {
            if (!BuscarUsuario(usuario, contraseña, rol))
            {
                usuarios.Add(new(nombre, apellido, usuario, contraseña, rol, correo));
            }
            else
                throw new Exception("Usuario existente");
        }
        public static void ModificarUsuario(string usuario, string usuarioNuevo)
        {
            foreach (Usuario user in usuarios)
            {
                if (user.User == usuario)
                    user.User = usuarioNuevo;
            }
        }
        public static void ModificarUsuario(string usuario, string contraVieja, string contraseña)
        {
            foreach (Usuario user in usuarios)
            {
                if (user.User == usuario)
                {
                    if (user.Contraseña == contraVieja)
                        user.Contraseña = contraseña;
                    else
                        throw new Exception("Contraseña anterior incorrecta");
                }
            }
        }
        public static void CambiarRolUsuario(string usuario, ERoles rol)
        {
            foreach (Usuario user in usuarios)
            {
                if (user.User == usuario)
                {
                    user.Rol = rol;
                }
            }  
        }
        public static void EliminarUsuario(string usuario)
        {
            Usuario auxUser = null!;

            foreach (Usuario user in usuarios)
            {
                if (user.User == usuario)
                {
                    auxUser = user;
                }
            }
            usuarios.Remove(auxUser);
        }

        public static bool ValidarContraseña(string contraseña)
        {
            if (contraseña.Length >= 4)
                return true;

            return false;
        }
    }
}
