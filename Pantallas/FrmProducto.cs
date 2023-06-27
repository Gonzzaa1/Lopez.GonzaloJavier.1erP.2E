using LibClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class FrmProducto : Form
    {
        private bool busqueda;
        private bool solicitudes;
        private bool onStock;
        private string? nombreProducto;
        private Usuario usuario;
        Logs log = new Logs();

        private FrmProducto()
        {
            InitializeComponent();
            usuario = null!;
            log.logEvento += BaseDatos.CrearRegistro;
        }
        public FrmProducto(bool busqueda,bool solicitudes, Usuario usuario):this()
        {
            this.busqueda = busqueda;
            this.usuario = usuario;
            this.solicitudes = solicitudes;
        }
        public void CrearMensajeRegistro(string mensaje)
        {
            log.Log($"{DateTime.Now} : {mensaje}");
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ControlarPaneles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cbCategoria_TextChanged(object sender, EventArgs e)
        {
            ListarMarcaProductos();
        }

        private void cbMarca_TextChanged(object sender, EventArgs e)
        {
            ListarNombreProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarDatosProductos();
        }
        private void cbBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if(!solicitudes)
                if(cbBuscarProducto.Text == String.Empty)
                    RefrescarListado(BaseDatos.ObtenerProductos());
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if(cbBuscarProducto.Text != String.Empty)
            {
                dgvProductos.DataSource = PCMaker.FiltrarProductos(cbBuscarProducto.Text);
                CrearMensajeRegistro($"El usuario {usuario.User} filtro los productos x {cbBuscarProducto.Text}.");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            pnlBotonera.Visible = false;
            pnlLista.Visible = true;
            pnlStockInfo.Visible = true;
            cbCargaCategoria.Text = String.Empty;
            txtNombreProducto.Text = String.Empty;
            cbMarcaProducto.Text = String.Empty;
            txtStockProducto.Text = String.Empty;
            txtPrecioProducto.Text= String.Empty;
            CrearMensajeRegistro($"El usuario {usuario.User} cancelo la moficicacion de stock o alta de producto.");
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            pnlBotonera.Visible = false;
            pnlLista.Visible = false;
            pnlStockInfo.Visible = false;
            pnlDatos.Visible = true;
            CrearListadoCategorias(cbCargaCategoria);
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de agregar un producto.");
        }
        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nombreProducto = (string)dgvProductos.Rows[e.RowIndex].Cells[1].Value;

            if(usuario.Rol == ERoles.Administrador || usuario.Rol == ERoles.Gerente)
            {
                if (solicitudes)
                {
                    pnlDatos.Visible = true;
                    txtNombreProducto.Enabled = false;
                    txtNombreProducto.Text = (string)dgvProductos.Rows[e.RowIndex].Cells[1].Value;
                    cbMarcaProducto.Enabled = false;
                    cbMarcaProducto.Text = (string)dgvProductos.Rows[e.RowIndex].Cells[2].Value;
                    txtPrecioProducto.Enabled = false;
                    txtPrecioProducto.Text = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbCargaCategoria.Enabled = false;
                    cbCargaCategoria.Text = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtStockProducto.PlaceholderText = "Ingresar cantidad de Stock";
                    txtStockProducto.Focus();
                }
                else 
                {
                    if (usuario.Rol == ERoles.Gerente)
                    {
                       SolicitarStock(nombreProducto);
                    }
                    else
                        btnEliminarProducto.Visible = true;
                }
            }
            else
            {
                SolicitarStock(nombreProducto);
            }
            
        }
        private void SolicitarStock(string nombreProducto)
        {
            if (onStock == false)
            {
                DialogResult respuesta = MessageBox.Show("Desea Solictar Stock del producto?", "Solicitar Stock", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    dgvProductos.ClearSelection();
                    PCMaker.SolicitarStock(nombreProducto);
                    MessageBox.Show("Solicitud enviada");
                }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(solicitudes)
                {
                    PCMaker.AgregarStock(nombreProducto!, txtStockProducto.Text);
                    MessageBox.Show("Stock agregado correctamente");
                    CrearMensajeRegistro($"El usuario {usuario.User} moficico el stock del producto {nombreProducto}.");
                    pnlDatos.Visible = false;
                    RefrescarListado(PCMaker.Solicitudes);
                }
                else
                {
                    Producto productoNuevo = PCMaker.CrearProducto(txtNombreProducto.Text, cbMarcaProducto.Text, txtPrecioProducto.Text, cbCargaCategoria.Text, txtStockProducto.Text);
                    PCMaker.AgregarProducto(productoNuevo);
                    pnlBotonera.Visible = true;
                    pnlLista.Visible = true;
                    pnlStockInfo.Visible = true;
                    pnlDatos.Visible = false;
                    MessageBox.Show("Producto agregado correctamente");
                    CrearMensajeRegistro($"El usuario {usuario.User} agrego el producto {txtNombreProducto.Text}.");
                    RefrescarListado(BaseDatos.ObtenerProductos());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Algo Salio Mal!");
                cbCargaCategoria.Text = String.Empty;
                txtNombreProducto.Text = String.Empty;
                cbMarcaProducto.Text = String.Empty;
                txtStockProducto.Text = String.Empty;
                txtPrecioProducto.Text = String.Empty;
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if(nombreProducto != null)
            {
                DialogResult respuesta = MessageBox.Show("Desea Eliminar el producto seleccionado?", "Eliminar Producto", MessageBoxButtons.YesNo);

                if(respuesta == DialogResult.Yes)
                {
                    try
                    {
                        PCMaker.EliminarProducto(nombreProducto);
                        MessageBox.Show("Producto Eliminado correctamente");
                        CrearMensajeRegistro($"El usuario {usuario.User} elimino correctamente el producto {nombreProducto}.");
                        RefrescarListado(BaseDatos.ObtenerProductos());

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Algo salio mal!");
                    }
                }
                btnEliminarProducto.Visible = false;
            }
        }
        private void ControlarPaneles()
        {
            pnlDatos.Visible = false;

            if (busqueda)
            {
                pnlBotonera.Visible = false;
                pnlStockInfo.Visible = false;
                pnlMarca.Visible = false;
                pnlProducto.Visible = false;
                CrearListadoCategorias(cbCategoria);
            }
            else if (solicitudes)
            {
                onStock = true;
                gbBuscarProducto.Visible = false;
                pnlBotonera.Visible = false;
                RefrescarListado(PCMaker.Solicitudes);
            }
            else
            {
                onStock = false;
                gbBuscarProducto.Visible = false;

                if(usuario.Rol == ERoles.Administrador)
                {
                    btnAgregarProducto.Visible = true;
                    label5.Visible = false;
                }
                else
                {
                    btnAgregarProducto.Visible = false;
                    btnEliminarProducto.Visible = false;
                }
                RefrescarListado(BaseDatos.ObtenerProductos());
                CrearListadoCategorias(cbBuscarProducto);
            }
            
        }
        private void CrearListadoCategorias(ComboBox despegable)
        {
            foreach (string categorias in Enum.GetNames(typeof(ECategoria)))
            {
                despegable.Items.Add(categorias);
            }
        }
        private void ListarMarcaProductos(ComboBox despegable)
        {
            if(cbCargaCategoria.Text != String.Empty)
            {
                despegable.Items.Clear();

                foreach (Producto producto in BaseDatos.ObtenerProductos())
                {
                    if (producto.Categoria.ToString() == cbCargaCategoria.Text)
                    {
                        string auxMarca = producto.Marca;

                        if (!despegable.Items.Contains(auxMarca))
                            despegable.Items.Add(auxMarca);
                    }
                }
            }

        }
        private void ListarMarcaProductos()
        {
            if (cbCategoria.Text != String.Empty)
            {
                cbMarca.Items.Clear();
                pnlMarca.Visible = true;

                foreach (Producto producto in PCMaker.Productos)
                {
                    if (producto.Categoria.ToString() == cbCategoria.Text)
                    {
                        string auxMarca = producto.Marca;

                        if (!cbMarca.Items.Contains(auxMarca))
                            cbMarca.Items.Add(auxMarca);
                    }
                }
            }
            else
            {
                pnlMarca.Visible = false;
                cbMarca.Text = String.Empty;
            }
        }
        private void ListarNombreProductos()
        {
            if (cbMarca.Text != String.Empty)
            {
                pnlProducto.Visible = true;
                cbProducto.Items.Clear();

                foreach (Producto producto in PCMaker.Productos)
                {
                    if (producto.Marca == cbMarca.Text && producto.Categoria.ToString() == cbCategoria.Text)
                    {
                        string auxProducto = producto.Nombre;

                        if (!cbProducto.Items.Contains(auxProducto))
                            cbProducto.Items.Add(auxProducto);
                    }
                }
            }
            else
            {
                pnlProducto.Visible = false;
                cbProducto.Text = String.Empty;
            }
        }
        private void MostrarDatosProductos()
        {
            if (cbProducto.Text != String.Empty)
            {
                foreach (Producto producto in PCMaker.Productos)
                {
                    if (producto.Nombre == cbProducto.Text)
                    {
                        rtbProducto.Text = producto.ToString();
                    }
                }
                CrearMensajeRegistro($"El usuario {usuario.User} realizo la busqueda del producto { cbProducto.Text}.");
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                foreach (Producto producto in PCMaker.Productos)
                {
                    if (producto.Marca == cbMarca.Text)
                    {

                        sb.AppendLine(producto.ToString());
                    }
                }

                rtbProducto.Text = sb.ToString();
                CrearMensajeRegistro($"El usuario {usuario.User} realizo la busqueda de producto de la marca {cbMarca.Text}.");
            }
        }
        private void RefrescarListado(List<Producto> listado)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listado;
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[3].Visible = false;
        }

        private void cbCargaCategoria_TextChanged(object sender, EventArgs e)
        {
            ListarMarcaProductos(cbMarcaProducto);
        }
    }
}
