using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaLopez_IEFI
{
    public class clsLogin : clsConexionBD
    {
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
        public int ObtenerIdUsuario(string nombreUsuario)
        {
            int id = -1;

            try
            {
                ConectarBD();

                string consulta = "SELECT Id FROM Usuarios WHERE Usuario = @usuario";
                comandoBaseDatos = new SqlCommand(consulta, conexionBaseDatos);
                comandoBaseDatos.Parameters.AddWithValue("@usuario", nombreUsuario);

                object resultado = comandoBaseDatos.ExecuteScalar();

                if (resultado != null)
                {
                    id = Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del usuario: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }

            return id;
        }
    }

}
