using LibClases;
using Microsoft.VisualBasic.ApplicationServices;
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
        private string? _dni;
        private bool _mod;
        Logs log = new Logs();
        private FrmClientes()
        {
            InitializeComponent();
            _usuario = null!;
            log.logEvento += BaseDatos.CrearRegistro;
        }
        public FrmClientes(Usuario user, bool busqueda) : this()
        {
            _usuario = user;
            _busqueda = busqueda;
        }
        public void CrearMensajeRegistro(string mensaje)
        {
            log.Log($"{DateTime.Now} : {mensaje}");
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            btnBaja.Visible = false;
            btnMod.Visible = false;
            Actualizarlistado();

            if(_busqueda)
            {
                btnAlta.Visible = false;
                pnlLista.Visible = false;
            }
        }
        private void Actualizarlistado()
        {
            dgvListado.DataSource = null;
            dgvListado.DataSource = BaseDatos.ObtenerClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text != String.Empty)
            {
                Actualizarlistado();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != String.Empty)
            {
                try
                {
                    Cliente clienteBuscado = BaseDatos.BuscarCliente(txtBuscar.Text);
                    CrearMensajeRegistro($"El usuario {_usuario.User} busco al cliente DNI {clienteBuscado.Dni}.");
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
            txtNombre.Text = (string)dgvListado.Rows[e.RowIndex].Cells[4].Value;
            txtApellido.Text = (string)dgvListado.Rows[e.RowIndex].Cells[5].Value;
            txtDni.Text = dgvListado.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEdad.Text = dgvListado.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            txtDireccion.Text = (string)dgvListado.Rows[e.RowIndex].Cells[2].Value;
            txtTelefono.Text = (string)dgvListado.Rows[e.RowIndex].Cells[3].Value;
            txtCorreo.Text = (string)dgvListado.Rows[e.RowIndex].Cells[6].Value;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtEdad.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            _dni = txtDni.Text;
            btnBaja.Visible = true;
            btnMod.Visible = true;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = true;
            pnlLista.Visible = false;
            pnlBotonera.Visible = false;
            txtNombre.Enabled = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            CrearMensajeRegistro($"El usuario {_usuario.User} ingreso a dar de alta un cliente.");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(_mod && _dni != null)
                {
                    
                    Cliente cliente = BaseDatos.BuscarCliente(_dni);
                    PCMaker.ModificarCliente(cliente, txtNombre.Text, txtApellido.Text, txtDni.Text, txtEdad.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                    pnlBotonera.Enabled = true;
                    pnlLista.Visible = true;
                    btnBaja.Visible = false;
                    btnMod.Visible = false;
                    dgvListado.ClearSelection();
                    _mod = false;
                    ReestablecerDatos();
                    MessageBox.Show($"Cliente {cliente.Nombre} {cliente.Apellido} modificado correctamente");
                    CrearMensajeRegistro($"El usuario {_usuario.User} modifico correctamente al cliente DNI {txtDni.Text}.");
                }
                else
                {
                    PCMaker.AltaCliente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtEdad.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                    pnlBotonera.Visible = true;
                    pnlLista.Visible = true;
                    ReestablecerDatos();
                    MessageBox.Show("Nuevo Cliente agregado");
                    CrearMensajeRegistro($"El usuario {_usuario.User} dio de alta al cliente DNI {txtDni.Text}.");
                }
                Actualizarlistado();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo Salio Mal");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtNombre.Text != String.Empty)
                txtApellido.Enabled = true;
            else
                txtApellido.Enabled = false;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != String.Empty)
                txtDni.Enabled = true;
            else
                txtDni.Enabled = false;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text != String.Empty)
                txtEdad.Enabled = true;
            else
                txtEdad.Enabled = false;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text != String.Empty)
                txtDireccion.Enabled = true;
            else
                txtDireccion.Enabled = false;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text != String.Empty)
                txtCorreo.Enabled = true;
            else
                txtCorreo.Enabled = false;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text != String.Empty)
                txtTelefono.Enabled = true;
            else
                txtTelefono.Enabled = false;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text != String.Empty)
                btnAceptar.Enabled = true;
            else
                btnAceptar.Enabled = false;
        }
        private void ReestablecerDatos()
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtDni.Text = String.Empty;
            txtEdad.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtCorreo.Text = String.Empty;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReestablecerDatos();
            CrearMensajeRegistro($"El usuario {_usuario.User} cancelo la modificacion o alta de un cliente.");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea eliminar al cliente?", "Eliminar cliente", MessageBoxButtons.YesNo);

            if(respuesta == DialogResult.Yes)
            {
                try
                {
                    if(_dni != null)
                    {
                        PCMaker.BajaCliente(_dni);
                        MessageBox.Show("Cliente eliminado");
                        btnBaja.Visible = false;
                        btnMod.Visible = false;
                        ReestablecerDatos();
                        Actualizarlistado();
                        CrearMensajeRegistro($"El usuario {_usuario.User} elimino al cliente DNI {_dni} correctamente.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Algo Salio Mal");
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            _mod = true;
            pnlBotonera.Enabled = false;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDni.Enabled = true;
            txtEdad.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            CrearMensajeRegistro($"El usuario {_usuario.User} ingreso a la seccion de modificar cliente.");
        }
    }
}
