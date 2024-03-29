﻿using System;
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
        private ERoles _rol;

        public Usuario(string nombre, string apellido, string usuario, string contraseña, ERoles rol, string correo) : base(nombre, apellido, correo)
        {
            _usuario = usuario;
            _contraseña = contraseña;
            _rol = rol;
        }

        public string User { get => _usuario; set => _usuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public ERoles Rol { get => _rol; set => _rol = value; }

        public override string ParsearDatos()
        {
            return $"{Nombre},{Apellido},{User},{Contraseña},{Rol},{Correo}";
        }
        public override string ToString()
        {
            string auxRol = Rol.ToString();

            return $" {Nombre.ToUpper()} {Apellido.ToUpper()} - {auxRol.ToUpper()}";
        }
    }
}
