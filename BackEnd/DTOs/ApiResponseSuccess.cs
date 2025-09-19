namespace BackEnd.DTOs;

public class ApiResponseSuccess<T>
{
    public ApiResponseSuccess(int code, string message, T data)
    {
        Code = code;
        Message = message;
        Data = data;
    }

    public required int Code { get; set; }
    public required string Message { get; set; }
    public required T Data { get; set; }
}
