using System;

class Program 
{
    static void Main() 
    {
        string input = Console.ReadLine();
        int sum = 0;

        foreach (char ch in input) 
        {
            if (char.IsLower(ch)) 
            {
                sum += ch - 'a' + 1;
            } 
            else if (char.IsUpper(ch)) 
            {
                sum += ch - 'A' + 27;
            }
        }

        if (IsPrime(sum)) 
        {
            Console.WriteLine("It is a prime word.");
        } 
        else 
        {
            Console.WriteLine("It is not a prime word.");
        }
    }

    static bool IsPrime(int num) 
    {
        if (num == 1) return true;
        if (num < 2) return false;
        
        for (int i = 2; i * i <= num; i++) 
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
