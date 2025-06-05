using TownleyPlayground;

var improvedConsole = new ImprovedConsole();
var romanNumeralStr = improvedConsole.ReadStringFromUser("Enter your Roman numeral: ");
var romanNumeral = RomanNumeral.Parse(romanNumeralStr.ToUpperInvariant());

Console.WriteLine($"{romanNumeral.RomanRepresentation} = {romanNumeral.DecimalRepresentation}");
