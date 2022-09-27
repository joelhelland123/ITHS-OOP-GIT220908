

using ClassesMethodsGit__22_09_08;

public class WebsiteGenerator : IWebsiteMethods
{
    
    protected string className;
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

     public string ClassMessages
    {
        get { return classMessages; }
    }

     public string Courses
    {
        get { return courses; }
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

     public string BottomTags
    {
        get { return bottomTags; }
        set { bottomTags = value; }
    }
}

