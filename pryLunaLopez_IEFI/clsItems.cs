using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaLopez_IEFI
{
    public class clsItems : clsConexionBD
    {
        public void cargarCmbTareas(ComboBox combo)
        {
            try
            {
                ConectarBD();

                string consulta = $"SELECT Id, Nombre FROM OpcionesTareas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                combo.DataSource = tabla;
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar OpcionesTareas: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }
        public void cargarCmbLugares(ComboBox combo)
        {
            try
            {
                ConectarBD();

                string consulta = $"SELECT Id, Nombre FROM OpcionesLugares";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                combo.DataSource = tabla;
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar OpcionesLugares: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public DataTable ObtenerTareas()
        {
            DataTable tabla = new DataTable();
            try
            {
                ConectarBD();
                string consulta = "SELECT Id, Nombre FROM OpcionesTareas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tareas: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }

            return tabla;
        }

        public DataTable ObtenerLugares()
        {
            DataTable tabla = new DataTable();
            try
            {
                ConectarBD();
                string consulta = "SELECT Id, Nombre FROM OpcionesLugares";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener lugares: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }

            return tabla;
        }
        public void AgregarTarea(string nombre)
        {
            try
            {
                ConectarBD();
                string consulta = "INSERT INTO OpcionesTareas (Nombre) VALUES (@Nombre)";
                SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tarea: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void AgregarLugar(string nombre)
        {
            try
            {
                ConectarBD();
                string consulta = "INSERT INTO OpcionesLugares (Nombre) VALUES (@Nombre)";
                SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar lugar: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void EliminarTarea(string nombre)
        {
            try
            {
                ConectarBD();
                string consulta = "DELETE FROM OpcionesTareas WHERE Nombre = @Nombre";
                SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar tarea: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void EliminarLugar(string nombre)
        {
            try
            {
                ConectarBD();
                string consulta = "DELETE FROM OpcionesLugares WHERE Nombre = @Nombre";
                SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar lugar: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void EditarTarea(string nombreViejo, string nombreNuevo)
        {
            try
            {
                ConectarBD();
                string consulta = "UPDATE OpcionesTareas SET Nombre = @Nuevo WHERE Nombre = @Viejo";
                SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
                comando.Parameters.AddWithValue("@Nuevo", nombreNuevo);
                comando.Parameters.AddWithValue("@Viejo", nombreViejo);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar tarea: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void EditarLugar(string nombreViejo, string nombreNuevo)
        {
            try
            {
                ConectarBD();
                string consulta = "UPDATE OpcionesLugares SET Nombre = @Nuevo WHERE Nombre = @Viejo";
                SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
                comando.Parameters.AddWithValue("@Nuevo", nombreNuevo);
                comando.Parameters.AddWithValue("@Viejo", nombreViejo);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar lugar: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }
    }

}
