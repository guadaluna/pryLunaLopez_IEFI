using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace pryLunaLopez_IEFI
{
    internal class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=RegistroLaboral;Trusted_Connection=True;";

        //conector
        SqlConnection conexionBaseDatos;

        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        //Login
        public string nombre;
        public string usuario;
        public string contrasena;
        public bool esAdmin;

        public int idSesionActual;
        public int idAuditoria;
        public DateTime horaInicio;
        public DateTime horaFin;
        public TimeSpan tiempoTrabajado;



        public void ConectarBD()
        {
            conexionBaseDatos = new SqlConnection(cadenaConexion);

            nombreBaseDeDatos = conexionBaseDatos.Database;

            conexionBaseDatos.Open();

        }

        public void DesconectarBD()
        {
            if (conexionBaseDatos.State == ConnectionState.Open)
                conexionBaseDatos.Close();
        }

        public bool IniciarSesion()
        {
            try
            {
                ConectarBD();

                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contrasena";
                SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);

                int contador = (int)comando.ExecuteScalar();

                return contador > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return false;
            }
            finally
            {
                DesconectarBD();
            }
        }

        public int InsertarAuditoria()
        {
            int idInsertado = 0;

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Auditoria (Usuario, Fecha, HoraInicio) " +
                               "OUTPUT INSERTED.Id " +
                               "VALUES (@Usuario, @Fecha, @HoraInicio)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Fecha", horaInicio.Date);
                    cmd.Parameters.AddWithValue("@HoraInicio", horaInicio);

                    con.Open();
                    idInsertado = (int)cmd.ExecuteScalar();
                }
            }

            return idInsertado;
        }

        public void CerrarAuditoria()
        {
            try
            {
                ConectarBD();
                string consulta = @"
                UPDATE Auditoria
                SET HoraFin = CONVERT(TIME, @HoraFin),
                    TiempoTrabajado = @Tiempo
                WHERE Usuario = @Usuario AND HoraFin IS NULL";

                SqlCommand cmd = new SqlCommand(consulta, conexionBaseDatos);
                cmd.Parameters.AddWithValue("@HoraFin", horaFin);
                cmd.Parameters.AddWithValue("@Tiempo", tiempoTrabajado);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void MostrarAuditoria(DataGridView dgv)
        {
            try
            {
                ConectarBD();
                DataTable tabla = new DataTable();
                string consulta = "SELECT * FROM Auditoria";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                adaptador.Fill(tabla);
                dgv.DataSource = tabla;
            }
            finally
            {
                DesconectarBD();
            }
        }


        public void RegistrarSesion()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Auditoria SET HoraFin = @HoraFin, TiempoTrabajado = @TiempoTrabajado WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@HoraFin", horaFin);
                    cmd.Parameters.AddWithValue("@TiempoTrabajado", tiempoTrabajado.ToString(@"hh\:mm\:ss"));
                    cmd.Parameters.AddWithValue("@Id", idAuditoria);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
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
                string consulta = "INSERT INTO Usuarios (Nombre, Usuario, Contraseña, EsAdmin) VALUES (@Nombre, @Usuario, @Contraseña, @EsAdmin)";
                using (SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contraseña", contrasena);
                    comando.Parameters.AddWithValue("@EsAdmin", esAdmin);

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
                string consulta = "UPDATE Usuarios SET Nombre = @Nombre, Usuario = @Usuario, Contraseña = @Contraseña, EsAdmin = @EsAdmin WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contraseña", contrasena);
                    comando.Parameters.AddWithValue("@EsAdmin", esAdmin);

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

        public bool usuarioExistente(string usuario, int? id = null)
        {
            try
            {
                ConectarBD();
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario";
                if (id != null)
                {
                    consulta += " AND Id <> @Id";
                }

                using (SqlCommand cmd = new SqlCommand(consulta, conexionBaseDatos))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    if (id != null)
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                    }

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            finally
            {
                DesconectarBD();
            }
        }

        public bool EsUsuarioAdmin(string usuario)
        {
            bool esAdmin = false;
            try
            {
                ConectarBD();
                string consulta = "SELECT EsAdmin FROM Usuarios WHERE Usuario = @Usuario";
                using (SqlCommand cmd = new SqlCommand(consulta, conexionBaseDatos))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        esAdmin = Convert.ToBoolean(resultado);
                    }
                }
            }
            finally
            {
                DesconectarBD();
            }
            return esAdmin;
        }
    }
}
    


