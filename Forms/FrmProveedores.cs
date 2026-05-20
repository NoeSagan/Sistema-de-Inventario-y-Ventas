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
    public partial class FrmProveedores : Form
    {
        private readonly ProveedorService _svc = new ProveedorService();
        private List<Proveedor> _proveedores   = new List<Proveedor>();

        public FrmProveedores()
        {
            InitializeComponent();
            Load += FrmProveedores_Load;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                new ClaSideBar(pnlSidebar, this).Configurar();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores()
        {
            _proveedores = _svc.ObtenerTodos();
            dgvProveedores.Rows.Clear();
            foreach (var p in _proveedores)
                dgvProveedores.Rows.Add(
                    p.RNC, p.Nombre, p.Contacto, p.Telefono,
                    p.Email, p.CondicionPago, p.TiempoEntrega, p.Estado);
        }

        private Proveedor? ObtenerSeleccionado()
        {
            if (dgvProveedores.CurrentRow == null) return null;
            int idx = dgvProveedores.CurrentRow.Index;
            if (idx < 0 || idx >= _proveedores.Count) return null;
            return _proveedores[idx];
        }

        // Nuevo proveedor
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para registrar un proveedor diseñe el formulario de alta de proveedor.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Editar proveedor
        private void button2_Click(object sender, EventArgs e)
        {
            var p = ObtenerSeleccionado();
            if (p == null) return;
            MessageBox.Show($"Para editar '{p.Nombre}' diseñe el formulario de edición de proveedor.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Ver órdenes del proveedor
        private void button3_Click(object sender, EventArgs e)
        {
            var p = ObtenerSeleccionado();
            if (p == null)
            {
                MessageBox.Show("Seleccione un proveedor.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var ordenes = _svc.ObtenerOrdenesPorProveedor(p.Id);
                if (ordenes.Count == 0)
                {
                    MessageBox.Show($"El proveedor '{p.Nombre}' no tiene órdenes registradas.", "Sin órdenes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var resumen = string.Join("\n", ordenes.Select(o =>
                    $"{o.Numero} | {o.FechaCreacion:dd/MM/yyyy} | {o.Estado} | {o.MontoTotal:C}"));
                MessageBox.Show($"Órdenes de {p.Nombre}:\n\n{resumen}", "Órdenes del proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener órdenes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Desempeño del proveedor
        private void button4_Click(object sender, EventArgs e)
        {
            var p = ObtenerSeleccionado();
            if (p == null)
            {
                MessageBox.Show("Seleccione un proveedor.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var ordenes    = _svc.ObtenerOrdenesPorProveedor(p.Id);
                int total      = ordenes.Count;
                int recibidas  = ordenes.Count(o => o.Estado == "Recibida");
                int canceladas = ordenes.Count(o => o.Estado == "Cancelada");
                decimal monto  = ordenes.Where(o => o.Estado == "Recibida").Sum(o => o.MontoTotal);

                MessageBox.Show(
                    $"Desempeño de {p.Nombre}\n\n" +
                    $"Total de órdenes:     {total}\n" +
                    $"Órdenes recibidas:    {recibidas}\n" +
                    $"Órdenes canceladas:   {canceladas}\n" +
                    $"Monto total recibido: {monto:C}",
                    "Desempeño del proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular desempeño: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
