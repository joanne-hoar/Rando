

namespace Rando;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapGet("/is-even/{number:int}", (int number) =>
        {
            var result = number % 2 == 0 ? $"{number} is an even number" : $"{number} is an odd number";
            return result;
        })
        .WithName("IsEven");

        // Root endpoint returns a greeting message
        app.MapGet("/", () => "Welcome to ASP.Net Core");

        app.MapGet("/randomnumbers", (HttpContext httpContext) =>
        {
            // Use RandomNumberManager to generate an array of 5 random integers between 1 and 100
            var rng = new RandomNumberManager();
            var randomNumbers = rng.GenerateRandomNumbers(5, 1, 101);
            return randomNumbers;
        })
        .WithName("GetRandomNumbers");

        app.Run();
    }
}
