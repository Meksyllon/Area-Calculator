namespace AreaCalculator
{
    public class Circle : IFigure
    {
        public double Radius;
        
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException();
            Radius = radius;
        }

        public double Area { 
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }

    public class Triangle : IFigure
    {
        // a, b, c is a three sides of triangle
        public double A;
        public double B;
        public double C;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentOutOfRangeException();
            if (a + b < c || a + c < b || b + c < a) throw new ArgumentOutOfRangeException();
            A = a;
            B = b;
            C = c;
        }

        //p is a half of the perimeter
        private double p { 
            get
            {
                return (A + B + C) / 2;
            }
        }

        public double Area
        {
            get
            {
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }

    public class Ellipse : IFigure
    {
        public double FirstHalfAxis;
        public double SecondHalfAxis;

        public Ellipse(double firstHalfAxis, double secondHalfAxis)
        {
            if (FirstHalfAxis < 0 || secondHalfAxis < 0) throw new ArgumentOutOfRangeException();
            FirstHalfAxis = firstHalfAxis;
            SecondHalfAxis = secondHalfAxis;
        }

        public double Area
        {
            get
            {
                return Math.PI * FirstHalfAxis * SecondHalfAxis;
            }
        }
    }
}
