using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

WebsiteGenerator webPage  = new StyledWebsiteGenerator(
    "\n<!DOCTYPE>\n<html>\n<head>\n<style>\np { color: ",
    "blue",
     "; }\n</style>\n</head>\n<body>",
     "IT-Klassen",
     2,
     new string[] { "   CSharp", "daTAbaser", "WebbuTVeckling  ",
     "clean Code      " }, 
     "</body>\n</html>");

Console.WriteLine(webPage.ClassName);
Console.WriteLine(webPage.ClassMessages);
Console.WriteLine(webPage.Courses);
Console.WriteLine(webPage.BottomTags);
Console.ReadLine();





