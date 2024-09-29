
namespace Studieplatform;

public class Kurs 
{
    public int CourseNumber { get ; set ; }
    public string NameOfCourse { get ; set ; } ="";
    public string CourseLength { get ; set ; } ="";
    public DateTime StartDate { get ; set ; }
    public DateTime EndDate { get ; set ; }
    public string ClassRoom { get; set; } ="";
    public Lärare Teacher { get; set; } = new Lärare();
    public Utbildningsledare EducationLeader { get; set; } = new Utbildningsledare();
    public Utbildningsledare Admin { get; set; } = new Utbildningsledare(); 
    public List<Studerande> Pupils { get; set; } = new List<Studerande>();
    // public Lists lists { get; set; }



    // public Person person { get; set; } = new Person();
    
    

    public Kurs(int courseNumber)
    {
        CourseNumber = courseNumber;
        Find();
        Lärare Teacher = new Lärare("Per");
        Utbildningsledare EducationLeader = new Utbildningsledare("Lena");
        Utbildningsledare Admin = new Utbildningsledare("Karin");
        List<Studerande> Pupils = new List<Studerande>();
    }

    // Metoder

    public void AddPupil(Studerande pupil)
    {
        Pupils.Add(pupil);
    }
    public void Find()
    {
        if (CourseNumber == 1)
        {
            NameOfCourse = "DevOps";
            CourseLength = "2 years";
            StartDate = DateTime.Now.AddDays(30);
            EndDate = DateTime.Now.AddYears(2);
            ClassRoom = "Ja";

        }
        else if (CourseNumber == 2)
        {
            NameOfCourse = "Frontend";
            CourseLength = "6 months";
            StartDate = DateTime.Now.AddDays(30);
            EndDate = DateTime.Now.AddMonths(6);
            ClassRoom = "Nä, distans";
        }
    }
    public override string ToString()
    {
        return $"Kursnummer: {CourseNumber} Kursnamn: {NameOfCourse} KursLängd: {CourseLength} Kursstart: {StartDate} Kursslut: {EndDate} klassrum: {ClassRoom}\nLärare: {Teacher}\nUtbildningsledare: {EducationLeader}\nAdmin: {Admin}";
    }

}
