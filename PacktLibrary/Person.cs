namespace Packt.Shared;

public partial class Person
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
     public string SayHello()
     {
         return $"{Name} says 'Hello'";
     }
     public string SayHello(string name)
     {
      return $"{Name} says 'Hello' {name}!";
     }
     public string OptionalParameters(
      string command = "Run",
      double number = 0.0,
      bool active = true
     )
     {
         return string.Format(
            "command is {0}, number is {1}, active is {2}", command, number, active
         );
     }

}

