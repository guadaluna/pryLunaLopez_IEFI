using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaLopez_IEFI
{
    internal class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=RegistroLaboral;Trusted_Connection=True;";

        //conector
        SqlConnection conexionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        //Registro
        public string usuario;
        public string contrasena;

        public void ConectarBD()
        {
            conexionBaseDatos = new SqlConnection(cadenaConexion);

            nombreBaseDeDatos = conexionBaseDatos.Database;

            conexionBaseDatos.Open();

        }

        //TABLA USUARIOS
        //Iniciar sesion
        public bool IniciarSesion()
        {
            try
            {
                ConectarBD();

                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario AND Contraseña = @contrasena";
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
        }

        //Agregar empleado
        public void AgregarEmpleado()
        {
            try
            {
                ConectarBD();
                string consulta = "INSERT INTO Usuarios (NombreUsuario, Contraseña) VALUES (@usuario, @contrasena)";
                SqlCommand cmd = new SqlCommand(consulta, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

