using System.Collections;
using System.Threading;

Console.WriteLine("Please enter number");
ArrayList arr = new ArrayList();
for (int i = 0; i <20; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    arr.Add(a);

}
arr.Sort();
ArrayList ab = new ArrayList(arr.GetRange(0, 3));
int average1 = 0;
foreach (int item in ab)
{
    average1 += item;
   
}
average1 = average1 / ab.Count;

arr.Reverse();
ArrayList ac = new ArrayList(arr.GetRange(0, 3));
int average = 0;
foreach (int item in ac)
{
   average+=item;
}
average = average/ac.Count;
Console.WriteLine("Average of the highest three numbers:" + average);
Console.WriteLine("Average of the lowest three numbers: " + average1);
Console.WriteLine("Sum of the Average  " + (average1 + average));