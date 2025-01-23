using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    internal class Program
    {
        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Animal speaks.");
            }
            public  void Speak2()
            {
                Console.WriteLine("Animal speaks.");
            }
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog barks.");
            }
            public void print()
            {

            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Cat meows.");
            }
        }
        static void Main(string[] args)
        {
            Animal myAnimal;

            myAnimal=new Animal();
            myAnimal.Speak();// animal barks

            myAnimal = new Dog();
            myAnimal.Speak();  // Output: Dog barks.
            //myAnimal.print();

            myAnimal = new Cat();
            myAnimal.Speak();  // Output: Cat meows.

            //Dog d = new Animal();
        }
    }
}
