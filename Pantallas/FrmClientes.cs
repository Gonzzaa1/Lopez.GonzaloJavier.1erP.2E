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
    public partial class FrmClientes : Form
    {
        private Usuario _usuario;
        private bool _busqueda;
        private FrmClientes()
        {
            InitializeComponent();
            _usuario = null!;
        }
        public FrmClientes(Usuario user, bool busqueda) : this()
        {
            _usuario = user;
            _busqueda = busqueda;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            dgvListado.DataSource = null;
            dgvListado.DataSource = PCMaker.Clientes;

            if(_busqueda)
            {
                btnAlta.Visible = false;
                btnBaja.Visible = false;
                btnMod.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseDatos.GuardarArchivoCliente(PCMaker.Clientes);
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text != String.Empty)
            {
                dgvListado.DataSource = null;
                dgvListado.DataSource = PCMaker.Clientes;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != String.Empty)
            {
                try
                {
                    Cliente clienteBuscado = PCMaker.BuscarCliente(txtBuscar.Text);
                    txtNombre.Text = clienteBuscado.Nombre;
                    txtApellido.Text = clienteBuscado.Apellido;
                    txtDni.Text = clienteBuscado.Dni.ToString();
                    txtEdad.Text = clienteBuscado.Edad.ToString();
                    txtDireccion.Text = clienteBuscado.Direccion;
                    txtTelefono.Text = clienteBuscado.Telefono;
                    txtCorreo.Text = clienteBuscado.Correo;
                    pnlDatos.Visible = true;
                    txtBuscar.Text = String.Empty;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Algo Salio Mal");
                }
            }
        }

        private void dgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = true;
            pnlLista.Visible = false;
            pnlBotonera.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                PCMaker.AltaCliente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtEdad.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                pnlDatos.Visible = false;
                pnlBotonera.Visible = true;
                pnlLista.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo Salio Mal");
            }
        }
    }
}
