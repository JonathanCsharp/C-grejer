
namespace Studieplatform;

public class Kurs : Ikurser
{
    public int CourseNumber { get ; set ; }
    public string NameOfCourse { get ; set ; } ="";
    public string CourseLength { get ; set ; } ="";
    public DateTime StartDate { get ; set ; }
    public DateTime EndDate { get ; set ; }
    public string ClassRoom { get; set; } ="";
    public Lärare Teacher { get; set; }
    public Utbildningsledare EducationLeader { get; set; }
    public Utbildningsledare Admin { get; set; }
    public List<Studerande> _Pupils { get; private set; } = new List<Studerande>();

    public Kurs(int courseNumber, string lärare, string utbildning, string admin)
    {
        CourseNumber = courseNumber;
        Find();
        Teacher = new Lärare(lärare);
        EducationLeader = new Utbildningsledare(utbildning);
        Admin = new Utbildningsledare(admin);
        List<Studerande> Pupils = new List<Studerande>();
    }

    // Metoder

    public void AddPupil(Studerande pupil)
    {
        _Pupils.Add(pupil);
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
