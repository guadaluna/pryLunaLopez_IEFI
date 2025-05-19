using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaLopez_IEFI
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        bool mostrarContraseña = false;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor complete los campos");
            }
            else
            {
                //conexionBD.usuario = txtUsuario.Text;
                //conexionBD.contrasena = txtContraseña.Text;

                //if (conexionBD.IniciarSesion())
                {
                    frmPrincipal form = new frmPrincipal();
                    form.Show();
                    this.Hide();
                }
                //else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void picVerContraseña_Click(object sender, EventArgs e)
        {
            mostrarContraseña = !mostrarContraseña;

            txtContraseña.UseSystemPasswordChar = !mostrarContraseña;

            picVerContraseña.Image = mostrarContraseña
                ? Properties.Resources.icons8_eye_15
                : Properties.Resources.icons8_closed_eye_15;
        }
    }
}
