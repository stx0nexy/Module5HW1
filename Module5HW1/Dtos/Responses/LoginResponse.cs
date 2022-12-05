namespace Module5HW1.Dtos.Responses;

public class LoginResponse
{
    public int Id { get; set; }

    public string Token { get; set; } = null!;

    public string Error { get; set; } = null!;
}