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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            personalizar();
        }

        private void personalizar()
        {
            panelTareasSubMenu.Visible = false;
            panelAdminSubMenu.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelTareasSubMenu.Visible == true)
            {
                panelTareasSubMenu.Visible = false;
            }

            if (panelAdminSubMenu.Visible == true)
            {
                panelAdminSubMenu.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelTareasSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAdminSubMenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarSubMenu();
        }

    }
}
