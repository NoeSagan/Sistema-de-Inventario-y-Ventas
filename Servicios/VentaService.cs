using ISW_II_2;
using Npgsql;

namespace ISW_II_2
{
    internal class VentaService
    {
        public List<Producto> BuscarProductos(string texto)
        {
            var lista = new List<Producto>();
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();

            var sql = @"SELECT id, sku, nombre, marca, precio_venta, stock_actual
                        FROM v_productos_completo
                        WHERE estado = 'Activo' AND stock_actual > 0";
            using var cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            if (!string.IsNullOrWhiteSpace(texto))
            {
                sql += " AND (LOWER(nombre) LIKE @texto OR LOWER(sku) LIKE @texto OR LOWER(marca) LIKE @texto)";
                cmd.Parameters.AddWithValue("@texto", $"%{texto.ToLower()}%");
            }
            cmd.CommandText = sql + " ORDER BY nombre";

            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new Producto
                {
                    Id          = r.GetInt32(0),
                    SKU         = r.GetString(1),
                    Nombre      = r.GetString(2),
                    Marca       = r.IsDBNull(3) ? "" : r.GetString(3),
                    PrecioVenta = r.GetDecimal(4),
                    StockActual = r.GetInt32(5)
                });
            return lista;
        }

        public ResultadoVenta ProcesarVenta(int clienteId, string metodoPago, List<ItemCarrito> items, decimal descuentoMonto)
        {
            if (items == null || items.Count == 0)
                return new ResultadoVenta { Exitoso = false, Mensaje = "El carrito está vacío." };
            if (string.IsNullOrWhiteSpace(metodoPago))
                return new ResultadoVenta { Exitoso = false, Mensaje = "Seleccione un método de pago." };

            decimal subtotal = items.Sum(i => i.Subtotal);
            decimal total    = Math.Max(0, subtotal - descuentoMonto);
            string  numero   = $"V{DateTime.Now:yyyyMMddHHmmss}";

            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                using var cmdVenta = new NpgsqlCommand(
                    @"INSERT INTO ventas
                        (numero, cliente_id, usuario_id, fecha, hora,
                         metodo_pago, subtotal, descuento_monto, total, estado)
                      VALUES
                        (@num, @cid, @uid, CURRENT_DATE, CURRENT_TIME,
                         @mp, @sub, @desc, @total, 'Completada')
                      RETURNING id", conn, tx);
                cmdVenta.Parameters.AddWithValue("@num",  numero);
                cmdVenta.Parameters.AddWithValue("@cid",  clienteId > 0 ? (object)clienteId : DBNull.Value);
                cmdVenta.Parameters.AddWithValue("@uid",  Sesion.UsuarioId > 0 ? (object)Sesion.UsuarioId : DBNull.Value);
                cmdVenta.Parameters.AddWithValue("@mp",   metodoPago);
                cmdVenta.Parameters.AddWithValue("@sub",  subtotal);
                cmdVenta.Parameters.AddWithValue("@desc", descuentoMonto);
                cmdVenta.Parameters.AddWithValue("@total",total);
                int ventaId = (int)cmdVenta.ExecuteScalar()!;

                foreach (var item in items)
                {
                    using var cmdItem = new NpgsqlCommand(
                        "INSERT INTO venta_items (venta_id, producto_id, cantidad, precio_unitario) " +
                        "VALUES (@vid, @pid, @cant, @precio)", conn, tx);
                    cmdItem.Parameters.AddWithValue("@vid",    ventaId);
                    cmdItem.Parameters.AddWithValue("@pid",    item.ProductoId);
                    cmdItem.Parameters.AddWithValue("@cant",   item.Cantidad);
                    cmdItem.Parameters.AddWithValue("@precio", item.PrecioUnitario);
                    cmdItem.ExecuteNonQuery();
                }

                tx.Commit();
                return new ResultadoVenta
                {
                    Exitoso = true,
                    Mensaje = $"Venta {numero} procesada correctamente. Total: {total:C}",
                    VentaId = ventaId,
                    Numero  = numero,
                    Total   = total
                };
            }
            catch (Exception ex)
            {
                tx.Rollback();
                return new ResultadoVenta { Exitoso = false, Mensaje = $"Error al procesar venta: {ex.Message}" };
            }
        }

        public List<Venta> ObtenerUltimas(int cantidad = 20)
        {
            var lista = new List<Venta>();
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                @"SELECT v.id, v.numero, v.cliente_id, COALESCE(c.nombre,'Consumidor final'),
                         v.usuario_id, COALESCE(u.nombre_completo,''),
                         v.fecha, v.hora, v.metodo_pago,
                         v.subtotal, v.descuento_pct, v.descuento_monto, v.total, v.estado
                  FROM ventas v
                  LEFT JOIN clientes c  ON c.id = v.cliente_id
                  LEFT JOIN usuarios u  ON u.id = v.usuario_id
                  ORDER BY v.fecha DESC, v.hora DESC
                  LIMIT @lim", conn);
            cmd.Parameters.AddWithValue("@lim", cantidad);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new Venta
                {
                    Id             = r.GetInt32(0),
                    Numero         = r.IsDBNull(1)  ? "" : r.GetString(1),
                    ClienteId      = r.IsDBNull(2)  ? 0  : r.GetInt32(2),
                    ClienteNombre  = r.GetString(3),
                    UsuarioId      = r.IsDBNull(4)  ? 0  : r.GetInt32(4),
                    Vendedor       = r.GetString(5),
                    Fecha          = DateOnly.FromDateTime(r.GetDateTime(6)),
                    Hora           = TimeOnly.FromTimeSpan(r.GetTimeSpan(7)),
                    MetodoPago     = r.IsDBNull(8)  ? "" : r.GetString(8),
                    Subtotal       = r.IsDBNull(9)  ? 0  : r.GetDecimal(9),
                    DescuentoPct   = r.IsDBNull(10) ? 0  : r.GetDecimal(10),
                    DescuentoMonto = r.IsDBNull(11) ? 0  : r.GetDecimal(11),
                    Total          = r.IsDBNull(12) ? 0  : r.GetDecimal(12),
                    Estado         = r.IsDBNull(13) ? "" : r.GetString(13)
                });
            return lista;
        }
    }

    internal class ResultadoVenta
    {
        public bool    Exitoso { get; set; }
        public string  Mensaje { get; set; } = "";
        public int     VentaId { get; set; }
        public string  Numero  { get; set; } = "";
        public decimal Total   { get; set; }
    }
}
