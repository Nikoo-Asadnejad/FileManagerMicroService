using FileManager.Configuration;

namespace FileManager.Tools
{
  public static class FileManagerTools
  {
    public static async Task SaveFile(IFormFile file , string title , string path)
    {
      string rootPath = AppConfigs.HostingEnvironment.ContentRootPath;
      string filePath = Path.Combine(rootPath, path);
      string fileName = Path.Combine(title,"-",
                              DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString(),
                              file.FileName);

      string fileFullPath = Path.Combine(filePath,fileName);

      using (FileStream stream = File.Create(fileFullPath))
        await file.CopyToAsync(stream);

      
  
    }

    public static async Task RemoveFile(string path)
    {
       File.Delete(path);
    }
  }
}
