using System;

abstract public class Website
{
    protected string className;
    protected string classMessages;
    protected string courses;
    protected string bottomTags;

    virtual public string ClassName
    {
        get { return className; }
        set { className = "<h1>Välkommna " + value + "</h1>"; }
    }

    virtual public void setClassMessages(int numberOfClassMessages)
    {
        
    }
    virtual public string ClassMessages
    {
        get { return classMessages; }
    }

    virtual public string Courses
    {
        get { return courses; }
    }
    virtual public void setCourses(string[] courses)
    {
        
    }
    virtual public string BottomTags
    {
        get { return bottomTags; }
        set { bottomTags = value; }
    }
}
