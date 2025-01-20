using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        
        //static int v(string s)
        //{
        //    int c = 0;
        //    foreach (char ch in s)
        //    {
        //        //if ("aeiouAEIOU".Contains(ch))
        //        //{
        //        //    c++;
        //        //}
        //        if(ch=='a' || ch== 'e' || ch == 'o' || ch == 'u' || ch == 'i' || ch == 'A' ||
        //          ch == 'E' || ch == 'O' || ch == 'U' || ch == 'I') { c++; }
        //    }
        //    return c;
        //}
        static void Main(string[] args)
        {
            //int count = v("adnan");
            //Console.WriteLine("the vowels counter : " + count);

            //string greeting = "Hello";
            //Console.WriteLine(greeting);


            //string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine("The length of the txt string is: " + txt.Length);
            //Console.WriteLine("lower case : "+txt.ToLower());
            //Console.WriteLine("upper case : " + txt.ToUpper());


            //string firstName = "John ";
            //string lastName = "Doe";
            //string name = firstName + lastName;
            //Console.WriteLine(name);


            //string name2 = string.Concat(firstName, lastName);
            //Console.WriteLine(name2);


            //int x = 10;
            //int y = 20;
            //int z = x + y;
            //Console.WriteLine(z);


            //string x2 = "10";
            //string y2 = "20";
            //string z2 = x2 + y2;
            //Console.WriteLine(z2);


            //int x3 = 10;
            //string y3 = "20";
            //Console.WriteLine(y3 + x3);
            //Console.WriteLine(x3 + y3);

            /*
             1-	Write a C# program that accepts a double input and converts it into an int. Display both values.
                •	Example:
                Input: 9.8
                Output:
                Double: 9.8
                Converted Int: 9

             */

            //Console.WriteLine("enter any double number");
            //double d= Convert.ToDouble(Console.ReadLine());
            //int i = (int)d;
            //Console.WriteLine(i);


            /*
             2-	Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.
                Example:
                Input: 25
                Output: "Your number is: 25"

             */
            //Console.WriteLine("enter any number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //string s = Convert.ToString(x);
            //Console.WriteLine("Your number is: " + s);


            /*
             * 3-	Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.
                Input: "C# is fun!"
                Output:
                Uppercase: C# IS FUN!
                Lowercase: c# is fun!

             */
            //Console.WriteLine("the sentence is : ");
            //string s=Console.ReadLine();
            //Console.WriteLine("lower case : "+s.ToLower());
            //Console.WriteLine("upper case : "+s.ToUpper());

            /*
             4-	Write a program that takes a user's full name as input and prints:
                The first name.
                The last name.
                The length of the full name.
                •	Example:
                Input: "John Doe"
                Output:
                First Name: John
                Last Name: Doe
                Total Characters: 8
             */
            //Console.WriteLine("enter your first name : ");
            //string s1=Console.ReadLine();
            //Console.WriteLine("enter your last name : ");
            //string s2 = Console.ReadLine();
            //string s3 = s1 +" " + s2;
            //Console.WriteLine("First Name: "+s1+"\n"+ " Last Name: "+s2+"\n"+ " Total Characters: "+s3.Length);


            /*
             5-	Write a program that accepts two integers and prints the smaller of the two.
                    Input: 5, 9
                    Output: "Smaller Number: 5"

             */
            //Console.WriteLine("enter the first number : ");
            //int num1=Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("enter the second number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 < num2)
            //{
            //    Console.WriteLine(num1 + " is smaller than " + num2);
            //}
            //else {
            //    Console.WriteLine(num2 + " is smaller than " + num1);
            //}

            /*
             
             
             6-	  Write a method that converts kilometers per hour to miles per hour. Use this method in a program to convert and display the result.
                Input: 15 km/h
                Output: "9.320568 mph"

             */
            //Console.WriteLine("enter a value in km/h you would convert it : ");
            //double d =Convert.ToDouble( Console.ReadLine());

            //double m = d / 1.6093446;
            //Console.WriteLine(m);


            /*
             7-	Write a method that takes hours and minutes as input and returns the total number of minutes.
                    Input: 5 hours, 37 minutes
                    Output: "Total: 337 minutes"

             */
            //Console.WriteLine("enter hours : ");
            //int i = Convert.ToInt32(Console.ReadLine())*60;
            //Console.WriteLine("enter minutes : ");
            //int i2 = Convert.ToInt32(Console.ReadLine());
            //int i3= i+i2;
            //Console.WriteLine("output : \"total " + i3 + " minutes");

            /*
             8-	Write a method that accepts minutes as input and calculates the total number of hours and minutes.
                •	Input: 546 minutes
                •	Output: "9 Hours, 6 Minutes"
             */
            //Console.WriteLine("Enter minutes : ");
            //int m = Convert.ToInt32(Console.ReadLine());//546
            //int h = m / 60;//9
            //int s = m % 60;//6
            //Console.WriteLine(h + " Hours, " + s + " Minutes");


            /*
             9-	Compare Two Numbers
Write a program that prints:
"Equal" if two numbers are the same.
"Greater" if the first is greater.
"Smaller" if the second is greater.
Use only comparison and ternary operators.
•	Input: 10, 20
•	Output: "Smaller"Sum of Digits

             */
            //Console.WriteLine("enter first number : ");
            //int num1 =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("enter second number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == num2)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else if (num1 > num2)
            //{
            //    Console.WriteLine("Greater");
            //}
            //else if (num1 < num2)
            //{
            //    Console.WriteLine("Smaller");
            //}



            /*
             Write a program that calculates the sum of the digits of a number using arithmetic operators and loops (no conditionals).
Input: 123
Output: "Sum of digits: 6"

             */


            //Console.WriteLine("Enter a number: ");
            //string s = Console.ReadLine();
            //int sum = 0;

            //for (int i = 0; i < s.Length; i++)
            //{

            //     sum += s[i]-'0';
            //    //int n = Convert.ToInt32(s[i].ToString());
            //    //sum += n;
            //}

            //Console.WriteLine($"Sum of digits: {sum}");



            /*
             10-	Reverse a Number
Write a program that reverses a number using arithmetic operators and loops.
Input: 1234
Output: "Reversed Number: 4321"

             */

            //Console.WriteLine("Enter a number: ");
            //string s = Console.ReadLine();
            //string r = "";

            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    r += s[i].ToString();

            //}
            //Console.WriteLine("Reversed Number:  " + r);


            /*
             11-	 Check Divisibility  
Write a program to check if a number is divisible by another number using logical and arithmetic operators. Return a message "Divisible" or "Not Divisible".
Input: 25, 5
Output: "Divisible"

             */
            //Console.WriteLine("enter first number : ");
            //int num1=Convert.ToInt32( Console.ReadLine());

            //Console.WriteLine("enter second number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 % num2 == 0) { Console.WriteLine("Divisible"); }
            //else { Console.WriteLine("Not Divisible"); }



            /*
             12-	Find the Middle Value
Write a program to find the middle value of three numbers using arithmetic and comparison operators.
Input: 15, 20, 10
Output: "The middle value is: 15"

             */

            //Console.WriteLine("Enter the first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number: ");
            //int c = int.Parse(Console.ReadLine());

            //int middle = a + b + c - Math.Max(a, Math.Max(b, c)) - Math.Min(a, Math.Min(b, c));

            //Console.WriteLine($"The middle value is: {middle}");



        }
    }
}
