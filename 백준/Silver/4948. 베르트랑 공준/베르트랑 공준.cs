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
                bool[] isPrime = IsPrime(2 * n);

                for (int i = n + 1;i <= 2 * n; i++)
                {
                    if (isPrime[i])
                        count++;
                }

                Console.WriteLine(count);
            }
        }

        static bool[] IsPrime(int max)
        {
            bool[] isPrime = new bool[max+1];
            for(int i = 2;  i <= max; i++)
                isPrime[i] = true;
            for(int i = 2; i*i <= max; i++)
            {
                if(isPrime[i])
                {
                    for( int j = i*i; j<=max; j += i)
                        isPrime[j] = false;
                }
            }
            return isPrime;
        }
    }
}
