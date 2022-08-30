using Simple.HttpApi.Host;
using Token.Module.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddModuleApplication<SimpleHttpApiHostModule>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.InitializeApplication();

app.MapControllers();

app.Run();