using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static int calculateFine(int[] actual, int[] expected)
    {
      if (expected[2] > actual[2]) return 0;

      if (expected[2] == actual[2])
      {
          if (expected[1] > actual[1]) return 0;

          if (expected[1] == actual[1])
          {
              if (expected[0] >= actual[0]) return 0;

              return 15 * (actual[0] - expected[0]);
          }

          return 500 * (actual[1] - expected[1]);
      }

      return 10000;
    }

    static void Main(String[] args) {
      /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      var actual = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
      var expected = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

      var result = calculateFine(actual, expected);

      Console.Write(result);
    }
}
