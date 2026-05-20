namespace ISW_II_2
{
    internal class KpiDashboard
    {
        public int     VentasHoy          { get; set; }
        public decimal IngresosHoy        { get; set; }
        public int     ProductosBajoStock { get; set; }
        public int     ClientesActivos    { get; set; }
        public int     TotalProductos     { get; set; }
        public int     ProductosAgotados  { get; set; }
        public decimal ValorInventario    { get; set; }
    }

    internal class AlertaStock
    {
        public string SKU         { get; set; } = "";
        public string Nombre      { get; set; } = "";
        public string Marca       { get; set; } = "";
        public string Categoria   { get; set; } = "";
        public int    StockActual { get; set; }
        public int    StockMinimo { get; set; }
        public string Alerta      { get; set; } = "";
    }
}
