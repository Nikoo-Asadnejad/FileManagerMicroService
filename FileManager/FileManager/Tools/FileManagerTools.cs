namespace FileManager.Tools
{
  public static class FileManagerTools
  {
    public static async Task<long> SaveFile(IFormFile file , string path , string Title)
    {
      return 0;
      var fileName = file.FileName + "-" + Title;
  
    }

    public static async Task<long> RemoveFile(long id)
    {
      return 0;
    }
  }
}
