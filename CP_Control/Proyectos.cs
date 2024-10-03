using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Control.CP_Control
{
    public partial class Proyectos : Form
    {
        public Proyectos()
        {
            InitializeComponent();
        }

       
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Proyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_NuevoProyecto_Click(object sender, EventArgs e)
        {
            Form NuevoProyecto = new NuevoProyecto();
            NuevoProyecto.Show();
        }
    }
}
