namespace TownleyPlayground;
public class ImprovedConsole
{
    public string ReadStringFromUser(string promptMessage)
    {
        Console.Write(promptMessage);
        var result = Console.ReadLine() ?? "";
        return result;
    }
}
