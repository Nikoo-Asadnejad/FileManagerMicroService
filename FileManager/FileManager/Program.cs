using FileManager.Configuration;


var builder = WebApplication.CreateBuilder(args);

FileManagerConfigurator.InjectServices(builder.Services, builder.Configuration);

var app = builder.Build();

FileManagerConfigurator.ConfigureAppPipeline(app);

app.Run();

AppConfigs.Initialize(app.Environment , builder.Configuration);


