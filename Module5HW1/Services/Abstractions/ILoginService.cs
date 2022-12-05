using Module5HW1.Dtos.Requests;
using Module5HW1.Dtos.Responses;

namespace Module5HW1.Services.Abstractions;

public interface ILoginService
{
    Task<LoginResponse> Register(string email, string password = null!);
    Task<LoginResponse> Login(string email, string password = null!);
}