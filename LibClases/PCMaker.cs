
using Newtonsoft.Json;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace LibClases
{
    public static class PCMaker
    {
        private static List<Producto> _productos = new List<Producto>();
        private static List<Producto> _solcitudes = new List<Producto>();
        private static List<Producto> _presupuesto = new List<Producto>();
        private static List<Presupuesto> _solicitudPresupuesto = new List<Presupuesto>();
        private static List<Venta> _ventas = new List<Venta>();

        public static List<Producto> Productos { get => _productos; }
        public static List<Producto> Solicitudes { get => _solcitudes; }
        public static List <Venta> Ventas { get => _ventas; }

        public static void Cargar()
        {
            _productos = BaseDatos.ObtenerProductos();
            _solicitudPresupuesto = BaseDatos.ObtenerPresupuestos();
            _ventas = BaseDatos.ObtenerVentas();
        }
        public static void ExportarJSON<T>(string nombreArchivo,List<T> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(nombreArchivo + ".json", json);
        }
        public static void ExportarCSV<T>(string nombreArchivo, List<T> lista)
        {
            if (lista == null || lista.Count == 0)
                return;

            using (StreamWriter writer = new StreamWriter(nombreArchivo+".csv", false, Encoding.UTF8))
            {
                if (typeof(T) == typeof(string))
                {
                    foreach (T item in lista)
                    {
                        writer.WriteLine(item);
                    }
                }
                else
                {
                    Type tipoObjeto = typeof(T);
                    PropertyInfo[] propiedades = tipoObjeto.GetProperties();

                    string encabezados = string.Join(",", propiedades.Select(p => p.Name));
                    writer.WriteLine(encabezados);

                    foreach (T objeto in lista)
                    {
                        string linea = string.Join(",", propiedades.Select(p => p.GetValue(objeto)?.ToString() ?? ""));
                        writer.WriteLine(linea);
                    }
                }
            }
        }
        #region Control Venta
        public static void CrearVenta(string presuId,string cliente,string numeroTarjeta, string cuotas,string precioFinal,string usuario)
        {
            if(!String.IsNullOrEmpty(presuId) && !String.IsNullOrEmpty(cliente) && !String.IsNullOrEmpty(numeroTarjeta) && !String.IsNullOrEmpty(cuotas) && !String.IsNullOrEmpty(precioFinal) && !String.IsNullOrEmpty(usuario))
            {
                BaseDatos.AgregarVenta(new(presuId, cliente, numeroTarjeta,cuotas, precioFinal, usuario));
                _ventas = BaseDatos.ObtenerVentas();
            }
        }
        #endregion
        #region Control Presupuesto
        public static Presupuesto BuscarPresupuesto(string id)
        {
            if(!String.IsNullOrEmpty(id))
                return BaseDatos.BuscarPresupuesto(id);
            throw new Exception("Presupuesto no encontrado");
  
        }
        public static string MostrarProductosPresupuesto(List<Producto> lista)
        {
            StringBuilder sb = new StringBuilder();
            if(lista != null)
            {
                double precio = 0;

                foreach(Producto producto in lista)
                {
                    precio += producto.Precio;
                    sb.AppendLine($"{producto.Nombre} - ${producto.Precio}");
                }
                sb.AppendLine($"\n\n Total     ------------------------    ${precio}");
            }

            return sb.ToString();
        }
        public static void AgregarProductoAlPresupuesto(Producto producto)
        {
            if (producto != null)
                _presupuesto.Add(producto);
        }
        public static string CrearPresupuesto(double precio)
        {
            Presupuesto nuevoPresupuesto = new Presupuesto(_presupuesto, precio);
            _solicitudPresupuesto.Add(nuevoPresupuesto);

            int id = BaseDatos.AgregarPresupuestoNuevo(nuevoPresupuesto);

            return id.ToString();
        }
        public static void EliminarProductoPresupuesto(Producto producto)
        {

            if(producto != null)
            {
                Producto productoEliminar = null!;

                foreach(Producto auxProducto in _presupuesto)
                {
                    if(auxProducto.Equals(producto))
                    {
                        productoEliminar = auxProducto;
                    }
                }
                if(productoEliminar != null)
                    _presupuesto.Remove(productoEliminar);
            }
        }
        #endregion
        #region Control Clientes
        public static void AltaCliente(string nombre,string apellido,string dni,string edad, string direccion,string telefono,string correo)
        {
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(direccion) && !String.IsNullOrEmpty(telefono) && !String.IsNullOrEmpty(correo))
            {
                if (double.TryParse(dni, out double _dni) && int.TryParse(edad, out int _edad))
                {
                    Cliente nuevoCliente = new(nombre, apellido, _dni, _edad, direccion, telefono, correo);
                    BaseDatos.AgregarCliente(nuevoCliente);
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
        public static void BajaCliente(string dni)
        {
            Cliente CBuscado = BaseDatos.BuscarCliente(dni);
            BaseDatos.EliminarCliente(CBuscado); 
        }
        public static void ModificarCliente(Cliente clienteViejo,string nombre, string apellido, string dni, string edad, string direccion, string telefono, string correo)
        {
            if(clienteViejo != null && !String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(direccion) && !String.IsNullOrEmpty(telefono) && !String.IsNullOrEmpty(correo) && double.TryParse(dni, out double _dni) && int.TryParse(edad, out int _edad))
            {
                Cliente clienteMod = new(nombre, apellido, _dni, _edad, direccion, telefono,correo);
                BaseDatos.ModificarCliente(clienteMod, clienteViejo.Dni.ToString());
            }
            else
            {
                throw new Exception("Datos incorrecto o mal cargados");
            }
        }
        #endregion
        #region Control Productos
        public static Producto BuscarProducto(string nombre)
        {
            if(!String.IsNullOrEmpty(nombre))
            {
                return BaseDatos.BuscarProducto(nombre);
            }
            else
            {
                throw new Exception("Producto no encontrado");
            }
        }
        public static List<Producto> FiltrarProductos(string categoria)
        {
            List<Producto> productosFiltrados = new List<Producto>();

            foreach (Producto producto in _productos)
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
                ECategoria _categoria = (ECategoria)Enum.Parse(typeof(ECategoria), categoria, true);
                if (double.TryParse(precio, out double price) && int.TryParse(stock, out int stockCantidad))
                {
                    return new Producto(nombre, marca, price, _categoria, stockCantidad);
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
                foreach(Producto item in _productos)
                {
                    if(item != producto)
                        check = true;
                }

                if(check)
                {
                    BaseDatos.AgregarProducto(producto);
                    _productos = BaseDatos.ObtenerProductos();
                }
                else
                    throw new Exception("Producto ya existe en listado");
            }
        }
        public static void SacarStockProducto(Producto producto)
        {
            if (producto != null)
            {
                int stock = producto.Stock - 1;
                BaseDatos.ModificarStockProducto(producto, stock);
            }
        }
        public static void EliminarProducto(string nombre)
        {
            if(!String.IsNullOrEmpty(nombre))
            {
                Producto productoEliminado = BaseDatos.BuscarProducto(nombre);
                BaseDatos.EliminarProducto(productoEliminado);
                _productos.Remove(productoEliminado);

            }
            else
            {
                throw new Exception("Producto no encontrado");
            }
        }
        public static void SolicitarStock(string nombre)
        {
            if (!String.IsNullOrEmpty(nombre))
            {
                foreach (Producto producto in _productos)
                {
                    if (producto.Nombre == nombre)
                    {
                        _solcitudes.Add(producto);
                    }
                }
            }
        }
        public static void AgregarStock(string nombre, string stock)
        {
            if (!String.IsNullOrEmpty(nombre) && int.TryParse(stock, out int cantidad))
            {
                Producto producto = BaseDatos.BuscarProducto(nombre);
                BaseDatos.ModificarStockProducto(producto, cantidad);
                foreach(Producto p in _solcitudes)
                {
                    if(p.Nombre == producto.Nombre)
                    {
                        _solcitudes.Remove(p);
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("Dato mal cargado");
            }
        }
        #endregion
    }
}
