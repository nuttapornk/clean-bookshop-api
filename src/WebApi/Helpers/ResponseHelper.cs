using Domain.Common;

namespace WebApi;

public static class ResponseHelper
{
    public static BaseResponse<T> Success<T>(T data)
    {
        return new BaseResponse<T>
        {
            Success= true,
            Resule = data
        };
    }

    public static BaseResponse<string> Error(Exception ex,string code = "N/A",string title = "No Title")
    {
        return new BaseResponse<string>
        {
            Success = false,
            Error = new BaseResponseError
            {
                Code = code,
                Title = title,
                Message = ex.Message ?? ""
            }
        };
    }

    public static BaseResponse<string> Error(string message, string code = "N/A", string title = "No Title")
    {
        return new BaseResponse<string>
        {
            Success = false,
            Error = new BaseResponseError
            {
                Code = code,
                Title = title,
                Message = message
            }
        };
    }

}
