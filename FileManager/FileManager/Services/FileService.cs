using FileManager.Configuration;
using FileManager.Dtos;
using FileManager.Interfaces;
using FileManager.Models;
using FileManager.Tools;
using GenericRepositoryDll.Repository.GenericRepository;
using Microsoft.Extensions.Options;

namespace FileManager.Services;
public class FileService : IFileService
{
  private IRepository<FileData> _repository;
  private AppSetting _appSetting;
  public FileService(IRepository<FileData> repository , IOptions<AppSetting> appSetting)
  {
    _repository = repository;
    _appSetting = appSetting.Value;
  }
  public async Task<ReturnModel<UploadReturnModel>> UploadAsync(UploadInputModel uploadInputModel)
  {
    ReturnModel<UploadReturnModel> result = new();
    var path = _appSetting.UploadDirectory;

    (bool isSuccessfull,string filePath , string message) saveFile =
      await FileManagerTools.SaveFileAsync(uploadInputModel.File ,uploadInputModel.Title,path);

    if(!saveFile.isSuccessfull)
    {
      result.CreateServerErrorModel();
      return result;
    }

    FileData fileData = new(uploadInputModel.File, uploadInputModel.Title, saveFile.filePath);

    await _repository.AddAsync(fileData);
    await _repository.SaveAsync();

    result.CreateSuccessModel(data: new UploadReturnModel(fileData.Id));
    return result;
  }
  public Task Download(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task Remove(Guid id)
  {
    throw new NotImplementedException();
  }

  
}

