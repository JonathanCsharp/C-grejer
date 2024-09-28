namespace Studieplatform;

public class Studerande
{

    public String Name { get; protected set; } ="";
    public String LastName { get; protected set; } ="";
    public int Phone { get; protected set; }
    public string IdNumber { get; protected set; } ="";
    public string Address { get; protected set; } ="";
    public string PostalCode { get; protected set; } ="";
    public string City { get; protected set; } ="";
    public required List<Studerande> Pupils { get; set; }
    public Studerande()
    {
        List<Studerande> Pupils = new List<Studerande>();
    }

    public void AddPupil(Studerande name)
    {
        Pupils.Add(name);
    }
}    
