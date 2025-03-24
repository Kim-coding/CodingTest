using System;
using System.IO;

namespace Beakjoon
{
    internal class Program
    {
        static int fibCount = 0;
        static int dpCount = 0;

        static int Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                fibCount++;
                return 1;
            }
            else return Fib(n - 1) + Fib(n - 2);
        }
        static int Fibonacci(int n)
        {
            int[] dp = new int[n+1];
            dp[1] = dp[2] = 1;

            for(int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
                dpCount++;
            }
            return dp[n];
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int input = int.Parse(sr.ReadLine());
            Fib(input);
            Fibonacci(input);

            sw.WriteLine($"{fibCount} {dpCount}");
            sw.Flush();
        }
    }
}