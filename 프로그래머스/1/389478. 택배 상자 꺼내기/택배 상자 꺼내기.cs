using System;

public class Solution 
{
    public int solution(int n, int w, int num) 
    {
        int answer = 0;
        int height = (n + w - 1) / w;
        int[,] warehouse = new int[height, w];

        int boxNumber = 1;
        for (int i = 0; i < height; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < w; j++)
                {
                    if (boxNumber <= n)
                    {
                        warehouse[i, j] = boxNumber++;
                    }
                }
            }
            else
            {
                for (int j = w-1; j >= 0; j--)
                {
                    if (boxNumber <= n)
                    {
                        warehouse[i, j] = boxNumber++;
                    }
                }
            }
        }

        int targetRow = -1;
        int targetCol = -1;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (warehouse[i, j] == num)
                {
                    targetRow = i;
                    targetCol = j;
                    break;
                }
            }
        }

        for (int i = targetRow; i < height; i++)
        {
            if(warehouse[i,targetCol] != 0)
                answer++;
        }

        return answer;
    }
}