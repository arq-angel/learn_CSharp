using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            
            car1.Drive();
            car2.Drive();
        
            Console.ReadKey();
        }
    }

    class Car
    {
        private String make;
        private String model;
        private int year;
        private String Color;

        public Car(String make, String model, int year, String Color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.Color = Color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}
