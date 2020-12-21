using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var N = Convert.ToInt32(Console.ReadLine());

        var sum = 0.0d;
        
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < N; i++)
        {
            sum += arr[i];
            if (dic.ContainsKey(arr[i]))
                dic[arr[i]] += 1;
            else
                dic.Add(arr[i], 1);
        }

        var median = 0.0;
        var maxValue = dic.Max(x => x.Value);
        var sortList = arr.OrderBy(x => x).ToList();
        if (sortList.Count() % 2 == 0)
        {
            var z = sortList.Count() / 2;
            median = (sortList[z - 1] + sortList[z]) / 2.0;
        }
        else
        {
            var z = sortList.Count() / 2;
            median = sortList[z];
        }

        var sortList2 = dic.OrderBy(x => x.Key).ToList();

        var mode = sortList2.Where(x => x.Value == maxValue).ToList().Min(x => x.Key);

        var mainValue = sum / N;

        Console.WriteLine(Math.Round(mainValue, 1));

        Console.WriteLine(Math.Round(median, 1));

        Console.WriteLine(mode);
    }


}
