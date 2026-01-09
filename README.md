# Rando

**Author:** Joanne

A simple ASP.NET Core Web API project that demonstrates:

- Generating random numbers via an API endpoint
- Checking if a number is even or odd
- Returning a welcome message at the root endpoint

## Endpoints

- `GET /`  
  Returns a welcome message: `Welcome to ASP.Net Core`

- `GET /randomnumbers`  
  Returns an array of 5 random integers between 1 and 100.

- `GET /is-even/{number}`  
  Returns whether the provided number is even or odd. Example: `5 is an odd number`

  Must be an integer!

## Getting Started

1. **Clone the repository**
2. **Navigate to the project directory**
3. **Run the application:**
   ```sh
   dotnet run --project Rando/Rando.csproj
   ```
4. **Access the endpoints** using your browser or a tool like Postman.

## Requirements
- .NET 6.0 or later

## Project Structure
- `Program.cs` - Main entry point and endpoint definitions
- `RandomNumberManager.cs` - Utility class for random number generation

## License
MIT
