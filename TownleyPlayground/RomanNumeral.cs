namespace TownleyPlayground;
public class RomanNumeral
{
    private readonly static Dictionary<char, int> RomanValues = new()
    {
        ['I'] = 1,
        ['V'] = 5,
        ['X'] = 10,
        ['L'] = 50,
        ['C'] = 100,
        ['D'] = 500,
        ['M'] = 1000
    };

    public static RomanNumeral Parse(string romanRepresentation)
    {
        var decimalRepresentation = 0;
        var positionalValues = romanRepresentation.Select(x => RomanValues.TryGetValue(x, out var decimalValue) ? decimalValue : throw new FormatException($"{x} is not a valid Roman numeral")).ToArray();

        var valueToTheRight = positionalValues[^1];
        var currentValueCounter = 0;
        var wasPreviousValueSubtracted = false;

        for (var i = positionalValues.Length - 1; i >= 0; i--) // It seems a bit easier to go backwards.
        {
            var currentValue = positionalValues[i];

            if (currentValue > valueToTheRight)
            {
                currentValueCounter = 1;
                decimalRepresentation += currentValue;
                wasPreviousValueSubtracted = false;
            }
            else if (currentValue < valueToTheRight)
            {
                if (currentValue != valueToTheRight / 10 && currentValue != valueToTheRight / 5)
                { // An X can only be before a C or L, a C can only be before an M or D
                    throw new FormatException($"{romanRepresentation} is not a valid Roman numeral. There is a '{romanRepresentation[i]}' at position {i} before '{romanRepresentation[i + 1]}'");
                }
                else
                { // This is, e.g., when an X is before a C - we subtract 10 from 100.
                    currentValueCounter = 1;
                    decimalRepresentation -= currentValue;
                    wasPreviousValueSubtracted = true;
                }
            }
            else if (currentValue == valueToTheRight)
            {
                currentValueCounter++;

                if (currentValue is 5 or 50 or 500 && currentValueCounter > 1)
                {
                    throw new FormatException($"{romanRepresentation} is not a valid Roman numeral. There are {currentValueCounter} consecutive '{romanRepresentation[i]}' at position {i}");
                }
                else if (currentValueCounter > 3)
                { // More then 3 is not allowed. E.g., IIII
                    throw new FormatException($"{romanRepresentation} is not a valid Roman numeral. There are {currentValueCounter} consecutive '{romanRepresentation[i]}' at position {i}");
                }
                else if (wasPreviousValueSubtracted)
                { // More than one numeral to be subtracted is not allowed. E.g., IIV or XXXC
                    throw new FormatException($"{romanRepresentation} is not a valid Roman numeral. There are {currentValueCounter} consecutive '{romanRepresentation[i]}' at position {i}, where they would be subtracted from the following numeral");
                }
                else
                {
                    decimalRepresentation += currentValue;
                    wasPreviousValueSubtracted = false;
                }
            }

            valueToTheRight = currentValue;
        }

        var result = new RomanNumeral(romanRepresentation, decimalRepresentation);
        return result;
    }

    private RomanNumeral(string romanRepresentation, int decimalRepresentation)
    {
        RomanRepresentation = romanRepresentation;
        DecimalRepresentation = decimalRepresentation;
    }

    public string RomanRepresentation { get; }
    public int DecimalRepresentation { get; }
}
