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
    public partial class ucAuditorias : UserControl
    {
        public ucAuditorias()
        {
            InitializeComponent();
        }

        clsConexionBD conexion = new clsConexionBD();

        private void ucAuditorias_Load(object sender, EventArgs e)
        {
            conexion.MostrarAuditoria(dgvAuditoria);

            dgvAuditoria.Columns["Usuario"].HeaderText = "Usuario";
            dgvAuditoria.Columns["Fecha"].HeaderText = "Fecha";
            dgvAuditoria.Columns["HoraInicio"].HeaderText = "Hora Inicio";
            dgvAuditoria.Columns["HoraFin"].HeaderText = "Hora Fin";
            dgvAuditoria.Columns["TiempoTrabajado"].HeaderText = "Tiempo Trabajado";

        }
    }
}
