// See https://aka.ms/new-console-template for more information
using Packt.Shared;
using static System.Console;
using System.Collections.Generic;

var bob = new Person();
WriteLine(bob.ToString());
bob.Name = "Bob";


bob.FavoriteAncientWander = WondersOftheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOftheAncientWorld.HanginggardensOfBabylon |
    WondersOftheAncientWorld.Mousoleum;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

WriteLine(format: "{0}'s favorite wonder is {1}. It's integer {2}.",
arg0: bob.Name,
arg1: bob.FavoriteAncientWander,
arg2: (int)bob.FavoriteAncientWander);

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int child = 0; child < bob.Children.Count; child++)
{
    WriteLine($"{bob.Children[child].Name}");
}

BankAccount.InterestRate = 0.012M;
var jonesAccount = new BankAccount();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} interest.",
         arg0: jonesAccount.AccountName,
         arg1: jonesAccount.Balance * BankAccount.InterestRate);


var gerrierAccount = new BankAccount();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
         arg0: gerrierAccount.AccountName,
         arg1: gerrierAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Sapies}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

var blankPerson = new Person();
WriteLine(format:"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: blankPerson.Name,
arg1: blankPerson.HomePlanet,
arg2: blankPerson.Instantianted);

var gunny = new Person("Gunny", "Mars");
WriteLine(format:"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: gunny.Name,
arg1: gunny.HomePlanet,
arg2: gunny.Instantianted);

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Babken"));
WriteLine(bob.OptionalParameters(active:false, command: "rest", number: 5));

var sam = new Person
{
    Name = "Sam",
    DateOfBirth =  new DateTime(1972,1,27)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);
sam.FavoriteIceCream = "Choclate Fudge";
WriteLine($"Sam's favorite ice-creme flavor is {sam.FavoriteIceCream}");
sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");