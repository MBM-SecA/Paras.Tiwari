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
public class Square: Shape,IshapeWithSides
{
    public Square(double side)
    {
        Side= side;      
    }
    public double Side { get; set; }
    public override double GetArea()=> Side*Side;
    public override double GetCircumference()=> 4*Side;
    public override void Display()
    {
       Console.WriteLine($"Displaying result for square of side {Side}");
       Console.WriteLine($"Area:{this.GetArea()}");
       Console.WriteLine($"Perimeter:{this.GetCircumference()}");
       Console.WriteLine($"Diagonal:{this.GetDiagonal()}");
    }

    public double GetDiagonal() => Math.Sqrt(2*Side*Side);
        
 
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
       Console.WriteLine($"Displaying result for Rectangle of Lenght {Length} and Breadth {Breadth}");
       Console.WriteLine($"Area:{this.GetArea()}");
       Console.WriteLine($"Perimeter:{this.GetCircumference()}");
        Console.WriteLine($"Diagonal:{this.GetDiagonal()}");
    
    }

   public double GetDiagonal() => Math.Sqrt(Length*Length + Breadth*Breadth);
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
