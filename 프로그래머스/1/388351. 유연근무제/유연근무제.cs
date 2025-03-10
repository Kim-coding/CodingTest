using System;

public class Solution 
{
    public int solution(int[] schedules, int[,] timelogs, int startday) 
    {
        int answer = 0;

        int n = schedules.Length;
        int sat = 6 - startday;
        if (sat < 0)
            sat = 6;
        int sun = 7 - startday;

        for(int i = 0; i < n; i++)
        {
            int count = 0;
            int timelim = schedules[i] + 10;
            if (timelim % 100 >= 60)
            {
                timelim += 100;
                timelim -= 60;
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