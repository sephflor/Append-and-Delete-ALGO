using System;

class Result
{
    public static string appendAndDelete(string s, string t, int k)
    {
        
        int commonLength = 0;
        int minLength = Math.Min(s.Length, t.Length);
        
        for (int i = 0; i < minLength; i++)
        {
            if (s[i] == t[i])
                commonLength++;
            else
                break;
        }
        
        
        int deleteNeeded = s.Length - commonLength;
        int appendNeeded = t.Length - commonLength;
        int minOperations = deleteNeeded + appendNeeded;
        
        
        if (minOperations == k)
            return "Yes";
        
        
        if (minOperations < k)
        {
            
            if (k >= s.Length + t.Length)
                return "Yes";
            
            
            if ((k - minOperations) % 2 == 0)
                return "Yes";
        }
        
        return "No";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine().Trim());
        
        string result = Result.appendAndDelete(s, t, k);
        Console.WriteLine(result);
    }
}
