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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int countofnegative = 0;
        int countofpositive = 0;
        int countofzero = 0;
        foreach (int key in arr)
        {
            if (key < 0)
            {
                countofnegative++;
            }
            else if (key > 0)
            {
                countofpositive++;
            }
            else
            {
                countofzero++;
            }
        }

        Console.WriteLine((double)countofpositive / arr.Count);
        Console.WriteLine((double)countofnegative / arr.Count);
        Console.WriteLine((double)countofzero / arr.Count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}