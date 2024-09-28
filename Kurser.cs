
namespace Studieplatform;

public class Kurs : Ikurser
{
    public int CourseNumber { get ; set ; }
    public string NameOfCourse { get ; set ; } ="";
    public int CourseLength { get ; set ; }
    public DateTime StartDate { get ; set ; }
    public DateTime EndDate { get ; set ; }
    public Person person { get; set; } = new Person();
    
    

    // public Kurs()
    // {
    //     List<Kurs> CourseList = new List<Kurs>();
    // }

    // Metoder

    public void Find()
    {
        
    }


}
