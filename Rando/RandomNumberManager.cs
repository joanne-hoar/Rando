namespace Rando;

public class RandomNumberManager
{
    private readonly Random _random = new();

    // Generates a single random integer between min (inclusive) and max (exclusive)
    public int GenerateRandomNumber(int min, int max)
    {
        return _random.Next(min, max);
    }

    // Generates an array of random integers
    public int[] GenerateRandomNumbers(int count, int min, int max)
    {
        return Enumerable.Range(0, count)
            .Select(_ => _random.Next(min, max))
            .ToArray();
    }
}
