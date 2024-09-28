namespace Studieplatform;

class Program
{
    static void Main()
    {
        Lists lists = new Lists();
        Studerande pupil = new Studerande("Benny");
        lists.AddPupil(pupil);
        pupil = new Studerande("Sara");
        lists.AddPupil(pupil);
        // Benny.ToString();
        foreach (var x in lists.Pupils)
        {
            Console.WriteLine(x);
        }
    }
}
