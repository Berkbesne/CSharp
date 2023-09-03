using System.Xml.Linq;

List<int> NumList=new List<int>() ;
NumList.Add(23) ;
NumList.Add(10);
NumList.Add(95) ;
NumList.Add(5);
NumList.Add(123);
  

List<string> ColorList=new List<string>() ; 
ColorList.Add("Red") ;
ColorList.Add("Blue");
ColorList.Add("Yellow");
ColorList.Add("Green");

//Count
Console.WriteLine(ColorList.Count);
Console.WriteLine(NumList.Count);

foreach (var num in NumList)
{
    Console.WriteLine(num); 
}
foreach (var color in ColorList)
{
    Console.WriteLine(color);
   
}


NumList.Remove(5);
ColorList.Remove("Green");
NumList.RemoveAt(0);
ColorList.RemoveAt(1);
NumList.ForEach(num => Console.WriteLine(num));
ColorList.ForEach(color => Console.WriteLine(color));

if (NumList.Contains(10))
{
    Console.WriteLine("Find 10");
}

Console.WriteLine(ColorList.BinarySearch("Red"));

string[] animal = { "Cat", "Dog", "Bird" };
List<string> animalList=new List<string>(animal) ;

animalList.Clear();
LinkedList<Users> usersList = new LinkedList<Users>() ;
Users user1 = new Users() ;
user1.Name = "Berk";
user1.SurName = "Besne";
user1.Age = 1564;

Users user2 = new Users();
user2.Name = "Berke";
user2.SurName = "Besn";
user2.Age = 1564;
usersList.AddLast(user1);
usersList.AddLast(user2);
List<Users> NewList= new List<Users>() ;
NewList.Add(new Users()
{
    Name = "Deniz",
    SurName="Ali",
    Age=20,
    });
foreach (var user in usersList)
{
    Console.WriteLine("Users Name "+user.Name);
    Console.WriteLine("Users Surname "+user.SurName);
    Console.WriteLine("Users Age " + user.Age);
}
public class Users 
{
    private string name;

    private string surname;
    private int age;

    public string Name { get => name; set => name = value; }

    public string SurName { get => surname; set => surname = value; }
    public int Age { get => age; set => age = value; }  
}