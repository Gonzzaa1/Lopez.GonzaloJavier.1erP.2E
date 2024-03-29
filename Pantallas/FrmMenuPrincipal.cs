﻿using LibClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Logging;

namespace Pantallas
{
    public partial class FrmMenuPrincipal : Form
    {
        private int sw, sh;
        private int lx, ly;
        private FrmLogin login = new();
        private Usuario usuario;
        private Form formularioActual = new();
        private Logs logs = new();


        private FrmMenuPrincipal()
        {
            InitializeComponent();
            usuario = null!;
            logs.logEvento += BaseDatos.CrearRegistro;

        }
        private void CrearMensajeRegistro(string mensaje)
        {
            logs.Log($"{DateTime.Now} : {mensaje}");
        }

        public FrmMenuPrincipal(string user):this()
        {
            usuario = BaseDatos.BuscarUsuario(user);
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = usuario.User;
            txtRol.Text = usuario.Rol.ToString();
            ControlBotonesRol();
            OcularSubmenus();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("No cerro sesion, Desea continuar?",
                                         "Cerrar Aplicacion",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CrearMensajeRegistro($"El usuario {usuario.User} cerro la aplicacion sin cerrar secion.");
                Application.Exit();
            }
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            sw = this.Size.Width;
            sh = this.Size.Height;
            ly = this.Location.Y;
            lx = this.Location.X;
            picRest.Visible = true;
            picMax.Visible = false;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblHoraLogo.Text = DateTime.Now.ToString("dd/MM/yy  -  HH:mm:ss");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRest_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            picRest.Visible = false;
            picMax.Visible = true;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubmenus(pnlVentas);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubmenus(pnlProductos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenus(pnlClientes);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubmenus(pnlReportes);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Administracion.");
            FrmAdministracion administracion = new FrmAdministracion(usuario);
            Abrirformulario(administracion);
            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
            CrearMensajeRegistro($"El usuario {usuario.User} cerro sesion.");
            login.Show();
        }

        private void Abrirformulario(Form formulario)
        {
            if(formularioActual != null)
            {
                formularioActual.Close();
            }

            formularioActual = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(formulario);
            pnlMain.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
            lblHoraLogo.Visible = true;
        }

        private void btnPBuscar_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Buscar Producto.");
            FrmProducto producto = new FrmProducto(true,false,usuario);
            Abrirformulario(producto);
        }

        private void btnPConsultar_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Consultar Producto.");
            FrmProducto producto = new FrmProducto(false,false,usuario);
            Abrirformulario(producto);
        }

        private void btnSolicitudStock_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Solicitudes Stock.");
            FrmProducto producto = new FrmProducto(false,true, usuario);
            Abrirformulario(producto);
        }
        private void btnCBuscar_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Buscar Cliente.");
            FrmClientes clientes = new FrmClientes(usuario, true);
            Abrirformulario(clientes);
        }

        private void btnCGestionar_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Gestionar Cliente.");
            FrmClientes clientes = new FrmClientes(usuario, false);
            Abrirformulario(clientes);
        }
        private void btnVPresu_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Generar Presupuesto.");
            FrmVentas ventas = new FrmVentas(usuario,true, false, false, false);
            Abrirformulario(ventas);
        }
        private void OcularSubmenus()
        {
            if(pnlVentas.Visible == true)
                pnlVentas.Visible = false;
            if (pnlProductos.Visible == true)
                pnlProductos.Visible = false;
            if(pnlClientes.Visible == true)
                pnlClientes.Visible = false;
            if(pnlReportes.Visible == true)
                pnlReportes.Visible = false;
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Solicitudes de Presupuesto.");
            FrmVentas ventas = new FrmVentas(usuario, false, false, false, true);
            Abrirformulario(ventas);
        }

        private void btnVEstado_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Consultar Estado de Presupuesto.");
            FrmVentas ventas = new FrmVentas(usuario, false, false, true, false);
            Abrirformulario(ventas);
        }

        private void btnVPedido_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Generar Pedido de Venta.");
            FrmVentas ventas = new FrmVentas(usuario, false, true, false, false);
            Abrirformulario(ventas);
        }

        private void btnRVentas_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de Reportes de ventas.");
            FrmReportes reporte = new FrmReportes(usuario,true,false);
            Abrirformulario(reporte);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            OcularSubmenus();
            CrearMensajeRegistro($"El usuario {usuario.User} ingreso a la seccion de exportar informes.");
            FrmReportes reporte = new FrmReportes(usuario, false, true);
            Abrirformulario(reporte);
        }

        private void MostrarSubmenus(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcularSubmenus();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void ControlBotonesRol()
        {
            if(usuario.Rol == ERoles.Empleado)
            {
                btnReportes.Visible = false;
                btnSolicitudStock.Visible = false;
                pnlProductos.Height = pnlProductos.Height - 40;
                btnSolicitudes.Visible = false;
                pnlVentas.Height = pnlVentas.Height - 40;
                btnCGestionar.Visible = false;
                pnlClientes.Height = pnlClientes.Height - 40;
            }
        }
    }
}
