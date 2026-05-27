using ISW_II_2.Core;
using Npgsql;

namespace ISW_II_2
{
    internal class CategoriaService
    {
        public List<Categoria> ObtenerTodas()
        {
            var lista = new List<Categoria>();
            using var conn = new NpgsqlConnection(DBConfig.ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT id, nombre FROM categorias ORDER BY nombre", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
                lista.Add(new Categoria { Id = r.GetInt32(0), Nombre = r.GetString(1) });
            return lista;
        }
    }
}
