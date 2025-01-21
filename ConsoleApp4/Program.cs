using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        class Car
        {
            private string model;
            private string s;
            private string t;
            public Car()
            {
                model = "Mustang";
            }
            public Car(string model, string s)
            {
                model = "Mustang";
            }

            //public string set(string m)
            //{
            //    model = m;
            //    return model;
            //}
        }

        class hotel
        {
            public int RoomNumber
            { // property

                //set; get;

                set
                {
                    RoomNumber = value;
                }
                get
                {
                    return RoomNumber;
                }

            }  // proerty  encapculation
            public hotel(int n) // constructor      initila property   method 
            {
                RoomNumber = n;
            }
            ~hotel()
            {
                Console.WriteLine("finish");
            }
        }

        class Room
        {
            public int RoomNumber { get; set; }
            public string RoomType { get; set; }
            public double PricePerNight { get; set; }
            public bool IsBooked { get; set; }

            public const string HotelName = "Grand Stay Hotel";

            public Room()
            {
                RoomNumber = 0;
                RoomType = "";
                PricePerNight = 0;
                IsBooked = false;

            }
            public Room(int i, string s, double d, bool b)
            {
                RoomNumber = i;
                RoomType = s;
                PricePerNight = d;
                IsBooked = b;
            }
            //public void print(int i, string s, double d, bool b)
            //{
            //    Console.WriteLine($"\nRoom Number: {i}");
            //    Console.WriteLine($"Room Type: {s}");
            //    Console.WriteLine($"Price Per Night: {d}");
            //    Console.WriteLine($"Is Booked: {b}");
            //}
            ~Room()
            {
                Console.WriteLine("this is de constructor");
            }
        }

        //class Student
        //{
        //    //private int std_id;//field
        //    public int student_id
        //    {
        //        get; set;
        //        /* get { return std_id; } set { std_id = value; }*/
        //    }//properity
        //    public string studen_name { get; set; }
        //    public double gpa { get; set; }
        //    public double age { get; set; }

        //    public Student()
        //    {
        //        student_id = 0;
        //        studen_name = "";
        //        gpa = 0;
        //        age = 0;
        //    }
        //    public Student(int student_id, string studen_name, double gpa, double age)
        //    {
        //        this.student_id = student_id;
        //        this.studen_name = studen_name;
        //        this.gpa = gpa;
        //        this.age = age;
        //    }
        //    ~Student()
        //    {
        //        Console.WriteLine(" F I N I S H ");
        //    }
        //}

        class bank
        {
            public const string bank_name = "Al Etihad Bank";
            public int customer_number { get; set; }  // properity
            public int bank_id { get; set; }
            public bank()
            {
                customer_number = 1;
                bank_id = 1;
            }
            public bank(int customer_number, int bank_id)
            {
                this.customer_number = customer_number;
                this.bank_id = bank_id;
            }
            public string print()
            {
                return "hazem";
            }
            ~bank()
            {
                Console.WriteLine("adnan");
            }
        }

        class Student
        {
            /*
             	A property named Name of type string to represent the student's name.
	A property named Age of type int to represent the student's age.
	A property named StudentID of type int to represent the student's ID.
	Add an auto property named Email to represent the student’s email.

             */
            private int age;
            public string Name { get; set; } //property 
            public int Age
            {
                set
                {
                    if (value < MinAge || value > MaxAge)
                    {
                        age = 0;
                    }
                    else
                    {
                        age = value;
                    }
                        
                }
                get
                {
                    return age;
                }
            }//property 
            public int StudentID { get; set; }//property 
            public string Email { get; set; }//property 
            /*
             o	Add a constant named MinAge to represent the
            minimum allowed age for a student (18 years).
o	Add a constant named MaxAge to represent the maximum
            allowed age for a student (40 years).

             */
            public const int MinAge = 18;// CONSTANT 
            public const int MaxAge = 40;//CONSTANT

            public Student()
            {//CONSTRUCTOR
                Name = "";
                Age = 0;
                StudentID = 0;
                Email = "";
            }
            public Student(string name, int age, int studentID, string email)//PARAMETERIZE CONSTRUCTOR
            {
                Name = name;
                Age = age;
                StudentID = studentID;
                Email = email;
            }


            /*
             o	Add a method named GetDetails that displays a 
            message containing the student’s name, age, and ID.
             */
            public void GetDetails()// METHOD
            {
                Console.WriteLine($" name : {Name} \n Age : {Age} \n student id : {StudentID}");
            }

            ~Student()//DESTRUCTOR
            {
                Console.WriteLine(" F I N I S H ");
            }

            static void Main(string[] args)
            {
                /*
                 o	Create an object from the Student class with the following values:
	Name: "Ahmad"
	Age: 22
	Student ID: 1001
o	Call the GetDetails method for the object.

                 */
                Student std = new Student();
                std.Name = "ahmad";
                std.Age = 22;
                std.StudentID = 1001;
                std.GetDetails();

                Console.WriteLine("\n");

                Student std2 = new Student("adnan", 24, 148108, "alghzawiadnan22@gmail.com");
                std2.GetDetails();

                Console.WriteLine("\n");

                /*
                   1- Class: A blueprint or template for creating objects, defining properties and methods.

                   2- Object: An instance of a class containing specific data and behavior defined by the class.

                   3- Difference: A class is a blueprint, while an object is a specific instance of that blueprint.

                   4- OOP Principles: Encapsulation, Inheritance, Polymorphism, and Abstraction.

                   5- Property: A class member that provides a flexible way to access and modify fields, often with get and set methods.

                   6- Field: A variable defined within a class to store data.

                   7- Constructor: A special method used to initialize objects of a class.

                   8- Encapsulation: Restricting access to an object's data and exposing only necessary parts through methods or properties.
                 */





                // bank b1 = new bank();
                // Console.WriteLine(b1.bank_id);
                //Console.WriteLine( b1.print());


                // bank b2 = new bank(1,5);
                // Console.WriteLine(b2.bank_id);
                // Console.WriteLine(b2.customer_number);




                //Student std=new Student();
                //std.student_id = -1;
                //Console.WriteLine(std.student_id+"\n");

                //Student std2 = new Student(148108,"adnan",2.63,24);
                //Console.WriteLine(" student id : "+std2.student_id +"\n student name : "+
                //    std2.studen_name+"\n student gpa : "+std2.gpa+"\n student age : "+std.age+"\n");



                //Room room1 = new Room();
                //Console.WriteLine(room1.PricePerNight);//0
                //room1.PricePerNight = 10;
                //Console.WriteLine(room1.PricePerNight);//10

                //Room room2 = new Room(20, "suite", 130, false);
                //Console.WriteLine(room2.PricePerNight);//130


                ////    Car c= new Car();
                //////Console.WriteLine( c.set("st"));
                //hotel h = new hotel(3);
                //h.RoomNumber = 10;
                //Console.WriteLine(h.RoomNumber);

                //hotel h2 = new hotel(3);
                //Console.WriteLine(h2.RoomNumber);
            }
        }
    }
}
