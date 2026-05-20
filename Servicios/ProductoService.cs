using Npgsql;

namespace ISW_II_2
{
    internal class ProductoService
    {
        public List<Producto> ObtenerTodos() => Buscar("", 0, "");

        public List<Producto> Buscar(string texto, int categoriaId, string estado)
        {
            var lista = new List<Producto>();
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();

            var sql = @"SELECT id, sku, nombre, marca, modelo, descripcion,
                               categoria_id, categoria_nombre,
                               precio_compra, precio_venta, margen_pct,
                               stock_actual, stock_minimo, ubicacion, estado
                        FROM v_productos_completo WHERE 1=1";
            using var cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                sql += " AND (LOWER(nombre) LIKE @texto OR LOWER(sku) LIKE @texto OR LOWER(marca) LIKE @texto)";
                cmd.Parameters.AddWithValue("@texto", $"%{texto.ToLower()}%");
            }
            if (categoriaId > 0)
            {
                sql += " AND categoria_id = @catId";
                cmd.Parameters.AddWithValue("@catId", categoriaId);
            }
            if (!string.IsNullOrWhiteSpace(estado) && estado != "Todos")
            {
                sql += " AND estado = @estado";
                cmd.Parameters.AddWithValue("@estado", estado);
            }
            cmd.CommandText = sql + " ORDER BY nombre";

            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new Producto
                {
                    Id              = r.GetInt32(0),
                    SKU             = r.GetString(1),
                    Nombre          = r.GetString(2),
                    Marca           = r.IsDBNull(3)  ? "" : r.GetString(3),
                    Modelo          = r.IsDBNull(4)  ? "" : r.GetString(4),
                    Descripcion     = r.IsDBNull(5)  ? "" : r.GetString(5),
                    CategoriaId     = r.IsDBNull(6)  ? 0  : r.GetInt32(6),
                    CategoriaNombre = r.IsDBNull(7)  ? "" : r.GetString(7),
                    PrecioCompra    = r.GetDecimal(8),
                    PrecioVenta     = r.GetDecimal(9),
                    MargenPct       = r.IsDBNull(10) ? 0  : r.GetDecimal(10),
                    StockActual     = r.GetInt32(11),
                    StockMinimo     = r.GetInt32(12),
                    Ubicacion       = r.IsDBNull(13) ? "" : r.GetString(13),
                    Estado          = r.GetString(14)
                });
            return lista;
        }

        public bool CambiarEstado(string sku, string nuevoEstado)
        {
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE productos SET estado = @estado WHERE sku = @sku", conn);
            cmd.Parameters.AddWithValue("@estado", nuevoEstado);
            cmd.Parameters.AddWithValue("@sku",    sku);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Guardar(Producto p, bool esNuevo)
        {
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();
            var sql = esNuevo
                ? @"INSERT INTO productos
                        (sku, nombre, marca, modelo, descripcion, categoria_id,
                         precio_compra, precio_venta, stock_actual, stock_minimo, ubicacion, estado)
                    VALUES
                        (@sku,@nombre,@marca,@modelo,@desc,@catId,
                         @pc,@pv,@stock,@smin,@ubic,@estado)"
                : @"UPDATE productos SET
                        nombre=@nombre, marca=@marca, modelo=@modelo, descripcion=@desc,
                        categoria_id=@catId, precio_compra=@pc, precio_venta=@pv,
                        stock_minimo=@smin, ubicacion=@ubic, estado=@estado
                    WHERE sku=@sku";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sku",    p.SKU);
            cmd.Parameters.AddWithValue("@nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@marca",  p.Marca);
            cmd.Parameters.AddWithValue("@modelo", p.Modelo);
            cmd.Parameters.AddWithValue("@desc",   p.Descripcion);
            cmd.Parameters.AddWithValue("@catId",  p.CategoriaId > 0 ? (object)p.CategoriaId : DBNull.Value);
            cmd.Parameters.AddWithValue("@pc",     p.PrecioCompra);
            cmd.Parameters.AddWithValue("@pv",     p.PrecioVenta);
            if (esNuevo)
                cmd.Parameters.AddWithValue("@stock", p.StockActual);
            cmd.Parameters.AddWithValue("@smin",   p.StockMinimo);
            cmd.Parameters.AddWithValue("@ubic",   p.Ubicacion);
            cmd.Parameters.AddWithValue("@estado", p.Estado);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
