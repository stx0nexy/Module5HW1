using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module5HW1.Config;
using Module5HW1.Dtos.Requests;
using Module5HW1.Dtos.Responses;
using Module5HW1.Services.Abstractions;

namespace Module5HW1.Services;

public class LoginService : ILoginService
{
    private readonly IInternalHttpClientService _httpClientService;
    private readonly ILogger<LoginService> _logger;
    private readonly ApiOption _options;
    private readonly string _login = "/api/login";
    private readonly string _register = "/api/register";

    public LoginService(
        IInternalHttpClientService client,
        IOptions<ApiOption> options,
        ILogger<LoginService> logger)
    {
        _httpClientService = client;
        _logger = logger;
        _options = options.Value;
    }

    public async Task<LoginResponse> Register(string email, string password = null!)
    {
        var result = await _httpClientService.SendAsync<LoginResponse,
            LoginRequest>($"{_options.Host}{_register}", HttpMethod.Post);
        if (result != null)
        {
            _logger.LogWarning("Register - Successful");
        }
        else
        {
            _logger.LogWarning("Register - UnSuccessful");
        }

        return result;
    }

    public async Task<LoginResponse> Login(string email, string password = null!)
    {
        var result = await _httpClientService.SendAsync<LoginResponse,
            LoginRequest>($"{_options.Host}{_login}", HttpMethod.Post);
        if (result != null)
        {
            _logger.LogWarning("Login - Successful");
        }
        else
        {
            _logger.LogWarning("Login - UnSuccessful");
        }

        return result;
    }
}