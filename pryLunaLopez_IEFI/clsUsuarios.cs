using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pryLunaLopez_IEFI
{
    public class clsUsuarios : clsConexionBD
    {
        public void MostrarUsuarios(DataGridView dgv)
        {
            try
            {
                ConectarBD();
                DataTable tabla = new DataTable();
                string consulta = "SELECT * FROM Usuarios";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                adaptador.Fill(tabla);
                dgv.DataSource = tabla;

                dgv.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar usuarios: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void agregarUsuario()
        {
            try
            {
                ConectarBD();
                string consulta = "INSERT INTO Usuarios (Nombre, Usuario, Contraseña, EsAdmin, Telefono, DNI, Mail) VALUES (@Nombre, @Usuario, @Contraseña, @EsAdmin, @Telefono, @DNI, @Mail)";
                using (SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contraseña", contrasena);
                    comando.Parameters.AddWithValue("@EsAdmin", esAdmin);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@DNI", dni);
                    comando.Parameters.AddWithValue("@Mail", mail);

                    comando.ExecuteNonQuery();

                }

                MessageBox.Show("El usuario ha sido añadido exitosamente", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void actualizarUsuario(int id)
        {
            try
            {
                ConectarBD();
                string consulta = "UPDATE Usuarios SET Nombre = @Nombre, Usuario = @Usuario, Contraseña = @Contraseña, EsAdmin = @EsAdmin, Telefono = @Telefono, DNI = @DNI, Mail = @Mail WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contraseña", contrasena);
                    comando.Parameters.AddWithValue("@EsAdmin", esAdmin);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@DNI", dni);
                    comando.Parameters.AddWithValue("@Mail", mail);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario actualizado correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }
        public void eliminarUsuario(int id)
        {
            try
            {
                ConectarBD();
                string consulta = "DELETE FROM Usuarios WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }


    }
}
