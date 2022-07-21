using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting.Internal;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FileManager.Configuration
{
  public static class FileManagerConfigurator
  {
    public static void InjectServices(IServiceCollection services , IConfiguration configuration)
    {
      // Add services to the container.
      services.AddControllers();
      services.AddEndpointsApiExplorer();
      services.AddSwaggerGen();
      services.Configure<AppSetting>(configuration);
    }

    public static void AddMiddlewares( WebApplication app)
    {
      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      app.UseAuthorization();

      app.MapControllers();

    }
  }
}
