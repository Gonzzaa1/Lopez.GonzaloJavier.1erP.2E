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
        Logs log = new Logs();
        private FrmAdministracion()
        {
            InitializeComponent();
            user = null!;
            log.logEvento += BaseDatos.CrearRegistro;
        }
        public FrmAdministracion(Usuario usuario) : this()
        {
            user = usuario;
        }
        public void CrearMensajeRegistro(string mensaje)
        {
            log.Log($"{DateTime.Now} : {mensaje}");
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
                ActualizarListado();
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
            txtLastPass.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
            txtNewPassRep.PasswordChar = '*';
            CrearMensajeRegistro($"El usuario {user.User} ingreso a modificar su contraseña.");
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
            CrearMensajeRegistro($"El usuario {user.User} cancelo el cambio de contraseña.");
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
        private void ActualizarListado()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = BaseDatos.ObtenerUsuarios();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDatos.ModificarUsuario(txtUsuario.Text, txtNewPassRep.Text);
                VaciarTextBox();
                pnlCambiarContraseña.Visible = false;
                cbShowPass.Checked = false;
                gbAdministracion.Visible = true;
                MessageBox.Show("Contraseña cambiada con exito!");
                CrearMensajeRegistro($"El usuario {user.User} cambio con exito su contraseña.");
                ActualizarListado();
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
            btnEditPass.Visible = false;
            btnConfirmSol.Visible = true;
            btnCancelSol.Visible = true;
            CrearMensajeRegistro($"El usuario {user.User} ingreso a la seccion de solicitud de modificacion de datos de usuarios.");
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
            btnEditPass.Visible = true;
            CrearMensajeRegistro($"El usuario {user.User} cancelo la solicitud de modificacion de datos de usuario.");
        }

        private void btnConfirmSol_Click(object sender, EventArgs e)
        {
            
            Registro.SolicitarMod(txtUsuario.Text,txtContraseña.Text,cbRoles.Text,txtNombre.Text,txtApellido.Text,txtCorreo.Text);
            VolverViejosDatos();
            btnEditPass.Visible = true;
            MessageBox.Show("Solicitud Enviado Correctamente");
            CrearMensajeRegistro($"El usuario {user.User} realizo una solicitud de modificacion de datos de usuarios.");

        }

        private void btnSolis_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(Registro.MostrarSolicitud(), "Solicitud de Modificacion", MessageBoxButtons.YesNo);

            if(respuesta == DialogResult.Yes)
            {
                Registro.ConfirmarSolicitudMod();
                CrearMensajeRegistro($"El usuario {user.User} confirmo la modificacion solicitada de un usuario.");
                ActualizarListado();
            }
            else
            {
                Registro.CancelarSolicitud();
                CrearMensajeRegistro($"El usuario {user.User} rechazo la modificacion solicitada de un usuario.");
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
            CrearMensajeRegistro($"El usuario {user.User} ingreso a modificar un usuario.");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(modOn == true)
            {
                if(auxUser != null && auxPass != null)
                {
                    try
                    {
                        ERoles rol = (ERoles)Enum.Parse(typeof(ERoles), cbRoles.Text, true);
                        Usuario usuarioMod = new(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text, rol, txtCorreo.Text);
                        BaseDatos.ModificarUsuario(usuarioMod, auxUser);
                        DeshabilitarBoxes();
                        VaciarDatosUsuario();
                        pnlBotonera.Enabled = true;
                        btnOk.Visible = false;
                        btnNo.Visible = false;
                        MessageBox.Show("Modificacion Exitosa");
                        CrearMensajeRegistro($"El usuario {user.User} modifico exitosamente al usuario {auxUser}.");
                        ActualizarListado();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Algo Salio Mal");
                    }
                }
            }
            else
            {
                try
                {
                    Usuario nuevoUsuario = Registro.VerificarUsuario(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text, cbRoles.Text, txtCorreo.Text);
                    BaseDatos.AgregarUsuario(nuevoUsuario);
                    DeshabilitarBoxes();
                    VaciarDatosUsuario();
                    pnlBotonera.Enabled = true;
                    btnOk.Visible = false;
                    btnNo.Visible = false;
                    MessageBox.Show("Alta exitosa");
                    CrearMensajeRegistro($"El usuario {user.User} dio de alta al usuario {txtUsuario.Text}.");
                    ActualizarListado();
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
            CrearMensajeRegistro($"El usuario {user.User} ingreso a dar de alta un usuario nuevo.");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DeshabilitarBoxes();
            VaciarDatosUsuario();
            pnlBotonera.Enabled = true;
            btnOk.Visible = false;
            btnNo.Visible = false;
            CrearMensajeRegistro($"El usuario {user.User} cancelo el alta de un usuario.");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"Desea eliminar al usuario: {txtUsuario.Text.ToUpper()}?", "BAJA USUARIO", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    Usuario usuarioEliminar = BaseDatos.BuscarUsuario(txtUsuario.Text);
                    BaseDatos.EliminarUsuario(usuarioEliminar);
                    ActualizarListado();
                    VaciarDatosUsuario();
                    MessageBox.Show("Usuario dado de baja");
                    CrearMensajeRegistro($"El usuario {user.User} dio de baja al usuario {txtUsuario.Text}.");
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message, "Algo Salio Mal!"); 
                }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == String.Empty)
            {
                ActualizarListado();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarioBuscado = new();
            try
            {
                Usuario auxUser = BaseDatos.BuscarUsuario(txtBuscar.Text);
                CrearMensajeRegistro($"El usuario {user.User} realizo la busqueda del usuario {txtBuscar.Text}.");
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
