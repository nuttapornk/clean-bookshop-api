using Domain.Common;
using Duende.IdentityServer.Models;

namespace WebApi;

public static class ResponseHelper
{
    public static BaseResponse<T> Success<T>(T data,string message = "")
    {
        return new BaseResponse<T>
        {
            Success = true,
            Message = message,
            Resule = data
        };
    }

    public static BaseResponse<string> SuccessCreate(string message = "Create data success")
    {
        return new BaseResponse<string>
        {
            Success = true,
            Message = message
        };
    }

    public static BaseResponse<string> Error(Exception ex,
        string code = "N/A",
        string source = "N/A",
        string hellpMessage = "",
        string hellpPath = "")
    {
        return new BaseResponse<string>
        {
            Success = false,
            Message = $"{ex.Message} {ex.InnerException}",
            Error = new BaseResponseError
            {
                Code = code,
                Source = source,
                HelpMessage = hellpMessage,
                HelpPath = hellpPath
            }
        };
    }

    public static BaseResponse<string> Error(string message, 
        string code = "N/A",
        string source = "N/A",
        string hellpMessage = "",
        string hellpPath = "")
    {
        return new BaseResponse<string>
        {
            Success = false,
            Message = message ,
            Error = new BaseResponseError
            {
                Code = code,
                Source = source,
                HelpMessage = hellpMessage,
                HelpPath = hellpPath
            }
        };
    }

}
