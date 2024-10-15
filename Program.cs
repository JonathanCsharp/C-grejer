using System.Text.Encodings.Web;
using System.Text.Json;

namespace Studieplatform;

class Program
{
    static void Main()
    {
        Kurs DevOps = new Kurs(1,"Pär","Lena","Karin");
        Lists lists = new Lists();

        lists.AddCourse(DevOps);

        Studerande pupil = new Studerande("Benny");
        DevOps.AddPupil(pupil);
        pupil = new Studerande("Sara");
        DevOps.AddPupil(pupil);

        Kurs Frontend = new Kurs(2,"Pär","Lena","Karin");

        lists.AddCourse(Frontend);

        pupil = new Studerande("Dennis");
        Frontend.AddPupil(pupil);
        pupil = new Studerande("Emil");
        Frontend.AddPupil(pupil);
        
        foreach (var x in lists._CourseList)
        {
            Console.WriteLine(x);
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        foreach (var x in DevOps._Pupils)
        {
            Console.WriteLine("Elev i DevOps: {0}", x);
        }
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        foreach (var x in Frontend._Pupils)
        {
            Console.WriteLine("Elev i Frontend: {0}", x);
        }
        Console.ResetColor();
        Lists.ConvertJson(lists);
        Console.WriteLine(lists);
    }
}
