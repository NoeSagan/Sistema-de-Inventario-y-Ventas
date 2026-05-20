namespace ISW_II_2
{
    internal class Venta
    {
        public int      Id             { get; set; }
        public string   Numero         { get; set; } = "";
        public int      ClienteId      { get; set; }
        public string   ClienteNombre  { get; set; } = "";
        public int      UsuarioId      { get; set; }
        public string   Vendedor       { get; set; } = "";
        public DateOnly Fecha          { get; set; }
        public TimeOnly Hora           { get; set; }
        public string   MetodoPago     { get; set; } = "";
        public decimal  Subtotal       { get; set; }
        public decimal  DescuentoPct   { get; set; }
        public decimal  DescuentoMonto { get; set; }
        public decimal  Total          { get; set; }
        public string   Estado         { get; set; } = "Completada";
    }
}
