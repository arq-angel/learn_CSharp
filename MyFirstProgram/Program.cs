﻿using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = Modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lamborghini");
            
            Console.WriteLine(Car.numberOfCars);
            
            Car.StartRace();
        
            Console.ReadKey();
        }
    }

    class Car
    {
        private String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun");
        }
    }
}
