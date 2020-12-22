using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var s1 = "6 12 8 10 20 16";
        var s2 = "5 4 3 2 1 5";

        var N = 6; // Convert.ToInt32(Console.ReadLine());
        var arr = s1/*Console.ReadLine()*/.Trim().Split().Select(x => Convert.ToInt32(x)).ToArray();
        var f = s2/*Console.ReadLine()*/.Trim().Split().Select(x => Convert.ToInt32(x)).ToArray();
        var w = f.Sum(x => x) * N;
        int[] arrF = new int[w];

        for (int i=0; i<N; i++)
        {
            for (int j=0; j<f[i]; j++)
            {
                arrF[i + j] = arr[i];
            }
        }

        double L, U = 0.0d;

        var z = w / 4;
        L = w / 2 % 2 == 0 ? (arrF[z - 1] + arrF[z]) / 2 : arrF[z];
        U = w / 2 % 2 == 0 ? (arrF[(w - z) - 1] + arrF[(w - z)]) / 2 : arrF[w - z - 1];

        Console.WriteLine(Math.Round(U-L,1));
    }
}