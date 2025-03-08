using System;
namespace Beakjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if(n == 0)
                    break;

                int count = 0;
                for(int i = n + 1;i<= 2 * n; i++)
                {
                    if (IsPrime(i))
                        count++;
                }

                Console.WriteLine(count);
            }
        }

        static bool IsPrime(int n)
        {
            if(n < 2)
                return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                    return false;
            }
            return true;
        }

    }
}
