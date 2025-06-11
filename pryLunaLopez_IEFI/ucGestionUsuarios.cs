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
    public partial class ucGestionUsuarios : UserControl
    {
        public ucGestionUsuarios()
        {
            InitializeComponent();
        }

        clsUsuarios usuarios = new clsUsuarios();
        clsLogin usuariosLogin = new clsLogin();

        private int idSeleccionado = -1;
        public string UsuarioSesion;

        private void ucGestionUsuarios_Load(object sender, EventArgs e)
        {
            usuarios.MostrarUsuarios(dgvUsuarios);
            dgvUsuarios.AllowUserToAddRows = false;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "" || txtTelefono.Text == "" || txtDNI.Text == "" || txtMail.Text == "" || (!optSi.Checked && !optNo.Checked))
            {
                MessageBox.Show("Por favor complete todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuariosLogin.usuarioExistente(txtUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario ya existe. Elija otro.", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuarios.nombre = txtNombre.Text;
                usuarios.usuario = txtUsuario.Text;
                usuarios.contrasena = txtContraseña.Text;
                usuarios.esAdmin = optSi.Checked;
                usuarios.telefono = txtTelefono.Text;
                usuarios.dni = txtDNI.Text;
                usuarios.mail = txtMail.Text;

                usuarios.agregarUsuario();
                cargarUsuarios();
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
                bool esAdmin = Convert.ToBoolean(fila.Cells["EsAdmin"].Value);
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtDNI.Text = fila.Cells["DNI"].Value.ToString();
                txtMail.Text = fila.Cells["Mail"].Value.ToString();
                optSi.Checked = esAdmin;
                optNo.Checked = !esAdmin;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null || dgvUsuarios.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione un usuario para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombre.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "" || (!optSi.Checked && !optNo.Checked))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);

            if (usuariosLogin.usuarioExistente(txtUsuario.Text, id))
            {
                MessageBox.Show("Ya existe otro usuario con ese nombre", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            usuarios.nombre = txtNombre.Text;
            usuarios.usuario = txtUsuario.Text;
            usuarios.contrasena = txtContraseña.Text;
            usuarios.esAdmin = optSi.Checked;
            usuarios.telefono = txtTelefono.Text;
            usuarios.dni = txtDNI.Text;
            usuarios.mail = txtMail.Text;

            int filaSeleccionada = dgvUsuarios.CurrentRow.Index;

            usuarios.actualizarUsuario(id);

            cargarUsuarios(limpiarCampos: false);

            if (dgvUsuarios.Rows.Count > filaSeleccionada)
            {
                dgvUsuarios.Rows[filaSeleccionada].Selected = true;
            }

        }

        private void cargarUsuarios(bool limpiarCampos = true)
        {
            usuarios.MostrarUsuarios(dgvUsuarios);
            dgvUsuarios.ClearSelection();

            if (limpiarCampos)
            {
                idSeleccionado = -1;
                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                optSi.Checked = false;
                optNo.Checked = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null || dgvUsuarios.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);
            string usuarioSeleccionado = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();

            if (usuarioSeleccionado == UsuarioSesion)
            {
                MessageBox.Show("No puedes eliminar al usuario con el que iniciaste sesión", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                usuarios.eliminarUsuario(id);
                cargarUsuarios();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
}
