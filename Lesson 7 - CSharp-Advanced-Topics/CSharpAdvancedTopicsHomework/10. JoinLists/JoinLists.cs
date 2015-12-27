using System; 
using System.Linq; 
using System.Collections.Generic; 

 class JoinLists 
 { 
     static void Main() 
     { 
         Console.WriteLine("Enter the first line of integers:"); 
         int[] firstLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
         Console.WriteLine("\nEnter the second line of integers:"); 
         int[] secondLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
         IEnumerable<int> union = firstLine.Union(secondLine); 
         IEnumerable<int> ordered = union.OrderBy(num => num); 
         Console.WriteLine("\nResult:"); 
         foreach (var number in ordered) 
         { 
             Console.Write("{0} ", number); 
         } 
         Console.WriteLine(); 
         Console.WriteLine(); 
     } 
 } 


