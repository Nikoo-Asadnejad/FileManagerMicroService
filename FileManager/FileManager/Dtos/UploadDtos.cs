namespace FileManager.Dtos;
public record UploadInputModel(IFormFile File , string Title);
public record UploadReturnModel(Guid FileId);


