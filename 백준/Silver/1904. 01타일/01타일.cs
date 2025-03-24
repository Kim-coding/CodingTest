using System;
using System.IO;

namespace Beakjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine());

            if (N == 1)
            {
                sw.WriteLine(1);
                sw.Flush();
                return;
            }
            else if (N == 2)
            {
                sw.WriteLine(2);
                sw.Flush();
                return;
            }

            int mod = 15746;
            int prev2 = 1;
            int prev1 = 2;
            int current = 0;

            for(int i = 3;  i <= N; i++)
            {
                current = (prev1 + prev2) % mod;
                prev2 = prev1;
                prev1 = current;
            }

            sw.WriteLine(current);
            sw.Flush();
        }
    }
}