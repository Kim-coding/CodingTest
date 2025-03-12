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

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            sw.AutoFlush = true;

            string[] input = sr.ReadLine().Split();
            N = int.Parse(input[0]);
            M = int.Parse(input[1]);
   
            Backtrack(1 ,0, sw);
        }

        static void Backtrack(int start, int depth, StreamWriter sw)
        {
            if(depth == M)
            {
                sw.WriteLine(string.Join(" ", sequence));
                return;
            }

            for(int i = start; i <= N; i++)
            {
                sequence.Add(i);
                Backtrack(i+1, depth + 1, sw);
                sequence.RemoveAt(sequence.Count - 1);
            }
        }
    }
}