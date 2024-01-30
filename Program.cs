using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, this is a test string with 123 numbers.";

        // Define a pattern to match numbers
        string pattern = @"\d+";

        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern);

        // Match the pattern against the input string
        MatchCollection matches = regex.Matches(input);

        // Iterate over the matches and print them
        foreach(Match match in matches)
        {
            Console.WriteLine("Found number: " + match.Value);
        }
    }
}
