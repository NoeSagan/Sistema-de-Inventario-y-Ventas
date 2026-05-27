using ISW_II_2.Core;
using Npgsql;

namespace ISW_II_2
{
    internal class OrdenCompraService
    {
        public List<OrdenCompra> ObtenerTodas()
        {
            var lista = new List<OrdenCompra>();
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                @"SELECT oc.id, oc.numero, oc.proveedor_id, p.nombre,
                         oc.fecha_creacion, oc.estado, oc.monto_total
                  FROM ordenes_compra oc
                  JOIN proveedores p ON p.id = oc.proveedor_id
                  ORDER BY oc.fecha_creacion DESC", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(Mapear(r));
            return lista;
        }

        public List<OrdenCompra> ObtenerPorEstado(string estado)
        {
            var lista = new List<OrdenCompra>();
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                @"SELECT oc.id, oc.numero, oc.proveedor_id, p.nombre,
                         oc.fecha_creacion, oc.estado, oc.monto_total
                  FROM ordenes_compra oc
                  JOIN proveedores p ON p.id = oc.proveedor_id
                  WHERE oc.estado = @estado
                  ORDER BY oc.fecha_creacion DESC", conn);
            cmd.Parameters.AddWithValue("@estado", estado);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(Mapear(r));
            return lista;
        }

        public bool CambiarEstado(int id, string nuevoEstado)
        {
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE ordenes_compra SET estado = @estado WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@estado", nuevoEstado);
            cmd.Parameters.AddWithValue("@id",     id);
            return cmd.ExecuteNonQuery() > 0;
        }

        private static OrdenCompra Mapear(NpgsqlDataReader r) => new OrdenCompra
        {
            Id              = r.GetInt32(0),
            Numero          = r.IsDBNull(1) ? "" : r.GetString(1),
            ProveedorId     = r.GetInt32(2),
            ProveedorNombre = r.GetString(3),
            FechaCreacion   = DateOnly.FromDateTime(r.GetDateTime(4)),
            Estado          = r.GetString(5),
            MontoTotal      = r.GetDecimal(6)
        };
    }
}
