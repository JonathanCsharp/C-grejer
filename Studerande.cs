namespace Studieplatform;

public class Studerande : Person
{


    public Studerande(string name)
    {
        Name = name;
        Find();

        
    }



    public void Find()
    {
        if (Name == "Benny")
        {
            LastName = "Bollträ";
            Phone = 0738059333;
            IdNumber = "94-04-23-0000";
            Address = "Knogjärnsgatan 27";
            PostalCode = "270 69";
            City = "Önnarp";
        }
        else if (Name == "Sara")
        {
            LastName = "Hjalmarsson";
            Phone = 073804003;
            IdNumber = "93-04-23-0000";
            Address = "Knogjärnsgatan 29";
            PostalCode = "270 69";
            City = "Önnarp";
        }
        else if (Name == "Dennis")
        {
            LastName = "Hjalmarsson";
            Phone = 073804003;
            IdNumber = "93-04-23-0000";
            Address = "Knogjärnsgatan 29";
            PostalCode = "270 69";
            City = "Önnarp";
        }
        else if (Name == "Emil")
        {
            LastName = "Hjalmarsson";
            Phone = 073804003;
            IdNumber = "93-04-23-0000";
            Address = "Knogjärnsgatan 29";
            PostalCode = "270 69";
            City = "Önnarp";
        }
    }
    public override string ToString()
    {
        return $"Namn: {Name} Efternamn: {LastName} Telefon: {Phone} Personnummer: {IdNumber} Adress: {Address}-{PostalCode} Stad: {City}\n";
    }
}    
