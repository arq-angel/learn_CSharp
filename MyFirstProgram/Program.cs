using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic = "not specific to a particular data type"
            //           add <T> or <Thing> or <Whatever> to: classes, methods, fields, etc.
            //           allows for code reusability for different data types
            
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            String[] stringArray = { "one", "two", "three", "four", "five" };
            
            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);

            Console.ReadKey();
        }

        public static void DisplayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}