using System;

public interface IshapeWithSides//interface for multiple inheritance
{
    double GetDiagonal();
}
public abstract class Shape
{
    public abstract double GetArea();
    
    public abstract double GetCircumference();
    
    public virtual void Display()
    {
        Console.WriteLine($"Displaying result for shape");
    }

}

public class Rectangle: Shape,IshapeWithSides 
{
    public Rectangle(double length,double breadth)
    {
        Length=length;
        Breadth=breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea()=> Length*Breadth;
    public override double GetCircumference()=> 2*(Length + Breadth);
    public override void Display()
    {
        if(Length == Breadth)
             Console.WriteLine($"Displaying result for Square of side [{Length}]");
        else
             Console.WriteLine($"Displaying result for Rectangle of side [{Length} x {Breadth}  ]");
       Console.WriteLine($"Area:{this.GetArea()}");
       Console.WriteLine($"Perimeter:{this.GetCircumference()}");
        Console.WriteLine($"Diagonal:{this.GetDiagonal()}");
    
    }

   public double GetDiagonal() => Math.Sqrt(Length*Length + Breadth*Breadth);
}
public class Square: Rectangle
{
    public Square(double side) : base(side,side)
    {

    }        
 
}

public class Circle: Shape 
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius { get; set; }
    public override double GetArea()=> Math.PI*Radius*Radius;
    public override double GetCircumference()=> 2*Math.PI*Radius;
    public override void Display()
    {
       Console.WriteLine($"Displaying result for Circle of Radius {Radius}");
       Console.WriteLine($"Area:{this.GetArea()}");
       Console.WriteLine($"Perimeter:{this.GetCircumference()}");
       
    }
}
