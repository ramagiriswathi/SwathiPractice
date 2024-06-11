using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> SubarraySum = new List<int> { 2, 5, 3 };

        SubarraySumCalculator subarraySumCalculator = new SubarraySumCalculator();
        int count = subarraySumCalculator.FunctionSubarraySum(SubarraySum);
        Console.WriteLine(count);
    }
}

public class SubarraySumCalculator
{int Ans = 0;
    public int FunctionSubarraySum(List<int> array)
    {
        
        for (int i = 0; i < array.Count; i++)
        {
             int sum = 0;
            for (int j = i; j < array.Count; j++)
            {
                sum+=array[j];
                Ans = sum+Ans; 
            }
        }
        return Ans;
    }
}

