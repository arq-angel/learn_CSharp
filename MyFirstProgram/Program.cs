// See https://aka.ms/new-console-template for more information

int x;  // declaration
x = 123;    // initialization

int y = 321;    // declaration + initialization

int z = x + y;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(x + y);
Console.WriteLine(z);

int age = 21;   // whole integer

Console.WriteLine("Your age is " + age);

double height = 300.5;  // decimal number

Console.WriteLine("Your height is " + height + "cm");

bool alive = true;  // boolean value - true or false

Console.WriteLine("Are you alive? " + alive);

char symbol = '@';  // inside single quotes - only single character

Console.WriteLine("Your Symbol is " + symbol);

string name = "Arthur";

Console.WriteLine("Hello " + name);

string userName = symbol + name;

Console.WriteLine("Your username is " + userName);

Console.ReadKey();