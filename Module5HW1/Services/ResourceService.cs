using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module5HW1.Config;
using Module5HW1.Dtos;
using Module5HW1.Dtos.Responses;
using Module5HW1.Services.Abstractions;

namespace Module5HW1.Services;

public class ResourceService: IResourceService
{
    private readonly IInternalHttpClientService _httpClientService;
    private readonly ILogger<ResourceService> _logger;
    private readonly ApiOption _options;
    private readonly string _resourceApi = "/api/unknown/";

    public ResourceService(
        IInternalHttpClientService client,
        IOptions<ApiOption> options,
        ILogger<ResourceService> logger)
    {
        _httpClientService = client;
        _logger = logger;
        _options = options.Value;
    }

    public async Task<ResourceDto> GetSingleResource(int id)
    {
        var result = await _httpClientService.SendAsync<SingleUserResponse<ResourceDto>,
            object>($"{_options.Host}{_resourceApi}{id}", HttpMethod.Get);

        if (result?.Data != null)
        {
            _logger.LogInformation($"Resource with id = {result.Data.Id} was found");
        }
        return result?.Data;
    }

    public async Task<ListUsersResponse<ResourceDto>> GetListResource()
    {
        var result = await _httpClientService.SendAsync<ListUsersResponse<ResourceDto>,
            object>($"{_options.Host}{_resourceApi}", HttpMethod.Get);
        if (result?.Page != null)
        {
            _logger.LogInformation($"Users was found");
        }
        return result;
    }
}