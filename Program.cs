namespace Studieplatform;

class Program
{
    static void Main()
    {
        Kurs DevOps = new Kurs(1);
        Lists lists = new Lists();
        DevOps.EducationLeader = new Utbildningsledare("Lena");
        DevOps.Admin = new Utbildningsledare("Karin");
        DevOps.Teacher = new Lärare("Per");
        lists.AddCourse(DevOps);

        Studerande pupil = new Studerande("Benny");
        DevOps.AddPupil(pupil);
        pupil = new Studerande("Sara");
        DevOps.AddPupil(pupil);

        // Console.WriteLine(DevOps);

        Kurs Frontend = new Kurs(2);
        Frontend.EducationLeader = new Utbildningsledare("Lena");
        Frontend.Admin = new Utbildningsledare("Karin");
        Frontend.Teacher = new Lärare("Per");
        lists.AddCourse(Frontend);

        pupil = new Studerande("Dennis");
        Frontend.AddPupil(pupil);
        pupil = new Studerande("Emil");
        Frontend.AddPupil(pupil);
        
        foreach (var x in lists.CourseList)
        {
            Console.WriteLine(x);
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        foreach (var x in DevOps.Pupils)
        {
            Console.WriteLine("Elev i DevOps: {0}", x);
        }
        Console.ResetColor();
        // Console.WriteLine(Frontend);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        foreach (var x in Frontend.Pupils)
        {
            Console.WriteLine("Elev i Frontend: {0}", x);
        }
    }
}
