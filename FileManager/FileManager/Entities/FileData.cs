using System.ComponentModel.DataAnnotations;

namespace FileManager.Models
{
  public class FileData
  {
    [Required]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public string Title { get; set; }

    [Required]
    public string FileAddress { get; set; }

    [Required]
    [MaxLength(100)]
    public string FileType { get; set; }

    public string FileFormat { get; set; }
    public long CreatedDate { get; set;}
    public long? DeleteDate { get; set; }

    public FileData(IFormFile file , string title , string fullPath)
    {
      this.Title = title;
      this.FileType = file.ContentType;
      this.FileFormat = Path.GetExtension(file.FileName);
      this.FileAddress = fullPath;
      this.CreatedDate = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }

    public void Delete()
    {
      this.DeleteDate = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }
  }
}
