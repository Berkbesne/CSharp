using System;

namespace Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();

            bool result = int.TryParse(num1, out int outnum);
            if (result)
            {
                Console.WriteLine("success");
                Console.WriteLine(outnum);

            }
            else
            {
                Console.WriteLine("Fail");
            }
            Methods instance = new Methods();
            instance.Sum(4, 5,out int sumresult);
            Console.WriteLine(sumresult);
            int numA= 999;
            instance.PrintScreen(numA);
            instance.PrintScreen("Berk" , "Besne");
        }
    }
    class Methods
    {
        public void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        public void PrintScreen(int  data)
        {
            Console.WriteLine(data);
        }
        public void PrintScreen(string data1, string data2)
        {
            Console.WriteLine(data1+data2);
        }
    }
}
