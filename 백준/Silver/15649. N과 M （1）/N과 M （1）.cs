using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Beakjoon
{

    internal class Program
    {
        static int N, M;
        static List<int > sequence = new List< int >();
        static bool[] visited;

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            sw.AutoFlush = true;

            string[] input = sr.ReadLine().Split();
            N = int.Parse(input[0]);
            M = int.Parse(input[1]);
   
            visited = new bool[N];

            Backtrack(0, sw);
        }

        static void Backtrack(int depth, StreamWriter sw)
        {
            if(depth == M)
            {
                sw.WriteLine(string.Join(" ", sequence));
                return;
            }

            for(int i = 0; i < N; i++)
            {
                if(!visited[i])
                {
                    visited[i] = true;
                    sequence.Add(i + 1);
                    Backtrack(depth + 1, sw);
                    sequence.RemoveAt(sequence.Count - 1);
                    visited[i] = false;
                }
            }
        }
    }
}