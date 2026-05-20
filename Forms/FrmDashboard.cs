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
    public partial class FrmDashboard : Form
    {
        private readonly DashboardService _svc = new DashboardService();

        public FrmDashboard()
        {
            InitializeComponent();
            Load += FrmDashboard_Load;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                new ClaSideBar(pnlSidebar, this).Configurar();
                CargarKpis();
                CargarAlertasStock();
                CargarUltimasVentas();
                CargarOrdenesPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarKpis()
        {
            var kpi = _svc.ObtenerKpis();
            MostrarKpi(pnlKpiVentas, "Ventas hoy", kpi.VentasHoy.ToString());
            MostrarKpi(pnlKpiIngresos, "Ingresos hoy", kpi.IngresosHoy.ToString("C"));
            MostrarKpi(pnlKpiProductos, "Bajo stock", kpi.ProductosBajoStock.ToString());
            MostrarKpi(pnlKpiClientes, "Clientes activos", kpi.ClientesActivos.ToString());
        }

        private void MostrarKpi(Panel panel, string titulo, string valor)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new Label
            {
                Text = valor,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(Font.FontFamily, 28, FontStyle.Bold)
            });
            panel.Controls.Add(new Label
            {
                Text = titulo,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30
            });
        }

        private void CargarAlertasStock()
        {
            var alertas = _svc.ObtenerAlertasStock();
            dgvAlertasStock.Columns.Clear();
            dgvAlertasStock.Columns.Add("SKU", "SKU");
            dgvAlertasStock.Columns.Add("Nombre", "Producto");
            dgvAlertasStock.Columns.Add("StockActual", "Stock actual");
            dgvAlertasStock.Columns.Add("StockMinimo", "Stock mínimo");
            dgvAlertasStock.Rows.Clear();
            foreach (var a in alertas)
                dgvAlertasStock.Rows.Add(a.SKU, a.Nombre, a.StockActual, a.StockMinimo);
        }

        private void CargarUltimasVentas()
        {
            var ventas = _svc.ObtenerUltimasVentas();
            dgvUltimasVentas.Columns.Clear();
            dgvUltimasVentas.Columns.Add("Id", "#");
            dgvUltimasVentas.Columns.Add("Cliente", "Cliente");
            dgvUltimasVentas.Columns.Add("Fecha", "Fecha");
            dgvUltimasVentas.Columns.Add("MetodoPago", "Método de pago");
            dgvUltimasVentas.Columns.Add("Total", "Total");
            dgvUltimasVentas.Columns.Add("Estado", "Estado");
            dgvUltimasVentas.Rows.Clear();
            foreach (var v in ventas)
                dgvUltimasVentas.Rows.Add(
                    v.Id, v.ClienteNombre,
                    v.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    v.MetodoPago,
                    v.Total.ToString("C"),
                    v.Estado);
        }

        private void CargarOrdenesPendientes()
        {
            var ordenes = _svc.ObtenerOrdenesPendientes();
            dgvOrdenesPendientes.Columns.Clear();
            dgvOrdenesPendientes.Columns.Add("Id", "#");
            dgvOrdenesPendientes.Columns.Add("Proveedor", "Proveedor");
            dgvOrdenesPendientes.Columns.Add("Fecha", "Fecha");
            dgvOrdenesPendientes.Columns.Add("Estado", "Estado");
            dgvOrdenesPendientes.Columns.Add("Total", "Total");
            dgvOrdenesPendientes.Rows.Clear();
            foreach (var o in ordenes)
                dgvOrdenesPendientes.Rows.Add(
                    o.Id, o.ProveedorNombre,
                    o.FechaCreacion.ToString("dd/MM/yyyy"),
                    o.Estado,
                    o.MontoTotal.ToString("C"));
        }

        private void FrmDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnNavVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnNavProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnNavInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnNavProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnNavOrdenes_Click(object sender, EventArgs e)
        {

        }

        private void btnNavClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnNavGarantias_Click(object sender, EventArgs e)
        {

        }

        private void btnNavReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnNavUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
