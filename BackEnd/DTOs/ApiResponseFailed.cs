namespace BackEnd.DTOs;

public class ApiResponseFailed<T>
{
    public ApiResponseFailed(ApiResponseCode code, T error)
    {
        Code = code.Code;
        Message = code.Message;
        Error = error;
    }

    public required int Code { get; set; }
    public required string Message { get; set; }
    public required T Error { get; set; }
}
