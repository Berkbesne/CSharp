string n=Console.ReadLine();
string[] a = n.Split(' ');


for (int i = 0; i < a.Length; i++)
{
    char[] charArray = a[i].ToCharArray();
    Array.Reverse(charArray);
    string reversedWord = new string(charArray);
    Console.WriteLine(reversedWord);
}