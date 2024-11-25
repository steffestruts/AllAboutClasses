using MainApp.Models;

User user = new User();

Console.WriteLine("Enter your first name: ");
user.FirstName = Console.ReadLine()!;

Console.WriteLine("Enter your last name: ");
user.LastName = Console.ReadLine()!;


Console.WriteLine($"Your name is {user.FullName}");
Console.ReadKey();