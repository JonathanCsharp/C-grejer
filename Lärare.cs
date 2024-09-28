namespace Studieplatform;

public class Lärare : Person
{
    public String FieldOfKnowledge { get; protected set; } = "";
    public String AreaOfAuthority { get; protected set; } = "";
    public Lärare(string name)
    {
        Name = name;
        Find();
    }

    public virtual void Find()
    {
            LastName = "740per";
            Phone = 0733784520;
            IdNumber = "74-07-01-00";
            Address = "740gatan 19";
            PostalCode = "740 08";
            City = "Volvotown";
            FieldOfKnowledge = "";
            AreaOfAuthority = ""; 
    }
}
