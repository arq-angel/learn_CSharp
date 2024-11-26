using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature
            
            Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
            
            Pizza pizza2 = new Pizza("stuffed crust", "red sauce", "mozzarella");
            
            Pizza pizza3 = new Pizza("stuffed crust", "red sauce");
            
            Pizza pizza4 = new Pizza("stuffed crust");
        
            Console.ReadKey();
        }
    }

    class Pizza
    {
        private String bread;
        private String sauce;
        private String cheese;
        private String topping;

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        
        public Pizza(String bread)
        {
            this.bread = bread;
        }
        
    }
}
