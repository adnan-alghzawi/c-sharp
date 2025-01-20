using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        //public class Car
        //{
        //    public string Make;
        //    public string Model;

        //    public void Start()
        //    {
        //        Console.WriteLine("Car is starting");
        //    }
        //}

        //field
        //public class Car
        //{
        //    public string make;
        //    public string model;
        //}

        //constant
        //public class Car
        //{
        //    public const int MaxSpeed=200; // Constant field
        //}

        //startic
        //public class Car
        //{
        //    public static int carCount = 5; // Static field
        //}

        //method related to class
        //public class Car
        //{
        //    public string Make;
        //    public string Model;
        //    public void Start() // Instance method
        //    {
        //        Console.WriteLine("Car is starting.");
        //    }
        //}
        //class Person
        //{

        //     public string name;
        //     public string  nationality;
        //     const int legs = 2;
        //        public void print()
        //        {
        //            Console.WriteLine("hello world");
        //        }
        //}
        //class Square
        //{
        //    public double length;
        //    public double width;

        //    public void multi()
        //    {
        //        Console.WriteLine( length* width);
        //    }

        //}


        //class Fruits
        //{
        //    //public string color;
        //    public const string color = "green";
        //    public static string shape;

        //    public static double rectangle()
        //    {
        //        return (0.5 * 3 * 3);
        //    }
        //    public void print()
        //    {
        //        Console.WriteLine("hello world!");
        //    }

        //}



        public static string number(int num)
        {
            if (num % 2 == 0) { return "even"; }
            else { return "odd"; }
        }
        public static int check(int num1,int num2 , int num3 , int num4 , int num5)
        {
            int smallest = num1;
            if(num2<num1) smallest = num2;
            else if(num3< num1) smallest = num3;
            else if (num4 < num1) smallest = num4;
            else if (num5 < num1) smallest = num5;
            return smallest;
        }
        public static int factorial(int num)
        {
            int m = 1;
            for (int i = num; i > 0; i--) 
            {
                m *= i;
                
            }
            return m;

        }



        public static string Prime(int num1, int num2)
        {
            string primes = "";
            for (int i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    primes += i + " "; 
                }
            }
            return primes;
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static int Largest(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }
        /*
         •	Room Type (e.g., Single, Double, Suite)
•	Price Per Night
•	IsBooked (whether the room is already booked or not)
•	HotelName = "Grand Stay Hotel";   as constant
*/
        class Room
        { 
            public int RoomNumber;
            public string RoomType;
            public double PricePerNight;
            public bool IsBooked;
            public const string HotelName = "Grand Stay Hotel"; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to {Room.HotelName}!");

            
            Room[] rooms = new Room[2];

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room();

                Console.WriteLine($"\nEnter details for Room {i + 1}:");

                Console.Write("Room Number: ");
                rooms[i].RoomNumber = int.Parse(Console.ReadLine());

                Console.Write("Room Type (e.g., Single, Double, Suite): ");
                rooms[i].RoomType = Console.ReadLine();

                Console.Write("Price Per Night: ");
                rooms[i].PricePerNight = double.Parse(Console.ReadLine());

                Console.Write("Is the room booked? (true/false): ");
                rooms[i].IsBooked = bool.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nRoom details in {Room.HotelName}:");
            foreach (var room in rooms)
            {
                Console.WriteLine($"\nRoom Number: {room.RoomNumber}");
                Console.WriteLine($"Room Type: {room.RoomType}");
                Console.WriteLine($"Price Per Night: {room.PricePerNight:C}");
                Console.WriteLine($"Is Booked: {room.IsBooked}");
            }


            /*
             1-	Write a C# program that accepts an integer and determines if the number is even or odd. Display the result.
•	Example Input: 7
•	Output: The number 7 is odd.

             */
            Console.WriteLine(number(7));

            /*
             2-	Write a C# program that accepts five numbers and displays the  2nd smallest of the five.
•	Example Input: 4, -3, 7, 2, 0
•	Output: 0

             */
            Console.WriteLine( check(1, 2, 0, 4, 5));
            /*
             3-	Write a program that calculates the factorial of a given number using a for loop.
•	Example Input: 5
•	Output: 120 (5 × 4 × 3 × 2 × 1 = 120)

             */
            Console.WriteLine( factorial(5));

            /*
             4-	Write a program that takes two integers as input and prints all the prime numbers between them using nested loops.
•	Example Input:
o	Start: 10
o	End: 30
•	Output: 11, 13, 17, 19, 23, 29

             */
            Console.WriteLine(Prime(10,30));
            /*
             5-	Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
•	Example Array: {3, 1, 4, 1, 5, 9}
•	Output: 9

             */
            //int[] a = new int[6];
            //Console.WriteLine("Enter 6 numbers:");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int largest = Largest(a);
            //Console.WriteLine(largest);

            /*
             6-	Write a program that prints the following number pattern using nested loops:
For n = 5, the output should be:
1  
2 3  
4 5 6  
7 8 9 10  
11 12 13 14 15  

             */
            //int n = 5;
            //int number = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(number + " ");
            //        number++;
            //    }
            //    Console.WriteLine();
            //}


            /*
             7-	Write a program that prints a pyramid pattern using stars (*) based on the input height. Use nested loops. (optional)
•	Example Input: n = 4
•	Output:
   *  
  ***  
 *****  
******* 

             */
            //Console.Write("Enter the height of the pyramid: ");
            //int n = int.Parse(Console.ReadLine());
            
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //Fruits apple = new Fruits();
            ////apple.color = "red";
            ////Console.WriteLine(apple.color="red");
            //Console.WriteLine(Fruits.color);
            //Fruits.shape = "cube";
            //Console.WriteLine(Fruits.shape);

            ////without static 
            ////Fruits meth = new Fruits();
            ////Console.WriteLine( meth.rectangle());
            //Console.WriteLine( Fruits.rectangle());

            //Fruits f = new Fruits();
            //f.print();

            //Person p = new Person();
            //Console.WriteLine(p.name = "sura");
            //Console.WriteLine(p.nationality = "jodanian");
            //p.print();

            //Square s= new Square();
            //s.length = 10;
            //s.width = 200;
            //s.multi();

            //class
            //Car myCar = new Car();

            //myCar.Make = "Toyota";
            //myCar.Model = "Camry";
            //myCar.Start();

            //int a=Car.carCount;
            //int a=Car.carCount;
            //Car.carCount = 5;
            //Console.WriteLine(Car.carCount);


            //while /do while
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("i = " + i);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("i = " + i);
            //    i++;
            //} while (i < 5);


            //for 
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("i = " + i);
            //}


            //Loop Through Array
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            // Foreach Loop
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //if else
            //int x = 10;
            //if (x > 5)
            //{
            //    Console.WriteLine("x is greater than 5");
            //}
            //else
            //{
            //    Console.WriteLine("x is less than or equal to 5");
            //}


            //switch
            //int day = 2;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day");
            //        break;
            //}





        }

        private static int largest(int[] a)
        {
            throw new NotImplementedException();
        }
    }
}
