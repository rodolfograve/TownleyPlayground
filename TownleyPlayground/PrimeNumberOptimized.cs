namespace TownleyPlayground;

public class PrimeNumberOptimized
{
    public void Run()
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine() ?? "0";
        int n = int.Parse(input);
        int squareRoot = (int)Math.Sqrt(n);
        int potentialFactor = 2;

        bool isPrime = true;

        while (isPrime && potentialFactor <= squareRoot)
        {
            if (n % potentialFactor == 0)
            {
                isPrime = false;
            }

            if (potentialFactor == 2)
            {
                potentialFactor++; // Go to 3
            }
            else
            {
                potentialFactor += 2; // Go to next odd number
            }
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
