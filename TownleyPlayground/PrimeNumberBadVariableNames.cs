namespace TownleyPlayground;

public class PrimeNumberBadVariableNames
{
    public void Run()
    {
        Console.WriteLine("Enter a number: ");
        string x = Console.ReadLine() ?? "0";
        int b = int.Parse(x);
        int i = 2;

        bool t = true;

        while (t && i < b)
        {
            if (b % i == 0)
            {
                t = false;
            }
            i++;
        }

        if (t)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
