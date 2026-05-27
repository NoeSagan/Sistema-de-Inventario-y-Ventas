using ISW_II_2.Core;
using Npgsql;

namespace ISW_II_2
{
    internal class ProveedorService
    {
        public List<Proveedor> ObtenerTodos()
        {
            var lista = new List<Proveedor>();
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT id, rnc, nombre, contacto, telefono, email, direccion, condicion_pago, tiempo_entrega, estado " +
                "FROM proveedores ORDER BY nombre", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new Proveedor
                {
                    Id            = r.GetInt32(0),
                    RNC           = r.IsDBNull(1) ? "" : r.GetString(1),
                    Nombre        = r.GetString(2),
                    Contacto      = r.IsDBNull(3) ? "" : r.GetString(3),
                    Telefono      = r.IsDBNull(4) ? "" : r.GetString(4),
                    Email         = r.IsDBNull(5) ? "" : r.GetString(5),
                    Direccion     = r.IsDBNull(6) ? "" : r.GetString(6),
                    CondicionPago = r.IsDBNull(7) ? "" : r.GetString(7),
                    TiempoEntrega = r.IsDBNull(8) ? 0  : r.GetInt32(8),
                    Estado        = r.GetString(9)
                });
            return lista;
        }

        public bool Guardar(Proveedor p, bool esNuevo)
        {
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            var sql = esNuevo
                ? "INSERT INTO proveedores (rnc,nombre,contacto,telefono,email,direccion,condicion_pago,tiempo_entrega,estado) " +
                  "VALUES (@rnc,@nombre,@contacto,@tel,@email,@dir,@condicion,@tentrega,@estado)"
                : "UPDATE proveedores SET rnc=@rnc,nombre=@nombre,contacto=@contacto,telefono=@tel," +
                  "email=@email,direccion=@dir,condicion_pago=@condicion,tiempo_entrega=@tentrega,estado=@estado WHERE id=@id";
            using var cmd = new NpgsqlCommand(sql, conn);
            if (!esNuevo)
                cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@rnc",      p.RNC);
            cmd.Parameters.AddWithValue("@nombre",   p.Nombre);
            cmd.Parameters.AddWithValue("@contacto", p.Contacto);
            cmd.Parameters.AddWithValue("@tel",      p.Telefono);
            cmd.Parameters.AddWithValue("@email",    p.Email);
            cmd.Parameters.AddWithValue("@dir",      p.Direccion);
            cmd.Parameters.AddWithValue("@condicion",p.CondicionPago);
            cmd.Parameters.AddWithValue("@tentrega", p.TiempoEntrega);
            cmd.Parameters.AddWithValue("@estado",   p.Estado);
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<OrdenCompra> ObtenerOrdenesPorProveedor(int proveedorId)
        {
            var lista = new List<OrdenCompra>();
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT oc.id, oc.numero, oc.proveedor_id, p.nombre, oc.fecha_creacion, oc.estado, oc.monto_total " +
                "FROM ordenes_compra oc JOIN proveedores p ON p.id = oc.proveedor_id " +
                "WHERE oc.proveedor_id = @pid ORDER BY oc.fecha_creacion DESC", conn);
            cmd.Parameters.AddWithValue("@pid", proveedorId);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new OrdenCompra
                {
                    Id              = r.GetInt32(0),
                    Numero          = r.IsDBNull(1) ? "" : r.GetString(1),
                    ProveedorId     = r.GetInt32(2),
                    ProveedorNombre = r.GetString(3),
                    FechaCreacion   = DateOnly.FromDateTime(r.GetDateTime(4)),
                    Estado          = r.GetString(5),
                    MontoTotal      = r.GetDecimal(6)
                });
            return lista;
        }
    }
}
