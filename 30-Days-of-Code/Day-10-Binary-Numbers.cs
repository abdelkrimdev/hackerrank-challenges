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
  static int LongestSequence(string number)
  {
    int current, max;
    max = current = 0;

    foreach (var n in number)
    {
      if (n == '1')
        current++;
      else
        current = 0;

      if (current > max) max = current;
    }

    return max;
  }

  static void Main(string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());

    int max = LongestSequence(Convert.ToString(n, 2));

    Console.WriteLine(max);
  }
}
