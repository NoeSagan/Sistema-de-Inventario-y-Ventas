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
    public partial class FrmVentas : Form
    {
        private readonly VentaService _ventaSvc = new VentaService();
        private readonly ClienteService _clienteSvc = new ClienteService();
        private readonly List<ItemCarrito> _carrito = new List<ItemCarrito>();
        private List<Producto> _productosEnGrid = new List<Producto>();

        public FrmVentas()
        {
            InitializeComponent();
            Load += FrmVentas_Load;
            txtUsuarioConectado.Text = $"{Sesion.NombreCompleto}  |  {Sesion.Rol}";
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            try
            {
                new ClaSideBar(pnlSidebar, this).Configurar();
                ConfigurarCarrito();
                CargarClientes();
                CargarProductos("");
                WirarEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarCarrito()
        {
            // El diseñador dejó solo la columna QuitarProducto; se insertan las columnas de datos antes.
            dgvCarrito.Columns.Insert(0, new DataGridViewTextBoxColumn { Name = "cSKU", HeaderText = "SKU", ReadOnly = true });
            dgvCarrito.Columns.Insert(1, new DataGridViewTextBoxColumn { Name = "cNombre", HeaderText = "Producto", ReadOnly = true });
            dgvCarrito.Columns.Insert(2, new DataGridViewTextBoxColumn { Name = "cPrecio", HeaderText = "Precio", ReadOnly = true });
            dgvCarrito.Columns.Insert(3, new DataGridViewTextBoxColumn { Name = "cCantidad", HeaderText = "Cantidad", ReadOnly = true });
            dgvCarrito.Columns.Insert(4, new DataGridViewTextBoxColumn { Name = "cSubtotal", HeaderText = "Subtotal", ReadOnly = true });
        }

        private void CargarClientes()
        {
            cmbCliente.Items.Clear();
            cmbCliente.Items.Add(new ComboItem(0, "Consumidor final"));
            foreach (var c in _clienteSvc.ObtenerTodos())
                cmbCliente.Items.Add(new ComboItem(c.Id, c.Nombre));
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            if (cmbCliente.Items.Count > 0)
                cmbCliente.SelectedIndex = 0;
        }

        private void CargarProductos(string texto)
        {
            _productosEnGrid = _ventaSvc.BuscarProductos(texto);
            dgvProductos.Rows.Clear();
            foreach (var p in _productosEnGrid)
                dgvProductos.Rows.Add(p.SKU, p.Nombre, p.Marca, p.PrecioVenta.ToString("C"), p.StockActual);
        }

        private void WirarEventos()
        {
            btnBuscar.Click += (s, e) => CargarProductos(txtBuscarProducto.Text.Trim());
            btnAgregarCarrito.Click += BtnAgregarCarrito_Click;
            btnQuitarItem.Click += BtnQuitarItem_Click;
            button3.Click += BtnCancelarVenta_Click;
            button5.Click += BtnProcesarVenta_Click;
            dgvProductos.CellClick += DgvProductos_CellClick;
            dgvCarrito.CellClick += DgvCarrito_CellClick;
        }

        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            AgregarAlCarrito(dgvProductos.CurrentRow.Index);
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProductos.Columns[e.ColumnIndex].Name == "AgregarProducto")
                AgregarAlCarrito(e.RowIndex);
        }

        private void AgregarAlCarrito(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _productosEnGrid.Count) return;

            var producto = _productosEnGrid[rowIndex];
            int stock = producto.StockActual;
            int cantidad = (int)nudCantidad.Value;

            if (cantidad > stock)
            {
                MessageBox.Show($"Stock insuficiente. Disponible: {stock}.", "Sin stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existente = _carrito.FirstOrDefault(i => i.SKU == producto.SKU);
            if (existente != null)
            {
                if (existente.Cantidad + cantidad > stock)
                {
                    MessageBox.Show($"No puede agregar más de {stock} unidades en total.", "Límite de stock",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existente.Cantidad += cantidad;
            }
            else
            {
                _carrito.Add(new ItemCarrito
                {
                    ProductoId = producto.Id,
                    SKU = producto.SKU,
                    Nombre = producto.Nombre,
                    Marca = producto.Marca,
                    PrecioUnitario = producto.PrecioVenta,
                    Cantidad = cantidad
                });
            }
            RefrescarCarrito();
        }

        private void BtnQuitarItem_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null) return;
            QuitarDelCarrito(dgvCarrito.CurrentRow.Index);
        }

        private void DgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCarrito.Columns[e.ColumnIndex].Name == "QuitarProducto")
                QuitarDelCarrito(e.RowIndex);
        }

        private void QuitarDelCarrito(int rowIndex)
        {
            string sku = dgvCarrito.Rows[rowIndex].Cells["cSKU"].Value?.ToString() ?? "";
            _carrito.RemoveAll(i => i.SKU == sku);
            RefrescarCarrito();
        }

        private void RefrescarCarrito()
        {
            dgvCarrito.Rows.Clear();
            foreach (var item in _carrito)
                dgvCarrito.Rows.Add(
                    item.SKU, item.Nombre,
                    item.PrecioUnitario.ToString("C"),
                    item.Cantidad,
                    item.Subtotal.ToString("C"));

            decimal total = _carrito.Sum(i => i.Subtotal);
            _ = total;
        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Desea cancelar y vaciar el carrito?", "Cancelar venta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            _carrito.Clear();
            RefrescarCarrito();
            txtBuscarProducto.Clear();
            CargarProductos("");
        }

        private void BtnProcesarVenta_Click(object sender, EventArgs e)
        {
            if (_carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Carrito vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clienteId = (cmbCliente.SelectedItem is ComboItem ci) ? ci.Id : 0;
            string metodoPago = cmbMetodoPago.SelectedItem?.ToString() ?? "";

            try
            {
                var resultado = _ventaSvc.ProcesarVenta(clienteId, metodoPago, _carrito, 0);
                if (resultado.Exitoso)
                {
                    MessageBox.Show(resultado.Mensaje, "Venta procesada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _carrito.Clear();
                    RefrescarCarrito();
                    CargarProductos("");
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Error en venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class ComboItem
        {
            public int Id { get; }
            public string Nombre { get; }
            public ComboItem(int id, string nombre) { Id = id; Nombre = nombre; }
            public override string ToString() => Nombre;
        }
    }
}
