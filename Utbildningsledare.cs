namespace Studieplatform;

public class Utbildningsledare : Lärare
{
   public DateTime EnploymentDate { get; private set; }
   public Utbildningsledare(string name) : base (name)
   {
      Name = name;
      Find();
   }

    public Utbildningsledare()
    {
    }

    public override void Find()
   {
      if (Name == "Lena")
      {
      LastName = "Handen";
      Phone = 0733784850;
      IdNumber = "80-02-15-0000";
      Address = "Tröttaregatan 16";
      PostalCode = "233 81";
      City = "tröttersta";
      FieldOfKnowledge = "DevOps, Frontend";
      AreaOfAuthority = "DevOps, Frontend";
      EnploymentDate = DateTime.Now.AddDays(-90);
      }
      else if (Name == "Karin")
      {
      LastName = "Datasson";
      Phone = 0733784380;
      IdNumber = "82-06-28-0000";
      Address = "Fibergatan 17";
      PostalCode = "280 91";
      City = "Internetstaden";
      FieldOfKnowledge = "DevOps, Frontend";
      AreaOfAuthority = "DevOps, Frontend";
      EnploymentDate = DateTime.Now.AddDays(-90);
      }
   }
    public override string ToString()
    {
        return $"Namn: {Name} Efternamn: {LastName} Personnummer: {IdNumber} Adress: {Address}-{PostalCode}-{City} Kunskapsområde: {FieldOfKnowledge} Ansvarsområde: {AreaOfAuthority} Anställningsdatum: {EnploymentDate}\n";
    }
}
