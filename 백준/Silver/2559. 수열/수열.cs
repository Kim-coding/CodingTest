using System;
using System.IO;
using System.Linq;

namespace Beakjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];

            int[] nums = sr.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            for(int i = 0; i < K; i++)
            {
                sum += nums[i];
            }

            int max = sum;

            for (int i = K; i < N; i++)
            {
                sum = sum - nums[i - K] + nums[i];
                if(sum > max)
                    max = sum;
            }

            sw.WriteLine(max);
            sw.Flush();
        }
    }
}