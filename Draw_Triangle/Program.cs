Console.Write("Kenar Uzunluğu: ");
int length = Convert.ToInt32(Console.ReadLine());
int counter = 1;
int counter1 = length;
for (int i = 0; i < length; i++)
{
    for (int j = counter1 - 1; j > 0; j--)
    {
        Console.Write("");
    }
    counter1--;
   for (int k = 1; k <= counter; k++)
    {
        Console.Write("*");
        Console.Write(" ");
    }
    counter++;
    Console.WriteLine();
}