using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

string gitTest;
//string[] courses = { "   C#", "daTAbaser", "WebbuTVeckling  ", "clean Code      " } "<!DOCTYPE>\n<html>\n<body>", ;
WebsiteGenerator webPage = new StyledWebsiteGenerator("<!DOCTYPE>\n<html>\n<head>\n<style>\np {color:","blue",
     "}\n</style>\n</head>\n<body>", 
    "IT-Klassen", 2, new string[] { "   CSharp", "daTAbaser", "WebbuTVeckling  ", "clean Code      " }, "</body>\n</html>");

Console.WriteLine(webPage.getTopTags());
Console.WriteLine(webPage.getClassName());
Console.WriteLine(webPage.getClassMessages());
Console.WriteLine(webPage.getCourses());
Console.WriteLine(webPage.getBottomTags());



public class WebsiteGenerator
{
    protected string topTags;
    protected string className;
    protected string classMessages;
    protected string courses;
    protected string bottomTags;
    
    public WebsiteGenerator(string className, int numberOfClassMessages, string[] courses, string bottomTags)
    {
        
        this.className = className;
        setClassMessages(numberOfClassMessages);
        setCourses(courses);
        this.bottomTags = bottomTags;
        
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
        this.courses = stringCourses + "</main>";
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
        return this.bottomTags;
    }
}
public class StyledWebsiteGenerator : WebsiteGenerator
{
    public string firstTopStyleTags;
    public string color;
    public string lastTopStyleTags;
    public string TopStyleTags
    {
        get { return TopStyleTags; }
        set { TopStyleTags = value; }
    }
    public string Color
    {
        get { return Color; }
        set { Color = value; }
    }
    public string LastTopStyleTags
    {
        get { return LastTopStyleTags; }
        set { LastTopStyleTags = value; }
    }


    public StyledWebsiteGenerator(string firstTopStyleTags, string color,string lastTopStyleTags, string className, int numberOfClassMessages, string[] courses, string bottomTags)
        :base(className, numberOfClassMessages, courses, bottomTags)
    {
        this.firstTopStyleTags = firstTopStyleTags;
        this.color = color;
        this.lastTopStyleTags = lastTopStyleTags;
        Console.Write(this.firstTopStyleTags);
        Console.Write(this.color);
        Console.Write(this.lastTopStyleTags);
    }
}





