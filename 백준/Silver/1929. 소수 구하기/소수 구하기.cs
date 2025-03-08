using System;
using System.Linq;

namespace Beakjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M = input[0];
            int N = input[1];

            bool[] isPrime = new bool[N+1];

            for (int i = 2; i <= N; i++)
            {
                isPrime[i] = true;
            }

            for(int i = 2; i*i <= N; i++)
            {
                if (isPrime[i])
                {
                    for(int j = i*i; j <= N; j+=i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for(int i = M;  i <= N; i++)
            {
                if(isPrime[i])
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
