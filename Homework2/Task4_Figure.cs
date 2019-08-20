using System;
using System.ComponentModel.DataAnnotations;

namespace Homework2.Task4
{
    public interface IDrawable
    {
        void Draw();
    }

    public class Task4_Figure : IDrawable
    {
        public double X { get; }
        public double Y { get; }

        public Task4_Figure(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Draw()
        {
            Console.WriteLine("Class: Figure, Method: Draw");
        }
    }

    public class Square : Figure, IDrawable
    {
        public Square(double X, double Y) : base(X, Y)
        {
        }

        public void Draw()
        {
            Console.WriteLine("Class: Square, Method: Draw");
        }

    }

    public class Rectangle : Figure, IDrawable
    {
        public Rectangle(double X, double Y) : base(X, Y)
        {
        }

        public void Draw()
        {
            Console.WriteLine("Class: Rectangle, Method: Draw");
        }
    }

    private static void DrawAll(IDrawable[] figures)
    {
        foreach (var figure in figures)
        {
            figure.Draw();
        }
    }
}
