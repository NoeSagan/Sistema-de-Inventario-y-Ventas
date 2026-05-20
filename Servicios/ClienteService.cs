using Npgsql;

namespace ISW_II_2
{
    internal class ClienteService
    {
        public List<Cliente> ObtenerTodos()
        {
            var lista = new List<Cliente>();
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT id, nombre, cedula_pasaporte, telefono, email, direccion FROM clientes ORDER BY nombre", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new Cliente
                {
                    Id              = r.GetInt32(0),
                    Nombre          = r.GetString(1),
                    CedulaPasaporte = r.IsDBNull(2) ? "" : r.GetString(2),
                    Telefono        = r.IsDBNull(3) ? "" : r.GetString(3),
                    Email           = r.IsDBNull(4) ? "" : r.GetString(4),
                    Direccion       = r.IsDBNull(5) ? "" : r.GetString(5)
                });
            return lista;
        }

        public bool Guardar(Cliente c, bool esNuevo)
        {
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            if (esNuevo)
            {
                cmd.CommandText =
                    "INSERT INTO clientes (nombre, cedula_pasaporte, telefono, email, direccion) " +
                    "VALUES (@nombre, @cedula, @tel, @email, @dir)";
            }
            else
            {
                cmd.CommandText =
                    "UPDATE clientes SET nombre=@nombre, cedula_pasaporte=@cedula, telefono=@tel, " +
                    "email=@email, direccion=@dir WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", c.Id);
            }
            cmd.Parameters.AddWithValue("@nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@cedula", c.CedulaPasaporte);
            cmd.Parameters.AddWithValue("@tel",    c.Telefono);
            cmd.Parameters.AddWithValue("@email",  c.Email);
            cmd.Parameters.AddWithValue("@dir",    c.Direccion);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
