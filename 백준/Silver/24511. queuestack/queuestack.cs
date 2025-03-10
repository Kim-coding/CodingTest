using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Beakjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] C = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
            Queue<int> queue = new Queue<int>();
            for(int i = n - 1; i >= 0; i--)
            {
                if (A[i] == 0)
                {
                    queue.Enqueue(B[i]);
                }
            }

            int[] result = new int[m];
            for(int i = 0; i < m; i++)
            {
                queue.Enqueue(C[i]);
                result[i] = queue.Dequeue();
            }

            Console.Write(string.Join(" ", result));
        }
    }
}