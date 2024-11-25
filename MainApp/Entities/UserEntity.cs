using System.ComponentModel.DataAnnotations;

namespace MainApp;

public class UserEntity
{
    [Key]
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public bool EmailConfirmed { get; set; }

}