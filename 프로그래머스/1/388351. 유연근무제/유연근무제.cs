using System;

public class Solution 
{
    public int solution(int[] schedules, int[,] timelogs, int startday) 
    {
        int answer = 0;

        int n = schedules.Length;
        int sat = (6 - startday + 7) % 7;
        int sun = (7 - startday + 7) % 7;

        for(int i = 0; i < n; i++)
        {
            int count = 0;
            int timelim = schedules[i] + 10;
            if (timelim % 100 >= 60)
            {
                timelim += 40;
            }
            for(int j = 0; j < 7; j++)
            {
                if(j == sat ||  j == sun)
                {
                    continue;
                }
                else
                {
                    if (timelogs[i, j] <= timelim)
                        count++;
                }
            }
            if(count >= 5)
                answer++;
        }

        return answer;
    }
}