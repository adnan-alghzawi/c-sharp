using System;
class Program
{
    //class Vehicle
    //{
    //    public string brand1 = "Ford";

    //    private string brand2 = "bmw";

    //    protected string brand3 = "byd";
    //    public void honk()
    //    { Console.WriteLine("Tuut, tuut!"); }

    //    //public void print3()
    //    //{
    //    //    Console.WriteLine(brand2);
    //    //}
    //}
    //class Car : Vehicle
    //{

    //    public string modelName = "Mustang";
    //    public string ss;

    //    public Car()
    //    {
    //       // ss = brand3;
    //        brand3 = "30";
    //    }

    //    public void print()

    //    { Console.WriteLine($" brand 3 : {brand3}"); }
    //}
    //sealed class S : Car
    //{
    //    public int a = 5;
    //    public void printS() { Console.WriteLine("this is seald class"); }

    //    //public void printT() { Console.WriteLine(brand3); }
    //}
    ////class T : S
    ////{

    ////}


    class Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public void print()
        {
            Console.WriteLine("\"Vehicle is starting.\" \n");
            Console.WriteLine($" the brand of vehicle : {Brand}\n and the model : {Model} \n");
        }
    }
    class Car : Vehicle
    {
        public int NumberOfDoors {  get; set; }
        
    }

    static void Main(string[] args)
    {
        
        Vehicle v= new Vehicle();

        Car c= new Car();
        c.Brand = "opel";
        c.Model = "2003";
        c.NumberOfDoors = 4;
        c.print();

        /*
            1- Constructor: A method that initializes an object when it's created.
            2- OOP Concepts: Encapsulation, Inheritance, Polymorphism, and Abstraction.
            3- Encapsulation: Protecting data by controlling access using methods or properties.
            4- Sealed Class: A class that cannot be inherited.
            5- Inheritance: A child class using the properties and methods of a parent class.
         */

        //Car myCar = new Car();

        //myCar.honk();
        //myCar.brand1 = "mazda";

        //myCar.ss = "hh";
        ////Console.WriteLine(myCar.ss);

        //Console.WriteLine(myCar.brand1 + " " + myCar.modelName);

        //S s = new S();

    }
}