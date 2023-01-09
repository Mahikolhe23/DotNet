namespace Drawing;

public class Rectangle : Shape, IPrintable
{
    //two point as data member of rect class
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    //default constructor
    public Rectangle()
    {
        this.StartPoint = new Point(0, 0);
        this.EndPoint = new Point(0, 0);
    }

    public Rectangle(Point p1, Point p2)
    {
        this.StartPoint = p1;
        this.EndPoint = p2;
    }

    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Type = " + t.Name);
        Console.WriteLine(
            "(" + this.StartPoint + "),(" + this.EndPoint + ")" + this.Color + "," + this.Width
        );
    }

    //Print Method from interface
    public void Print()
    {
        Console.WriteLine("Printing object");
        Type t = this.GetType();
        Console.WriteLine("Type = " + t.Name);
        Console.WriteLine(
            "(" + this.StartPoint + "),(" + this.EndPoint + ")" + this.Color + "," + this.Width
        );
    }
}
