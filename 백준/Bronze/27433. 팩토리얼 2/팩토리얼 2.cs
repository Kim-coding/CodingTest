using System;
using System.IO;

namespace Beakjoon
{
    internal class Program
    {
        static long Factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            return num * Factorial(num - 1);
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int num = int.Parse(sr.ReadLine());
            sw.WriteLine(Factorial(num));

            sw.Flush();
        }
    }
}