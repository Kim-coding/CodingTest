using System;
using System.IO;

namespace Beakjoon
{
    internal class Program
    {
        static int count = 0;

        static int Recursion(string s, int l, int r)
        {
            count++;
            if (l >= r) return 1;
            else if (s[l] != s[r]) return 0;
            else return Recursion(s, l + 1, r - 1);
        }

        static int IsPalindrome(string s)
        {
            count = 0;
            return Recursion(s, 0, s.Length - 1);
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string s = sr.ReadLine();
                int result = IsPalindrome(s);
                sw.WriteLine($"{result} {count}");
            }

            sw.Flush();
        }
    }
}