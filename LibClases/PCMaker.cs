namespace LibClases
{
    public static class PCMaker
    {

        private static List<Producto> _productos = new List<Producto>();
        private static List<Producto> _solcitudes = new List<Producto>();
        private static List<Cliente> _clientes = new List<Cliente>();

        public static List<Producto> Productos { get => _productos; }
        public static List<Producto> Solicitudes { get => _solcitudes; }
        public static List<Cliente> Clientes { get => _clientes; }


        public static void Cargar()
        {
            _productos = BaseDatos.CargarArchivoProductos();
            _clientes = BaseDatos.CargarArchivoClientes();
        }
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
                    if( cliente2.Equals(cliente))
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
