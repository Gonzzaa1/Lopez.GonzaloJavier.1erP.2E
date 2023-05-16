namespace LibClases
{
    public static class PCMaker
    {
        
        private static List<Producto> productos = new List<Producto>();
        private static List<Producto> solcitudes = new List<Producto>();

        public static List<Producto> Productos { get => productos;}
        public static List<Producto> Solicitudes { get => solcitudes; }


        public static void Cargar()
        {
            productos = BaseDatos.CargarArchivoProductos();
        }
        
        public static List<Producto> FiltrarProductos(string categoria)
        {
            List<Producto> productosFiltrados = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if(producto.Categoria.ToString() == categoria)
                {
                    productosFiltrados.Add(producto);
                }
            }
            return productosFiltrados;
        }
        public static Producto CrearProducto(string nombre,string marca,string precio, string categoria,string stock)
        {
            if(!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(marca) && !String.IsNullOrEmpty(precio) && !String.IsNullOrEmpty(stock) && !String.IsNullOrEmpty(categoria))
            {
                if(double.TryParse(precio, out double price) && int.TryParse(stock, out int stockCantidad))
                {
                    return new Producto(GeneradorId(), nombre, marca, price, BaseDatos.ParsearCategoria(categoria), stockCantidad);
                }
                else
                {
                    throw new Exception("Datos incorrectos o mal cargados");
                }
            }
            else
            {
                throw new Exception("Datos incorrectos o mal cargados");
            }
        }
        public static void AgregarProducto(Producto producto)
        {
            bool check = false;

            if(producto != null)
            {
                foreach(Producto item in productos)
                {
                    if(item != producto)
                        check = true;
                }

                if(check)
                    productos.Add(producto);
                else
                    throw new Exception("Producto ya existe en listado");
            }
        }
        public static void EliminarProducto(string id)
        {
            if(!String.IsNullOrEmpty(id))
            {
                Producto productoEliminado = null!;

                foreach(Producto item in productos)
                {
                    if(item.Id == id)
                    {
                        productoEliminado = item;
                    }
                }

                productos.Remove(productoEliminado);
            }
            else
            {
                throw new Exception("ID incorrecto");
            }
        }
        public static void SolicitarStock(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                foreach (Producto producto in productos)
                {
                    if (producto.Id == id)
                    {
                        solcitudes.Add(producto);
                    }
                }
            }
        }
        public static void AgregarStock(string id, string stock)
        {
            if (!String.IsNullOrEmpty(id) && int.TryParse(stock, out int cantidad))
            {

                foreach(Producto producto in productos)
                {
                    if(producto.Id == id)
                    {
                        producto.Stock = cantidad;
                    }
                }
            }
            else
            {
                throw new Exception("Dato mal cargado");
            }
        }
        private static string GeneradorId()
        {
            Random random = new Random();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var clave = new char[16];

            for (int i = 0; i < clave.Length; i++)
            {
                clave[i] = caracteres[random.Next(caracteres.Length)];
            }

            string resultado = new string(clave);

            return resultado;
        }
    }
}
