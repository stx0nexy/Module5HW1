namespace Module5HW1.Dtos.Requests;

public class LoginRequest
{
    public string Email { get; set; }

    public string Password { get; set; } = null!;
}