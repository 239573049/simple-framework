using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Simple.Admin.Application.Contract.User;
using Simple.Admin.Application.Contract.User.Views;
using System.Text.Json;
using Token.Extensions;

namespace Test.Simple.HttpApi;

public class UserInfoTest
{
    private IServiceProvider ServiceProvider;
    private IUserInfoService _userInfoService;

    [SetUp]
    public async Task Setup()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("./appsettings.json")
            .Build();

        var service = new ServiceCollection();
        service.AddSingleton<IConfiguration>(configuration);

        await service.AddModuleApplicationAsync<TestSimpleHttpApiModule>();
        ServiceProvider = service.BuildServiceProvider();

        _userInfoService = ServiceProvider.GetRequiredService<IUserInfoService>();
    }

    [Test]
    public async Task GetListAsync()
    {
        var data = await _userInfoService.GetListAsync(new GetUserInfoInput());
        Console.WriteLine(JsonSerializer.Serialize(data));
        Assert.Pass();
    }
}