class MyFirstProgram
{
    static void Main(string[] args)
    {
        // string interpolation = allows us to insert variables into a string literal
        //                        precede a string literal with $
        //                        {} are placeholders

        String firstName = "John";
        String lastName = "Doe";
        int age = 26;
        
        // Console.WriteLine("Hello " + firstName + " " + lastName + ".");
        // Console.WriteLine("You are " + age + " years old.");
        
        Console.WriteLine($"Hello {firstName} {lastName}.");
        Console.WriteLine($"You are {age, -10} years old.");

        Console.ReadKey();
    }
}
// See https://aka.ms/new-console-template for more information