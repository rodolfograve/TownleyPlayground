namespace TownleyPlayground;

public class PrimeNumber
{
    public void Run()
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine() ?? "0";
        int n = int.Parse(input);
        int potentialFactor = 2;

        bool isPrime = true;

        while (isPrime && potentialFactor < n)
        {
            if (n % potentialFactor == 0)
            {
                isPrime = false;
            }
            potentialFactor++;
        }

        if (isPrime)
        {
            Console.WriteLine($"{n} is prime.");
        }
        else
        {
            Console.WriteLine($"{n} is not prime because it's divisible by {potentialFactor}.");
        }
    }
}
