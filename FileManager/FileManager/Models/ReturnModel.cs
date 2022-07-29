
using FileManager.Models;
using FileManager.Percistances;
using System.Net;

namespace FileManager.Models;
public class ReturnModel<T>
{
  public HttpStatusCode HttpStatusCode { get; set; }
  public string Message { get; set; }
  public T Data { get; set; }
  public string DataTitle { get; set; }

  public List<FieldErrorsModel> FieldErrors { get; set; }

  public ReturnModel()
  {

  }

  public ReturnModel(T? data, HttpStatusCode statusCode, string title = null,
    string message = null, List<FieldErrorsModel> fieldErrors = null)
  {
    this.DataTitle = title;
    this.Data = data;
    this.HttpStatusCode = statusCode;
    this.FieldErrors = fieldErrors;

    this.Message = statusCode switch
    {
      HttpStatusCode.OK => message ?? ReturnMessage.SuccessMessage,
      HttpStatusCode.BadRequest => message ?? ReturnMessage.InvalidInputDataErrorMessage,
      HttpStatusCode.InternalServerError => message ?? ReturnMessage.InternalServerErrorMessage,
      HttpStatusCode.NotFound => message ?? ReturnMessage.NotFoundMessage,
      HttpStatusCode.Forbidden => message ?? ReturnMessage.AccessDeniedErrorMessage,
      _ => message
    };

  }

  public ReturnModel<T> CreateSuccessModel(T data, string title = null, string message = null)
  {
    this.Data = data;
    this.HttpStatusCode = HttpStatusCode.OK;
    this.DataTitle = title;
    this.Message = message == null ? ReturnMessage.SuccessMessage : message;
    return this;
  }

  public ReturnModel<T> CreateNotFoundModel(string title = null, string message = null)
  {
    this.HttpStatusCode = HttpStatusCode.NotFound;
    this.DataTitle = title;
    this.Message = message == null ? ReturnMessage.NotFoundMessage : message;
    return this;
  }

  public ReturnModel<T> CreateServerErrorModel(string title = null, string message = null)
  {
    this.HttpStatusCode = HttpStatusCode.InternalServerError;
    this.DataTitle = title;
    this.Message = message == null ? ReturnMessage.InternalServerErrorMessage : message;
    return this;
  }

  public ReturnModel<T> CreateBadRequestModel(string title = null, string message = null, List<FieldErrorsModel> fieldErrors = null)
  {
    this.HttpStatusCode = HttpStatusCode.BadRequest;
    this.DataTitle = title;
    this.Message = message == null ? ReturnMessage.InvalidInputDataErrorMessage : message;
    this.FieldErrors = fieldErrors;
    return this;
  }

  public ReturnModel<T> CreateDuplicatedErrorModel(string title = null, string message = null)
  {
    this.HttpStatusCode = HttpStatusCode.Conflict;
    this.DataTitle = title;
    this.Message = message == null ? ReturnMessage.DuplicationErrorMessage : message;
    return this;
  }

  public ReturnModel<T> CreateAccessDeniedErrorMode(string title = null, string message = null)
  {
    this.HttpStatusCode = HttpStatusCode.Forbidden;
    this.DataTitle = title;
    this.Message = message == null ? ReturnMessage.AccessDeniedErrorMessage : message;
    return this;
  }

}

