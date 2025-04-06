namespace SimpleNotesApp.DTO;
public partial class UserForLoginDTO
{
    public string Email { get; set; }
    public string Password { get; set; }

    public UserForLoginDTO()
    {
        Email ??= string.Empty;
        Password ??= string.Empty;
    }
}