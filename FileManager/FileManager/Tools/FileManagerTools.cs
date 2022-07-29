using FileManager.Configuration;
using FileManager.Percistances;

namespace FileManager.Tools
{
  public static class FileManagerTools
  {
    public static async Task<(bool isSuccessFull, string filePath)> SaveFileAsync(IFormFile file ,
                                                                      string title , string path)
    {
      try
      {
        string rootPath = AppConfigs.HostingEnvironment.ContentRootPath;
        string filePath = Path.Combine(rootPath, path);
        string fileName = Path.Combine(title,DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString(),file.Name);

        string fileFullPath = Path.Combine(filePath, fileName);

        using (FileStream stream = File.Create(fileFullPath))
          await file.CopyToAsync(stream);

        return (true, fileFullPath);
      }
      catch (Exception ex)
      {
        //add logs
        return (false,FileIOErrors.FileSavingFailed);
      }
      
  
    }

    public static async Task RemoveFileAsync(string path)
    {
       File.Delete(path);
    }
  }
}
