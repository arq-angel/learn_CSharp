// See https://aka.ms/new-console-template for more information

class MyFirstProgram
{
    static void Main(string[] args)
    {
        // method = performs a section of code, whenever it's called "invoked".
        //          benefit = Let's us reuse code w/o writing it multiple times

        String name = "John";
        int age = 20;
        
        singHappyBirthday(name, age);

        Console.ReadKey();
    }

    static void singHappyBirthday(String birthdayBoy, int yearsOld)
    {
        Console.WriteLine("Happy Birthday to you!");
        Console.WriteLine("Happy Birthday to you!");
        Console.WriteLine("Happy Birthday to dear " + birthdayBoy + "!");
        Console.WriteLine("You are " + yearsOld + " years old!");
        Console.WriteLine("Happy Birthday to you!");
        Console.WriteLine("");
    }
}


