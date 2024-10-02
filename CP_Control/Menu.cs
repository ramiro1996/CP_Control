using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Control
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            PanelCatalogos.Visible = false;
            PanelPresupuestos.Visible = false;
            PanelMovimientos.Visible = false;
            PanelDashBoard.Visible = false;
        }
        private void hideSubMenu()
        {
            if (PanelCatalogos.Visible == true)
            {
                PanelCatalogos.Visible = false;
            }
            if (PanelPresupuestos.Visible == true)
            {
                PanelPresupuestos.Visible = true;
            }
            if (PanelMovimientos.Visible == true)
            {
                PanelMovimientos.Visible = false;
            }
            if (PanelDashBoard.Visible == true)
            {
                PanelDashBoard.Visible = false;
            }   
        }
        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //Opciones Menú Lateral

        #region Catálogos
        private void Btn_Catalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelCatalogos);
        }

        private void Btn_Proyectos_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }

        private void Btn_Trabajadores_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }

        private void Btn_Materiales_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }
        #endregion
        #region Presupuestos
        private void Btn_Presupuestos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelPresupuestos);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }
        #endregion
        #region Movimientos
        private void Btn_Movimientos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelMovimientos);
        }
        private void Btn_Cobros_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }

        private void Btn_Nomina_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }

        private void Btn_OtrosGastos_Click(object sender, EventArgs e)
        {
            //Código...
            hideSubMenu();
        }

        #endregion

        private void Btn_DashBoard_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelDashBoard);
        }
    }
}
