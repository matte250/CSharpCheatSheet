using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int iRead;
        double dRead;
        string sRead;
        // Read and save an integer, double, and String to your variables.
        iRead = 12;
        dRead = 4.0d;
        sRead = "hej";
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + iRead);
        // Print the sum of the double variables on a new line.
        dRead = d + dRead;
        Console.WriteLine("{0:N1}",dRead);
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + sRead);
    }
}
