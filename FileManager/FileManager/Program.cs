using FileManager.Configuration;

var builder = WebApplication.CreateBuilder(args);

FileManagerConfigurator.InjectServices(builder.Services);

var app = builder.Build();

FileManagerConfigurator.AddMiddlewares(app);

app.Run();
