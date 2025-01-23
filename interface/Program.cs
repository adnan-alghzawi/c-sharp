using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        interface IShape
        {
            void Draw(); // Abstract method

        }

        class Circle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Circle.");
            }
           
        }

        class Rectangle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Rectangle.");
            }
        }

        static void Main(string[] args)
        {
            IShape circle = new Circle();
            circle.Draw();            // Output: Drawing a Circle.

            IShape rectangle = new Rectangle();
            rectangle.Draw();         // Output: Drawing a Rectangle.
        }
    }
}
