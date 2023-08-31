// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir sayı giriniz");
int a=Convert.ToInt32(Console.ReadLine());
string[] strings=new string[a];
for (int i = 0; i < strings.Length ; i++)
{
    strings[i] = Console.ReadLine();

}
Array.Reverse(strings);
foreach (string str in strings)
{
    Console.Write(""+str);
}
  
