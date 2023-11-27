using System;

namespace Dz8_3;

interface IShape
{
    int GetArea();
}

interface IRectangle : IShape
{
    int Width { get; set; }
    int Height { get; set; }
}

interface ISquare : IShape
{
    int Side { get; set; }
}

class Rectangle : IRectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : ISquare
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}
internal class Dz8_3
    {
        static void Main(string[] args)
        {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine($"Площа прямокутника: {rect.GetArea()}");
        Square square = new Square();
        square.Side = 10;
        Console.WriteLine($"Площа квадрата: {square.GetArea()}");
        Console.ReadKey();


    }
    }
    
