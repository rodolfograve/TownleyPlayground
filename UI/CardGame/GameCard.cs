namespace UI;

public class GameCard
{
    public GameCard(string name, string description, string backgroundColor, string foregroundColor, string borderColor)
    {
        Name = name;
        Description = description;
        BackgroundColor = backgroundColor;
        ForegroundColor = foregroundColor;
        BorderColor = borderColor;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public string BackgroundColor { get; set; }
    public string ForegroundColor { get; set; }
    public string BorderColor { get; set; }
}
