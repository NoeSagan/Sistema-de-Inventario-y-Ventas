namespace ISW_II_2
{
    internal class ItemCarrito
    {
        public int     ProductoId     { get; set; }
        public string  SKU            { get; set; } = "";
        public string  Nombre         { get; set; } = "";
        public string  Marca          { get; set; } = "";
        public decimal PrecioUnitario { get; set; }
        public int     Cantidad       { get; set; }
        public decimal Subtotal       => PrecioUnitario * Cantidad;
    }
}
