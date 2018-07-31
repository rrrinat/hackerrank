namespace _7_MiniMaxSum
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

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            int[] result = new int[2];

            int sum = 0;            
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            result[0] = sum - arr[arr.Length - 1];
            result[1] = sum - arr[0];

            Console.WriteLine(String.Join(" ", result));

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
