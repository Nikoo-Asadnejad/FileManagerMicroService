using FileManager.Dtos;
using FileManager.Models;

namespace FileManager.Interfaces;
public interface IFileService
{
  Task<ReturnModel<UploadReturnModel>> UploadAsync(UploadInputModel uploadInputModel);

  Task Download(Guid id);

  Task Remove(Guid id);
}

