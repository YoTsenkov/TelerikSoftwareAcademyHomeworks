namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public override int CalculateSurface()
        {
            return this.height * this.width / 2;
        }
    }
}
