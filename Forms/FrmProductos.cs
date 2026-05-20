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
    public partial class FrmProductos : Form
    {
        private readonly ProductoService  _svc    = new ProductoService();
        private readonly CategoriaService _catSvc = new CategoriaService();
        private List<Producto>  _productos   = new List<Producto>();
        private List<Categoria> _categorias  = new List<Categoria>();

        public FrmProductos()
        {
            InitializeComponent();
            Load += FrmProductos_Load;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                new ClaSideBar(pnlSidebar, this).Configurar();
                CargarFiltros();
                CargarProductos();
                WirarEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WirarEventos()
        {
            txtBuscarProducto.TextChanged           += (s, ev) => CargarProductos();
            cmbFiltroCategoria.SelectedIndexChanged += (s, ev) => CargarProductos();
            cmbFiltroEstado.SelectedIndexChanged    += (s, ev) => CargarProductos();
            btnNuevoProducto.Click   += BtnNuevoProducto_Click;
            btnEditarProducto.Click  += BtnEditarProducto_Click;
            btnDesactivar.Click      += BtnDesactivar_Click;
            btnExportarProductos.Click += BtnExportar_Click;
        }

        private void CargarFiltros()
        {
            _categorias = _catSvc.ObtenerTodas();

            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.Add(new Categoria { Id = 0, Nombre = "Todos" });
            foreach (var cat in _categorias)
                cmbFiltroCategoria.Items.Add(cat);
            cmbFiltroCategoria.DisplayMember = "Nombre";
            cmbFiltroCategoria.SelectedIndex = 0;

            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.AddRange(new object[] { "Todos", "Activo", "Agotado", "Descontinuado" });
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void CargarProductos()
        {
            try
            {
                var texto      = txtBuscarProducto.Text.Trim();
                int categoriaId = (cmbFiltroCategoria.SelectedItem is Categoria cat) ? cat.Id : 0;
                var estado     = cmbFiltroEstado.SelectedItem?.ToString() ?? "";

                _productos = _svc.Buscar(texto, categoriaId, estado);
                dgvProductos.Rows.Clear();
                foreach (var p in _productos)
                    dgvProductos.Rows.Add(
                        p.SKU, p.Nombre, p.Marca, p.CategoriaNombre,
                        p.PrecioCompra, p.PrecioVenta, p.MargenPct,
                        p.StockActual, p.StockMinimo, p.Ubicacion, p.Estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para crear un producto diseñe el formulario de alta de producto.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            string sku = dgvProductos.CurrentRow.Cells["SKU"].Value?.ToString() ?? "";
            MessageBox.Show($"Para editar el producto '{sku}' diseñe el formulario de edición.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            string sku    = dgvProductos.CurrentRow.Cells["SKU"].Value?.ToString() ?? "";
            string estado = dgvProductos.CurrentRow.Cells["Estado"].Value?.ToString() ?? "";

            string nuevoEstado = estado == "Activo" ? "Descontinuado" : "Activo";
            string accion      = estado == "Activo" ? "descontinuar" : "reactivar";

            var confirm = MessageBox.Show($"¿Desea {accion} el producto '{sku}'?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _svc.CambiarEstado(sku, nuevoEstado);
                CargarProductos();
                btnDesactivar.Text = nuevoEstado == "Activo" ? "Descontinuar" : "Reactivar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar estado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de exportación pendiente de implementar.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
        }
    }
}
