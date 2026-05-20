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
    public partial class FrmClientes : Form
    {
        private readonly ClienteService _svc = new ClienteService();

        public FrmClientes()
        {
            InitializeComponent();
            Load += FrmClientes_Load;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
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

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
