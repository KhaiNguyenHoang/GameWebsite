using BackEnd.Utils;

namespace BackEnd;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddControllers();
        builder.Services.AddDbContext<DatabaseContext>();
        var app = builder.Build();
        app.Use(
            (context, next) =>
            {
                if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
                {
                    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                    context.Response.Headers.Add(
                        "Access-Control-Allow-Methods",
                        "GET, POST, PUT, DELETE, OPTIONS"
                    );
                    context.Response.Headers.Add(
                        "Access-Control-Allow-Headers",
                        "Content-Type, Authorization, Content-Length, X-Requested-With"
                    );
                    context.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
                }
                else
                {
                    Console.WriteLine("Not Development");
                }
                return next();
            }
        );

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
        }

        // các middleware khác
        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapControllers(); // map API endpoints

        app.UseHttpsRedirection();

        app.Run();
    }
}
