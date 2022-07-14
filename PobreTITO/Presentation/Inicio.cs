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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMisReclamos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewReclamo_Click(object sender, EventArgs e)
        {
            Incidente incidente = new Incidente();
            incidente.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea cerrar la aplicacion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }
    }
}