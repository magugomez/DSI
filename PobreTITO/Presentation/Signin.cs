using DataAccess;
using Domain;

namespace Presentation
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email") tbEmail.Text = "";
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "") tbEmail.Text = "Email";
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Nombre completo") tbName.Text = "";
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "") tbName.Text = "Nombre completo";
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "Nombre de usuario") tbUser.Text = "";
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "") tbUser.Text = "Nombre de usuario";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Contraseña") tbPassword.Text = "";
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "") tbPassword.Text = "Contraseña";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            var validSignin = user.SigninUser(tbEmail.Text, tbName.Text, tbUser.Text, tbPassword.Text);
            if (validSignin == true)
            {
                MessageBox.Show("Usuaro registrado correctamente");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}