using System;

namespace Homework2.Task3
{
    public class Task3_Figure
    {
        public double X { get; }
        public double Y { get; }

        public Task3_Figure(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Class: Figure, Method: Draw");
        }
    }

    public class Square : Task3_Figure
    {
        public Square(double X, double Y) : base(X, Y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Class: Square, Method: Draw");
        }

    }

    public class Rectangle : Task3_Figure
    {
        public Rectangle(double X, double Y) : base(X, Y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Class: Rectangle, Method: Draw");
        }
    }
}