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

            int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int v = input[0];
            int e = input[1];
            int k = int.Parse(sr.ReadLine());
            
            List<(int, int)>[] graph = new List<(int, int)>[v+1];
            for(int i = 1; i <= v; i++)
            {
                graph[i] = new List<(int, int)>();
            }


            for(int i = 0; i < e; i++)
            {
                int[] nums = sr.ReadLine().Split().Select(int.Parse).ToArray();
                int start = nums[0];
                int target = nums[1];
                int weight = nums[2];

                graph[start].Add((target, weight));
            }

            int[] distances = PriorityQueue(graph, v, k);

            for (int i = 1; i <= v; i++)
                sw.WriteLine(distances[i] == int.MaxValue ? "INF" : distances[i].ToString());

            sw.Flush();
        }

        static int[] PriorityQueue(List<(int, int)>[] graph, int v, int start)
        {
            int[] distance = Enumerable.Repeat(int.MaxValue, v+1).ToArray();
            distance[start] = 0;

            SortedSet<(int, int)> pq = new SortedSet<(int, int)>();
            pq.Add((0, start));

            while (pq.Count > 0)
            {
                var (dist, node) = pq.Min;
                pq.Remove(pq.Min);

                if (distance[node] < dist)
                    continue;

                foreach(var (next, weigth) in graph[node])
                {
                    int newDist = dist + weigth;
                    if (newDist < distance[next])
                    {
                        pq.Remove((distance[next], next));
                        distance[next] = newDist;
                        pq.Add((newDist, next));
                    }
                }
            }
            return distance;
        }
    }
}