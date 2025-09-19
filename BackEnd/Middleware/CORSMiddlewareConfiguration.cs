namespace BackEnd.Middleware
{
    public class CustomCORSMiddleware : IMiddleware
    {
        private readonly string[] _allowedOrigins =
        {
            "http://localhost:3000", // React dev
            "http://localhost:4200", // Angular dev
            "http://localhost:5173", // Vite/ Vue dev
            // thêm domain thật sau khi deploy
        };

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var origin = context.Request.Headers["Origin"].ToString();

            // Nếu Origin hợp lệ thì add CORS headers
            if (!string.IsNullOrEmpty(origin) && _allowedOrigins.Contains(origin))
            {
                context.Response.Headers.Add("Access-Control-Allow-Origin", origin);
                context.Response.Headers.Add("Vary", "Origin");
                context.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
                context.Response.Headers.Add(
                    "Access-Control-Allow-Methods",
                    "GET, POST, PUT, DELETE, OPTIONS"
                );
                context.Response.Headers.Add(
                    "Access-Control-Allow-Headers",
                    "Content-Type, Authorization, Content-Length, X-Requested-With"
                );
            }

            // Xử lý preflight (OPTIONS)
            if (context.Request.Method == HttpMethods.Options)
            {
                context.Response.StatusCode = StatusCodes.Status204NoContent; // No content
                return;
            }

            await next(context);
        }
    }
}
