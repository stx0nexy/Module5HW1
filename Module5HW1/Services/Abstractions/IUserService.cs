using Module5HW1.Dtos;
using Module5HW1.Dtos.Responses;

namespace Module5HW1.Services.Abstractions;

public interface IUserService
{
    Task<UserDto> GetUserById(int id);
    Task<UserResponse> CreateUser(string name, string job);
    Task<List<UserDto>> GetListUsers(int page);
    Task<UpdateUserResponse> UpdateUserPut(string name, string job, int id);
    Task<UpdateUserResponse> UpdateUserPatch(string name, string job, int id);
    Task<bool> DeleteUser(int id);
    Task<ListUsersResponse<UserDto>> UsersDelay(int page);
}