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

        public Presupuesto(string id, List<Producto> productos)
        {
            _id = id;
            _productos = productos;
            _estado = EEstados.Revision;
        }

        public string Id { get => _id; }
        public List<Producto> Productos { get => _productos; }
        public EEstados Estado { get => _estado; set => _estado = value; }

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
            return $"{Id},{ListarProductos()},{Estado}";
        }
    }
}
