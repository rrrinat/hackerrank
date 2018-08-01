namespace _8_BirthdayCakeCandles
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Solution
    {
        private static string _path = "hackerrank.data";

        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {            
            List<int> numbers = new List<int>();
            int max = 0;
            numbers.Add(ar[max]);
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > ar[max])
                {
                    max = i;
                    numbers.Clear();
                    numbers.Add(ar[i]);
                }
                else if (ar[i] == ar[max])
                {
                    numbers.Add(ar[i]);
                }
            }

            return numbers.Count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@_path, true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(ar);

            //textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
