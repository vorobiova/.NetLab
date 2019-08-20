using System;

namespace Homework2.Task1
{
    public abstract class Task1_Figure
    {
        public abstract void Draw();
    }

    public class Square : Task1_Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Class: Square, Method: Draw");
        }
    }
    
    public class Rectangle : Task1_Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Class: Rectangle, Method: Draw");
        }
    }


}