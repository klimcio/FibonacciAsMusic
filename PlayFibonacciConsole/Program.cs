using System;

namespace PlayFibonacciConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibo = new Fibonacci();

            while (true)
            {
                Console.WriteLine(fibo.GetNext());
            }
        }
    }
}
