using System; 
using System.Collections.Generic; 
using System.Linq; 

class CountOfNames 
 { 
     static void Main(string[] args) 
     { 
         Console.WriteLine("Enter a list of names on a single line separated by space:"); 
         string[] names = Console.ReadLine().Split(); 
         Dictionary<string, int> counts = names.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count()); 
         var list = counts.Keys.ToList(); 
         list.Sort(); 
         Console.WriteLine("\nCount of names in alphabetical order:"); 
         foreach (var key in list) 
         { 
             Console.WriteLine("{0} -> {1}", key, counts[key]); 
         } 
         Console.WriteLine(); 
     } 
 } 

