namespace task2;

public class Rectangle : Shape
{
    private int Width; 
    private int Length; 
    public Rectangle(int width, int length, string color) : base(color)
    {
        Width = width;
        Length = length;
    }
}
