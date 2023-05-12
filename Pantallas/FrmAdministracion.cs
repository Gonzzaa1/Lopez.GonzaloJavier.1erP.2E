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
    public partial class FrmAdministracion : Form
    {
        Usuario user;
        private FrmAdministracion()
        {
            InitializeComponent();
            user = null!;
        }
        public FrmAdministracion(Usuario usuario) : this()
        {
            user = usuario;
        }
        private void FrmAdministracion_Load(object sender, EventArgs e)
        {
            pnlCambiarContraseña.Visible = false;
            pnlListado.Visible = false;
            pnlBotonera.Visible = false;
            DeshabilitarBoxs();
            MostrarDatos(user);

            if(user.Rol == ERoles.Administrador)
            {
                pnlListado.Visible = true;
                pnlBotonera.Visible = true;
                btnEditPass.Visible = false;
                btnSolicitarCambios.Visible = false;
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = Registro.Usuarios;
            }
            
        }
        private void DeshabilitarBoxs()
        {
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            cbRoles.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCorreo.Enabled = false;
        }
        private void MostrarDatos(Usuario user)
        {
            txtUsuario.Text = user.User;
            txtContraseña.Text = user.Contraseña;
            cbRoles.Text = user.Rol.ToString();
            txtNombre.Text = user.Nombre;
            txtApellido.Text = user.Apellido;
            txtCorreo.Text = user.Correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditPass_Click(object sender, EventArgs e)
        {
            gbAdministracion.Visible = false;
            pnlCambiarContraseña.Visible = true;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked)
            {
                txtLastPass.PasswordChar = '\0';
                txtNewPass.PasswordChar = '\0';
                txtNewPassRep.PasswordChar = '\0';
            }
            else
            {
                txtLastPass.PasswordChar = '*';
                txtNewPass.PasswordChar = '*';
                txtNewPassRep.PasswordChar = '*';
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlCambiarContraseña.Visible = false;
            gbAdministracion.Visible = true;
        }
    }
}
