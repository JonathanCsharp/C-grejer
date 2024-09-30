
namespace Studieplatform;

public class Kurs 
{
    public int _CourseNumber { get ; private set ; }
    public string _NameOfCourse { get ; private set ; } ="";
    public string _CourseLength { get ; private set ; } ="";
    public DateTime _StartDate { get ; private set ; }
    public DateTime _EndDate { get ; private set ; }
    public string _ClassRoom { get; private set; } ="";
    public Lärare Teacher { get; set; } = new Lärare();
    public Utbildningsledare EducationLeader { get; set; } = new Utbildningsledare();
    public Utbildningsledare Admin { get; set; } = new Utbildningsledare(); 
    public List<Studerande> _Pupils { get; private set; } = new List<Studerande>();
    // public Lists lists { get; set; }



    // public Person person { get; set; } = new Person();
    
    

    public Kurs(int courseNumber)
    {
        _CourseNumber = courseNumber;
        Find();
        // Lärare Teacher = new Lärare(Per);
        // Utbildningsledare EducationLeader = new Utbildningsledare(Lena);
        // Utbildningsledare Admin = new Utbildningsledare(Karin);
        List<Studerande> Pupils = new List<Studerande>();
    }

    // Metoder

    public void AddPupil(Studerande pupil)
    {
        _Pupils.Add(pupil);
    }
    public void Find()
    {
        if (_CourseNumber == 1)
        {
            _NameOfCourse = "DevOps";
            _CourseLength = "2 years";
            _StartDate = DateTime.Now.AddDays(30);
            _EndDate = DateTime.Now.AddYears(2);
            _ClassRoom = "Ja";

        }
        else if (_CourseNumber == 2)
        {
            _NameOfCourse = "Frontend";
            _CourseLength = "6 months";
            _StartDate = DateTime.Now.AddDays(30);
            _EndDate = DateTime.Now.AddMonths(6);
            _ClassRoom = "Nä, distans";
        }
    }
    public override string ToString()
    {
        return $"Kursnummer: {_CourseNumber} Kursnamn: {_NameOfCourse} KursLängd: {_CourseLength} Kursstart: {_StartDate} Kursslut: {_EndDate} klassrum: {_ClassRoom}\nLärare: {Teacher}\nUtbildningsledare: {EducationLeader}\nAdmin: {Admin}";
    }

}
