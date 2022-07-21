using FileManager.Dtos;
using FileManager.Dtos.ReturnTypes;

namespace FileManager.Interfaces;
public interface IUploadService
{
  Task<ReturnModel<UploadReturnModel>> UploadAsync(UploadInputModel uploadInputModel);

  Task Download(Guid id);

  Task Remove(Guid id);
}

