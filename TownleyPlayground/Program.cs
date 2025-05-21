var name = ReadStringFromConsole("What's your name? ");
var yearOfBirth = ReadNumberFromConsole("What year were your born in? ");

var age = 2025 - yearOfBirth;

if (name.Length % age == 0)
{
    Console.WriteLine($"Youuuuuu beloooooong toooooo Hufflepuff! Because the length of your name ({name.Length}) is divisible by your age in 2025 ({age})");
}
else if (age % name.Length == 0)
{
    Console.WriteLine($"Youuuuuu beloooooong toooooo Hufflepuff! Because your age in 2025 ({age}) is divisible by the length of your name ({name.Length})");
}
else
{
    var isNameLengthPrime = IsPrime(name.Length);

    if (isNameLengthPrime)
    {
        Console.WriteLine($"Youuuuuu beloooooong toooooo Ravenclaw! Because the length of your name ({name.Length}) is a prime number.");
    }
    else
    {
        var yearOfBirth2Digits = yearOfBirth % 100;
        var isYearOfBirth2DigitsPrime = IsPrime(yearOfBirth2Digits);

        if (isYearOfBirth2DigitsPrime)
        {
            Console.WriteLine($"Youuuuuu beloooooong toooooo Ravenclaw! Because the year you were born in ({yearOfBirth2Digits}) is a prime number.");
        }
        else
        {
            if (IsEven(name.Length))
            {
                Console.WriteLine($"Youuuuuu beloooooong toooooo Slytherin! Because the length of your name ({name.Length}) is even.");
            }
            else if (IsEven(yearOfBirth))
            {
                Console.WriteLine($"Youuuuuu beloooooong toooooo Slytherin! Because the year you were born in is ({yearOfBirth}) is even.");
            }
            else
            {
                Console.WriteLine("Youuuuuu beloooooong toooooo Gryffindor! Because you don't belong anywhere else.");
            }
        }
    }
}

string ReadStringFromConsole(string promptMessage)
{
    Console.Write(promptMessage);
    var result = Console.ReadLine() ?? "";
    return result;
}

int ReadNumberFromConsole(string promptMessage)
{
    var str = ReadStringFromConsole(promptMessage);
    var result = int.Parse(str);
    return result;
}

bool IsPrime(int n)
{
    var isPrime = true;
    var i = 2;

    while (i <= n / 2 && isPrime)
    {
        if (n % i == 0)
        {
            isPrime = false;
        }

        i++;
    }

    return isPrime;
}

bool IsEven(int n)
{
    return n % 2 == 0;
}
