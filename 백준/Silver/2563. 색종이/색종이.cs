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

            int[,] canvas = new int[100, 100];

            int num = int.Parse(sr.ReadLine());
            while (num > 0)
            {
                int[] startXY = sr.ReadLine().Split().Select(int.Parse).ToArray();
                int x = startXY[0];
                int y = startXY[1];
                for (int i = x; i < x + 10; i++)
                {
                    for (int j = y; j < y + 10; j++)
                    {
                        canvas[i, j] = 1;
                    }
                }
                num--;
            }

            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (canvas[i, j] >= 1)
                    {
                        count++;
                    }
                }
            }

            sw.WriteLine(count);
            sw.Flush();
        }
    }
}
