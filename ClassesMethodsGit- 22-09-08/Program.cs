
using System.Runtime.CompilerServices;
/*
WebsiteGenerator webPage = new WebsiteGenerator();

webPage.setTopTags("<DOCTYPE>\n<html>\n<body>");
webPage.setClassName("IT-Klassen");
webPage.setClassMessages(2);
webPage.setBottomTags("</main>\n</body>\n</html>");

Console.WriteLine(webPage.getTopTags);
Console.WriteLine(webPage.getClassName);
Console.WriteLine(webPage.getClassMessages);
Console.WriteLine(webPage.getCourses);
Console.WriteLine(webPage.bottomTags);
*/

string[] courses = { "   C#", "daTAbaser", "WebbuTVeKkling  ", "clean Code      " };
WebsiteGenerator webPage2 = new WebsiteGenerator("<!DOCTYPE>\n<html>\n<body>", "IT-Klassen", 2, courses, "</main>\n</body>\n</html>");
//webPage2.getTopTags();
Console.WriteLine(webPage2.getTopTags());
//webPage2.getClassName();
Console.WriteLine(webPage2.getClassName());
webPage2.getClassMessages();
webPage2.getCourses();
webPage2.getBottomTags();

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
    
    public void getClassMessages()
    {
        Console.WriteLine(this.classMessages);
    }

    public void setCourses(string[] courses)
    {
        string stringCourses = "";
        
        
        foreach (string course in courses)
        {
            stringCourses += $"<Kurs i {course.Trim().ToUpper().Substring(0, 1) + course.Trim().Substring(1).ToLower().Replace("kk", "ck")}/>\n";
        }
        this.courses = stringCourses;
        
    }
    
    public void getCourses()
    {
        Console.WriteLine(this.courses);
    }
        
    public void setBottomTags(string bottomTags)
    {
        this.bottomTags = bottomTags;
    }

    public void getBottomTags()
    {
        Console.Write(this.bottomTags);
    }
}

