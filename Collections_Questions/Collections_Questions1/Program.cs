

using System.Diagnostics.Metrics;

Console.WriteLine("Enter 20 positive numbers entered from the keyboard");
List<int> list = new List<int>();
List<int> list2 = new List<int>();
Console.Write("Enter a number: ");
for (int i = 0; i < 6; i++)
{

    if (int.TryParse(Console.ReadLine(), out int n))
    {
        if (n < 0)
        {
            Console.WriteLine("Number Negative.");
            i--;
        }
        else
        {
            int result = IsPrime(n);
            if (result == 0)
            {
                list.Add(n);
            }
            else
            {
                list2.Add(n);
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter an integer.");
        i--;
    }
}
static int IsPrime(int n)
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
list.Sort();

foreach (var items in list)
{


    Console.WriteLine(items);

}
int sum = 0;

foreach (var items in list)
{
    sum += items;
}
int average1 = sum / list.Count;
Console.WriteLine("Average of non-prime numbers " + average1);
Console.WriteLine("Sum of non-prime numbers: " + sum);

Console.WriteLine("Prime number");
list2.Sort();

foreach (var items in list2)
{


    Console.WriteLine(items);

}
int sum1 = 0;
int average = 0;
foreach (var items in list2)
{
    sum1 += items;
}
average = (sum1 / list2.Count);
Console.WriteLine("Average of prime numbers " + average);

Console.WriteLine("Sum of prime numbers: " + sum1);

