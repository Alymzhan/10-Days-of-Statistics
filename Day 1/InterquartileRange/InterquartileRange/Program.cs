using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var N = Convert.ToInt32(Console.ReadLine());
        var arr = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).ToArray();
        var f = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).ToArray();
        var w = f.Sum(x => x);
        int[] arrF = new int[w];
        int q = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < f[i]; j++)
            {
                arrF[q] = arr[i];
                q++;
            }
        }

        arrF = arrF.Select(x => x).OrderBy(x => x).ToArray();

        double L, U = 0.0d;

        var z = w / 4;
        L = w / 2 % 2 == 0 ? (arrF[z - 1] + arrF[z]) / 2 : arrF[z];
        U = w / 2 % 2 == 0 ? (arrF[(w - z) - 1] + arrF[(w - z)]) / 2 : arrF[w - z - 1];

        Console.WriteLine("{0:0.0}", Math.Round(U - L, 1));

    }
}