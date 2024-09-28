
namespace Studieplatform;

public class Kurs : Ikurser
{
    public int CourseNumber { get ; set ; }
    public string NameOfCourse { get ; set ; } ="";
    public int CourseLength { get ; set ; }
    public DateTime StartDate { get ; set ; }
    public DateTime EndDate { get ; set ; }
    public required List<Kurs> CourseList { get; set; }

    public Kurs()
    {
        List<Kurs> CourseList = new List<Kurs>();
    }

    // Metoder

    public void AddCourse(Kurs course)
    {
        CourseList.Add(course);
    }
}
