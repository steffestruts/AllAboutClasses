namespace MainApp.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static UserEntity Create(UserRegistrationForm userRegistrationForm)
    {
        return new UserEntity
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = userRegistrationForm.FirstName,
            LastName = userRegistrationForm.LastName,
            Email = userRegistrationForm.Email,
            Password = SecurePasswordGenerator.Generate(userRegistrationForm.Password),
            EmailConfirmed = false
        };
    }
}
