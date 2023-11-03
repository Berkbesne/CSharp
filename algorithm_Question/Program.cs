Console.WriteLine("Please Enter:");

string input = Console.ReadLine();
string[] parts = input.Split(',');
if (parts.Length > 0)
{
    string result = parts[0]; 
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Hatalı giriş yapıldı.");
}
