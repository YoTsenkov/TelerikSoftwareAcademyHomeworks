namespace ShapeLibrary
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public override int CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}
