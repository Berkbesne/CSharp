using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        List<char> vowelList = new List<char>();

        foreach (char letter in sentence.ToLower())
        {
            if ("aeiou".Contains(letter))
            {
                vowelList.Add(letter);
            }
        }

      
        vowelList.Sort();

        
        Console.WriteLine("Sorted Vowels: ");
        foreach (char vowel in vowelList)
        {
            Console.Write(vowel + " ");
        }

        Console.WriteLine();
    }
}
