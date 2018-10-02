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

  static void Multiples(int number)
  {
    for (var i = 1; i <= 10; i++)
      Console.WriteLine($"{number} x {i} = {number * i}");
  }

  static void Main(string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());
    Multiples(n);
  }
}
