using System;
using System.Collections.Generic;
using System.IO;

class Solution {
  static void Main(String[] args) {
    int i = 4;
    double d = 4.0;
    string s = "HackerRank ";

    // Declare second integer, double, and String variables.
    int integerInput;
    double doubleInput;
    string stringInput;

    // Read and save an integer, double, and String to your variables.
    integerInput = Convert.ToInt32(Console.ReadLine());
    doubleInput = Convert.ToDouble(Console.ReadLine());
    stringInput = Console.ReadLine();

    // Print the sum of both integer variables on a new line.
    Console.WriteLine($"{i + integerInput}");

    // Print the sum of the double variables on a new line.
    Console.WriteLine($"{(d + doubleInput):0.0}");

    // Concatenate and print the String variables on a new line
    // The 's' variable above should be printed first.
    Console.WriteLine(s + stringInput);
  }
}
