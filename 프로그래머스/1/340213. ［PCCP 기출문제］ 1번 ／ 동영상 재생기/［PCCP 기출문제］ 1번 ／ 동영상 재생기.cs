using System;
using System.Linq;

public class Solution 
{
    private  int ConvertToSeconds(string time)
    {
        int[] parts = time.Split(':').Select(int.Parse).ToArray();
        return parts[0] * 60 + parts[1];
    }
    
    private string ConvertToTimeFormat(int seconds)
    {
        int min = seconds / 60;
        int sec = seconds % 60;

        return $"{min:D2}:{sec:D2}";
    }
    
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
       
        int video_time = ConvertToSeconds(video_len);
        int current_time = ConvertToSeconds(pos);
        int op_start_time = ConvertToSeconds(op_start);
        int op_end_time = ConvertToSeconds(op_end);

        if (op_start_time <= current_time && current_time <= op_end_time)
        {
            current_time = op_end_time;
        }

        foreach (var cmd in commands)
        {
            switch(cmd)
            {
                case "prev":
                    current_time -= 10;
                    if(current_time < 0)
                        current_time = 0;
                    break;
                case "next":
                    current_time += 10;
                    if(current_time > video_time)
                        current_time = video_time;
                    break;
            }

            if (op_start_time <= current_time && current_time <= op_end_time)
            {
                current_time = op_end_time;
            }
        }

        string answer = ConvertToTimeFormat(current_time);
        return answer;
    }
}