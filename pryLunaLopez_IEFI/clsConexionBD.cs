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
    public class clsConexionBD
    {
        //cadena de conexion
        protected string cadenaConexion = "Server=localhost;Database=RegistroLaboral;Trusted_Connection=True;";

        //conector
        protected SqlConnection conexionBaseDatos;

        protected SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        //Login
        public string nombre;
        public string telefono;
        public string dni;
        public string mail;
        public string usuario;
        public string contrasena;
        public bool esAdmin;

        public int idSesionActual;
        public int idAuditoria;
        public DateTime fecha;
        public DateTime horaInicio = DateTime.Now;
        public DateTime horaFin;
        public TimeSpan tiempoTrabajado;

        public int tareaId;
        public int lugarId;
        public string comentario;
        public string detalle;



        protected void ConectarBD()
        {
            conexionBaseDatos = new SqlConnection(cadenaConexion);

            nombreBaseDeDatos = conexionBaseDatos.Database;

            conexionBaseDatos.Open();

        }

        protected void DesconectarBD()
        {
            if (conexionBaseDatos.State == ConnectionState.Open)
                conexionBaseDatos.Close();
        }

    }
}
    


