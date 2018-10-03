using System;
using System.Collections.Generic;
using System.IO;

class Solution {
  static void SpecialPrint(string word)
  {
    string even, odd;
    even = odd = string.Empty;

    for(var i = 0; i < word.Length; i++)
    {
      if (i % 2 == 0)
        even += word[i];
      else
        odd += word[i];
    }

    Console.WriteLine($"{even} {odd}");
  }

  static void Main(String[] args) {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    var n = Convert.ToInt32(Console.ReadLine());
    for(var i = 0; i < n; i++)
      SpecialPrint(Console.ReadLine());
  }
}
