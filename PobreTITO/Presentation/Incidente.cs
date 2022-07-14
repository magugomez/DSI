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
    public partial class Incidente : Form
    {
        public Incidente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (combTipo.Text!=null)
            {
                if (tbDescription.Text != "")
                {
                    if (tbArea.Text != "")
                    {
                        if (tbDireccion.Text != "")
                        {
                            UserModel incidente = new UserModel();
                            var validNewIncidente = incidente.newIncidente(combTipo.Text, tbDescription.Text, tbArea.Text, tbDireccion.Text);
                            if (validNewIncidente == true)
                            {
                                MessageBox.Show("Incidente registrado correctamente");
                                Inicio inicio = new Inicio();
                                inicio.Show();
                                this.Hide();
                            }
                            else msgError("Debe indicar la dirección donde sucedió en incidente");
                        }
                        else msgError("Debe indicar un área o barrio donde sucedió el incidente");
                    }
                    else msgError("Debe escribir una descripcion del incidente");
                }
                else msgError("Debe indicar el tipo de incidente");
            }
        }

        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}