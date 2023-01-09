using Drawing;
using System.Collections.Generic;

//create two point  and create line object
Point pt1 = new Point(12, 12);
Point pt2 = new Point(120, 145);
Shape shape1 = new Line(pt1, pt2);

// create one point for circle
Point pt3 = new Point(45, 45);
int rad = 20;
Shape shape2 = new Circle(pt3, rad);

//create two point for rectangle
Point p4 = new Point(50, 30);
Point p5 = new Point(30, 20);
Shape shape3 = new Rectangle(p4, p5);

//use List collection and add all shape in list
List<Shape> shapes = new List<Shape>();
shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);

Console.WriteLine("Drawing all shapes");
foreach (Shape s in shapes)
{
    s.Draw();
}
