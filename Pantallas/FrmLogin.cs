using LibClases;
namespace Pantallas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsuario.Text = "admin";
            txtContraseña.Text = "admin";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Registro.ConfirmarUsuario(txtUsuario.Text, txtContraseña.Text))
                {
                    PCMaker.Cargar();
                    FrmMenuPrincipal inicio = new FrmMenuPrincipal(txtUsuario.Text);
                    inicio.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo Salio Mal!");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}