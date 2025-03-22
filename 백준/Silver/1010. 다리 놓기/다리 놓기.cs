using System;
using System.IO;
using System.Linq;

namespace Beakjoon
{
    internal class Program
    {
        static long Combination(int M, int N)
        {
            long result = 1;
            for (int i = 0; i < N; i++)
            {
                result *= (M - i);
                result /= (i + 1);
            }
            return result;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine());
            for(int i = 0;  i < T; i++)
            {
                int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
                int N = input[0];
                int M = input[1];

                long result = Combination(M,N);
                sw.WriteLine(result);
            }
            sw.Flush();
        }
    }
}