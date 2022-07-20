namespace FileManager.Tools
{
  public static class FileManagerTools
  {
    public static async Task SaveFile(IFormFile file  , string title)
    {
      var fileName = Path.Combine(title,"-",DateTime.Now.ToString(), Path.GetRandomFileName());

      using (var stream = File.Create(fileName))
        await file.CopyToAsync(stream);
  
    }

    public static async Task RemoveFile(string path)
    {
  
    }
  }
}
