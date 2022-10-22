using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Simple.Application.Contract.User;
using Token.Module.Extensions;

namespace Test.Simple.HttpApi;

public class UserInfoTest
{
    private IServiceProvider ServiceProvider;
    private IUserInfoService _userInfoService;

    [SetUp]
    public void Setup()
    {
        var service = new ServiceCollection();
        service.AddModuleApplicationAsync<TestSimpleHttpApiModule>();
        ServiceProvider = service.BuildServiceProvider();

        _userInfoService = ServiceProvider.GetRequiredService<IUserInfoService>();
    }

    [Test]
    public async Task GetListAsync()
    {
        var data = await _userInfoService.GetListAsync();
        Console.WriteLine(JsonSerializer.Serialize(data));
        Assert.Pass();
    }
}