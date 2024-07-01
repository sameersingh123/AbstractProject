namespace AbstractProject
{
    abstract class Figure
    {
        public double Height, Width, Radius;
        public const double Pi = 3.14f;

        public abstract double Area();

    }
     class Rectangle : Figure
    {
        
        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double Area()
        {
            return Height * Width;
        }

    }
    class Circle: Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double Area()
        {
            return Pi* Radius * Radius;
        }

    }
    class Cone : Figure
    {
        public Cone(double Height, double Radius)
        {
            this.Height = Height;
            this.Radius = Radius;
        }
        public override double Area()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    class TestFigures
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine("Area of Rectangle: "+rectangle.Area());

            Circle circle = new Circle(10);
            Console.WriteLine("Area of Circle: "+circle.Area());

            Cone cone = new Cone(10, 20);
            Console.WriteLine("Area of Cone: "+cone.Area());
        }
    }
}