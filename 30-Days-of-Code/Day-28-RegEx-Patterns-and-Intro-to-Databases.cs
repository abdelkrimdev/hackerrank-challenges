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
  static bool IsGmail(string email)
  {
    var regex = new Regex(@"@gmail.com$");
    return regex.IsMatch(email);
  }

  static void Main(string[] args) {
    int N = Convert.ToInt32(Console.ReadLine());

    var firstNames = new List<string>();

    for (int NItr = 0; NItr < N; NItr++) {
      string[] firstNameEmailID = Console.ReadLine().Split(' ');

      if (IsGmail(firstNameEmailID[1]))
        firstNames.Add(firstNameEmailID[0]);
    }

    firstNames.Sort();

    foreach (var firstName in firstNames)
      Console.WriteLine(firstName);
  }
}
