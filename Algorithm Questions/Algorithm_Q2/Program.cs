// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sayı Giriniz");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayi giriniz");
int m = Convert.ToInt32(Console.ReadLine());
int[] b = new int[n];
for (int i = 0; i < b.Length-1; i++)
{
   b[i]=Convert.ToInt32(Console.ReadLine());
   
}
foreach (int num in b)
{
    if (num == m || num % m == 0)
    {
        Console.Write(" "+num);
    }

}