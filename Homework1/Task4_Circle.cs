namespace Homework1
{
    public static class Task4_Circle
    {
        private const double _pi = 3.1416;
        
        public static double Square(double radius)
        {
            return _pi * radius * radius;
        }

        public static double Circumference(double radius)
        {
            return _pi * 2 * radius;
        }
    }
}