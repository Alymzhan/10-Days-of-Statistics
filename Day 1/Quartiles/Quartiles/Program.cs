using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var N = 10;// Convert.ToInt32(Console.ReadLine());
        var s = "3 7 8 5 12 14 21 15 18 14";
        var arr = s/*Console.ReadLine()*/.Trim().Split().Select(x => Convert.ToInt32(x)).OrderBy(x => x).ToArray();

        var median = N % 2 == 0 ? (arr[N / 2 - 1] + arr[N / 2]) / 2 : arr[N / 2];

        int L, U = 0;

        var Z = N / 4;
        L = N / 2 % 2 == 0 ? (arr[Z - 1] + arr[Z]) / 2 : arr[Z];
        U = N / 2 % 2 == 0 ? (arr[(N - Z)-1] + arr[(N - Z)]) / 2 : arr[N - Z - 1];

        Console.WriteLine(L);
        Console.WriteLine(median);
        Console.WriteLine(U);
    }
}