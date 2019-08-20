using System;

namespace Homework2.Task2
{
    public abstract class Task2_Figure
    {
        public double X { get; }
        public double Y { get; }

        public Task2_Figure(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public abstract void Draw();
    }

    public class Square : Task2_Figure
    {
        public Square(double X, double Y) : base(X, Y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Class: Square, Method: Draw");
        }

    }

    public class Rectangle : Task2_Figure
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
