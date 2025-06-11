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
    public partial class frmEditarItems : Form
    {
        private string tipo; // "Tareas" o "Lugares"
        clsItems items = new clsItems();

        public frmEditarItems(string tipoItem)
        {
            InitializeComponent();
            tipo = tipoItem;
        }

        private void frmEditarItems_Load(object sender, EventArgs e)
        {
            this.Text = "Editar " + tipo;
            CargarLista();
        }

        private void CargarLista()
        {
            lstItems.Items.Clear();
            DataTable dt = (tipo == "Tareas") ? items.ObtenerTareas() : items.ObtenerLugares();

            foreach (DataRow fila in dt.Rows)
            {
                lstItems.Items.Add(fila["Nombre"].ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevo = txtItems.Text.Trim();
            if (string.IsNullOrEmpty(nuevo)) return;

            if (tipo == "Tareas")
                items.AgregarTarea(nuevo);
            else
                items.AgregarLugar(nuevo);

            CargarLista();
            txtItems.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null || string.IsNullOrEmpty(txtItems.Text.Trim()))
                return;

            string viejo = lstItems.SelectedItem.ToString();
            string nuevo = txtItems.Text.Trim();

            if (tipo == "Tareas")
                items.EditarTarea(viejo, nuevo);
            else
                items.EditarLugar(viejo, nuevo);

            CargarLista();
            txtItems.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;

            string nombre = lstItems.SelectedItem.ToString();

            DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar '" + nombre + "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (tipo == "Tareas")
                    items.EliminarTarea(nombre);
                else
                    items.EliminarLugar(nombre);

                CargarLista();
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem != null)
            {
                txtItems.Text = lstItems.SelectedItem.ToString();
            }
        }
    }
}
