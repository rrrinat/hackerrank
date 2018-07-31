namespace _6_Staircase
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
        /*
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                    
                    if (j >= n - 1 - i)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }          
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        */
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                    
                    var s = (j >= n - 1 - i) ? '#' : ' ';
                    Console.Write(s);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
     
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
