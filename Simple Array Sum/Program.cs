namespace Simple_Array_Sum
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Solution
    {
        private static string _path = "hackerrank.data";

        /*
         * Complete the simpleArraySum function below.
         */
        static int simpleArraySum(int[] ar)
        {
            /*
             * Write your code here.
             */
            int sum = 0;
            for (int i = 0; i < ar.Count(); ++i)
            {
                sum += ar[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@_path, true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
