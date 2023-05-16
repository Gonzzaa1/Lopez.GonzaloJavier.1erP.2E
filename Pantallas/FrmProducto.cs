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
        private string? idProducto;
        private Usuario usuario;

        private FrmProducto()
        {
            InitializeComponent();
            usuario = null!;
            
        }
        public FrmProducto(bool busqueda,bool solicitudes, Usuario usuario):this()
        {
            this.busqueda = busqueda;
            this.usuario = usuario;
            this.solicitudes = solicitudes;
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
                    RefrescarListado(PCMaker.Productos);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if(cbBuscarProducto.Text != String.Empty)
                dgvProductos.DataSource = PCMaker.FiltrarProductos(cbBuscarProducto.Text);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BaseDatos.GuardarArchivoProducto(PCMaker.Productos);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            pnlBotonera.Visible = true;
            pnlLista.Visible = true;
            pnlStockInfo.Visible = true;
            cbCargaCategoria.Text = String.Empty;
            txtNombreProducto.Text = String.Empty;
            txtMarcaProducto.Text = String.Empty;
            txtStockProducto.Text = String.Empty;
            txtPrecioProducto.Text= String.Empty;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            pnlBotonera.Visible = false;
            pnlLista.Visible = false;
            pnlStockInfo.Visible = false;
            pnlDatos.Visible = true;
            CrearListadoCategorias(cbCargaCategoria);  
        }
        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = (string)dgvProductos.Rows[e.RowIndex].Cells[0].Value;

            if(usuario.Rol == ERoles.Administrador)
            {
                btnEliminarProducto.Visible = true;

                if(solicitudes)
                {
                    pnlDatos.Visible = true;
                    txtNombreProducto.Enabled = false;
                    txtNombreProducto.Text = (string)dgvProductos.Rows[e.RowIndex].Cells[1].Value;
                    txtMarcaProducto.Enabled = false;
                    txtMarcaProducto.Text = (string)dgvProductos.Rows[e.RowIndex].Cells[2].Value;
                    txtPrecioProducto.Enabled = false;
                    txtPrecioProducto.Text = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbCargaCategoria.Enabled = false;
                    cbCargaCategoria.Text = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtStockProducto.PlaceholderText = "Ingresar cantidad de Stock";
                    txtStockProducto.Focus();
                }
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Desea Solictar Stock del producto?", "Solicitar Stock",MessageBoxButtons.YesNo);

                if(respuesta == DialogResult.Yes)
                {
                    dgvProductos.ClearSelection();
                    PCMaker.SolicitarStock(idProducto);
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
                    PCMaker.AgregarStock(idProducto!, txtStockProducto.Text);
                    MessageBox.Show("Stock agregado correctamente");
                }
                else
                {
                    Producto productoNuevo = PCMaker.CrearProducto(txtNombreProducto.Text, txtMarcaProducto.Text, txtPrecioProducto.Text, cbCargaCategoria.Text, txtStockProducto.Text);
                    PCMaker.AgregarProducto(productoNuevo);
                    pnlBotonera.Visible = true;
                    pnlLista.Visible = true;
                    pnlStockInfo.Visible = true;
                    pnlDatos.Visible = false;
                    MessageBox.Show("Producto agregado correctamente");
                    RefrescarListado(PCMaker.Productos);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Algo Salio Mal!");
                cbCargaCategoria.Text = String.Empty;
                txtNombreProducto.Text = String.Empty;
                txtMarcaProducto.Text = String.Empty;
                txtStockProducto.Text = String.Empty;
                txtPrecioProducto.Text = String.Empty;
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if(idProducto != null)
            {
                DialogResult respuesta = MessageBox.Show("Desea Eliminar el producto seleccionado?", "Eliminar Producto", MessageBoxButtons.YesNo);

                if(respuesta == DialogResult.Yes)
                {
                    try
                    {
                        PCMaker.EliminarProducto(idProducto);
                        MessageBox.Show("Producto Eliminado correctamente");
                        RefrescarListado(PCMaker.Productos);

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
                gbBuscarProducto.Visible = false;
                pnlBotonera.Visible = false;
                btnGuardar.Visible = false;
                RefrescarListado(PCMaker.Solicitudes);
            }
            else
            {
                gbBuscarProducto.Visible = false;

                if(usuario.Rol == ERoles.Administrador)
                {
                    btnAgregarProducto.Visible = true;
                }
                else
                {
                    btnAgregarProducto.Visible = false;
                    btnEliminarProducto.Visible = false;
                    btnGuardar.Visible = false;
                }
                RefrescarListado(PCMaker.Productos);
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
            }
        }
        private void RefrescarListado(List<Producto> listado)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listado;
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[3].Visible = false;
        }

        
    }
}
