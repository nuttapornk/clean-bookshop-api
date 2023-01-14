namespace Domain.Common;

public class BaseResponse<T>
{
    public bool Success { get; set; }
    public T? Resule { get; set; }
    public BaseResponseError Error { get; set; } = new BaseResponseError();
}

public class BaseResponseError
{
    public string Code { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty; 
}