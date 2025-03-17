using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> playerIndexMap = new Dictionary<string, int>();
        for(int i = 0; i < players.Length; i++)
        {
            playerIndexMap[players[i]] = i;
        }

        string[] answer = new string[] { };

        foreach (string call in callings)
        {
            int index = playerIndexMap[call];

            if (index > 0)
            {
                string temp = players[index];
                players[index] = players[index - 1];
                players[index - 1] = temp;

                playerIndexMap[players[index]] = index;
                playerIndexMap[players[index - 1]] = index - 1;
            }
        }
        answer = players;
        return answer;
    }
}