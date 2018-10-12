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

class Solution {
  static int LargestHourGlass(int[][] matrix)
  {
    int max = int.MinValue;

    for (int i = 0; i < 4; i++)
    {
      for (int j = 0; j < 4; j++)
      {
        int current = matrix[j+1][i+1];

        for (int k = 0; k < 3; k++)
          current += matrix[j][i+k] + matrix[j+2][i+k];

        if (current > max) max = current;
      }
    }

    return max;
  }

  static void Main(string[] args) {
    int[][] arr = new int[6][];

    for (int i = 0; i < 6; i++) {
      arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    }

    Console.Write(LargestHourGlass(arr));
  }
}
