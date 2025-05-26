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
        clsConexionBD conexionBD = new clsConexionBD();

        bool mostrarContraseña = false;
        public static string UsuarioSesion = "";
        public static bool EsAdminSesion = false;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                mensajeError("Por favor complete los campos");
            }
            else
            {
                conexionBD.usuario = txtUsuario.Text;
                conexionBD.contrasena = txtContraseña.Text;

                if (conexionBD.IniciarSesion())
                {
                    UsuarioSesion = txtUsuario.Text;
                    EsAdminSesion = conexionBD.EsUsuarioAdmin(txtUsuario.Text);

                    conexionBD.horaInicio = DateTime.Now;

                    int idAuditoria = conexionBD.InsertarAuditoria();

                    frmPrincipal form = new frmPrincipal(txtUsuario.Text, conexionBD.horaInicio, idAuditoria);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    mensajeError("Usuario o contraseña incorrectos");
                }
            }
        }

        private void mensajeError(String mensaje)
        {
            lblError.Text = "    " + mensaje;
            lblError.Visible = true;
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
