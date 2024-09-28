namespace Studieplatform;

public class Lists
{
public List<Studerande> Pupils { get; set; } = new List<Studerande>();

 public List<Kurs> CourseList{ get; set; } = new List<Kurs>();


    public void AddPupil(Studerande pupil)
    {
        Pupils.Add(pupil);
    }
      public void AddCourse(Kurs course)
    {
        CourseList.Add(course);
    }
}
