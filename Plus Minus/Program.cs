namespace Plus_Minus
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

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            int count = arr.Length;
            int positiveCount = 0;
            int negativeCount = 0;
            int zerosCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else //arr[i] == 0
                {
                    zerosCount++;
                }
            }

            Console.WriteLine(Math.Round((double)positiveCount / count, 6, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round((double)negativeCount / count, 6, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round((double)zerosCount / count, 6, MidpointRounding.AwayFromZero));

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);


        }
    }
}
