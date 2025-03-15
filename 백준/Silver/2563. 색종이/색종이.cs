namespace BaekJoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] canvas = new int[100, 100];

            int num = int.Parse(Console.ReadLine());
            while (num > 0) 
            {
                string[] startXY = Console.ReadLine().Split(' ');
                int x = int.Parse(startXY[0]);
                int y = int.Parse(startXY[1]);
                for(int i = x; i < x + 10; i++) 
                {
                    for(int j = y; j < y + 10; j++)
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

            Console.WriteLine(count);

        }
    }
}
