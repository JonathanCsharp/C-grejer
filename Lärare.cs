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

    public Lärare()
    {
    }

    public virtual void Find()
    {
            LastName = "740";
            Phone = 0733784520;
            IdNumber = "74-07-01-0000";
            Address = "740gatan 19";
            PostalCode = "740 08";
            City = "Volvotown";
            FieldOfKnowledge = "DevOps, Frontend";
            AreaOfAuthority = "DevOps, Frontend"; 
    }
    public override string ToString()
    {
        return $"Namn: {Name} Efternamn: {LastName} Personnummer: {IdNumber} Adress: {Address}-{PostalCode}-{City} Kunskapsområde: {FieldOfKnowledge} Ansvarsområde: {AreaOfAuthority}\n";
    }
}
