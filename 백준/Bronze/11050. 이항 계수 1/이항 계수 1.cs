using System;
using System.IO;
using System.Linq;

namespace Beakjoon
{
    internal class Program
    {
        static int Factorial(int num)
        {
            if(num == 0 || num == 1)
                return 1;
            return num * Factorial(num-1);
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();

            int N = input[0];
            int K = input[1];

            sw.WriteLine(Factorial(N) / (Factorial(K) * Factorial(N - K)));
            sw.Flush();
        }
    }
}