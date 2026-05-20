namespace ISW_II_2
{
    internal class Proveedor
    {
        public int    Id            { get; set; }
        public string RNC           { get; set; } = "";
        public string Nombre        { get; set; } = "";
        public string Contacto      { get; set; } = "";
        public string Telefono      { get; set; } = "";
        public string Email         { get; set; } = "";
        public string Direccion     { get; set; } = "";
        public string CondicionPago { get; set; } = "";
        public int    TiempoEntrega { get; set; }
        public string Estado        { get; set; } = "Activo";
    }
}
