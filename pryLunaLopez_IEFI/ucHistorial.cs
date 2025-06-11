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
    public partial class ucHistorial : UserControl
    {
        public ucHistorial()
        {
            InitializeComponent();
        }
        clsTareas tareas = new clsTareas();
        private void ucHistorial_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }

        public void CargarTareas()
        {
            clsTareas tareas = new clsTareas();
            DataTable dt = tareas.ObtenerNombres();
            dgvHistorial.DataSource = dt;
        }
    }
}
