Console.Write("Enter a number: ");
var nStr = Console.ReadLine() ?? "";

var n = long.Parse(nStr);

long i = 2;
while (i < n / 2)
{
    if (n % i == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{n} is not prime because it's divisible, at least, by {i}");
        break;
    }

    if (i % 100000 == 0)
    {
        Console.Write($"{i}, ");
    }

    i++;
}

if (n % i != 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{n} is prime");
}
