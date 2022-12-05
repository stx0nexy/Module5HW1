using Module5HW1.Dtos;
using Module5HW1.Dtos.Responses;

namespace Module5HW1.Services.Abstractions;

public interface IResourceService
{
    Task<ResourceDto> GetSingleResource(int id);
    Task<ListUsersResponse<ResourceDto>> GetListResource();
}