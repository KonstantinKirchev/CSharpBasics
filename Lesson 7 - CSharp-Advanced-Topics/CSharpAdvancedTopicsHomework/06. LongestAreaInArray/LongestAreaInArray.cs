using System; 
using System.Collections.Generic; 

class LongestAreaInArray 
 { 
     static void Main() 
     { 
         int n; 
         Console.Write("How many strings would you like to enter? "); 
         while (!int.TryParse(Console.ReadLine(), out n) || n < 1) 
         { 
             Console.WriteLine("Please enter a valid integer greater than 0."); 
         } 
         Console.WriteLine(); 
         string[] elements = new string[n]; 
         for (int i = 0; i < n; i++) 
         { 
             Console.Write("Enter string {0}: ", i + 1); 
             elements[i] = Console.ReadLine(); 
         } 
         List<List<string>> areas = new List<List<string>>(); 
         for (int listNumber = 0, element = 0; element < n; listNumber++) 
         { 
             areas.Add(new List<string>()); 
             areas[listNumber].Add(elements[element]); 
             for (int member = element + 1; member < n; member++) 
             { 
                 if (elements[member] == elements[element]) 
                 { 
                     areas[listNumber].Add(elements[member]); 
                     element++; 
                     if (member == n - 1) 
                     { 
                         element = n; 
                     }                                        
                 } 
                 else 
                 { 
                     element++; 
                     if (member == n - 1) 
                     { 
                         element = n; 
                     } 
                     break; 
                 } 
             } 
         } 
         int countOfEqual = 0; 
         int indexOfLongest = 0; 
         for (int i = 0; i < areas.Count; i++) 
         { 
             if (areas[i].Count > countOfEqual) 
             { 
                 countOfEqual = areas[i].Count; 
                 indexOfLongest = i; 
             } 
         } 
         Console.WriteLine("\nResult:"); 
         Console.WriteLine(countOfEqual); 
         for (int i = 0; i < countOfEqual; i++) 
         { 
             Console.WriteLine(areas[indexOfLongest][i]); 
         } 
     } 
 } 


