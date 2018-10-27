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
  static int Maximum(int n, int k)
  {
    var max = 0;

    for (var i = 1; i < n; i++)
    {
      for (var j = i + 1; j <= n; j++)
      {
        var candidate = i & j;
        if (candidate > max && candidate < k) max = candidate;
      }
    }

    return max;
  }

  static void Main(string[] args) {
    int t = Convert.ToInt32(Console.ReadLine());

    for (int tItr = 0; tItr < t; tItr++) {
      string[] nk = Console.ReadLine().Split(' ');

      int n = Convert.ToInt32(nk[0]);

      int k = Convert.ToInt32(nk[1]);

      Console.WriteLine(Maximum(n, k));
    }
  }
}
