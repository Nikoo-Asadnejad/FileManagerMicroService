using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Percistance
{

  public readonly struct FileMimeTypes
  {  
    public readonly struct ImageFormats
    {
      public const string Jpeg = ".jpeg";
      public const string Jpg = ".jpg";
      public const string Png = ".png";
      public const string Gif = ".gif";
      public const string Webp = ".webp";
    }
    public readonly struct ImageContentMediaTypes
    {
      public const string Jpg = "image/jpg";
      public const string Jpeg = "image/jpeg";
      public const string PJpeg = "image/pjpeg";
      public const string Png = "image/png";
      public const string XPng = "image/x-png";
      public const string Webp = "image/WebP";
      public const string Gif = "image/gif";
    }
    public readonly struct VideoFormats
    {
      public const string Mp4 = ".mp4";
      public const string Mpeg = ".mpeg";
    }
    public readonly struct VideoContentMediaTypes
    {
      public const string Mp4 = "video/mp4";
      public const string Mpeg = "video/mpeg";
    }
    public readonly struct TextFormats
    {
      public const string Txt = ".txt";
      public const string Pdf = ".pdf";
      public const string Doc = ".doc";
      public const string Docx = ".docx";
      public const string Xls = ".xls";
      public const string Xlsx = ".xlsx";
    }
    public readonly struct TextContentMediaTypes
    {
      public const string Txt = "text/plain";
      public const string Pdf = "application/pdf";
      public const string Doc = ".application/vnd.ms-word";
      public const string Docx = "application/vnd.ms-word";
      public const string Xls = "application/vnd.ms-excel";
      public const string Xlsx = "application/vnd.openxmlformats";
    }
    public readonly struct FileTypes
    {
      public const string Image = "Image";
      public const string Video = "Video";
      public const string Text = "Text";
    }

  }
}

