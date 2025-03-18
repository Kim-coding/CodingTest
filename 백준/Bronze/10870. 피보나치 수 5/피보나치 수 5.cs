using System;
using System.IO;

namespace Beakjoon
{
    internal class Program
    {
        static int Fibonacci(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;

            return Fibonacci(num - 1) + Fibonacci(num-2);
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int num = int.Parse(sr.ReadLine());
            sw.WriteLine(Fibonacci(num));

            sw.Flush();
        }
    }
}