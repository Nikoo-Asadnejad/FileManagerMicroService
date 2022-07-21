using FileManager.Configuration;


var builder = WebApplication.CreateBuilder(args);

FileManagerConfigurator.InjectServices(builder.Services, builder.Configuration);

var app = builder.Build();

FileManagerConfigurator.AddMiddlewares(app);

app.Run();

AppConfigs.Initialize(app.Environment , builder.Configuration);


