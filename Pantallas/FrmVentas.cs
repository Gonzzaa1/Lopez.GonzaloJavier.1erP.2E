using LibClases;

namespace Pantallas
{
    public partial class FrmVentas : Form
    {
        private int producto = 1995;
        private bool _presupuesto;
        private bool _venta;
        private bool _estado;
        private bool _solicitudes;
        private double _precioPresupuesto = 0;
        private FrmVentas()
        {
            InitializeComponent();
        }
        public FrmVentas(bool presupuesto,bool venta, bool estado,bool solicitudes):this()
        {
            _presupuesto = presupuesto;
            _venta = venta;
            _estado = estado;
            _solicitudes = solicitudes;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            pnCliente.Visible = false;
            if(_presupuesto)
            {
                pnlVenta.Visible = false;
                pnlFactura.Visible = false;
                pnlSolicitudes.Visible = false;
                pnPerifericos.Visible = false;
                lblCategoria.Text = "Microprocesador";
                rtbInfo.Text = "Tu procesador es la pieza central del rendimiento de los programas. Para saber si un procesador es potente lo que tenés que medir es la frecuencia, el ancho de bus, la memoria caché y los núcleos e hilos de procesamiento.";
                LlenarLista(lblCategoria.Text, "Intel");
            }
            else if(_venta)
            {
                pnPresupuesto.Visible = false;
                pnlVenta.Visible = true;
                pnlFactura.Visible = false;
                pnlSolicitudes.Visible = false;
                pnlDatosVenta.Visible = false;
                pnDatosCVenta.Visible = false;
                pnlFinal.Visible = false;
                ListarTarjetas();
                lblMontoEnCuotas.Text = String.Empty;

            }
            else if(_estado)
            {
                pnPresupuesto.Visible = false;
                pnlVenta.Visible = false;
                pnlFactura.Visible = false;
                pnlSolicitudes.Visible = true;
                btnAprobar.Visible = false;
                btnRechazar.Visible = false;
                dgvSolicitudes.Visible = false;
            }
            else if(_solicitudes)
            {
                pnPresupuesto.Visible = false;
                pnlVenta.Visible = false;
                pnlFactura.Visible = false;
                pnlSolicitudes.Visible = true;
                lblId.Text = String.Empty;
                lblEstadoPresupuesto.Text = String.Empty;
                dgvSolicitudes.DataSource = null;
                dgvSolicitudes.DataSource = PCMaker.SolPresupuesto;
                dgvSolicitudes.Columns[1].Visible = false;

            }
        }

        private void cbProcesador_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = true;
            pnPerifericos.Visible=false;
            lblCategoria.Text = "Microprocesador";
            rtbInfo.Text = "Tu procesador es la pieza central del rendimiento de los programas. Para saber si un procesador es potente lo que tenés que medir es la frecuencia, el ancho de bus, la memoria caché y los núcleos e hilos de procesamiento.";
            LlenarLista(lblCategoria.Text, "Intel");

        }

