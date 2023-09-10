Dictionary<int,string> Users=new Dictionary<int,string>();
Users.Add(10,"Berk ");
Users.Add(20, "Özgür ");
Users.Add(30, "ALi");
foreach (var item in Users)
{
    Console.WriteLine(item);    
}
Console.WriteLine(Users.Count);