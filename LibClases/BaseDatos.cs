using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace LibClases
{
    public static class BaseDatos
    {
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string _connectionString;
        private static SqlDataReader? reader;

        private static List<string> _presupuestosProductosID = new List<string>();
        
        static BaseDatos()
        {
            _connectionString = @"Server = DESKTOP-U0AEOQ5; Database = PCMarkerDB; Trusted_Connection = True;";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
        }
        #region Logs        
        public static void CrearRegistro(string mensaje)
        {
            
            try
            {
                _connection.Open();
                _command.CommandText = "INSERT INTO Logs (Registro) VALUES (@mensaje)";

                _command.Parameters.AddWithValue("@mensaje", mensaje);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static List<string> ObtenerRegistros()
        {
            List<string> lista = new List<string>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Logs";

            reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string registro = reader.GetString(0);

                lista.Add(new(registro));
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            return lista;
        }
        #endregion
        #region Presupuestos
        public static void ObtenerIDPresupuestos()
        {
            _connection.Open();
            _command.CommandText = "SELECT * FROM PresupuestoProducto";
            reader = _command.ExecuteReader();

            _presupuestosProductosID.Clear();

            while (reader.Read())
            {
                int presupuestoID = reader.GetInt32(0);
                int productoID = reader.GetInt32(1);

                _presupuestosProductosID.Add($"{presupuestoID},{productoID}");
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        public static List<Presupuesto> ObtenerPresupuestos()
        {
            List<Presupuesto> lista = new List<Presupuesto>();

            ObtenerIDPresupuestos();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Presupuestos";

            reader = _command.ExecuteReader();

            while(reader.Read())
            {
                Presupuesto presupuestoActual;
                List<Producto> productos = new List<Producto>();

                string id = reader.GetInt32(0).ToString();

                foreach (string ids in _presupuestosProductosID)
                {
                    string[] columna = ids.Split(",");

                    string presupuestoID = columna[0];
                    string productoID = columna[1];

                    if(presupuestoID.ToString() == id)
                    {
                        foreach(Producto p in PCMaker.Productos)
                        {
                            if(p.Id == productoID.ToString())
                            {
                                productos.Add(new(p.Id, p.Nombre, p.Marca, p.Precio, p.Categoria, p.Stock));
                                break;
                            }
                        }
                    }
                }

                double precio = Convert.ToDouble(reader.GetDecimal(2));

                presupuestoActual = new(id,productos, precio);
                presupuestoActual.Estado = (EEstados)Enum.Parse(typeof(EEstados), reader.GetString(1), true);

                lista.Add(presupuestoActual);
            }
            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            return lista;
        }
        public static Presupuesto BuscarPresupuesto(string id)
        {
            try
            {
                
                string presupuestoId = "";
                EEstados estado = EEstados.Revision;
                double precio = 0;
                List<Producto> productosPresupuesto = new List<Producto>();

                _connection.Open();
                _command.CommandText = "SELECT P.*, Pr.* " +
                                       "FROM PresupuestoProducto PP, Presupuestos P, Productos PR " +
                                       "WHERE P.Presupuesto_ID = PP.Presupuesto_ID " +
                                       $"and PR.Producto_ID = PP.Producto_ID and PP.Presupuesto_ID = @id";

                _command.Parameters.AddWithValue("@id", id);

                reader = _command.ExecuteReader();

                while (reader.Read())
                {
                    presupuestoId = reader.GetInt32(0).ToString();
                    estado = (EEstados)Enum.Parse(typeof(EEstados), reader.GetString(1), true);
                    precio = Convert.ToDouble(reader.GetDecimal(2));

                    string productoId = reader.GetDecimal(3).ToString();
                    string nombre = reader.GetString(4);
                    string marca = reader.GetString(5);
                    double productoPrecio = Convert.ToDouble(reader.GetDecimal(6));
                    ECategoria categoria = (ECategoria)Enum.Parse(typeof(ECategoria), reader.GetString(7), true);
                    int stock = reader.GetInt32(8);

                    productosPresupuesto.Add(new(productoId, nombre, marca, productoPrecio, categoria, stock));
                }

                reader.Close();
                Presupuesto presupuesto = new(presupuestoId, productosPresupuesto, precio);
                presupuesto.Estado = estado;

                return presupuesto;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }            
        }
        public static void ModificarEstadoPresupuesto(Presupuesto presupuesto)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "UPDATE Presupuestos SET Estado = @estado " +
                                       "WHERE Presupuesto_ID = @id";

                _command.Parameters.AddWithValue("@estado", presupuesto.Estado);
                _command.Parameters.AddWithValue("@id", presupuesto.Id);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static int AgregarPresupuestoNuevo(Presupuesto presupuesto)
        {
            try
            {
                _connection.Open();

                string queryPresupuesto = "INSERT INTO Presupuestos (Estado, Precio) " +
                                          "VALUES (@Estado, @Precio);" +
                                          "SELECT SCOPE_IDENTITY();";

                SqlCommand commandPresupuesto = new SqlCommand(queryPresupuesto, _connection);
                commandPresupuesto.Parameters.AddWithValue("@Estado", presupuesto.Estado.ToString());
                commandPresupuesto.Parameters.AddWithValue("@Precio", presupuesto.Precio);

                int presupuestoID = Convert.ToInt32(commandPresupuesto.ExecuteScalar());

                string queryProducto = "INSERT INTO PresupuestoProducto (Presupuesto_ID, Producto_ID) " +
                                       "VALUES (@PresupuestoID, @ProductoID)";

                SqlCommand commandProducto = new SqlCommand(queryProducto, _connection);

                foreach (Producto producto in presupuesto.Productos)
                {
                    commandProducto.Parameters.Clear();
                    commandProducto.Parameters.AddWithValue("@PresupuestoID", presupuestoID);
                    commandProducto.Parameters.AddWithValue("@ProductoID", producto.Id);
                    commandProducto.ExecuteNonQuery();
                }

                return presupuestoID;
            } 
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        #endregion
        #region Ventas
        public static List<Venta> ObtenerVentas()
        {
            List<Venta> lista = new List<Venta>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Ventas";
            reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string presuID = reader.GetInt32(0).ToString();
                string clienteDNI = reader.GetDecimal(1).ToString();
                string tarjetaNumero = reader.GetString(2);
                string cuotas = reader.GetString(3);
                string ganancias = reader.GetString(4);
                string usuario = reader.GetString(5);

                lista.Add(new(presuID, clienteDNI, tarjetaNumero, cuotas, ganancias, usuario));
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            return lista;
        }
        public static void AgregarVenta(Venta venta)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "INSERT INTO Ventas (Presupuesto_ID, Cliente_DNI, TarjetaNumero, Cuotas, Ganancia, Usuario_User) "+
                                       "VALUES (@PresupuestoID, @ClienteDNI, @NumeroTarjeta, @Cuotas, @Ganancias,@Usuario)";

                _command.Parameters.AddWithValue("@PresupuestoID", Convert.ToInt32(venta.PresupuestoId));
                _command.Parameters.AddWithValue("@ClienteDNI", Convert.ToDecimal(venta.Cliente));
                _command.Parameters.AddWithValue("@NumeroTarjeta", venta.TarjetaNumero);
                _command.Parameters.AddWithValue("@Cuotas", venta.Cuotas);
                _command.Parameters.AddWithValue("@Ganancias", venta.Ganancia);
                _command.Parameters.AddWithValue("@Usuario", venta.Usuario);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        #endregion
        #region Productos ABM
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Productos";
            reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetDecimal(0).ToString();
                string nombre = reader.GetString(1);
                string marca = reader.GetString(2);
                double precio = Convert.ToDouble(reader.GetDecimal(3));
                ECategoria categoria = (ECategoria)Enum.Parse(typeof(ECategoria), reader.GetString(4), true);
                int stock = reader.GetInt32(5);

                lista.Add(new(id, nombre, marca, precio, categoria, stock));
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            return lista;
        }
        public static void AgregarProducto(Producto producto)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "INSERT INTO Productos (Nombre, Marca, Precio, categoria, Stock) "+
                                       "VALUES (@nombre, @marca, @precio, @categoria, @stock)";

                _command.Parameters.AddWithValue("@nombre", producto.Nombre);
                _command.Parameters.AddWithValue("@marca", producto.Marca);
                _command.Parameters.AddWithValue("@precio", producto.Precio);
                _command.Parameters.AddWithValue("@categoria", producto.Categoria.ToString());
                _command.Parameters.AddWithValue("@stock", producto.Stock);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static void EliminarProducto(Producto producto)
        {
            try
            {
                _connection.Open();
                _command.CommandText = $"DELETE Productos WHERE Producto_ID = {producto.Id}";

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static void ModificarStockProducto(Producto producto, int stock)
        {
            try
            {
                _connection.Open();
                _command.CommandText = $"UPDATE Productos SET Stock = @stock WHERE Producto_ID = @id";

                _command.Parameters.AddWithValue("@stock", stock);
                _command.Parameters.AddWithValue("@id", producto.Id);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            
        }
        public static Producto BuscarProducto(string nombre)
        {
            Producto productoBuscado = null!;

            _connection.Open();
            _command.CommandText = $"SELECT * FROM Productos WHERE Nombre = @nombre";
            _command.Parameters.AddWithValue("@nombre", nombre);

            reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetDecimal(0).ToString();
                string _nombre = reader.GetString(1);
                string marca = reader.GetString(2);
                double precio = Convert.ToDouble(reader.GetDecimal(3));
                ECategoria categoria = (ECategoria)Enum.Parse(typeof(ECategoria), reader.GetString(4), true);
                int stock = reader.GetInt32(5);

                if(_nombre == nombre)
                {
                    productoBuscado = new(id, _nombre, marca, precio, categoria, stock);
                    break;
                }
            }
            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            return productoBuscado;
        }
        #endregion
        #region Usuarios ABM
        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Usuarios";

            reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                string usuario = reader.GetString(2);
                string contraseña = reader.GetString(3);
                ERoles rol = (ERoles)Enum.Parse(typeof(ERoles), reader.GetString(4), true);
                string correo = reader.GetString(5);

                lista.Add(new(nombre, apellido, usuario, contraseña, rol, correo));
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            return lista;
        }
        public static void AgregarUsuario(Usuario usuarioNuevo)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "INSERT INTO Usuarios (Nombre, Apellido, Usuario, Contraseña, Rol, Correo) "+ 
                                       "VALUES (@nombre, @Apellido, @usuario, @contraseña, @rol, @correo)";

                _command.Parameters.AddWithValue("@nombre", usuarioNuevo.Nombre);
                _command.Parameters.AddWithValue("@Apellido", usuarioNuevo.Apellido);
                _command.Parameters.AddWithValue("@usuario", usuarioNuevo.User);
                _command.Parameters.AddWithValue("@contraseña", usuarioNuevo.Contraseña);
                _command.Parameters.AddWithValue("@rol", usuarioNuevo.Rol.ToString());
                _command.Parameters.AddWithValue("@correo", usuarioNuevo.Correo);

                _command.ExecuteNonQuery();

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static void EliminarUsuario(Usuario usuario)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "DELETE Usuarios WHERE Usuario = @usuario";

                _command.Parameters.AddWithValue("@usuario", usuario.User);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static Usuario BuscarUsuario(string usuario)
        {
            Usuario usuarioBuscado = null!;

            _connection.Open();

            _command.CommandText = "SELECT * FROM Usuarios";
            reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                string user = reader.GetString(2);
                string contraseña = reader.GetString(3);
                ERoles rol = (ERoles)Enum.Parse(typeof(ERoles), reader.GetString(4), true);
                string correo = reader.GetString(5);

                if(user == usuario)
                {
                    usuarioBuscado = new(nombre, apellido, user, contraseña, rol, correo);
                    break;
                }
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            if (usuarioBuscado != null)
                return usuarioBuscado;
            else
                throw new Exception("Usuario no encontrado");
        }
        public static void ModificarUsuario(Usuario usuarioMod, string usuario)
        {
            try
            {

                _connection.Open();

                _command.CommandText = "UPDATE Usuarios SET Nombre = @nombre, Apellido = @apellido, Correo = @correo, Usuario = @nuevoUser, " +
                                       "Contraseña = @contraseña, Rol = @rol WHERE Usuario = @usuario";

                _command.Parameters.AddWithValue("@nombre", usuarioMod.Nombre);
                _command.Parameters.AddWithValue("@Apellido", usuarioMod.Apellido);
                _command.Parameters.AddWithValue("@correo", usuarioMod.Correo);
                _command.Parameters.AddWithValue("@nuevoUser", usuarioMod.User);
                _command.Parameters.AddWithValue("@contraseña", usuarioMod.Contraseña);
                _command.Parameters.AddWithValue("@rol", usuarioMod.Rol.ToString());

                _command.Parameters.AddWithValue("@usuario", usuario);

                _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static void ModificarUsuario(Usuario usuario)
        {
            try
            {
                _connection.Open();

                _command.CommandText = "UPDATE Usuarios SET Nombre = @nombre, Apellido = @apellido, Correo = @correo WHERE Usuario = @usuario";

                _command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                _command.Parameters.AddWithValue("@Apellido", usuario.Apellido);;
                _command.Parameters.AddWithValue("@correo", usuario.Correo);
                _command.Parameters.AddWithValue("@usuario", usuario.User);

                _command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static void ModificarUsuario(string usuario, string nuevaContraseña)
        {
            try
            {
                _connection.Open();

                _command.CommandText = "UPDATE Usuarios SET Contraseña = @contraseña WHERE Usuario = @usuario";

                _command.Parameters.AddWithValue("@contraseña", nuevaContraseña);
                _command.Parameters.AddWithValue("@usuario", usuario);
                _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        #endregion
        #region Clientes ABM
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            _connection.Open();
            _command.CommandText = "SELECT * FROM Clientes";
            reader = _command.ExecuteReader();

            while (reader.Read())
            {

                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                double dni = Convert.ToDouble(reader.GetDecimal(2));
                int edad = reader.GetInt32(3);
                string direccion = reader.GetString(4);
                string telefono = reader.GetString(5);
                string correo = reader.GetString(6);


                lista.Add(new(nombre, apellido, dni, edad, direccion, telefono, correo));
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            return lista;
        }
        public static void AgregarCliente(Cliente cliente)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "INSERT INTO Clientes (Nombre, Apellido, Dni, Edad, Direccion, Telefono, Correo) "+
                                       "VALUES (@nombre, @Apellido,@Dni, @Edad, @Direccion, @Telefono, @correo)";

                _command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                _command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                _command.Parameters.AddWithValue("@Dni", cliente.Dni);
                _command.Parameters.AddWithValue("@Edad", cliente.Edad);
                _command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                _command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                _command.Parameters.AddWithValue("@correo", cliente.Correo);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static Cliente BuscarCliente(string dni)
        {
            Cliente clienteBuscado = null!;

            _connection.Open();

            _command.CommandText = "SELECT * FROM Clientes";
            reader = _command.ExecuteReader();

            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                double _dni = Convert.ToDouble(reader.GetDecimal(2));
                int edad = reader.GetInt32(3);
                string direccion = reader.GetString(4);
                string telefono = reader.GetString(5);
                string correo = reader.GetString(6);

                if (_dni.ToString() == dni)
                {
                    clienteBuscado = new(nombre, apellido, _dni, edad, direccion,telefono, correo);
                    break;
                }
            }

            reader.Close();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            if (clienteBuscado != null)
                return clienteBuscado;
            else
                throw new Exception("Usuario no encontrado");
        }
        public static void EliminarCliente(Cliente cliente)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "DELETE Clientes WHERE Dni = @dni";

                _command.Parameters.AddWithValue("@dni", cliente.Dni);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        public static void ModificarCliente(Cliente cliente,string dni)
        {
            try
            {
                _connection.Open();
                _command.CommandText = "UPDATE Clientes SET Nombre = @nombre, Apellido = @Apellido,Dni = @Dni, Edad = @Edad, "+
                                       "Direccion = @Direccion, Telefono = @Telefono, Correo = @correo " +
                                       $"WHERE Dni = @_dni";

                _command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                _command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                _command.Parameters.AddWithValue("@Dni", cliente.Dni);
                _command.Parameters.AddWithValue("@Edad", cliente.Edad);
                _command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                _command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                _command.Parameters.AddWithValue("@correo", cliente.Correo);

                _command.Parameters.AddWithValue("@_dni", dni);

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Parameters.Clear();

                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        #endregion
    }
}


