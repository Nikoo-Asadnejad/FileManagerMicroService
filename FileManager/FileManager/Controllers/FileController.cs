using ErrorHandlingDll.Extensions;
using FileManager.Dtos;
using FileManager.Interfaces;
using FileManager.Models;
using FileManager.Percistances;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FileManager.Controllers
{
  public class FileController : Controller
  {
    private IFileService _fileService;
    public FileController(IFileService fileService)
    {
      _fileService = fileService;
    }

    /// <summary>
    /// An Api to upload a file
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(ReturnModel<UploadReturnModel>),200)]
    [ProducesResponseType(typeof(ReturnModel<UploadReturnModel>), 400)]
    [ProducesResponseType(typeof(ReturnModel<UploadReturnModel>), 500)]
    public async Task<IActionResult> Upload(UploadInputModel uploadInputModel)
    {
      ReturnModel<UploadReturnModel> result;
      if (!ModelState.IsValid)
      {
        var errors = ModelState.GetModelErrors();
        result = new ReturnModel<UploadReturnModel>(null, HttpStatusCode.BadRequest, fieldErrors: errors);
         
      }
      else
      {
        result = await _fileService.UploadAsync(uploadInputModel);
      } 
      return StatusCode((int)result.HttpStatusCode,result);
    }
  }
}
