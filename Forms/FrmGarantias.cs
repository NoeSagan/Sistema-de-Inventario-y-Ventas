using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISW_II_2
{
    public partial class FrmGarantias : Form
    {
        public FrmGarantias()
        {
            InitializeComponent();
            Load += FrmGarantias_Load;
        }

        private void FrmGarantias_Load(object sender, EventArgs e)
        {
            try
            {
                new ClaSideBar(pnlSidebar, this).Configurar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
