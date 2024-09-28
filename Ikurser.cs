namespace Studieplatform;

public interface Ikurser
{
    public int CourseNumber { get; set; }
    public string NameOfCourse { get; set; } 
    public int CourseLength  { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
