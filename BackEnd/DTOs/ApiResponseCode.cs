namespace BackEnd.DTOs;

public record ApiResponseCode(int Code, string Message)
{
    public static readonly ApiResponseCode Success = new(200, "Success");
    public static readonly ApiResponseCode Failed = new(500, "Failed");
    public static readonly ApiResponseCode NotFound = new(404, "Not Found");
    public static readonly ApiResponseCode Unauthorized = new(401, "Unauthorized");
    public static readonly ApiResponseCode Forbidden = new(403, "Forbidden");
    public static readonly ApiResponseCode BadRequest = new(400, "Bad Request");
    public static readonly ApiResponseCode Conflict = new(409, "Conflict");
    public static readonly ApiResponseCode UnprocessableEntity = new(422, "Unprocessable Entity");
    public static readonly ApiResponseCode TooManyRequests = new(429, "Too Many Requests");
    public static readonly ApiResponseCode ServiceUnavailable = new(503, "Service Unavailable");
    public static readonly ApiResponseCode GatewayTimeout = new(504, "Gateway Timeout");
    public static readonly ApiResponseCode MethodNotAllowed = new(405, "Method Not Allowed");
    public static readonly ApiResponseCode NotAcceptable = new(406, "Not Acceptable");
    public static readonly ApiResponseCode ProxyAuthenticationRequired = new(
        407,
        "Proxy Authentication Required"
    );
    public static readonly ApiResponseCode RequestTimeout = new(408, "Request Timeout");
    public static readonly ApiResponseCode LengthRequired = new(411, "Length Required");
    public static readonly ApiResponseCode PreconditionFailed = new(412, "Precondition Failed");
    public static readonly ApiResponseCode RequestEntityTooLarge = new(
        413,
        "Request Entity Too Large"
    );
    public static readonly ApiResponseCode RequestUriTooLong = new(414, "Request-URI Too Long");
    public static readonly ApiResponseCode UnsupportedMediaType = new(
        415,
        "Unsupported Media Type"
    );
    public static readonly ApiResponseCode RequestedRangeNotSatisfiable = new(
        416,
        "Requested Range Not Satisfiable"
    );
    public static readonly ApiResponseCode ExpectationFailed = new(417, "Expectation Failed");
    public static readonly ApiResponseCode ImATeapot = new(418, "I'm a teapot");
    public static readonly ApiResponseCode MisdirectedRequest = new(421, "Misdirected Request");
    public static readonly ApiResponseCode Locked = new(423, "Locked");
    public static readonly ApiResponseCode FailedDependency = new(424, "Failed Dependency");
}
