
using System.Runtime.CompilerServices;



WebsiteGenerator webPage = new WebsiteGenerator();

webPage.setTopTags();
webPage.setClassName();
webPage.setClassMessage();
webPage.setBottomTags();

Console.WriteLine(webPage.topTags);
Console.WriteLine(webPage.className);
Console.WriteLine(webPage.classMessages);
webPage.setCourses();
Console.WriteLine(webPage.bottomTags);

public class WebsiteGenerator
{
    public string topTags;
    public string className;
    public string classMessages;
    public string bottomTags;


    public void setTopTags()
    {
        this.topTags = "<DOCTYPE>\n<html>\n<body>";
    }

    public void printTopTags()
    {
        Console.WriteLine(this.topTags);
    }

    public void setClassName()
    {

        Console.WriteLine("Vilken klass ska skrivas in?");
        className = Console.ReadLine();
        this.className = "<h1>Välkommna " + className + "</h1>";
    }

    public void getClassName()
    {
        Console.WriteLine(this.className);
    }

    public void setClassMessage()
    {
        string meddelande = "";
        string meddelanden = "";
        int antalMeddelanden;
        Console.WriteLine("Hur många klasspecifika meddelanden önskar du skriva?");
        antalMeddelanden = int.Parse(Console.ReadLine());
        for (int i = 0; i < antalMeddelanden; i++)
        {
            Console.WriteLine("Skriv ditt klasspecifika meddelande:");
            meddelande = Console.ReadLine();
            meddelanden += "<p><b>Meddelande:</b> " + meddelande + ".</p>\n";
        }
        meddelanden += "<main>";
        this.classMessages = meddelanden;
    }
    
    public void getClassMessage()
    {
        Console.WriteLine(this.classMessages);
    }

    public void setCourses()
    {
        string[] techniques = { "   C#", "daTAbaser", "WebbuTVeKkling  ", "clean Code      " };
        foreach (string course in techniques)
        {
            Console.WriteLine($"<Kurs i {course.Trim().ToUpper().Substring(0, 1) + course.Trim().Substring(1).ToLower().Replace("kk", "ck")}/>");
        }
    }
        
    public void setBottomTags()
    {
        this.bottomTags = "</main>\n</body>\n</html>";
    }

    public void getBottomTags()
    {
        Console.WriteLine(this.bottomTags);
    }
}

