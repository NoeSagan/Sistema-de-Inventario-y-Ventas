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
    public partial class FrmOrdenesCompra : Form
    {
        private readonly OrdenCompraService _svc = new OrdenCompraService();
        private DataGridView dgvOrdenes = null!;

        public FrmOrdenesCompra()
        {
            InitializeComponent();
            Load += FrmOrdenesCompra_Load;
            txtUsuarioConectado.Text = $"{Sesion.NombreCompleto}  |  {Sesion.Rol}";
        }

        private void FrmOrdenesCompra_Load(object sender, EventArgs e)
        {
            try
            {
                new ClaSideBar(pnlSidebar, this).Configurar();
                ConfigurarGrid();
                ConfigurarFiltro();
                CargarOrdenes();
                WirarEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar órdenes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvOrdenes = new DataGridView
            {
                Dock = DockStyle.Bottom,
                Height = 500,
                ReadOnly = true,
                AllowUserToAddRows = false,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            };
            dgvOrdenes.Columns.Add("gId", "#");
            dgvOrdenes.Columns.Add("gProveedor", "Proveedor");
            dgvOrdenes.Columns.Add("gFecha", "Fecha");
            dgvOrdenes.Columns.Add("gEstado", "Estado");
            dgvOrdenes.Columns.Add("gTotal", "Total");
            Controls.Add(dgvOrdenes);
        }

        private void ConfigurarFiltro()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Todas", "Pendiente", "Recibida", "Cancelada" });
            comboBox1.SelectedIndex = 0;
        }

        private void WirarEventos()
        {
            btnNuevaOrden.Click += BtnNuevaOrden_Click;
            btnVerDetalleOrden.Click += BtnVerDetalle_Click;
            btnMarcarRecibida.Click += BtnMarcarRecibida_Click;
            btnCancelarOrden.Click += BtnCancelarOrden_Click;
            comboBox1.SelectedIndexChanged += (s, ev) => CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            try
            {
                string filtro = comboBox1.SelectedItem?.ToString() ?? "Todas";
                var ordenes = filtro == "Todas"
                    ? _svc.ObtenerTodas()
                    : _svc.ObtenerPorEstado(filtro);

                dgvOrdenes.Rows.Clear();
                foreach (var o in ordenes)
                    dgvOrdenes.Rows.Add(
                        o.Id, o.ProveedorNombre,
                        o.FechaCreacion.ToString("dd/MM/yyyy"),
                        o.Estado,
                        o.MontoTotal.ToString("C"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar órdenes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? ObtenerIdSeleccionado()
        {
            if (dgvOrdenes.CurrentRow == null) return null;
            return Convert.ToInt32(dgvOrdenes.CurrentRow.Cells["gId"].Value);
        }

        private void BtnNuevaOrden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para crear una orden diseñe el formulario de nueva orden de compra.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Seleccione una orden.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Detalle de la orden #{id}: diseñe el formulario de detalle.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMarcarRecibida_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Seleccione una orden.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string estado = dgvOrdenes.CurrentRow!.Cells["gEstado"].Value?.ToString() ?? "";
            if (estado != "Pendiente")
            {
                MessageBox.Show("Solo se pueden marcar como recibidas las órdenes pendientes.", "Estado inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show($"¿Marcar la orden #{id} como recibida?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _svc.CambiarEstado(id.Value, "Recibida");
                CargarOrdenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelarOrden_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Seleccione una orden.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string estado = dgvOrdenes.CurrentRow!.Cells["gEstado"].Value?.ToString() ?? "";
            if (estado == "Recibida" || estado == "Cancelada")
            {
                MessageBox.Show("No se puede cancelar una orden ya recibida o cancelada.", "Estado inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show($"¿Cancelar la orden #{id}?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _svc.CambiarEstado(id.Value, "Cancelada");
                CargarOrdenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
