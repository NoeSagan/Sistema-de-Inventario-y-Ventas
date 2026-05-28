using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW_II_2
{
    internal class AuthService
    {
        private const int MAX_INTENTOS = 5;

        public ResultadoLogin Autenticar(string username, string password)
        {
            using var conn = new NpgsqlConnection(DBConfig.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT id, nombre_completo, rol, estado, intentos_fallidos FROM usuarios WHERE username = @u", conn);
            cmd.Parameters.AddWithValue("@u", username);
            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return new ResultadoLogin { Exitoso = false, Mensaje = "Usuario o contraseña incorrectos." };

            int id = reader.GetInt32(0);
            string nombre = reader.GetString(1);
            string rol = reader.GetString(2);
            string estado = reader.GetString(3);
            int intentos = reader.GetInt32(4);
            reader.Close();

            if (estado == "Bloqueado")
                return new ResultadoLogin { Exitoso = false, Mensaje = "Cuenta bloqueada. Contacte al administrador." };

            using var cmdPass = new NpgsqlCommand(
                "SELECT (password_hash = crypt(@p, password_hash)) FROM usuarios WHERE id = @id", conn);
            cmdPass.Parameters.AddWithValue("@p", password);
            cmdPass.Parameters.AddWithValue("@id", id);
            bool valida = (bool)cmdPass.ExecuteScalar()!;

            if (valida)
            {
                using var cmdOk = new NpgsqlCommand(
                    "UPDATE usuarios SET intentos_fallidos = @intentos, ultimo_acceso = NOW() WHERE id = @id", conn);
                cmdOk.Parameters.AddWithValue("@intentos", 0);
                cmdOk.Parameters.AddWithValue("@id", id);
                cmdOk.ExecuteNonQuery();

                Sesion.UsuarioId = id;
                Sesion.NombreCompleto = nombre;
                Sesion.Rol = rol;

                return new ResultadoLogin { Exitoso = true, UsuarioId = id, NombreCompleto = nombre, Rol = rol };
            }

            intentos++;
            string nuevoEstado = intentos >= MAX_INTENTOS ? "Bloqueado" : "Activo";

            using var cmdFail = new NpgsqlCommand(
                "UPDATE usuarios SET intentos_fallidos = @intentos, estado = @estado WHERE id = @id", conn);
            cmdFail.Parameters.AddWithValue("@intentos", intentos);
            cmdFail.Parameters.AddWithValue("@estado", nuevoEstado);
            cmdFail.Parameters.AddWithValue("@id", id);
            cmdFail.ExecuteNonQuery();

            string msg = intentos >= MAX_INTENTOS
                ? "Cuenta bloqueada por demasiados intentos."
                : $"Credenciales incorrectas. Intentos restantes: {MAX_INTENTOS - intentos}";

            return new ResultadoLogin { Exitoso = false, Mensaje = msg };
        }
    }

    internal class ResultadoLogin
    {
        public bool Exitoso { get; set; }
        public int UsuarioId { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Rol { get; set; }
        public string? Mensaje { get; set; }
    }
}