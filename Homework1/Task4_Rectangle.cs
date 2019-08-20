using System.Numerics;

namespace Homework1
{
    public static class Task4_Rectangle
    {
        public static double Area(Vector2 leftTopPoint,Vector2 rightBottomPoint)
        {
            return 2 * (GetHeight(leftTopPoint,rightBottomPoint) + GetWidth(leftTopPoint,rightBottomPoint));
        }
        public static double Square(Vector2 leftTopPoint,Vector2 rightBottomPoint)
        {
            return GetHeight(leftTopPoint,rightBottomPoint) * GetWidth(leftTopPoint,rightBottomPoint);
        }

        public static double GetWidth(Vector2 leftTopPoint,Vector2 rightBottomPoint)
        {
            double _width = leftTopPoint.X - rightBottomPoint.X;
            if (_width < 0) _width *= -1;
            
            return _width;
        }
        
        public static double GetHeight(Vector2 leftTopPoint,Vector2 rightBottomPoint)
        {
            double _height = leftTopPoint.Y - rightBottomPoint.Y;
            if (_height < 0) _height *= -1;
            
            return _height;
        }
    }
}