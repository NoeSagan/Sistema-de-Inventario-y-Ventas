namespace ISW_II_2
{
    internal class OrdenCompra
    {
        public int      Id              { get; set; }
        public string   Numero          { get; set; } = "";
        public int      ProveedorId     { get; set; }
        public string   ProveedorNombre { get; set; } = "";
        public int      UsuarioId       { get; set; }
        public DateOnly FechaCreacion   { get; set; }
        public DateOnly? FechaEsperada  { get; set; }
        public decimal  MontoTotal      { get; set; }
        public string   Estado          { get; set; } = "Pendiente";
        public string   Notas           { get; set; } = "";
    }
}
