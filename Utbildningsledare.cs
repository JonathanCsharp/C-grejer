namespace Studieplatform;

public class Utbildningsledare: Lärare
{
 public DateTime EnploymentDate { get; private set; } 
 public Utbildningsledare()
 {
    Name = "Rövpanna";
 }
}
