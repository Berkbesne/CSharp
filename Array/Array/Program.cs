using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animal = { "Cat", "Dog", "Fish", "Tiger" };
            string[] colors = new string[5];
            int[] array;
            array = new int[5];
            colors[0] = "Blue";
            Console.WriteLine(animal[1]);
            array[3] = 10;
            Console.WriteLine(array[3]);
            Console.WriteLine(colors[0]);

            //**
            Console.WriteLine("Please enter the number of elements of the array");
            int Arraysize = int.Parse(Console.ReadLine());
            int[] NumbersArray = new int[Arraysize];
            for (int i = 0; i < Arraysize; i++)
            {
                Console.WriteLine("Please {0}. enter the number", i + 1);
                NumbersArray[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var number in NumbersArray)
            {
                toplam += number;
            }
            Console.WriteLine("Ortalama" +toplam/Arraysize);
        }
    }
}
