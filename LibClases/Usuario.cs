using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Usuario : Persona
    {
        private string _usuario;
        private string _contraseña;
        private string _rol;

        public Usuario(string nombre, string apellido, string usuario, string contraseña, string rol, string correo) : base(nombre, apellido, correo)
        {
            _usuario = usuario;
            _contraseña = contraseña;
            _rol = rol;
        }

        public string User { get => _usuario; set => _usuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public string Rol { get => _rol; set => _rol = value; }

        public string parseUsuario()
        {
            return $"{Nombre},{Apellido},{User},{Contraseña},{Rol},{Correo}";
        }
        public override string ToString()
        {
            return $" {Nombre.ToUpper()} {Apellido.ToUpper()} - {Rol.ToUpper()}";
        }

        public void RealizarPresupuesto()
        {

        }

        public void RealizarVenta()
        {

        }

        public void RealizarCompra()
        {

        }

        public void ConsultarStock()
        {

        }
    }
}
