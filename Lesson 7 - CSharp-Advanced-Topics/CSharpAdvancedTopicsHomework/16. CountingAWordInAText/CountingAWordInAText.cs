using System; 
using System.Text.RegularExpressions; 
//using System.IO; 

 class CountingAWordInText 
 { 
     static void Main() 
     { 
         Console.Write("Enter the word you would like to count: "); 
         string lookupWord = Console.ReadLine(); 
         Console.WriteLine("\nPlease enter the text below:"); 
         string text = Console.ReadLine(); 
 
         //string text = null; 
         //using (StreamReader sr = new StreamReader("CountWordInText.txt")) 
         //{ 
         //    text = sr.ReadToEnd();            
         //} 
 
         string[] words = Regex.Split(text, @"\W");  
         int count = 0; 
         foreach (var word in words) 
         { 
             if (word.Equals(lookupWord, StringComparison.InvariantCultureIgnoreCase)) 
             { 
                 count++; 
             }             
         } 
         Console.WriteLine("\nThe text contains the word \"{0}\" {1} times.\n", lookupWord, count); 
     } 
 } 


