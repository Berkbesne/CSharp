using System;

namespace Array_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 24, 32, 19, 45, 56 };
            Console.WriteLine("   Unordered Array  ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("  Sort Array  ");
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   Array Clear  ");
            Array.Clear(numbers, 2, 3);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            ;

            Console.WriteLine(Array.IndexOf(numbers, 56));
          

        }
    }
}
