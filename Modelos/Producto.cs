namespace ISW_II_2
{
    internal class Producto
    {
        public int     Id             { get; set; }
        public string  SKU            { get; set; } = "";
        public string  Nombre         { get; set; } = "";
        public string  Marca          { get; set; } = "";
        public string  Modelo         { get; set; } = "";
        public string  Descripcion    { get; set; } = "";
        public int     CategoriaId    { get; set; }
        public string  CategoriaNombre { get; set; } = "";
        public decimal PrecioCompra   { get; set; }
        public decimal PrecioVenta    { get; set; }
        public decimal MargenPct      { get; set; }
        public int     StockActual    { get; set; }
        public int     StockMinimo    { get; set; }
        public string  Ubicacion      { get; set; } = "";
        public string  Estado         { get; set; } = "Activo";
    }
}
