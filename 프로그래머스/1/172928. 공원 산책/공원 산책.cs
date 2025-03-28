using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] park, string[] routes) 
    {
        int height = park.Length;
        int width = park[0].Length;
        int startX = 0;
        int startY = 0;
        
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                if(park[i][j] == 'S')
                {
                    startX = i;
                    startY = j;
                }
            }
        }
        
        var directions = new Dictionary<char, (int, int)>
        {
            {'N',(-1,0)},{'S',(1,0)},{'W',(0,-1)},{'E',(0,1)}
        };
        
        int x = startX;
        int y = startY;
        
        foreach (var route in routes)
        {
            char direction = route[0];
            int distance = int.Parse(route.Substring(2));
            
            int newX = x, newY = y;
            bool canMove = true;
            
            for (int step = 1; step <= distance; step++) {
                int nextX = x + directions[direction].Item1 * step;
                int nextY = y + directions[direction].Item2 * step;

                if (nextX < 0 || nextX >= height || nextY < 0 || nextY >= width || park[nextX][nextY] == 'X') {
                    canMove = false;
                    break;
                }
                newX = nextX;
                newY = nextY;
            }
            
            if (canMove) {
                x = newX;
                y = newY;
            }
        }
        
        return new int[] {x, y};
    }
}