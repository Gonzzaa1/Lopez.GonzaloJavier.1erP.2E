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
    public partial class FrmReportes : Form
    {
        private bool _ventas;
        private bool _informes;
        private Logs log = new Logs();
        private Usuario _usuario;

        private FrmReportes()
        {
            InitializeComponent();
            _usuario = null!;
            log.logEvento += BaseDatos.CrearRegistro;
        }
        public FrmReportes(Usuario usuario,bool ventas,bool informes):this()
        {
            _usuario = usuario;
            _ventas = ventas;
            _informes = informes;
        }
        public void CrearMensajeRegistro(string mensaje)
        {
            log.Log($"{DateTime.Now} : {mensaje}");
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            if(_ventas)
            {
                dgvReportesVentas.DataSource = null;
                dgvReportesVentas.DataSource = PCMaker.Ventas;
                plVentas.Visible = true;
                plInformes.Visible = false;
            }
            if(_informes)
            {
                plInformes.Visible = true;
                plVentas.Visible = false;

                if(_usuario.Rol == ERoles.Administrador)
                {
                    rbUsuarios.Visible = true;
                    rbRegistros.Visible = true;
                }
                else
                {
                    rbUsuarios.Visible = false;
                    rbRegistros.Visible = false;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            if(rbClientes.Checked)
            {
                PCMaker.ExportarJSON("ClientesJson", BaseDatos.ObtenerClientes());
                rbClientes.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo JSON para los Clientes.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if(rbProductos.Checked)
            {
                PCMaker.ExportarJSON("ProductosJson", BaseDatos.ObtenerProductos());
                rbProductos.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo JSON para los Producto.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if(rbPresupuestos.Checked)
            {
                PCMaker.ExportarJSON("PresupuestosJson", BaseDatos.ObtenerPresupuestos());
                rbPresupuestos.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo JSON para los Presupuesto.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if(rbVentas.Checked)
            {
                PCMaker.ExportarJSON("VentasJson", BaseDatos.ObtenerVentas());
                rbVentas.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo JSON para los Ventas.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if(rbUsuarios.Checked)
            {
                PCMaker.ExportarJSON("UsuariosJson", BaseDatos.ObtenerUsuarios());
                rbUsuarios.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo JSON para los Usuarios.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if(rbRegistros.Checked)
            {
                PCMaker.ExportarJSON("RegistrosJson", BaseDatos.ObtenerRegistros());
                rbRegistros.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo JSON para los Registros.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else
            {
                MessageBox.Show("No se selecciono ningun opcion");
            }
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            if (rbClientes.Checked)
            {
                PCMaker.ExportarCSV("ClientesCSV", BaseDatos.ObtenerClientes());
                rbClientes.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo CSV para los Clientes.");
                MessageBox.Show("Archivo Exportado correctamente");
            }

            else if (rbProductos.Checked)
            {
                PCMaker.ExportarCSV("ProductosCSV", BaseDatos.ObtenerProductos());
                rbProductos.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo CSV para los Producto.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if (rbPresupuestos.Checked)
            {
                PCMaker.ExportarCSV("PresupuestosCSV", BaseDatos.ObtenerPresupuestos());
                rbPresupuestos.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo CSV para los Presupuesto.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if (rbVentas.Checked)
            {
                PCMaker.ExportarCSV("VentasCSV", BaseDatos.ObtenerVentas());
                rbVentas.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo CSV para los Ventas.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if (rbUsuarios.Checked)
            {
                PCMaker.ExportarCSV("UsuariosCSV", BaseDatos.ObtenerUsuarios());
                rbUsuarios.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo CSV para los Usuarios.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else if (rbRegistros.Checked)
            {
                PCMaker.ExportarCSV("RegistrosCSV", BaseDatos.ObtenerRegistros());
                rbRegistros.Checked = false;
                CrearMensajeRegistro($"El usuario {_usuario.User} genero un archivo CSV para los Registros.");
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else
            {
                MessageBox.Show("No se selecciono ningun opcion");
            }
        }
    }
}
