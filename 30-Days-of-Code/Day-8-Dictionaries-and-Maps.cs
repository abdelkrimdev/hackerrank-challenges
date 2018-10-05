using System;
using System.Collections.Generic;
using System.IO;

class Solution {
  static void Main(String[] args) {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    var phoneBook = new Dictionary<string, string>();

    var n = Convert.ToInt32(Console.ReadLine());
    for (var i = 0; i < n; i++)
    {
      var input = Console.ReadLine().Split(' ');
      phoneBook.Add(input[0], input[1]);
    }

    var query = string.Empty;
    while (!string.IsNullOrEmpty(query = Console.ReadLine()))
    {
      if (phoneBook.TryGetValue(query, out var value))
        Console.WriteLine($"{query}={value}");
      else
        Console.WriteLine("Not found");
    }
  }
}
