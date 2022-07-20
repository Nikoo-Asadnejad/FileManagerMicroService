namespace FileManager.Configuration
{
  public static class FileManagerConfigurator
  {
    public static void InjectServices(IServiceCollection services)
    {
      // Add services to the container.
      services.AddControllers();
      services.AddEndpointsApiExplorer();
      services.AddSwaggerGen();

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
