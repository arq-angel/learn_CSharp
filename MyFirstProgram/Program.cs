class MyFirstProgram
{
    static void Main(string[] args)
    {
        // params keyword = a method parameter that takes a variable number of arguments
        //                  The parameter type must be a single - dimensional array

        double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
        
        Console.WriteLine("Total total: " + total);
        
        Console.ReadKey();
    }

    static double CheckOut(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price;
        }
        
        return total;
    }
}
// See https://aka.ms/new-console-template for more information

