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
    public partial class NuevoProveedor : Form
    {
        public event  EventHandler ProveedorNuevo;
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        private void NuevoProveedor_Load(object sender, EventArgs e)
        {

        }

    }
}
