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
        private Usuario user;
        private string? auxUser;
        private string? auxPass;
        private bool modOn = false;
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
            CargarRoles();
            DeshabilitarBoxes();
            txtSolicitudesMod.Text = Registro.Solicitudes.Count.ToString();

            if(user.Rol == ERoles.Administrador)
            {
                pnlListado.Visible = true;
                pnlBotonera.Visible = true;
                btnEditPass.Visible = false;
                btnSolicitarCambios.Visible = false;
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = Registro.Usuarios;
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                MostrarDatos(user);
                txtContraseña.PasswordChar = '*';
            }
            
        }
        private void CargarRoles()
        {
            foreach(string roles in Enum.GetNames(typeof(ERoles)))
            {
                cbRoles.Items.Add(roles);
            }
        }
        private void DeshabilitarBoxes()
        {
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            cbRoles.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCorreo.Enabled = false;
        }
        private void HabilitarBoxes()
        {
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            cbRoles.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
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
            VaciarTextBox();
            cbShowPass.Checked = false;
            pnlCambiarContraseña.Visible = false;
            gbAdministracion.Visible = true;
        }

        private void txtNewPassRep_TextChanged(object sender, EventArgs e)
        {
            if(txtNewPass.Text != String.Empty && txtLastPass.Text != String.Empty && txtNewPassRep.Text == txtNewPass.Text)
            {
                btnConfirmar.Enabled = true;
            }
            else
            {
                btnConfirmar.Enabled = false;
            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (Registro.ValidarContraseña(txtNewPass.Text))
            {
                txtNewPassRep.Enabled = true;
            }
            else
            {
                txtNewPassRep.Enabled = false;
                txtNewPassRep.Text = String.Empty;
            }
        }
        private void VaciarDatosUsuario()
        {
            txtUsuario.Text = String.Empty;
            txtContraseña.Text = String.Empty;
            cbRoles.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtCorreo.Text = String.Empty;
        }
        private void VaciarTextBox()
        {
            
            txtNewPassRep.Text = String.Empty;
            txtLastPass.Text = String.Empty;
            txtNewPass.Text = String.Empty;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Registro.ModificarUsuario(txtUsuario.Text, txtLastPass.Text, txtNewPassRep.Text);
                VaciarTextBox();
                pnlCambiarContraseña.Visible = false;
                cbShowPass.Checked = false;
                MessageBox.Show("Contraseña cambiada con exito!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Algo Salio Mal!");
                VaciarTextBox();
            }

        }

        private void btnSolicitarCambios_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            btnSolicitarCambios.Visible = false;
            btnConfirmSol.Visible = true;
            btnCancelSol.Visible = true;
        }
        private void VolverViejosDatos()
        {
            btnSolicitarCambios.Visible = true;
            btnConfirmSol.Visible = false;
            btnCancelSol.Visible = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCorreo.Enabled = false;
            txtNombre.Text = user.Nombre;
            txtApellido.Text = user.Apellido;
            txtCorreo.Text = user.Correo;
        }

        private void btnCancelSol_Click(object sender, EventArgs e)
        {
            VolverViejosDatos();
        }

        private void btnConfirmSol_Click(object sender, EventArgs e)
        {
            
            Registro.SolicitarMod(txtUsuario.Text,txtContraseña.Text,BaseDatos.ParsearRol(cbRoles.Text),txtNombre.Text,txtApellido.Text,txtCorreo.Text);
            VolverViejosDatos();
            MessageBox.Show("Solicitud Enviado Correctamente");

        }

        private void btnSolis_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(Registro.MostrarSolicitud(), "Solicitud de Modificacion", MessageBoxButtons.YesNo);

            if(respuesta == DialogResult.Yes)
            {
                Registro.ConfirmarSolicitudMod();
            }
            else
            {
                Registro.CancelarSolicitud();
            }
            txtSolicitudesMod.Text = Registro.Solicitudes.Count.ToString();
        }

        private void txtSolicitudesMod_TextChanged(object sender, EventArgs e)
        {
            if(txtSolicitudesMod.Text == "0")
            {
                btnSolis.Enabled = false;
            }
            else
            {
                btnSolis.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HabilitarBoxes();
            pnlBotonera.Enabled = false;
            btnOk.Visible = true;
            btnNo.Visible = true;
            modOn = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(modOn == true)
            {
                if(auxUser != null && auxPass != null)
                {
                    try
                    {
                        Registro.CambiarRolUsuario(auxUser, BaseDatos.ParsearRol(cbRoles.Text));
                        Registro.ModificarUsuario(auxUser, auxPass, txtContraseña.Text);
                        Registro.ModificarUsuario(auxUser,txtNombre.Text,txtApellido.Text,txtCorreo.Text);
                        Registro.ModificarUsuario(auxUser, txtUsuario.Text);
                        DeshabilitarBoxes();
                        VaciarDatosUsuario();
                        pnlBotonera.Enabled = true;
                        btnOk.Visible = false;
                        btnNo.Visible = false;
                        MessageBox.Show("Modificacion Exitosa");
                        dgvUsers.DataSource = null;
                        dgvUsers.DataSource = Registro.Usuarios;

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Algo Salio Mal");
                    }
                }
            }
            else
            {
                try
                {
                    Registro.CrearUsuario(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text, BaseDatos.ParsearRol(cbRoles.Text), txtCorreo.Text);
                    DeshabilitarBoxes();
                    VaciarDatosUsuario();
                    pnlBotonera.Enabled = true;
                    btnOk.Visible = false;
                    btnNo.Visible = false;
                    MessageBox.Show("Alta exitosa");
                    dgvUsers.DataSource = null;
                    dgvUsers.DataSource = Registro.Usuarios;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Algo Salio Mal");
                }
            }
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = (string)dgvUsers.Rows[e.RowIndex].Cells[0].Value;
            txtContraseña.Text = (string)dgvUsers.Rows[e.RowIndex].Cells[1].Value;
            cbRoles.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNombre.Text = (string)dgvUsers.Rows[e.RowIndex].Cells[3].Value;
            txtApellido.Text = (string)dgvUsers.Rows[e.RowIndex].Cells[4].Value;
            txtCorreo.Text = (string)dgvUsers.Rows[e.RowIndex].Cells[5].Value;
            auxUser = txtUsuario.Text;
            auxPass = txtContraseña.Text;

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text != String.Empty)
            {
                btnBaja.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnBaja.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            HabilitarBoxes();
            pnlBotonera.Enabled = false;
            btnOk.Visible = true;
            btnNo.Visible = true;
            modOn = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DeshabilitarBoxes();
            VaciarDatosUsuario();
            pnlBotonera.Enabled = true;
            btnOk.Visible = false;
            btnNo.Visible = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"Desea eliminar al usuario: {txtUsuario.Text.ToUpper()}?", "BAJA USUARIO", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Registro.EliminarUsuario(txtUsuario.Text);
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = Registro.Usuarios;
                VaciarDatosUsuario();
                MessageBox.Show("Usuario dado de baja");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Guardar?","GUARDAR",MessageBoxButtons.YesNo);
            if(respuesta == DialogResult.Yes)
            {
                BaseDatos.GuardarUsuario(Registro.Usuarios);
                MessageBox.Show("Guardado exitoso");
                Close();
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == String.Empty)
            {
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = Registro.Usuarios;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarioBuscado = new();
            try
            {
                Usuario auxUser = Registro.BuscarUsuario(txtBuscar.Text);
                usuarioBuscado.Add(new(auxUser.Nombre, auxUser.Apellido, auxUser.User, auxUser.Contraseña, auxUser.Rol, auxUser.Correo));
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = usuarioBuscado;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo Salio Mal!");
            }
        }
    }
}
