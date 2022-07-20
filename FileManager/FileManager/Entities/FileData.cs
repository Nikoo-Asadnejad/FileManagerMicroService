using System.ComponentModel.DataAnnotations;

namespace FileManager.Models
{
  public class FileData
  {
    [Required]
    public long Id { get; set; }

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
  }
}
