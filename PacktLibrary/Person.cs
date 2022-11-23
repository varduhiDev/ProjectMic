namespace Packt.Shared;

public class Person
{
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOftheAncientWorld FavoriteAncientWander;
    public WondersOftheAncientWorld BucketList;
    public List<Person> Children = new List<Person>();
    public const string Sapies = "Homo Sapien";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantianted;
    //constructors
    public Person()
    {
        // set defoult values for fields
        // including read-only fields
        Name = "Unknown";
        Instantianted = DateTime.Now;
    }

     public Person(string initialName, string homePlanet)
     {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantianted = DateTime.Now;
     }

     public (string, int) GetFruit()
{
   return ("Apples", 5);
}
}

