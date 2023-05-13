using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Producto
    {
        private string _id;
        private string _nombre;
        private string _marca;
        private double _precio;
        private ECategoria _categoria;
        private int _stock;

        public Producto(string id,string nombre, string marca, double precio, ECategoria categoria, int stock)
        {
            _id = id;
            _nombre = nombre;
            _marca = marca;
            _precio = precio;
            _categoria = categoria;
            _stock = stock;
        }
        public string Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } } 
        public string Marca { get { return _marca; } set { _marca = value; } }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public ECategoria Categoria { get { return _categoria; } set { _categoria = value; } } 
        public int Stock { get { return _stock; } set { _stock = value; } }

        public string parseProducto()
        {
            return $"{Id},{Nombre},{Marca},{Precio},{Categoria},{Stock}";
        }

    }
}
