using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        var x = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        var w = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        double sumW = w.Sum(a => a);
        double sumXW = 0.0d;

        for (int i = 0; i < N; i++)
        {
            sumXW += x[i] * w[i];
        }

        double z = Math.Round(sumXW / sumW, 1);

        Console.WriteLine("{0:0.0}", z);
    }
}