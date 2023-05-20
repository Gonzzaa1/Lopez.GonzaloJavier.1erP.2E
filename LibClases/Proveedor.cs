using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Proveedor
    {
        private string _local;
        private string _telefono;
        private string _direccion;
        private List<Producto> _stock;

        public Proveedor(string local, string telefeno, string direccion)
        {
            _local = local;
            _telefono = telefeno;
            _direccion = direccion;
            _stock = new List<Producto>();
        }

        public string Local { get => _local; set => _local = value; }
        
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public List<Producto> Stock { get => _stock; set => _stock = value; }

    }
}
