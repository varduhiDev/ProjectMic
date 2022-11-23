public class TextAndNumbers
{
    public string? Text;
    public int Number;
}

public class Processor
{
    public TextAndNumbers GetTheDate()
    {
        return new TextAndNumbers
        {
            Text = "What's the maening of life",
            Number = 42
        };
    }
}