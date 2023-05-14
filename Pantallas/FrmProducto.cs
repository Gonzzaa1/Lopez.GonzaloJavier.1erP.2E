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

        private FrmProducto()
        {
            InitializeComponent();
            PCMaker.Cargar();
        }
        public FrmProducto(bool busqueda):this()
        {
            this.busqueda = busqueda;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ControlarPaneles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ControlarPaneles()
        {
            if (busqueda)
            {
                pnlBotonera.Visible = false;
                pnlLista.Visible = false;
                pnlStockInfo.Visible = false;
                pnlMarca.Visible = false;
                pnlProducto.Visible = false;

                foreach(string categorias in Enum.GetNames(typeof(ECategoria)))
                {
                    cbCategoria.Items.Add(categorias);
                }

            }
            else
            {
                gbBuscarProducto.Visible = false;
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = PCMaker.productos;
            }
        }

        private void cbCategoria_TextChanged(object sender, EventArgs e)
        {
            if(cbCategoria.Text != String.Empty)
            {
                pnlMarca.Visible = true;

                foreach(Producto producto in PCMaker.productos)
                {
                    if(producto.Categoria.ToString() == cbCategoria.Text)
                    {
                        string auxMarca = producto.Marca;

                        if(!cbMarca.Items.Contains(auxMarca))
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

        private void cbMarca_TextChanged(object sender, EventArgs e)
        {
            if (cbMarca.Text != String.Empty)
            {
                pnlProducto.Visible = true;

                foreach (Producto producto in PCMaker.productos)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbProducto.Text != String.Empty)
            {
                foreach (Producto producto in PCMaker.productos)
                {
                    if(producto.Nombre == cbProducto.Text)
                    {
                        rtbProducto.Text = producto.ToString();
                    }
                }

            }
            else
            {
                StringBuilder sb = new StringBuilder();

                foreach (Producto producto in PCMaker.productos)
                {
                    if (producto.Marca == cbMarca.Text)
                    {

                        sb.AppendLine(producto.ToString());
                    }
                }

                rtbProducto.Text = sb.ToString();
            }
        }
    }
}
