class MyFirstProgram
{
    static void Main(string[] args)
    {
        // conditional operator = used in conditional assignment iif a condition is true/false
        
        // (condition) ? x : y
        
        double temperature = 20;
        String message;

        if (temperature >= 15)
        {
            message = "It's warm outside!";
        }
        else
        {
            message = "It's cold outside!";
        }
        Console.WriteLine(message);
        
        message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
        
        Console.WriteLine(message);
        
        Console.WriteLine((temperature >= 15) ? "It's warm outside!" : "It's cold outside!");

        Console.ReadKey();
    }
}
// See https://aka.ms/new-console-template for more information