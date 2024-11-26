using MainApp;
using MainApp.Factories;

var userRegistrationForm = UserFactory.Create();

// User user = new User();

#region User Registration Dialog

Console.WriteLine("Enter your first name: ");
//user.FirstName = Console.ReadLine()!;
userRegistrationForm.FirstName = Console.ReadLine()!;

Console.WriteLine("Enter your last name: ");
//user.LastName = Console.ReadLine()!;
userRegistrationForm.LastName = Console.ReadLine()!;

Console.WriteLine("Enter your email: ");
userRegistrationForm.Email = Console.ReadLine()!;

#endregion

// Console.WriteLine($"Your name is {user.FullName}");

var userEntity = UserFactory.Create(userRegistrationForm);

Console.WriteLine("");
Console.WriteLine($"{"Id:", -15}{userEntity.Id}");
Console.WriteLine($"{"Name:",-15}{userEntity.FirstName} {userEntity.LastName}");
Console.WriteLine($"{"Email:",-15}{userEntity.Email}");

Console.ReadKey();