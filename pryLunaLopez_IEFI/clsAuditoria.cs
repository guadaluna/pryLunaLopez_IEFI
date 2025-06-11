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
    public class clsAuditoria : clsConexionBD
    {
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
    }
}
