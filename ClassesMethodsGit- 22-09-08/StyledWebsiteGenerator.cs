using System;
public class StyledWebsiteGenerator : WebsiteGenerator
{
    public string firstTopStyleTags;
    protected string color;
    protected string lastTopStyleTags;

    public string FirstTopStyleTags
    {
        get { return firstTopStyleTags; }
        set { firstTopStyleTags = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string LastTopStyleTags
    {
        get { return lastTopStyleTags; }
        set { lastTopStyleTags = value; }
    }

    public StyledWebsiteGenerator(string firstTopStyleTags, string color, string lastTopStyleTags, string className, int numberOfClassMessages, string[] courses, string bottomTags)
        : base(className, numberOfClassMessages, courses, bottomTags)
    {
        FirstTopStyleTags = firstTopStyleTags;
        Color = color;
        LastTopStyleTags = lastTopStyleTags;
        Console.Write(FirstTopStyleTags);
        Console.Write(Color);
        Console.Write(LastTopStyleTags);
    }
}