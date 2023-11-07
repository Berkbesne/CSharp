
string n = Console.ReadLine();
string[] arr = n.Split(' ');

string rest = string.Join(" ", arr.Skip(1));
for (int i = 0; i < arr.Length; i++)
{
    char[] charArray = arr[i].ToCharArray();
    Array.Reverse(charArray);
    string reversedWord = new string(charArray);
    Console.Write(reversedWord + " ");
}


