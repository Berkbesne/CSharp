using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the depth of the Fibonacci sequence: ");
        int depth = Convert.ToInt32(Console.ReadLine());

        FibonacciCalculator calculator = new FibonacciCalculator();
        double average = calculator.CalculateFibonacciAverage(depth);

        Console.WriteLine($"Average of the Fibonacci sequence: {average}");
    }
}

class FibonacciCalculator
{
    public double CalculateFibonacciAverage(int depth)
    {
        int[] fibonacciSequence = GenerateFibonacciSequence(depth);
        double sum = 0;

        foreach (int number in fibonacciSequence)
        {
            sum += number;
        }

        return sum / depth;
    }

    private int[] GenerateFibonacciSequence(int depth)
    {
        int[] fibonacciSequence = new int[depth];
        fibonacciSequence[0] = 0;
        if (depth > 1)
        {
            fibonacciSequence[1] = 1;
            for (int i = 2; i < depth; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }
        }
        return fibonacciSequence;
    }
}
