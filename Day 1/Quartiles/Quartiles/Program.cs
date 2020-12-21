using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var N = Convert.ToInt32(Console.ReadLine());

        var arr = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).OrderBy(x => x).ToArray();

        var median = N % 2 ==0 ? arr[N/2] : (arr[N-1]+arr[N])/2;

        var L = 


    }
}