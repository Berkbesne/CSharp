Dictionary<int,string> Users=new Dictionary<int,string>();
Users.Add(10,"Berk ");
Users.Add(20, "Özgür ");
Users.Add(30, "ALi");
foreach (var item in Users)
{
    Console.WriteLine(item);    
}
Console.WriteLine("**** Count ****");
Console.WriteLine(Users.Count);
Console.WriteLine("**** Contains ****");
Console.WriteLine(Users.ContainsKey(12));
Console.WriteLine("**** Remove ****");
Users.Remove(12);
foreach (var item in Users)
{
    Console.WriteLine(item.Value);
}
Console.WriteLine("*** Key ***");
foreach (var item in Users.Keys)
{
    Console.WriteLine(item);    
}