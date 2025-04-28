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
            int M = input[1];

            int[,] arr = new int[N,N];

            for (int i = 0; i < N; i++)
            {
                int[] nums = sr.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < N; j++)
                {
                    arr[i,j] = nums[j];
                }
            }

            int[,] prefix = new int[N+1,N+1];

            for(int i = 1; i <= N; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    prefix[i,j] = prefix[i,j-1] + prefix[i-1,j] - prefix[i-1,j-1] + arr[i-1,j-1];
                }
            }

            for(int i = 0; i < M; i++)
            {
                int[] query = sr.ReadLine().Split().Select(int.Parse).ToArray();
                int x1 = query[0];
                int y1 = query[1];
                int x2 = query[2];
                int y2 = query[3];

                int result = prefix[x2, y2] - prefix[x2, y1-1] - prefix[x1-1,y2] + prefix[x1-1,y1-1];
                sw.WriteLine(result);
            }
            sw.Flush();
        }
    }
}