using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage1 = new Car[3];
            
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lamborghini");
            
            garage1[0] = car1;
            garage1[1] = car2;
            garage1[2] = car3;
            
            Car[] garage2 = {new Car("Mustang"), new Car("Corvette"), new Car("Lamborghini")};
            
            /*
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            */

            foreach (Car car in garage1)
            {
                Console.WriteLine(car.model);
            }
            
            foreach (Car car in garage2)
            {
                Console.WriteLine(car.model);
            }
            
            Console.ReadKey();
        }
    }

    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
