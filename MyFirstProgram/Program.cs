// See https://aka.ms/new-console-template for more information

class MyFirstProgram
{
    static void Main(string[] args)
    {
        // return = returns data back to the place where a method is invoked

        double x;
        double y;
        double result;
        
        Console.Write("Enter in number 1: ");
        x = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter in number 2: ");
        y = Convert.ToInt32(Console.ReadLine());

        result = Multiply(x, y);
        
        Console.WriteLine(result);

        Console.ReadKey();
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }
    
}


