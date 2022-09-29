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
printTxt();
//Console.ReadLine();
FileInfo file = new FileInfo(@"C:\Users\Joel Helland\Documents\ITHS\Test\ITHS-Filhantering2022-09-27\TextWebsiteGenerator.txt");

//Open file for Read\Write
FileStream fs = file.Open(FileMode.Append, FileAccess.Write, FileShare.Read);

//Create StreamWriter object to write string to FileSream
public void printTxt() { 
StreamWriter sw = new StreamWriter(fs);
sw.WriteLine("<!DOCTYPE>\n<html>\n<head>\n<style>\np{color: blue; }\n</style>\n</head>");
sw.WriteLine(webPage.ClassName);
sw.WriteLine(webPage.ClassMessages);
sw.WriteLine(webPage.Courses);
sw.WriteLine(webPage.BottomTags);
    }

// Man ska stänga filen efter användning!
sw.Close();





