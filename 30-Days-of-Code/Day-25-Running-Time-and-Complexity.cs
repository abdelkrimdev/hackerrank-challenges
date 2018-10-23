using System;
using System.Collections.Generic;
using System.IO;

class Solution {
  static bool IsPrime(int number)
  {
    if (number == 1) return false;
    for (var i = 2; i <= Math.Sqrt(number); i++)
      if (number % i == 0) return false;
    return true;
  }

  static void Main(String[] args) {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    var t = Convert.ToInt32(Console.ReadLine());
    while (t-- > 0)
    {
      var n = Convert.ToInt32(Console.ReadLine());
      if (IsPrime(n)) Console.WriteLine("Prime");
      else Console.WriteLine("Not prime");
    }
  }
}
