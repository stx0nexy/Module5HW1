using Module5HW1.Services;
using Module5HW1.Services.Abstractions;

namespace Module5HW1;

public class App
{
    private readonly IUserService _userService;
    private readonly IResourceService _resourceService;
    private readonly ILoginService _loginService;

    public App(IUserService userService,
        ILoginService loginService,
        IResourceService resourceService)
    {
        _userService = userService;
        _resourceService = resourceService;
        _loginService = loginService;
    }

    public async Task Start()
    {
        var users = await _userService.GetListUsers(2);
        var user23 = await _userService.GetUserById(23);
        var user = await _userService.GetUserById(2);
        var resources = await _resourceService.GetListResource();
        var resorce = await _resourceService.GetSingleResource(2);
        var resorce23 = await _resourceService.GetSingleResource(23);
        var userCreate = await _userService.CreateUser("morpheus", "leader");
        var userUpdatePut = await _userService.UpdateUserPut("morpheus", "zion resident", 2);
        var userUpdatePatch = await _userService.UpdateUserPatch("morpheus", "zion resident", 2);
        var userDelete = await _userService.DeleteUser(2);
        var registerSuccessful = await _loginService.Register("eve.holt@reqres.in", "pistol");
        var registerUnSuccessful = await _loginService.Register("sydney@fife");
        var loginSuccessful = await _loginService.Login("eve.holt@reqres.in", "cityslicka");
        var loginUnSuccessful = await _loginService.Login("peter@klaven");
        var delayedResponse = await _userService.UsersDelay(3);
    }
}