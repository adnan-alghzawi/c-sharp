using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        /*
         •	Create a Calculator class with methods to add:
o	Two integers.
o	Three integers.
o	Two double values.
•	Write a program to demonstrate method overloading.

         */
        class Calculator
        {
            public void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void add(int a, int b, int c)
            {
                Console.WriteLine(a + b + c);
            }
            public void add(double a, double b)
            {
                Console.WriteLine(a + b);
            }
        }








        /*
          Create a Shape class with a method draw(). Create two child classes:
•	Circle that overrides draw() to print "Drawing a Circle."
•	Rectangle that overrides draw() to print "Drawing a Rectangle."
  Write a program to demonstrate method overriding and invoke methods polymorphically using a base class reference.

         */
        class Shape
        {
            public virtual void draw()
            {
                Console.WriteLine("Shape");
            }
        }
        class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("drawwing a Circle");
            }
        }
        
        class Rectangle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("drawing a Rectangle");
            }
        }






        /*
         1.	Create an abstract class Animal with:
o	An abstract method makeSound().
o	A concrete method sleep() that prints "Animal is sleeping."
o	Create two concrete classes:
	Dog that implements makeSound() as "Dog barks."
	Cat that implements makeSound() as "Cat meows."
o	Write a program to demonstrate the use of abstract classes.

         */
        abstract class Animal
        {
            public abstract void makeSound();
            public void sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }
        }
        class Dog : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks.");
            }
        }
        class Cat : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Cat barks.");
            }
        }





        /*
         1.	Create an interface Playable with:
o	A method play().
o	Implement this interface in two classes:
	Guitar that implements play() as "Playing the guitar."
	Piano that implements play() as "Playing the piano."
o	Write a program to demonstrate the use of interfaces and polymorphism by calling play().

         */
        interface Playable
        {
            void play();
        }
        class Guitar : Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the guitar.");
            }
        }
        class Piano : Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the Piano.");
            }
        }

        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.add(1, 2);
            c.add(1, 2, 3);
            c.add(1.1, 3.3);
            Console.WriteLine("\n");

            Shape s=new Shape();
            s.draw();
            s=new Circle();
            s.draw();
            s=new Rectangle();  
            s.draw();
            Console.WriteLine("\n");

            Animal a = new Dog();
            a.makeSound();
            a=new Cat();
            a.makeSound();
            Console.WriteLine("\n");

            Playable p=new Guitar();
            p.play();
            p=new Piano();
            p.play();
        }
    }
}
