namespace DotNetFundamentals.Core.Services.Models;

public class ApiResponseModelExtended
{
    public string Message { get; set; }
    public bool IsSuccess => Errors.Count > 0 ? false : true; //{ get; private set; }
    public int HttpStatusCode { get; set; }
    public int TotalCount { get; private set; }
    public dynamic Data { get; private set; }

    public ApiResponseModelExtended()
    {
        Errors = new List<ValidationError>();
    }

    public List<ValidationError> Errors { get; set; }

    public ApiResponseModelExtended SetSuccess()
    {
        Errors = new List<ValidationError>();
        return this;
    }

    public ApiResponseModelExtended SetSuccess(dynamic data, int statuscode = 200)
    {
        Errors = new List<ValidationError>();
        Data = data;
        HttpStatusCode = statuscode;
        return this;
    }

    public ApiResponseModelExtended SetSuccess(dynamic data, string message, int statuscode = 0)
    {
        Errors = new List<ValidationError>();
        Data = data;
        Message = message;
        HttpStatusCode = statuscode;
        return this;
    }

    public ApiResponseModelExtended SetStatusCode(int statuscode)
    {
        HttpStatusCode = statuscode;
        return this;
    }

    public ApiResponseModelExtended SetError(string code, string errorMessage)
    {
        
        var validationError = new ValidationError
        {
            ErrorCode = code,
            ErrorMessage = errorMessage
        };

        Errors.Add(validationError);
        return this;
    }

    public ApiResponseModelExtended SetErrors(List<ValidationError> validationErrors)
    {
        Errors = validationErrors;
        return this;
    }

    public ApiResponseModelExtended SetMessage(string message)
    {
        Message = message;
        return this;
    }

    public ApiResponseModelExtended SetTotalCount(int count)
    {
        TotalCount = count;
        return this;
    }
}

public class ValidationError
{
    public string ErrorCode { get; set; }
    public string ErrorMessage { get; set; }
}