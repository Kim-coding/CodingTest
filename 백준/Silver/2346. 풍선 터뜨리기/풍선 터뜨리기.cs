using System;
using System.Collections.Generic;
using System.Linq;
namespace Beakjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var balloons = new List<(int position, int move)>();

            string[] input = Console.ReadLine().Split();
            for(int i = 0; i < N; i++)
            {
                balloons.Add((i+1,int.Parse(input[i])));
            }

            var queue = new LinkedList<(int position, int move)>(balloons);

            while(queue.Count > 0)
            {
                var current = queue.First.Value;
                queue.RemoveFirst();
                Console.Write(current.position + " ");

                if(queue.Count > 0)
                {
                    if(current.move >0)
                    {
                        for (int i = 0; i < current.move - 1; i++)
                        {
                            var temp = queue.First.Value;
                            queue.RemoveFirst();
                            queue.AddLast(temp);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < -current.move; i++)
                        {
                            var temp = queue.Last.Value;
                            queue.RemoveLast();
                            queue.AddFirst(temp);
                        }
                    }
                }
            }
        }
    }
}