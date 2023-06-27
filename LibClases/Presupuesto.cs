using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Presupuesto
    {
        private string _id;
        private List<Producto> _productos;
        private EEstados _estado;
        private double _precio;

        public Presupuesto(List<Producto> productos, double precio)
        {
            _id = String.Empty;
            _productos = productos;
            _estado = EEstados.Revision;
            _precio = precio;

        }
        public Presupuesto(string id, List<Producto> productos,double precio):this(productos,precio)
        {
            _id = id;
            _estado = EEstados.Revision;
        }

        public string Id { get => _id; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }
        public EEstados Estado { get => _estado; set => _estado = value; }
        public double Precio { get => _precio; set => _precio = value; }    

        private string ListarProductos()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Producto producto in _productos)
            {
                sb.Append($"{producto.Id}.");
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return $"{Id},{ListarProductos()},{Estado},{Precio}";
        }
    }
}
