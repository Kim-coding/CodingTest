using System;
namespace Beakjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i = 1; i * i <= N; i++)
                count++;

            Console.WriteLine(count);
        }
    }
}