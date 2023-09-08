using System;

namespace Practical1b
{
    class pracg1b
    {
        public static void Main()
        {
         	string s1 = "Akshay";
      	 	Console.WriteLine("Fisrt String:"+s1); 
 
		string s2 = "Padhi";
      	 	Console.WriteLine("Second String:"+s2);

		Console.WriteLine("The length of the txt string is: " + s2.Length);

		Console.WriteLine("Capital:"+s1.ToUpper()); 
 
		Console.WriteLine("Small:"+s2.ToLower());

		string con = string.Concat(s1, s2);
		Console.WriteLine("Concatination Operation: "+con);

		//string inter = $"Interpolation Operation: {firstName} {lastName}";
      		//Console.WriteLine(inter);
		
		Console.WriteLine("Index 1 value:"+s1[1]);

		Console.WriteLine("Index of the value h:"+s1.IndexOf("h")); 

     		int Pos = s2.IndexOf("P");
		Console.WriteLine("Index pos pf p:"+Pos);

     		string lastName = s2.Substring(Pos);
		Console.WriteLine("The substring:"+lastName);

		string s3 = "We are the so-called \"Vikings\" from the north.";
		Console.WriteLine("The sequence \"  inserts a double quote in a string:"+s3);

		string s4 = "It\'s alright.";
		Console.WriteLine("The sequence \'  inserts a single quote in a string:"+s4);

		string s5 = "The character \\ is called backslash.";
		Console.WriteLine("The sequence \\  inserts a single backslash in a string:"+s5);

		string s6 = "Vandu ";    
            	string s7 = (String)s6.Clone();    
             	Console.WriteLine("Value:"+s6);  
             	Console.WriteLine("Clone value:"+s7);   

		 
        }
    }
}