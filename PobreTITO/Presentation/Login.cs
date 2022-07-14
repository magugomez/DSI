using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text != "Usuario") {
                if (tbPassword.Text != "Contraseña")
                {
                    UserModel user=new UserModel();
                    var validLogin = user.LoginUser(tbUser.Text, tbPassword.Text);
                    if (validLogin == true)
                    {
                        Inicio inicio = new Inicio();
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña incorrecta");
                        tbPassword.Text = "Contraseña";
                        tbUser.Focus();
                    }
                }
                else msgError("Ingrese su contraseña");
            }
            else msgError("Ingrese su nombre de usuario");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
        }

   
        private void tbUser_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if(tbUser.Text=="Usuario") 
                tbUser.Text = ""; 
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "") 
                tbUser.Text = "Usuario";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Contraseña")
            {
                tbPassword.Text = "";
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Contraseña";
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            tbPassword.Text = "Contraseña";
            tbPassword.UseSystemPasswordChar = false;
            tbUser.Text = "Usuario";
            lblErrorMessage.Visible = false;
            this.Show();
        }
    }
}