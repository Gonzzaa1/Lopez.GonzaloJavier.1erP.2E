
using System.Text;

namespace LibClases
{
    public static class PCMaker
    {
        private static List<Producto> _productos = new List<Producto>();
        private static List<Producto> _solcitudes = new List<Producto>();
        private static List<Cliente> _clientes = new List<Cliente>();
        private static List<Producto> _presupuesto = new List<Producto>();
        private static List<Presupuesto> _solicitudPresupuesto = new List<Presupuesto>();
        private static List<Venta> _ventas = new List<Venta>();

        public static List<Producto> Productos { get => _productos; }
        public static List<Producto> Solicitudes { get => _solcitudes; }
        public static List<Cliente> Clientes { get => _clientes; }
        public static List<Producto> Presupuesto { get => _presupuesto; }
        public static List<Presupuesto> SolPresupuesto { get => _solicitudPresupuesto; }
        public static List <Venta> Ventas { get => _ventas; }

        public static void Cargar()
        {
            _productos = BaseDatos.CargarArchivoProductos();
            _clientes = BaseDatos.CargarArchivoClientes();
            _solicitudPresupuesto = BaseDatos.CargarArchivoPresupuesto();
            _ventas = BaseDatos.CargarArchivoVentas();
        }
        #region Control Venta
        public static void CrearVenta(string presuId,string cliente,string numeroTarjeta, string cuotas,string precioFinal,string usuario)
        {
            if(!String.IsNullOrEmpty(presuId) && !String.IsNullOrEmpty(cliente) && !String.IsNullOrEmpty(numeroTarjeta) && !String.IsNullOrEmpty(cuotas) && !String.IsNullOrEmpty(precioFinal) && !String.IsNullOrEmpty(usuario))
            {
                _ventas.Add(new(presuId, cliente, numeroTarjeta,cuotas, precioFinal, usuario));
            }
        }
        #endregion
        #region Control Presupuesto
        public static Presupuesto BuscarPresupuesto(string id)
        {
            if(!String.IsNullOrEmpty(id))
            {
                foreach(Presupuesto presupuesto in _solicitudPresupuesto)
                {
                    if(presupuesto.Id == id)
                    { 
                        return presupuesto; 
                    }
                }
            }
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
            Presupuesto nuevoPresupuesto = new Presupuesto(GeneradorId("numero"), _presupuesto,precio);
            _solicitudPresupuesto.Add(nuevoPresupuesto);

            return nuevoPresupuesto.Id;
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
                    _clientes.Add(new(nombre, apellido, _dni, _edad, direccion, telefono,correo));
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
        public static void BajaCliente(Cliente cliente)
        {
            if(cliente != null)
            {

                Cliente auxCliente =null!;

                foreach(Cliente cliente2 in _clientes)
                {
                    if(cliente2.Equals(cliente))
                    {
                        auxCliente = cliente;
                    }
                }
                _clientes.Remove(auxCliente);
            }
        }
        public static void ModificarCliente(Cliente clienteViejo,string nombre, string apellido, string dni, string edad, string direccion, string telefono, string correo)
        {
            if(clienteViejo != null && !String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(direccion) && !String.IsNullOrEmpty(telefono) && !String.IsNullOrEmpty(correo) && double.TryParse(dni, out double _dni) && int.TryParse(edad, out int _edad))
            {     
                foreach (Cliente cliente in _clientes)
                {
                    if(cliente.Equals(clienteViejo))
                    {
                        cliente.Nombre = nombre;
                        cliente.Apellido = apellido;
                        cliente.Dni = _dni;
                        cliente.Edad = _edad;
                        cliente.Direccion = direccion;
                        cliente.Telefono = telefono;
                        cliente.Correo = correo;
                    }
                }
            }
            else
            {
                throw new Exception("Datos incorrecto o mal cargados");
            }
        }
        public static Cliente BuscarCliente(string dni)
        {
            if(int.TryParse(dni, out int _dni))
            {
                foreach(Cliente cliente in _clientes)
                {
                    if(cliente.Dni == _dni)
                    {
                        return cliente;
                    }
                }
                throw new Exception("Cliente no encontrado");
            }
            else
            {
                throw new Exception("Cliente no encontrado");
            }
        }
        #endregion
        #region Control Productos
        public static Producto BuscarProductoId(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                Producto productoBuscado = null!;
                foreach (Producto producto in _productos)
                {
                    if (producto.Id == id)
                    {
                        productoBuscado = producto;
                    }
                }
                return productoBuscado;
            }
            else
            {
                throw new Exception("Producto no encontrado");
            }
        }
        public static Producto BuscarProducto(string nombre)
        {
            if(!String.IsNullOrEmpty(nombre))
            {
                Producto productoBuscado = null!;
                foreach(Producto producto in _productos)
                {
                    if(producto.Nombre == nombre)
                    {
                        productoBuscado = producto;
                    }
                }
                return productoBuscado;
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
                if(double.TryParse(precio, out double price) && int.TryParse(stock, out int stockCantidad))
                {
                    return new Producto(GeneradorId("alfanumerico"), nombre, marca, price, BaseDatos.ParsearCategoria(categoria), stockCantidad);
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
                    _productos.Add(producto);
                else
                    throw new Exception("Producto ya existe en listado");
            }
        }
        public static void SacarStockProducto(Producto producto)
        {
            if (producto != null)
            {
                
                foreach (Producto item in _productos)
                {
                    if(item == producto)
                    {
                        item.Stock -= 1;
                    }
                }
            }
        }
        public static void EliminarProducto(string id)
        {
            if(!String.IsNullOrEmpty(id))
            {
                Producto productoEliminado = null!;

                foreach(Producto item in _productos)
                {
                    if(item.Id == id)
                    {
                        productoEliminado = item;
                    }
                }

                _productos.Remove(productoEliminado);
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
                foreach (Producto producto in _productos)
                {
                    if (producto.Id == id)
                    {
                        _solcitudes.Add(producto);
                    }
                }
            }
        }
        public static void AgregarStock(string id, string stock)
        {
            if (!String.IsNullOrEmpty(id) && int.TryParse(stock, out int cantidad))
            {

                foreach(Producto producto in _productos)
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
        #endregion
        private static string GeneradorId(string tipo)
        {
            Random random = new Random();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string numeros = "0123456789";
            var clave = new char[16];

            switch(tipo)
            {
                case "alfanumerico":
                    for (int i = 0; i < clave.Length; i++)
                    {
                        clave[i] = caracteres[random.Next(caracteres.Length)];
                    }
                    break;
                case "numero":
                    for (int i = 0; i < clave.Length; i++)
                    {
                        clave[i] = numeros[random.Next(numeros.Length)];
                    }
                    break;
            }

            string resultado = new string(clave);

            return resultado;
        }

    }
}
