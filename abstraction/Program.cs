using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Program
    {
        abstract class Shape
        {
            public abstract void Draw();  // Abstract method
            //public abstract void s();  // Abstract method
            public void Display()         // Non-abstract method
            {
                Console.WriteLine("Displaying shape...");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle.");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Rectangle.");
            }
        }
        static void Main(string[] args)
        {
            Shape s=new Rectangle();


            Shape circle = new Circle();
            circle.Draw();            // Output: Drawing a Circle.
            circle.Display();         // Output: Displaying shape...
           

            Shape rectangle = new Rectangle();
            rectangle.Draw();         // Output: Drawing a Rectangle.
        }
    }
}
