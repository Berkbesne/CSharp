See https://aka.ms/new-console-template for more information
Console.WriteLine("Pozitif Sayı Giriniz");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Sayı negatif");
}
Console.WriteLine("Sayi giriniz");
int b = Convert.ToInt32(Console.ReadLine());
int[] dizi = new int[b];
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = Convert.ToInt32(Console.ReadLine());


}
foreach (int num in dizi)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
}