namespace ISW_II_2
{
    internal class Categoria
    {
        public int    Id     { get; set; }
        public string Nombre { get; set; } = "";
        public override string ToString() => Nombre;
    }
}
