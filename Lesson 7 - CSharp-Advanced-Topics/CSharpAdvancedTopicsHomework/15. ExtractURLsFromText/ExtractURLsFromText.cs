using System; 
using System.Text.RegularExpressions; 

class ExtractURLs 
{ 
     static void Main() 
     { 
         Console.WriteLine("Please enter the text below:"); 
         string input = Console.ReadLine(); 
         Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase); 
         Console.WriteLine("\nAll URLs matching the criteria:"); 
         foreach(Match m in linkParser.Matches(input)) 
         { 
             Console.WriteLine(m); 
         } 
         Console.WriteLine(); 
     } 
 } 


