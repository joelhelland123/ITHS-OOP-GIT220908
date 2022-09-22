/*
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

internal interface ITags
{
    void PrintTopTags(string color);
    void PrintHello(string welcomeMessage);
    void PrintMessages(string message1, string message2);
    void PrintBottomTags();

}

class Tags : ITags
{
    public string Color
    {
        get { return this.Color; }
        set { Color = value; }
    }
    public string WelcomeMessage
    {
        get { return this.WelcomeMessage; }
        set { WelcomeMessage = value; }
    }
    public string Messages
    {
        get { return this.Messages; }
        set { Messages = value; }
    }
    public void PrintMessages(string message1, string message2)
    {
        Console.WriteLine($"<p>Meddelande: {message1}</p>");
        Console.WriteLine($"<p>Meddelande: {message2}</p>");
    }
    public void PrintTopTags(string color)
    {
        Console.WriteLine($"<!DOCTYPE>\n<html>\n<head>\n<style>\np{{ color: {color}; }} \n" +
            $"</style>\n</head>\n<body>\n<main>");
    }
    public void PrintHello(string message)
    {
        Console.WriteLine($"<h1>Välkomna: {message}</h1>");
    }
    public void PrintBottomTags()
    {
        Console.WriteLine("</main>\n</body>\n<html>");
    }

}


class Webpage
{
    public ITags tags;

    public Webpage(ITags yourWebPage)
    {
        this.tags = yourWebPage;
    }

    static public void Main()
    {
        Webpage webpage = new Webpage(new Tags());

        webpage.tags.PrintTopTags("red");
        webpage.tags.PrintHello("Klass A!");
        webpage.tags.PrintMessages("Glöm inte att övning ger färdighet", "Öppna boken på sida 257");
        webpage.tags.PrintBottomTags();
    }
}
*/