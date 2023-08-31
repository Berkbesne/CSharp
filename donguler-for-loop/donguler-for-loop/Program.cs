using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int maxCandleHeight = candles.Max();
        int count = candles.Count(c => c == maxCandleHeight);
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        // Çıktıyı "output.txt" dosyasına yazdırma
        using (TextWriter textWriter = new StreamWriter("output.txt"))
        {
            textWriter.WriteLine(result);
        }
    }
}
