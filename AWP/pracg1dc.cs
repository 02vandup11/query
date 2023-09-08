using System;

namespace Practical1dc
{
    class pracg1dc
    {
        public static void Main()
        {
        	char ch;
	   	Console.WriteLine("Enter the Character:");
		ch=char.Parse(Console.ReadLine());
		
		if (ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
		{
			Console.WriteLine("Is a vowel");
		}
		else
		{
			Console.WriteLine("Is a Consonant");
		}
        }
    }
}