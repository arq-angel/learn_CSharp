// See https://aka.ms/new-console-template for more information

String fullName = "John Doe";
String phoneNumber = "555-555-5555";

// fullName = fullName.ToUpper();
// fullName = fullName.ToLower();

// Console.WriteLine(fullName);

// phoneNumber = phoneNumber.Replace("-", "");

// Console.WriteLine(phoneNumber);

// String userName = fullName.Insert(0, "Mr.");

// Console.WriteLine(userName);

// Console.WriteLine(fullName.Length);

String firstName = fullName.Substring(0, 4);

Console.WriteLine(firstName);

String lastName = fullName.Substring(5, 3);

Console.WriteLine(lastName);

Console.ReadKey();