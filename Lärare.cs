namespace Studieplatform;

public class Lärare : Studerande
{
    public String FieldOfKnowledge { get; protected set; } = "";
    public String HeadOfClass { get; protected set; } = "";
    public Lärare()
    {

    }
}
