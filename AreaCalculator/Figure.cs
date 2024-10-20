namespace AreaCalculator
{
    public class Figure
    {
        public IFigure figure;
        public Figure(double radius)
        {
            figure = new Circle(radius);
        }

        public Figure(double a, double b, double c)
        {
            figure = new Triangle(a, b, c);
        }

        public Figure(double firstHalfAxis, double secondHalfAxis)
        {
            figure = new Ellipse(firstHalfAxis, secondHalfAxis);
        }

        public double Area { 
            get
            {
                return figure.Area;
            }
        }
    }
}
