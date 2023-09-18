Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);

int heat = 32;
if (heat <= (int)Weather.Normal)
{
    Console.WriteLine("Let's wait for the weather to warm up to go out.");
}
else if (heat >= (int)Weather.Normal)
{
    Console.WriteLine("It's hot to go out");
}
else if (heat >= (int)Weather.Normal && heat < (int)Weather.SoHot)
{
    Console.WriteLine("Let's go out");
}




enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Moved,
}
enum Weather
{
    Cold = 5,
    Normal = 20,
    Hot = 25,
    SoHot = 30,
}