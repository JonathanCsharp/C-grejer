namespace Studieplatform;

public class Lists
{

 public List<Kurs> _CourseList{ get; private set; } = new List<Kurs>();

      public void AddCourse(Kurs course)
    {
        _CourseList.Add(course);
    }
}
