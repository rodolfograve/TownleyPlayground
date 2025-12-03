List<int> v = [10, 20, 30, 40, 50];
ConsoleKeyInfo key;
int i = 0;
do
{
    Console.WriteLine($"The current number is '{v[i]}'. Press ESC to exit or any other key to get the next number.");
    i = (i + 1) % v.Count;

    key = Console.ReadKey();
} while (key.Key != ConsoleKey.Escape);


