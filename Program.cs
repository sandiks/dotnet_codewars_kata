using System;
using System.Collections.Generic;
using System.Linq;

namespace Console.Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { -6, -4, -3, -2, 0, 1, 2, 3, 6, 8 };
            TransformList(data);
        }

        private static void TransformList(int[] data)
        {
            var res = new List<List<int>>(10);
            res.Add(new List<int>(10) { data[0] });

            for (int i = 0; i < data.Length - 1; i++)
            {
                var curr = data[i + 1];
                if (curr - data[i] == 1)
                {
                    res[^1].Add(curr);
                }
                else
                {
                    res.Add(new List<int>(10) { curr });
                }
            }

            foreach (var span in res)
            {
                var SpanInfo = span.Count() > 2 ? $"{span.First()}-{span.Last()}" : String.Join(",", span);
                System.Console.WriteLine(SpanInfo);
            }
        }
    }


}
