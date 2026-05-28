using Npgsql;

namespace ISW_II_2
{
    internal class DashboardService
    {
        public KpiDashboard ObtenerKpis()
        {
            var kpi = new KpiDashboard();
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand(
                @"SELECT ventas_hoy, ingresos_hoy, productos_bajo_stock,
                         clientes_activos, total_productos, productos_agotados, valor_inventario
                  FROM v_resumen_dashboard", conn);
            using var r = cmd.ExecuteReader();
            if (r.Read())
            {
                kpi.VentasHoy = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                kpi.IngresosHoy = r.IsDBNull(1) ? 0 : r.GetDecimal(1);
                kpi.ProductosBajoStock = r.IsDBNull(2) ? 0 : r.GetInt32(2);
                kpi.ClientesActivos = r.IsDBNull(3) ? 0 : r.GetInt32(3);
                kpi.TotalProductos = r.IsDBNull(4) ? 0 : r.GetInt32(4);
                kpi.ProductosAgotados = r.IsDBNull(5) ? 0 : r.GetInt32(5);
                kpi.ValorInventario = r.IsDBNull(6) ? 0 : r.GetDecimal(6);
            }
            return kpi;
        }

        public List<AlertaStock> ObtenerAlertasStock()
        {
            var lista = new List<AlertaStock>();
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT sku, nombre, marca, categoria, stock_actual, stock_minimo, alerta " +
                "FROM v_productos_stock_bajo ORDER BY stock_actual ASC", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new AlertaStock
                {
                    SKU = r.GetString(0),
                    Nombre = r.GetString(1),
                    Marca = r.IsDBNull(2) ? "" : r.GetString(2),
                    Categoria = r.IsDBNull(3) ? "" : r.GetString(3),
                    StockActual = r.GetInt32(4),
                    StockMinimo = r.GetInt32(5),
                    Alerta = r.IsDBNull(6) ? "" : r.GetString(6)
                });
            return lista;
        }

        public List<Venta> ObtenerUltimasVentas() =>
            new VentaService().ObtenerUltimas(20);

        public List<OrdenCompra> ObtenerOrdenesPendientes() =>
            new OrdenCompraService().ObtenerPorEstado("Pendiente");
    }
}