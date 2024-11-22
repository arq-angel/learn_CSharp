// See https://aka.ms/new-console-template for more information

// type casting = Converting a value to a different data type
//                Useful when we accept user input (string)
//                Different data types can do different things

double a = 3.14;

int b = Convert.ToInt32(a);

Console.WriteLine(b);

Console.WriteLine(a.GetTypeCode());

Console.WriteLine(b.GetTypeCode());

int c = 123;

double d = Convert.ToDouble(c) + 0.1;

Console.WriteLine(d);

Console.WriteLine(d.GetTypeCode());

int e = 321;

string f = Convert.ToString(e);

Console.WriteLine(f);

Console.WriteLine(f.GetTypeCode());

string g = "$";

char h = Convert.ToChar(g);

Console.WriteLine(h);

Console.WriteLine(h.GetTypeCode());

string i = "true";

bool j = Convert.ToBoolean(i);

Console.WriteLine(j);

Console.WriteLine(j.GetTypeCode());

Console.ReadKey();