using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

string gitTest;
//string[] courses = { "   C#", "daTAbaser", "WebbuTVeckling  ", "clean Code      " } "<!DOCTYPE>\n<html>\n<body>", ;
WebsiteGenerator webPage = new StyledWebsiteGenerator("\n<!DOCTYPE>\n<html>\n<head>\n<style>\np { color:","blue",
     "; }\n</style>\n</head>\n<body>", 
    "IT-Klassen", 2, new string[] { "   CSharp", "daTAbaser", "WebbuTVeckling  ", "clean Code      " }, "</body>\n</html>");



Console.WriteLine(webPage.ClassName);
Console.WriteLine(webPage.getClassMessages());
Console.WriteLine(webPage.getCourses());
Console.WriteLine(webPage.BottomTags);



public class WebsiteGenerator
{

    
    public string className;
    protected string classMessages;
    protected string courses;
    protected string bottomTags;
    
    public WebsiteGenerator(string className, int numberOfClassMessages, string[] courses, string bottomTags)
    {
        setClassMessages(numberOfClassMessages);
        ClassName = className;
        setCourses(courses);
        BottomTags = bottomTags;
        
    }

    public string ClassName
    {
        get { return className; }
        set { className = "<h1>Välkommna " + value + "</h1>"; }
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
    public string BottomTags
    {
        get { return bottomTags; }
        set { bottomTags = value; }
    }
     /*   
    public void setBottomTags(string bottomTags)
    {
        this.bottomTags = bottomTags;
    }

    public string getBottomTags()
    {
        return this.bottomTags;
    }
     */

}

public class StyledWebsiteGenerator : WebsiteGenerator
{
    protected string firstTopStyleTags;
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

    public StyledWebsiteGenerator(string firstTopStyleTags, string color,string lastTopStyleTags, string className, int numberOfClassMessages, string[] courses, string bottomTags)
        :base(className, numberOfClassMessages, courses, bottomTags)
    {

        FirstTopStyleTags = firstTopStyleTags;
        Color = color;
        LastTopStyleTags = lastTopStyleTags;

       Console.Write(FirstTopStyleTags);
       Console.Write(Color);
       Console.Write(LastTopStyleTags);
       
    }
}





