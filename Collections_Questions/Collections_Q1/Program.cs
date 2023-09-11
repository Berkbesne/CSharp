

Console.WriteLine("Enter 20 positive numbers entered from the keyboard");
List<int> list = new List<int>();
List<int> list2 = new List<int>();

for (int i = 0; i < 3; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    int result = prime_number(n);
    if (result == 0)
    {
        list.Add(n);
    }
    else
    {
        list2.Add(n);
    }


};
static int prime_number(int n)
{
    int counter = 0;
    int number = n;
    int i;
    for (i = 2; i <= number - 1; i++)
    {
        if (number % i == 0)
        {
            return 0;
        }

    }
    if (i == number)
    {
        return 1;
    }
    return 0;

}
Console.WriteLine("Nonprime");
foreach (var items in list)
{
    Console.WriteLine(items);
}
Console.WriteLine("Prime number");
foreach (var items in list2)
{
    Console.WriteLine(items);
}