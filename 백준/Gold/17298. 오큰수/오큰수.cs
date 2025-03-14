using System;
using System.Collections.Generic;
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

            int N = int.Parse(sr.ReadLine());

            int[] A = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = new int[N];
            Array.Fill(result, -1);

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                while (stack.Count > 0 && A[stack.Peek()] < A[i]) 
                {
                    int index = stack.Pop();
                    result[index] = A[i];
                }
                stack.Push(i);
            }

            sw.WriteLine(string.Join(" ", result));
            sw.Flush();
        }
    }
}