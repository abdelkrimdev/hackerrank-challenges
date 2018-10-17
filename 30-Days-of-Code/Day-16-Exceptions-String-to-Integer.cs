using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
  static void Main(String[] args) {
    string S = Console.ReadLine();

    try
    {
      Console.Write(int.Parse(S));
    }
    catch (Exception)
    {
      Console.Write("Bad String");
    }
  }
}
