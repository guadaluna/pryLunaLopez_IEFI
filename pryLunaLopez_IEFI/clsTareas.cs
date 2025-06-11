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
    public class clsTareas : clsConexionBD
    {
        public void InsertarTarea()
        {
            try
            {
                ConectarBD();

                string consulta = "INSERT INTO Tareas (Usuario, Fecha, TareaId, LugarId, Detalles, Comentario) " +
                                  "VALUES (@Usuario, @Fecha, @TareaId, @LugarId, @Detalles, @Comentario)";

                comandoBaseDatos = new SqlCommand(consulta, conexionBaseDatos);
                comandoBaseDatos.Parameters.AddWithValue("@Usuario", usuario);
                comandoBaseDatos.Parameters.AddWithValue("@Fecha", fecha);
                comandoBaseDatos.Parameters.AddWithValue("@TareaId", tareaId);
                comandoBaseDatos.Parameters.AddWithValue("@LugarId", lugarId);
                comandoBaseDatos.Parameters.AddWithValue("@Detalles", detalle);
                comandoBaseDatos.Parameters.AddWithValue("@Comentario", comentario);

                comandoBaseDatos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la tarea: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }
        }

        public void MostrarTareas(DataGridView dgv)
        {
            try
            {
                ConectarBD();
                DataTable tabla = new DataTable();
                string consulta = "SELECT * FROM Tareas";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                adaptador.Fill(tabla);
                dgv.DataSource = tabla;
            }
            finally
            {
                DesconectarBD();
            }
        }

        public DataTable ObtenerNombres()
        {
            DataTable dt = new DataTable();

            try
            {
                ConectarBD();

                string consulta = @"
            SELECT 
                T.Usuario,
                T.Fecha,
                TAR.Nombre AS Tarea,
                LUG.Nombre AS Lugar,
                T.Detalles,
                T.Comentario
            FROM 
                Tareas T
            JOIN 
                OpcionesTareas TAR ON T.TareaId = TAR.Id
            JOIN 
                OpcionesLugares LUG ON T.LugarId = LUG.Id";

                SqlCommand cmd = new SqlCommand(consulta, conexionBaseDatos);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tareas: " + ex.Message);
            }
            finally
            {
                DesconectarBD();
            }

            return dt;
        }


    }
}
