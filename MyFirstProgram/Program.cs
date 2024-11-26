// See https://aka.ms/new-console-template for more information

// array = a variable that can store multiple values. fixed size

// String[] cars = { "BMW", "Mustang", "Corvette" };

String[] cars = new string[3];

cars[0] = "Tesla";
cars[1] = "Mustang";
cars[2] = "Corvette";

/*Console.WriteLine(cars[0]);
Console.WriteLine(cars[1]);
Console.WriteLine(cars[2]);*/

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

Console.ReadKey();
