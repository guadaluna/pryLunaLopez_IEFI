using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace pryLunaLopez_IEFI
{
    public partial class ucTareas : UserControl
    {
        public ucTareas()
        {
            InitializeComponent();
        }

        clsItems items = new clsItems();
        clsTareas tareas = new clsTareas();
        clsLogin login = new clsLogin();

        private bool esAdmin;

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            panelReclamos.Visible = !panelReclamos.Visible;
            if (panelReclamos.Visible)
            {
                btnReclamos.Text = "Reclamos ▲";
            }
            else
            {
                btnReclamos.Text = "Reclamos ▼";
            }

        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            panelLicencia.Visible = !panelLicencia.Visible;
            if (panelLicencia.Visible)
            {
                btnLicencia.Text = "Licencia ▲";
            }

            else
            {
                btnLicencia.Text = "Licencia ▼";
            }

        }

        private void btnUniforme_Click(object sender, EventArgs e)
        {
            panelUniforme.Visible = !panelUniforme.Visible;
            if (panelUniforme.Visible)
            {
                btnUniforme.Text = "Uniforme ▲";
            }
            else
            {
                btnUniforme.Text = "Uniforme ▼";
            }
        }

        private void ucTareas_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = DateTime.Today;

            esAdmin = frmLogIn.EsAdminSesion;
            btnEditarTarea.Visible = esAdmin;
            btnEditarLugar.Visible = esAdmin;

            items.cargarCmbTareas(cmbTarea);
            items.cargarCmbLugares(cmbLugar);
        }


        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            frmEditarItems editar = new frmEditarItems("Tareas");
            editar.ShowDialog();
            items.cargarCmbTareas(cmbTarea);
        }

        private void CheckBox_UnicoPorCategoria_CheckedChanged(object sender, EventArgs e)
        {
            UICheckBox chk = sender as UICheckBox;
            if (chk.Checked && chk.Parent is UIPanel panel)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is UICheckBox cb && cb != chk)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private string detallesCadena()
        {
            List<string> detalles = new List<string>();

            if (chkSalario.Checked) detalles.Add("Salario");
            if (chkRecibo.Checked) detalles.Add("Recibo");
            if (chkHorasExtras.Checked) detalles.Add("Horas Extras");
            if (chkBonificaciones.Checked) detalles.Add("Bonificaciones");
            //Licencia
            if (chkEnfermedad.Checked) detalles.Add("Enfermedad");
            if (chkVacacion.Checked) detalles.Add("Vacación");
            if (chkMaternidad.Checked) detalles.Add("Maternidad/Paternidad");
            if (chkDuelo.Checked) detalles.Add("Duelo familiar");
            //Uniforme
            if (chkInsumos.Checked) detalles.Add("Insumos");
            if (chkIncompleto.Checked) detalles.Add("Incompleto");
            if (chkDeteriorado.Checked) detalles.Add("Deteriorado");
            if (chkReemplazo.Checked) detalles.Add("Reemplazo");
            return string.Join(", ", detalles);

        }
        private bool checkboxSeleccionado()
        {
            return chkSalario.Checked || chkRecibo.Checked || chkHorasExtras.Checked || chkBonificaciones.Checked ||
                   chkEnfermedad.Checked || chkVacacion.Checked || chkMaternidad.Checked || chkDuelo.Checked ||
                   chkInsumos.Checked || chkIncompleto.Checked || chkDeteriorado.Checked || chkReemplazo.Checked;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedItem == null || cmbLugar.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una tarea y un lugar.");
                return;
            }

            string fecha = dtpFecha.Value.ToShortDateString();
            string tarea = cmbTarea.Text;
            string lugar = cmbLugar.Text;

            dgvTareas.Rows.Add(fecha, tarea, lugar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que querés cancelar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                limpiarCampos();
            }
        }

        private void limpiarCampos()
        {
            //Limpiar campos
            dtpFecha.Value = DateTime.Today;
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            txtComentario.Clear();

            //Reclamos
            chkSalario.Checked = false;
            chkRecibo.Checked = false;
            chkHorasExtras.Checked = false;
            chkBonificaciones.Checked = false;
            //Licencia
            chkEnfermedad.Checked = false;
            chkVacacion.Checked = false;
            chkMaternidad.Checked = false;
            chkDuelo.Checked = false;
            //Uniforme
            chkInsumos.Checked = false;
            chkIncompleto.Checked = false;
            chkDeteriorado.Checked = false;
            chkReemplazo.Checked = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int idUsuario = login.ObtenerIdUsuario(frmLogIn.UsuarioSesion);

            if (cmbTarea.SelectedValue == null || cmbLugar.SelectedValue == null ||
                !checkboxSeleccionado() || txtComentario.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos y seleccione al menos un detalle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            tareas.usuario = frmLogIn.UsuarioSesion;
            tareas.fecha = dtpFecha.Value;
            tareas.tareaId = Convert.ToInt32(cmbTarea.SelectedValue);
            tareas.lugarId = Convert.ToInt32(cmbLugar.SelectedValue);
            tareas.detalle = detallesCadena();
            tareas.comentario = txtComentario.Text;

            tareas.InsertarTarea();

            foreach (Control control in this.Parent.Controls)
            {
                if (control is ucHistorial historial)
                {
                    historial.CargarTareas();
                    break;
                }
            }

            MessageBox.Show("Tarea guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();

        }

        private void btnEditarLugar_Click(object sender, EventArgs e)
        {
            frmEditarItems editar = new frmEditarItems("Lugares");
            editar.ShowDialog();
            items.cargarCmbLugares(cmbLugar);
        }
    }
}
