namespace Studieplatform;

public interface Ikurser
{
    public int CourseNumber { get; set ; }
    public string NameOfCourse { get; set; } 
    public string CourseLength  { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ClassRoom { get; set; }
    public Lärare Teacher { get; set; }
    public Utbildningsledare EducationLeader { get; set; }
    public Utbildningsledare Admin { get; set; }

    // Metoder
    public void AddPupil(Studerande pupil)
    {

    }

    public void Find()
    {

    }

}
