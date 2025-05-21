Console.Write("Enter a number: ");
var n1Str = Console.ReadLine() ?? "";
var n1 = int.Parse(n1Str);

Console.Write("Enter another number: ");
var n2Str = Console.ReadLine() ?? "";
var n2 = int.Parse(n2Str);

var i = n1;

while (i <= n2)
{
    Console.Write(i);
    if (i < n2)
    {
        Console.Write(", ");
    }

    i++;
}

