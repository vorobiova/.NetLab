using System.Numerics;

namespace Homework1
{
    public class Task1_Rectangle
    {
        private readonly Vector2 _leftTopPoint;
        private readonly Vector2 _rightBottomPoint;

        private double _height;
        private double _width;
        
        public Task1_Rectangle(Vector2 leftTopPoint,Vector2 rightBottomPoint)
        {
            _leftTopPoint = leftTopPoint;
            _rightBottomPoint = rightBottomPoint;

            _width = leftTopPoint.X - rightBottomPoint.X;
            _height = leftTopPoint.Y - rightBottomPoint.Y;
            
            if (_width < 0) _width *= -1;
            if (_height < 0) _height *= -1;
        }
        
        public double Area()
        {
            return 2 * (_height + _width);
        }

        public double Square()
        {
            return _height * _width;
        }
    }
}