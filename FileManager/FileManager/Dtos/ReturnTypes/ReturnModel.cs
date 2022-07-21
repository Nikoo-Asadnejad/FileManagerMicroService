
using System.Net;

namespace FileManager.Dtos.ReturnTypes;
  public class ReturnModel<T>
  {
    public HttpStatusCode HttpStatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    public string DataTitle { get; set; }

    public ReturnModel()
    {

    }

    public ReturnModel(T? data ,HttpStatusCode statusCode, string title = null,
      string message = null)
    {
      DataTitle = title;
      Data = data;

      switch (statusCode)
    {
      case HttpStatusCode.OK:
        {
          Data = data;
          HttpStatusCode = HttpStatusCode.OK;
          Message = message == null ? ReturnMessage.SuccessMessage : message;

        }
        break;
      case HttpStatusCode.NotFound:
        {
          HttpStatusCode = HttpStatusCode.NotFound;
          Message = message == null ? ReturnMessage.NotFoundMessage : message;
        }
        break;
      case HttpStatusCode.InternalServerError:
        {
          HttpStatusCode = HttpStatusCode.InternalServerError;
          Message = message == null ? ReturnMessage.ServerErrorMessage : message;
        }
        break;
      case HttpStatusCode.BadRequest:
        {
          HttpStatusCode = HttpStatusCode.BadRequest;
          Message = message == null ? ReturnMessage.InvalidInputDataErrorMessage : message;

        }
        break;

      default:
        {
          HttpStatusCode = (HttpStatusCode)statusCode;
          Message = message;
        }
        break;
    }

    
    }

    public ReturnModel(string title , T data , HttpStatusCode statusCode , string message)
    {
      Data = data;
      DataTitle = title;
      HttpStatusCode = statusCode;
      Message = message;
    }


    public ReturnModel<T> CreateSuccessModel(T data ,string title = null, string message = null)
    { 
      this.Data = data;
      this.HttpStatusCode = HttpStatusCode.OK;
      this.DataTitle = title;
      this.Message = message == null ? ReturnMessage.SuccessMessage : message;
      return this;
    }

    public ReturnModel<T> CreateNotFoundModel(string title = null,string message = null)
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
      this.Message = message == null ? ReturnMessage.ServerErrorMessage : message;
      return this;
    }

    public ReturnModel<T> CreateBadRequestModel(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.DataTitle = title;
      this.Message = message == null ? ReturnMessage.ServerErrorMessage : message;
      return this;
    }

    public ReturnModel<T> CreateInvalidInputErrorModel(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.DataTitle = title;
      this.Message = message == null ? ReturnMessage.InvalidInputDataErrorMessage : message;
      return this;
    }

    public ReturnModel<T> CreateDuplicatedErrorModel(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.DataTitle = title;
      this.Message = message == null ? ReturnMessage.DuplicationErrorMessage : message;
      return this;
    }

  }

