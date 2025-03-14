using System;
using System.IO;
using System.Text;

namespace Beakjoon
{

    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string str = sr.ReadLine();
            string explosiveStr = sr.ReadLine();
            int expLen = explosiveStr.Length;

            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                sb.Append(c);

                if (sb.Length >= expLen && sb.ToString(sb.Length - expLen, expLen) == explosiveStr)
                {
                    sb.Length -= expLen;
                }
            }

            sw.WriteLine(sb.Length > 0 ? sb.ToString() : "FRULA");
            sw.Flush();
        }
    }
}