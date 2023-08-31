using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 23;
            Console.WriteLine(a + b);
            int result = sum(a, b);
            Console.WriteLine(result);
            Methods example = new Methods();
            example.Write(Convert.ToString(result ));
            Console.WriteLine(+a + b);
            int num2 = example.increaseCollect(ref a, ref b);
            example.Write(Convert.ToString(num2));
            example.Write(Convert.ToString(a + b));
                          
        }
        static int sum(int num1, int num2)
        {
            return (num1+num2);
        }
    }   
    class Methods
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
        public int increaseCollect(ref int num1,ref int num2)
        {
            num1 += 1;
            num2 += 1;

            return (num1 + num2);
        }
    }
}
