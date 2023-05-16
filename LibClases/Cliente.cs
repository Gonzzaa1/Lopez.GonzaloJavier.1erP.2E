﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Cliente : Persona
    {
        private string _dni;
        private int _edad;
        private string _direccion;
        private string _telefono;
        public Cliente(string nombre,string apellido,string correo,string dni,int edad,string direccion,string telefono) : base (nombre,apellido,correo)
        {
            _dni = dni;
            _edad = edad;
            _direccion = direccion;
            _telefono = telefono;
        }

        public string Dni { get => _dni; set => _dni = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Direccion { get => _direccion; set => _direccion = value;}
        public string Telefono { get => _telefono; set => _telefono = value; }

        public override string ParsearDatos()
        {
            return $"{Nombre},{Apellido},{Correo}";
        }

    }
}
