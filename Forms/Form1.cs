using Npgsql;

namespace ISW_II_2
{
    public partial class Login : Form
    {
        private readonly AuthService _auth = new AuthService();

        public Login()
        {
            InitializeComponent();
        }

        private void txtNomUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;

            if (string.IsNullOrWhiteSpace(txtNomUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                var resultado = _auth.Autenticar(txtNomUsuario.Text.Trim(), txtContraseña.Text);

                if (resultado.Exitoso)
                {
                    Sesion.UsuarioId      = resultado.UsuarioId;
                    Sesion.NombreCompleto = resultado.NombreCompleto!;
                    Sesion.Rol            = resultado.Rol!;
                    MessageBox.Show($"Bienvenido, {resultado.NombreCompleto} ({resultado.Rol})");
                    new FrmDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje);
                    txtContraseña.Clear();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}");
            }
        }
    }
}
