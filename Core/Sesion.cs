namespace ISW_II_2
{
    internal static class Sesion
    {
        public static int    UsuarioId      { get; set; }
        public static string NombreCompleto { get; set; } = "";
        public static string Rol            { get; set; } = "";

        public static void Limpiar()
        {
            UsuarioId      = 0;
            NombreCompleto = "";
            Rol            = "";
        }
    }
}
