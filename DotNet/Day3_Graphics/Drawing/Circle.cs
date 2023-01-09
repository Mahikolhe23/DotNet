namespace Drawing;

public class Circle : Shape, IPrintable
{
    public int Radius { get; set; }
    public Point Center { get; set; }

    //default constructor
    public Circle()
    {
        this.Center = new Point(0, 0);
        this.Radius = 1;
    }

    //parameterised constructor
    public Circle(Point c, int r)
    {
        this.Center = c;
        this.Radius = r;
    }

    //over ride draw method from base class
    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Type = " + t.Name);
        Console.WriteLine(
            "(" + this.Center + "),(" + this.Radius + ")" + this.Color + "," + this.Width
        );
    }

    //print method from interface
    public void Print()
    {
        Console.WriteLine("Printing object");
        Type t = this.GetType();
        Console.WriteLine("Type = " + t.Name);
        Console.WriteLine(
            "(" + this.Center + "),(" + this.Radius + ")" + this.Color + "," + this.Width
        );
    }
}
