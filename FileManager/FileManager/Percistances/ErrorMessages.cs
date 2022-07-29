namespace FileManager.Percistances;
public readonly struct FileValidationErrors
{
  public const string NullError = "فایل وارد نشده است";
  public const string InvalidFormatError = "فرمت ورودی صحیح نیست";
  public const string InvalidSizeError = "حجم فایل ورودی صحیح نیست";
  public const string InvalidDimentionError = "اندازه های فایل ورودی صحیح نیست";
  public const string IncludeMaliciousBytesError = "فایل مخرب است";

}

public readonly struct FileIOErrors
{
  public const string FileSavingFailed = "زخیره فایل با خطا مواجه شد";

}

