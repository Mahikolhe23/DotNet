namespace Drawing;

public class Line : Shape
{
    // Creating two point for starting and ending
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    //default constructor
    public Line()
    {
        this.StartPoint = new Point(0, 0);
        this.EndPoint = new Point(0, 0);
    }

    //parameterised constructor
    public Line(Point p1, Point p2)
    {
        this.StartPoint = p1;
        this.EndPoint = p2;
    }

    //over ride draw method from parent class
    public override void Draw()
    {
        //Type of class
        Type t = this.GetType();
        Console.WriteLine("Type = " + t.Name);
        Console.WriteLine(
            "(" + this.StartPoint + "),(" + this.EndPoint + ")," + this.Color + "," + this.Width
        );
    }
}
