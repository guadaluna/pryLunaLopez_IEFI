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

        #region Variables
        private int idAuditoriaActual;
        private DateTime horaInicioSesion;
        private TimeSpan tiempoTrabajado;
        private string usuarioActual;

        clsAuditoria auditoria = new clsAuditoria();

        ucAuditorias ucAuditorias = new ucAuditorias();
        ucGestionUsuarios ucGestionUsuarios = new ucGestionUsuarios();
        ucTareas ucTareas = new ucTareas();
        ucHistorial ucHistorial = new ucHistorial();
        #endregion


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

            auditoria.usuario = usuario;
            auditoria.horaInicio = horaInicio;
            auditoria.idAuditoria = idAuditoria;

            InicializarControles();
        }

        private void InicializarControles()
        {
            OcultarSubMenus();

            List<UserControl> controles = new List<UserControl> { ucAuditorias, ucGestionUsuarios, ucTareas, ucHistorial };

            foreach (var ctrl in controles)
            {
                ctrl.Dock = DockStyle.Fill;
                ctrl.Visible = false;
                panelFormulario.Controls.Add(ctrl);
            }
        }

        private void OcultarSubMenus()
        {
            panelTareasSubMenu.Visible = false;
            panelAdminSubMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void MostrarControl(UserControl control)
        {
            ucAuditorias.Visible = false;
            ucGestionUsuarios.Visible = false;
            ucTareas.Visible = false;
            ucHistorial.Visible = false;

            control.Visible = true;
            control.BringToFront();
        }

        private void RegistrarCierreSesion()
        {
            auditoria.horaFin = DateTime.Now;
            auditoria.tiempoTrabajado = auditoria.horaFin - auditoria.horaInicio;
            auditoria.RegistrarSesion();
        }

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
            MostrarSubMenu(panelTareasSubMenu);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAdminSubMenu);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            horaInicioSesion = DateTime.Now;

            lblBienvenido.Text = $"Bienvenido {usuarioActual}";
            stripStatusLblUsuario.Text = "Usuario: " + usuarioActual;
            stripStatusLblFecha.Text = "Fecha: " + horaInicioSesion.ToString("dd/MM/yyyy");
            stripStatusLblTiempo.Text = "Tiempo: 00:00:00";

            timer.Interval = 1000;
            timer.Start();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            MostrarControl(ucAuditorias);
        }


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistrarCierreSesion();
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
            MostrarControl(ucGestionUsuarios);
        }

        private void btnRegistrarTarea_Click(object sender, EventArgs e)
        {
            MostrarControl(ucTareas);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (!frmLogIn.EsAdminSesion)
            {
                MessageBox.Show("No tienes permisos para acceder al historial.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MostrarControl(ucHistorial);
        }
    

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RegistrarCierreSesion();
                frmLogIn logIn = new frmLogIn();
                logIn.Show();
                this.Hide();
            }
        }
    }
}