        private void cbMother_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Motherboard";
            rtbInfo.Text = "Es donde se conectarán todos los componentes de tu PC. Según el modelo que elijas tendrás diferentes beneficios de conectividad y expansión.";
            LlenarLista();
        }

        private void cbCooler_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Cooler";
            rtbInfo.Text = "El cooler mantiene la temperatura de tu equipo, evitando el daño en los componentes y permitiendo que este funcione correctamente.";
            LlenarLista();
        }

        private void cbMemoria_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Memorias";
            rtbInfo.Text = "Las memorias sirven para cargar y almacenar todas las instrucciones que se ejecutan en el procesador. Lo que se debe tener en cuenta en esta sección es el tamaño, la frecuencia y la cantidad de módulos.";
            LlenarLista("MemoriaRam");
        }

        private void cbGpu_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Placa de Video";
            rtbInfo.Text = "El procesador gráfico de una tarjeta es muchísimo más potente que el que tienen los procesadores, por esta razón es necesaria para el buen funcionamiento del equipo y muy recomendada para gamers y profesionales de los gráficos.";
            LlenarLista("GPU");
        }

        private void cbAlmacenamiento_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Almacenamiento";
            rtbInfo.Text = "Acá es donde se guardarán tus documentos. Se debe tener en cuenta el tamaño y la velocidad. Las unidades SSD son más veloces y pueden ser utilizadas como unidad principal de almacenamiento o como un complemento de un almacenamiento HDD.";
            LlenarLista("Disco");
        }

        private void cbFuente_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Fuente";
            rtbInfo.Text = "La fuente es la encargada de alimentar al resto de los componentes y va a ser uno de los factores a tener en cuenta si querés armar una pc potente.";
            LlenarLista();
        }

        private void cbGabinete_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Gabinete";
            rtbInfo.Text = "Es fundamental para el armado de la pc ya que contendrá todos los componentes funcionales de la misma.";
            LlenarLista();
        }

        private void cbMonitor_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Monitor";
            rtbInfo.Text = "El monitor es fundamental si querés disfrutar de tus juegos y peliculas favoritas.";
            LlenarLista();
        }

        private void cbPerifericos_Click(object sender, EventArgs e)
        {
            pnMarcas.Visible = false;
            pnPerifericos.Visible = true;
            lblCategoria.Text = "Perifericos";
            rtbInfo.Text = "Mouses, Teclados, Auriculares y mas.";
            pnPerifericos.Visible = true;
            LlenarLista("Auriculares");
        }

        private void lblCategoria_TextChanged(object sender, EventArgs e)
        {
            if(lblCategoria.Text == "Microprocesador")
            {
                lblProducto.Visible = true;
                lblProducto.Text = "Intel";
            }
            else if(lblCategoria.Text == "Perifericos")
            {
                lblProducto.Visible = true;
                lblProducto.Text = "Auriculares";
            }
            else
            {
                lblProducto.Visible = false;
            }
        }

        private void btnIntel_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "Intel";
            LlenarLista(lblCategoria.Text, "Intel");
        }

        private void btnAmd_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "AMD";
            LlenarLista(lblCategoria.Text, "AMD");
        }
        private void LlenarLista()
        {
            cbLista.Text = String.Empty;
            cbLista.Items.Clear();
            foreach (Producto producto in PCMaker.Productos)
            {
                if (producto.Categoria.ToString() == lblCategoria.Text)
                {
                    if (!cbLista.Items.Contains(producto.Nombre) && producto.Stock > 0)
                        cbLista.Items.Add(producto.Nombre);
                }
            }
        }
        private void LlenarLista(string categoria)
        {
            cbLista.Text = String.Empty;
            cbLista.Items.Clear();
            foreach (Producto producto in PCMaker.Productos)
            {
                if (producto.Categoria.ToString() == categoria)
                {
                    if (!cbLista.Items.Contains(producto.Nombre) && producto.Stock > 0)
                        cbLista.Items.Add(producto.Nombre);
                }
            }
        }
        private void LlenarLista(string categoria, string marca)
        {
            cbLista.Text = String.Empty;
            cbLista.Items.Clear();
            foreach (Producto producto in PCMaker.Productos)
            {
                if (producto.Categoria.ToString() == categoria)
                {
                    if (producto.Marca == marca)
                    {
                        if (!cbLista.Items.Contains(producto.Nombre) && producto.Stock > 0)
                            cbLista.Items.Add(producto.Nombre);
                    }
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(lblMonto.Text);
            try
            {
                Producto producto = PCMaker.BuscarProducto(cbLista.Text.ToString());
                dgvProductos.Rows.Add(producto.Nombre);
                PCMaker.AgregarProductoAlPresupuesto(producto);
                _precioPresupuesto += producto.Precio;
                lblMonto.Text = _precioPresupuesto.ToString();
                cbLista.Text = String.Empty;
                dgvProductos.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Algo salio mal");
            }
        }

        private void cbLista_TextChanged(object sender, EventArgs e)
        {
            if (cbLista.Text != String.Empty)
            {
                foreach (Producto producto in PCMaker.Productos)
                {
                    if (producto.Nombre == cbLista.Text)
                    {
                        rtbInfoProducto.Text = producto.ToString();
                    }
                }
            }
            else
            {
                rtbInfoProducto.Text = String.Empty;
            }
        }

        private void btnAuris_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "Auriculares";
            LlenarLista("Auriculares");
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "Teclado";
            LlenarLista("Teclado");
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "Mouse";
            LlenarLista("Mouse");
        }

        private void btnCamaras_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "CamaraWeb";
            LlenarLista("CamaraWeb");
        }

        private void btnParlantes_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "Parlantes";
            LlenarLista("Parlantes");
        }

        private void btnMicrofono_Click(object sender, EventArgs e)
        {
            lblProducto.Text = "Microfono";
            LlenarLista("Microfono");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(producto != 1995)
            {
                double precio = Convert.ToDouble(lblMonto.Text);
                string nombre = (string)dgvProductos.CurrentCell.Value;
                Producto aux = PCMaker.BuscarProducto(nombre);
                _precioPresupuesto -= aux.Precio;
                lblMonto.Text = _precioPresupuesto.ToString();
                dgvProductos.Rows.RemoveAt(producto);
                PCMaker.EliminarProductoPresupuesto(aux);
                dgvProductos.ClearSelection();
                producto = 1995;
            }
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(producto == 1995)
                producto = dgvProductos.CurrentRow.Index;
        }

        private void btnGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            if(dgvProductos.Rows.Count != 0)
            {
                lblPresupuestoID.Text =  PCMaker.CrearPresupuesto(_precioPresupuesto);
                dgvProductos.Rows.Clear();
                _precioPresupuesto = 0;
                lblMonto.Text = "0";
                MessageBox.Show($"Presupuesto N° {lblPresupuestoID.Text} Creado");
                pnPresupuesto.Visible = false;
                pnCliente.Visible = true;
                
            }
            else
            {
                MessageBox.Show("No hay productos en la lista");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(txtBuscarCliente.Text != String.Empty)
            {
                try
                {
                    Cliente clienteBuscado = PCMaker.BuscarCliente(txtBuscarCliente.Text);
                    if(_presupuesto)
                    {
                        lblNombre.Text = clienteBuscado.Nombre;
                        lblApellido.Text = clienteBuscado.Apellido;
                        lblCorreo.Text = clienteBuscado.Correo;
                        pnEnviar.Visible = true;
                    }
                    else if(_venta)
                    {
                        lblClienteNombre.Text = clienteBuscado.Nombre;
                        lblClienteApellido.Text = clienteBuscado.Apellido;
                        lblClienteCorreo.Text = clienteBuscado.Correo;
                        lblClienteEdad.Text = clienteBuscado.Edad.ToString();
                        lblClienteDomicilio.Text = clienteBuscado.Direccion;
                        lblClienteTelefono.Text = clienteBuscado.Telefono.ToString();
                        lblClienteDni.Text = clienteBuscado.Dni.ToString();

                        lblFacturaNombre.Text = lblClienteNombre.Text;
                        lblFacturaApellido.Text = lblClienteApellido.Text;
                        lblFacturaDni.Text = lblClienteDni.Text;
                        lblFacturaTelefono.Text = lblClienteTelefono.Text;
                        lblFacturaDomicilio.Text = lblClienteDomicilio.Text;
                        lblFacturaCorreo.Text = lblClienteCorreo.Text;

                        pnDatosCVenta.Visible = true;
                        pnCliente.Visible = false;
                        pnlDatosVenta.Visible = true;

                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Algo Salio Mal");
                }
                txtBuscarCliente.Text = String.Empty;
            }
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
            pnlDatosCliente.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = true;
            pnlDatosCliente.Visible = false;
            txtApellido.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtDni.Text = String.Empty;
            txtDomicilio.Text = String.Empty;
            txtEdad.Text = String.Empty;
            txtTelefono.Text = String.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                PCMaker.AltaCliente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtEdad.Text, txtDomicilio.Text, txtTelefono.Text, txtCorreo.Text);
                if(_solicitudes)
                {
                    lblApellido.Text = txtApellido.Text;
                    lblNombre.Text = txtNombre.Text;
                    lblCorreo.Text = txtCorreo.Text;
                    pnlBuscarCliente.Visible = true;
                    pnlDatosCliente.Visible = false;
                    pnEnviar.Visible = true;
                }
                else if(_venta)
                {
                    lblClienteNombre.Text = txtNombre.Text;
                    lblClienteApellido.Text = txtApellido.Text;
                    lblClienteCorreo.Text = txtCorreo.Text;
                    lblClienteEdad.Text = txtEdad.Text.ToString();
                    lblClienteDomicilio.Text = txtDomicilio.Text;
                    lblClienteTelefono.Text = txtTelefono.Text.ToString();
                    lblClienteDni.Text = txtDni.Text.ToString();

                    lblFacturaNombre.Text = lblClienteNombre.Text;
                    lblFacturaApellido.Text = lblClienteApellido.Text;
                    lblFacturaDni.Text = lblClienteDni.Text;
                    lblFacturaTelefono.Text = lblClienteTelefono.Text;
                    lblFacturaDomicilio.Text = lblClienteDomicilio.Text;
                    lblFacturaCorreo.Text = lblClienteCorreo.Text;

                    pnDatosCVenta.Visible = true;
                    pnCliente.Visible = false;
                    pnlDatosVenta.Visible = true;

                    Presupuesto presupuestoSeleccionado = PCMaker.BuscarPresupuesto(lblIdPresupuesto.Text);
                    rtbVentaProducto.Text = PCMaker.MostrarProductosPresupuesto(presupuestoSeleccionado.Productos);
                }
                
                txtApellido.Text = String.Empty;
                txtCorreo.Text = String.Empty;
                txtNombre.Text = String.Empty;
                txtDni.Text = String.Empty;
                txtDomicilio.Text = String.Empty;
                txtEdad.Text = String.Empty;
                txtTelefono.Text = String.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo Salio Mal");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presupuesto Enviado Correctamente");
            BaseDatos.GuardarArchivoPresupuesto(PCMaker.SolPresupuesto);
            Close();
        }
        private void BuscarPresupuesto(string id)
        {
            try
            {
                Presupuesto presupuestoSeleccionado = PCMaker.BuscarPresupuesto(id);
                if(_venta)
                {
                    btnPresupuesto.Visible = false;
                    pnDatosCVenta.Visible = false;
                    pnCliente.Visible = true;
                    pnBuscarPresupuesto.Visible = false;
                    lblPresupuestoID.Text = txtBuscarPVenta.Text;
                    lblIdPresupuesto.Text = lblPresupuestoID.Text;
                    rtbVentaProducto.Text = PCMaker.MostrarProductosPresupuesto(presupuestoSeleccionado.Productos);
                    _precioPresupuesto = presupuestoSeleccionado.Precio;
                }
                else
                {
                
                    lblId.Text = presupuestoSeleccionado.Id;
                    lblEstadoPresupuesto.Text = presupuestoSeleccionado.Estado.ToString();

                    rtbPresupuesto.Text = PCMaker.MostrarProductosPresupuesto(presupuestoSeleccionado.Productos);
                   
                    if (presupuestoSeleccionado.Estado != EEstados.Revision && _solicitudes)
                    {
                        btnAprobar.Visible = false;
                        btnRechazar.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal");
                if(_venta)
                {
                    btnPresupuesto.Visible = true;
                    pnBuscarPresupuesto.Visible = false;
                }
            }
        }

        private void dgvSolicitudes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (string)dgvSolicitudes.Rows[e.RowIndex].Cells[0].Value;
            BuscarPresupuesto(id);
        }

        private void btnBuscarPresupuesto_Click(object sender, EventArgs e)
        {
            if(_solicitudes)
            {
                BuscarPresupuesto(txtBuscarNPresupuesto.Text);
                txtBuscarNPresupuesto.Text = String.Empty;
            }
            if(_venta)
            {
                BuscarPresupuesto(txtBuscarPVenta.Text);
                txtBuscarPVenta.Text = String.Empty;
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            Presupuesto presupuesto = PCMaker.BuscarPresupuesto(lblId.Text);

            presupuesto.Estado = EEstados.Rechazado;
            rtbPresupuesto.Text = String.Empty;
            lblId.Text = String.Empty;
            lblEstadoPresupuesto.Text = String.Empty;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            Presupuesto presupuesto = PCMaker.BuscarPresupuesto(lblId.Text);

            presupuesto.Estado = EEstados.Aprobado;
            rtbPresupuesto.Text = String.Empty;
            lblId.Text = String.Empty;
            lblEstadoPresupuesto.Text = String.Empty;

            BaseDatos.GuardarArchivoPresupuesto(PCMaker.SolPresupuesto);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            btnPresupuesto.Visible = false;
            pnlVenta.Visible = false;
            pnPresupuesto.Visible = true;
            pnPerifericos.Visible = false;
            lblCategoria.Text = "Microprocesador";
            rtbInfo.Text = "Tu procesador es la pieza central del rendimiento de los programas. Para saber si un procesador es potente lo que tenés que medir es la frecuencia, el ancho de bus, la memoria caché y los núcleos e hilos de procesamiento.";
            LlenarLista(lblCategoria.Text, "Intel");
        }
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEfectivo.Checked)
            {
                double descuento = _precioPresupuesto * 0.15;
                double precioFinal = _precioPresupuesto - descuento;

                pnlEfectivo.Visible = true;
                lblPrecioEfectivo.Text = _precioPresupuesto.ToString();
                lblDescuentoEfectivo.Text = descuento.ToString();
                lblPrecioFEfectivo.Text = precioFinal.ToString();
            }
            else
            {
                pnlEfectivo.Visible = false; ;
            }
        }
        private void ListarTarjetas()
        {
            cbTipoTarjeta.Items.Add("Visa");
            cbTipoTarjeta.Items.Add("MasterCard");
            cbTipoTarjeta.Items.Add("American Express");
        }

        private void rbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if( rbDebito.Checked)
            {
                double descuento = _precioPresupuesto * 0.05;
                double precioFinal = _precioPresupuesto - descuento;

                pnlDebito.Visible = true;
                lblPrecioDebito.Text = _precioPresupuesto.ToString();
                lblDescuentoDebito.Text = descuento.ToString();
                lblPrecioFDebito.Text = precioFinal.ToString();

                pnlDatosTarjeta.Visible = true;
                pnlCuotas.Visible = false;

            }
            else
            {
                pnlDebito.Visible = false;
                pnlDatosTarjeta.Visible = false;
            }
        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCredito.Checked)
            {
                double recargo = _precioPresupuesto * 0.15;
                double precioFinal = _precioPresupuesto + recargo;

                pnlCredito.Visible = true;
                lblPrecioCredito.Text = _precioPresupuesto.ToString();
                lblRecargoCredito.Text = recargo.ToString();
                lblPrecioFCredito.Text = precioFinal.ToString();

                pnlDatosTarjeta.Visible = true;
                pnlCuotas.Visible = false;
            }
            else
            {
                pnlCredito.Visible = false;
                pnlDatosTarjeta.Visible = false;
            }
        }

        private void txtCodTarjeta_TextChanged(object sender, EventArgs e)
        {
            if(txtCodTarjeta.Text.Length >= 3)
            {
                pnlCuotas.Visible = true;
            }
        }

        private void rbCuotas1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCuotas1.Checked)
            {
                double precioFinal = _precioPresupuesto * 1.15;

                lblMontoEnCuotas.Text = precioFinal.ToString();
            }
        }

        private void rbCuotas3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuotas3.Checked)
            {
                double precioFinal = _precioPresupuesto * 1.15;
                double cuotas = precioFinal / 3;

                lblMontoEnCuotas.Text = cuotas.ToString();
            }
        }

        private void rbCuotas6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuotas6.Checked)
            {
                double precioFinal = _precioPresupuesto * 1.15;
                double cuotas = precioFinal / 6;

                lblMontoEnCuotas.Text = cuotas.ToString();
            }
        }

        private void rbCuotas12_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuotas12.Checked)
            {
                double precioFinal = _precioPresupuesto * 1.15;
                double cuotas = precioFinal / 12;

                lblMontoEnCuotas.Text = cuotas.ToString();
            }
        }
    }
}
