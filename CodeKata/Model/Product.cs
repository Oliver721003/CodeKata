namespace CodeKata.Model
{
    public class Product
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Size => Length * Width * Height;
    }
}