using BackEnd.Middleware;
using BackEnd.Utils;

namespace BackEnd;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddTransient<DatabaseContext>();
        builder.Services.AddTransient<CustomCORSMiddleware>();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddControllers();
        builder.Services.AddDbContext<DatabaseContext>();
        var app = builder.Build();
        app.UseMiddleware<CustomCORSMiddleware>();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
        }

        // các middleware khác
        app.UseAuthorization();
        app.MapControllers(); // map API endpoints

        app.UseHttpsRedirection();

        app.Run();
    }
}
