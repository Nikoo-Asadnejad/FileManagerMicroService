using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Dtos.FileValidation
{
  public class FileValidationSettingInputModel
  {
    public List<string> ValidContentTypes { get; set; }
    public List<string> ValidFormats { get; set; }
    public KeyValuePair<int, int>? MaxDimensions;
    public KeyValuePair<int, int>? MinDimensions;
    public List<KeyValuePair<int, int>>? ValidDimensions;
    public KeyValuePair<int, int>? Ratio { get; set; }
    public int ValidMaxSize { get; set; }
    public int ValidMinSize { get; set; }
    public string Type { get; set; }
  }
}
