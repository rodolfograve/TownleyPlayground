Console.Write("What's your name? ");
var name = Console.ReadLine() ?? "";

Console.Write("What year were your born in? ");
var yearOfBirthStr = Console.ReadLine() ?? "";
var yearOfBirth = int.Parse(yearOfBirthStr);

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
    var isNameLengthPrime = true;
    var i = 2;

    while (i <= name.Length / 2 && isNameLengthPrime)
    {
        if (name.Length % i == 0)
        {
            isNameLengthPrime = false;
        }

        i++;
    }

    if (isNameLengthPrime)
    {
        Console.WriteLine($"Youuuuuu beloooooong toooooo Ravenclaw! Because the length of your name ({name.Length}) is a prime number.");
    }
    else
    {
        var yearOfBirth2Digits = yearOfBirth % 100;
        var isYearOfBirth2DigitsPrime = true;
        i = 2;

        while (i < yearOfBirth2Digits / 2 && isYearOfBirth2DigitsPrime)
        {
            if (yearOfBirth2Digits % i == 0)
            {
                isYearOfBirth2DigitsPrime = false;
            }

            i++;
        }

        if (isYearOfBirth2DigitsPrime)
        {
            Console.WriteLine($"Youuuuuu beloooooong toooooo Ravenclaw! Because the year you were born in ({yearOfBirth2Digits}) is a prime number.");
        }
        else
        {
            if (name.Length % 2 == 0)
            {
                Console.WriteLine($"Youuuuuu beloooooong toooooo Slytherin! Because the length of your name ({name.Length}) is even.");
            }
            else if (yearOfBirth % 2 == 0)
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
