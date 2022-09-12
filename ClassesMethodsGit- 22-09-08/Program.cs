
using System.Runtime.CompilerServices;

string gitTest;
//string[] courses = { "   C#", "daTAbaser", "WebbuTVeckling  ", "clean Code      " };
WebsiteGenerator webPage = new WebsiteGenerator("<!DOCTYPE>\n<html>\n<body>", "IT-Klassen", 2, new string[] { "   CSharp", "daTAbaser", "WebbuTVeckling  ", "clean Code      " }, "</main>\n</body>\n</html>");

Console.WriteLine(webPage.getTopTags());
Console.WriteLine(webPage.getClassName());
Console.WriteLine(webPage.getClassMessages());
Console.WriteLine(webPage.getCourses());
Console.WriteLine(webPage.getBottomTags());

public class WebsiteGenerator
{
    private string topTags;
    private string className;
    private string classMessages;
    private string courses;
    private string bottomTags;
    

    public WebsiteGenerator(string topTags, string className, int numberOfClassMessages, string[] courses, string bottomTags)
    {
        setTopTags(topTags);
        setClassName(className);
        setClassMessages(numberOfClassMessages);
        setCourses(courses);
        setBottomTags(bottomTags);
    }
    public WebsiteGenerator()
    {

    }

    public void setTopTags(string topTags)
    {
        this.topTags = topTags;
    }

    public string getTopTags()
    {
        return this.topTags;
    }

    public void setClassName(string className)
    { 
        this.className = "<h1>Välkommna " + className + "</h1>";
    }

    public string getClassName()
    {
        return this.className;
    }

    public void setClassMessages(int numberOfClassMessages)
    {
        string meddelande = "";
        string meddelanden = "";
        for (int i = 0; i < numberOfClassMessages; i++)
        {
            Console.WriteLine("Skriv ditt klasspecifika meddelande:");
            meddelande = Console.ReadLine();
            meddelanden += "<p><b>Meddelande:</b> " + meddelande + ".</p>\n";
        }
        meddelanden += "<main>";
        this.classMessages = meddelanden;
    }
    
    public string getClassMessages()
    {
        return this.classMessages;
    }

    public void setCourses(string[] courses)
    {
        string stringCourses = "";
        
        
        foreach (string course in courses)
        {
            stringCourses += $"<Kurs i {course.Trim().ToUpper().Substring(0, 1) + course.Trim().Substring(1).ToLower()}/>\n";
        }
        this.courses = stringCourses;
        
    }
    
    public string getCourses()
    {
        return this.courses;
    }
        
    public void setBottomTags(string bottomTags)
    {
        this.bottomTags = bottomTags;
    }

    public string getBottomTags()
    {
        return bottomTags;
    }
}

