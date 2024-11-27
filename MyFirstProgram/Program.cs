using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index
            //        Similar to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;

            List<String> food = new List<String>();
            
            food.Add("Soda");
            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("HotDog");
            food.Add("Fries");
            food.Add("Soda");
            
            // food.Remove("Soda");
            
            // food.Insert(0, "Sushi");
            
            // Console.WriteLine(food[0]);

            // Console.WriteLine(food.Count);

            // Console.WriteLine(food.IndexOf("Hamburger"));

            // Console.WriteLine(food.LastIndexOf("Soda"));

            // Console.WriteLine(food.Contains("Pizza"));
            
            // food.Sort();

            // food.Reverse();
            
            // food.Clear();
            
            String[] foodArray = food.ToArray();
            
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            
            
            Console.ReadKey();
        }
    }
}
