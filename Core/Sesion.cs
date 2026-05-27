namespace ISW_II_2
{
    internal static class Sesion
    {
        public static int    UsuarioId      { get; set; }
        public static string NombreCompleto { get; set; } = "";
        public static string Rol            { get; set; } = "";

        // aquí agregamos la propiedad Usuario que devuelve el NombreCompleto
        public static string Usuario => NombreCompleto;
        public static void Limpiar()
        {
            UsuarioId      = 0;
            NombreCompleto = "";
            Rol            = "";
        }
    }
}
