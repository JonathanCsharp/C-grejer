namespace Studieplatform;

public class Lists
{


 public List<Kurs> CourseList{ get; set; } = new List<Kurs>();



      public void AddCourse(Kurs course)
    {
        CourseList.Add(course);
    }
}
