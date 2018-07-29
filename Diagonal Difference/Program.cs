namespace Diagonal_Difference
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

        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {
            int n = arr.Length - 1;
            int summ1 = 0;
            int summ2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ1 += arr[i][i];
                summ2 += arr[n - i][i];
            }

            return Math.Abs(summ1 - summ2);
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
