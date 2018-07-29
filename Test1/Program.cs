namespace Test1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Solution
    {
        private static string _path = "hackerrank.data";

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int sumA = 0;
            int sumB = 0;
            for (int i = 0; i < a.Count; ++i)
            {
                if (a[i] > b[i])
                {
                    sumA++;
                }
                else if (a[i] < b[i])
                {
                    sumB++;
                }
            }

            return new List<int>() {sumA, sumB};
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@_path, true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp))
                .ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp))
                .ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}