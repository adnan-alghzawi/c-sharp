using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//gray color meaning these not used 

namespace ConsoleApp1
{
    internal class Program //class
    {
        static void Main(string[] args) //function
        {
            //Console.WriteLine("Hello World!");

            // decleration 
            //string[] cars;
            //cars = new string[5];
            //cars[0] = "opel";
            //cars[1] = "bmw";
            //Console.WriteLine(cars[0]);

            //decleration and initilization
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine(cars[0]); // volvo
            //Console.WriteLine(cars.Length);//4

            //change elements in array
            //cars[3] = "BYD";
            //Console.WriteLine(cars[3]);// byd

            //int[] myNum = { 30, 10, 30, 40 };

            //Console.WriteLine(myNum.Length);
            //sort
            //Array.Sort(myNum);
            //Console.WriteLine(myNum[0]);

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.Write(cars[i]+" ");
            //    //Console.WriteLine(cars[i]);
            //}


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("enter your name");
            //string name;
            //name= Console.ReadLine();
            //Console.WriteLine("your name is "+name);

            //int a=Console.Read();
            //Console.WriteLine(a);

            /*//////////////////////////////////////*/

            //1 - Create console application that read string from user and print the same string

            //string s = Console.ReadLine();
            //Console.WriteLine(s);


            /* 
             2-	Define variables with kind of
a.	 Double
b.	String 
c.	Char
d.	Bool
e.	Int
f.	Const
Then display it in console application

            // */
            //double d = 5.5;
            //string s = "adnan";
            //char c = 'A';
            //bool b = true;
            //int i = 5;
            //const int j = 10;
            //Console.WriteLine(d + " " + s + " " + c + " " + b + " " + i + " " + j);


            //3-	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            //string[] s = { "opel", "bmw", "haval" };
            //foreach (string s2 in s)
            //{
            //    Console.WriteLine(s2);
            //}
            //Console.WriteLine(s.Length);


            /*
             4-	Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially. Go to the editor
•	Input your firstname: Sami
•	Input your lastname: Ali
•	Input your year of birth: 1999
•	Sami Ali 1999

             */
            //Console.WriteLine("enter your first name");
            //string name=Console.ReadLine();


            //Console.WriteLine("enter your last name");
            //string name1=Console.ReadLine();


            //Console.WriteLine("enter your birth year");
            //int year =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine(name+" "+name1+" "+year);




            /*
             5-	Write a program in C # to store elements in an array and print it. 
•	Test Data :	
•	Input 10 elements in the array :
•	element - 0 : 1
•	element - 1 : 1
•	element - 2 : 2
•	.......
•	Expected Output :
•	Elements in array are: 1 1 2 3 4 5 6 7 8 9

             */

            //int[] arr = new int[10];

            //Console.WriteLine("enter 10 elements");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("enter the element of index " + i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("\n");
            //foreach (int i in arr)
            //{

            //    Console.Write(i + " ");
            //}


        }
    }
}
