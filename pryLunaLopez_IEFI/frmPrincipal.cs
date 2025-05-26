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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            InicializarControles();
        }

        public frmPrincipal(string usuario, DateTime horaInicio, int idAuditoria)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.horaInicioSesion = horaInicio;
            this.idAuditoriaActual = idAuditoria;

            conexion.usuario = usuario;
            conexion.horaInicio = horaInicio;
            conexion.idAuditoria = idAuditoria;

            InicializarControles();

            tiempoTrabajado = TimeSpan.Zero;
            timer.Interval = 1000;
            timer.Start();
        }

        private void InicializarControles()
        {
            personalizar();

            ucAuditorias.Dock = DockStyle.Fill;
            ucGestionUsuarios.Dock = DockStyle.Fill;

            panelFormulario.Controls.Add(ucAuditorias);
            panelFormulario.Controls.Add(ucGestionUsuarios);

            ucAuditorias.Visible = false;
            ucGestionUsuarios.Visible = false;
        }


        private int idAuditoriaActual;
        private DateTime horaInicioSesion;
        private TimeSpan tiempoTrabajado;

        private string usuarioActual;

        public string UsuarioSesion;
        public bool EsAdminSesion;


        clsConexionBD conexion = new clsConexionBD();

        ucAuditorias ucAuditorias = new ucAuditorias();
        ucGestionUsuarios ucGestionUsuarios = new ucGestionUsuarios();


        private void personalizar()
        {
            panelTareasSubMenu.Visible = false;
            panelAdminSubMenu.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelTareasSubMenu.Visible == true)
            {
                panelTareasSubMenu.Visible = false;
            }

            if (panelAdminSubMenu.Visible == true)
            {
                panelAdminSubMenu.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelTareasSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAdminSubMenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            horaInicioSesion = DateTime.Now;

            stripStatusLblUsuario.Text = "Usuario: " + usuarioActual;
            stripStatusLblFecha.Text = "Fecha: " + horaInicioSesion.ToString("dd/MM/yyyy");
            stripStatusLblTiempo.Text = "Tiempo: 00:00:00";

            timer.Interval = 1000;
            timer.Start();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            ucAuditorias.Visible = true;
            ucAuditorias.BringToFront();
            ucGestionUsuarios.Visible = false;
        }


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.horaFin = DateTime.Now;
            conexion.tiempoTrabajado = conexion.horaFin - conexion.horaInicio;
            conexion.RegistrarSesion();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tiempoTrabajado = DateTime.Now - horaInicioSesion;
            stripStatusLblTiempo.Text = tiempoTrabajado.ToString(@"hh\:mm\:ss");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (!frmLogIn.EsAdminSesion)
            {
                MessageBox.Show("No tienes permisos para acceder a la gestión de usuarios.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ucGestionUsuarios.Visible = true;
            ucGestionUsuarios.BringToFront();
            ucAuditorias.Visible = false;
        }
    }
}
