using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        //Read count of numbers
        var N = Convert.ToInt32(Console.ReadLine());
        //Read array and order it
        var arr = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).OrderBy(x => x).ToArray();

        //Find Mean
        var mean = Convert.ToDouble(arr.Sum(x => x))/N;

        var sumD = arr.Sum(x => Math.Pow(x - mean, 2));
        var deviation = Math.Sqrt(sumD/N);

        Console.WriteLine(Math.Round(deviation,1));
    }
}