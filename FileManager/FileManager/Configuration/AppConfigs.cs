namespace FileManager.Configuration
{
  public static class AppConfigs
  {
    
    public static IWebHostEnvironment HostingEnvironment { get; private set; }
    private static bool IsHostEnvoironmentInitialized { get;  set; }

    public static IConfiguration Configuration { get; private set; }
    private static bool IsConfigurationInitialized { get; set; }

    public static void Initialize(IWebHostEnvironment hostEnvironment , IConfiguration configuration)
    {
      if (!IsHostEnvoironmentInitialized)
      {
        HostingEnvironment = hostEnvironment;
        IsHostEnvoironmentInitialized = true;
      }

      if(!IsConfigurationInitialized)
      {
        Configuration = configuration;
        IsConfigurationInitialized = true;
      }

    }
  }
}
