namespace Homework1
{
    public class Task3_Circle
    {
        private const double _pi = 3.1416;
        
        public double Square(double radius)
        {
            return _pi * radius * radius;
        }

        public double Circumference(double radius)
        {
            return _pi * 2 * radius;
        }
    }
}