// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Bir cümle giriniz:");
string cumle = Console.ReadLine();

int kelimeSayisi = KelimeSayisiHesapla(cumle);
int harfSayisi = HarfSayisiHesapla(cumle);

Console.WriteLine($"Girilen cümledeki toplam kelime sayısı: {kelimeSayisi}");
Console.WriteLine($"Girilen cümledeki toplam harf sayısı: {harfSayisi}");
        

        static int KelimeSayisiHesapla(string str)
{
    string[] kelimeler = str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    return kelimeler.Length;
}

static int HarfSayisiHesapla(string str)
{
    int harfSayisi = 0;
    foreach (char karakter in str)
    {
        if (char.IsLetter(karakter))
        {
            harfSayisi++;
        }
    }
    return harfSayisi;
}
    