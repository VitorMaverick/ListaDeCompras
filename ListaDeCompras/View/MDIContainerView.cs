using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras.View
{
    public partial class MDIContainerView : Form
    {
        public MDIContainerView()
        {
            InitializeComponent();
        }

        private void casasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CasaView casa = new CasaView();
            casa.MdiParent = this;
            casa.Show();
        }
    }
}
