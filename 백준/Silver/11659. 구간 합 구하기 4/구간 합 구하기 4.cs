using System;
using System.IO;
using System.Linq;

namespace Beakjoon
{

    internal class Program
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static int[] Input()
        {
            return sr.ReadLine().Split().Select(int.Parse).ToArray();
        }

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] input = Input();

            int N = input[0];
            int M = input[1];

            int[] nums = Input();
            int[] prefixSum = new int[N + 1];
            for(int i = 1; i <= N; i++)
            {
                prefixSum[i] = prefixSum[i-1] + nums[i-1];
            }

            for(int k = 0; k < M; k++)
            {
                int[] interval = Input();
                int i = interval[0];
                int j = interval[1];

                sw.WriteLine(prefixSum[j] - prefixSum[i - 1]);
            }
            sw.Flush();
        }
    }
}