namespace FileManager.Configuration
{
  public class AppSetting
  {

    public Loggings Logging { get; set; }
    public string AllowedHosts { get; set; }
    public string ConnectionString { get; set; }
    public string UploadDirectory { get; set; }


    public class Loggings
    {
      public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
      public string Default { get; set; }
      public string MicrosoftAspNetCore { get; set; }
    }



  }
}
