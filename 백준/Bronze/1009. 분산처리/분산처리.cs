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

            int t = int.Parse(sr.ReadLine()); 

            while (t-- > 0)
            {
                string[] input = sr.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                int lastDigit = a % 10;

                int[][] pattern = {
                new int[] { 10 },         
                new int[] { 1 },          
                new int[] { 2, 4, 8, 6 }, 
                new int[] { 3, 9, 7, 1 }, 
                new int[] { 4, 6 },        
                new int[] { 5 },           
                new int[] { 6 },           
                new int[] { 7, 9, 3, 1 },  
                new int[] { 8, 4, 2, 6 },  
                new int[] { 9, 1 }         
                };

                int[] cycle = pattern[lastDigit]; 
                int cycleLength = cycle.Length;  

                int index = (b - 1) % cycleLength;
                sw.WriteLine(cycle[index]);
                sw.Flush();
            }
        }
    }
}