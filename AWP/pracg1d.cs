using System;

namespace Practical1D
{
    class pracg1d
    {
        public static void Main()
        {
        	Console.WriteLine("Please make your selection");
      		Console.WriteLine("1 Fibonacciseries ");
      		Console.WriteLine("2 Prime numbers");
      		Console.WriteLine("3 Vowels");
		Console.WriteLine("4 foreach loop witharrays");
		Console.WriteLine("5 Reverse a number and find sum of digits of a number");


      		int Selection = int.Parse( Console.ReadLine( ) );

      switch( Selection ) {

        case 1:
        	int n1=0,n2=1,n3,i,number;    

         	Console.Write("Enter the number of elements: ");    
         	number = int.Parse(Console.ReadLine());  

         	Console.Write(n1+" "+n2+" ");  
 
         	for(i=2;i<number;++i)   
        	 {    
          		n3=n1+n2;    
          		Console.Write(n3+" ");    
          		n1=n2;    
          		n2=n3;    
         	}    
        break;
    
        case 2:
        	 int n, i, r=0, flag=0; 
   
          	Console.Write("Enter the Number to check Prime: ");    
          	n = int.Parse(Console.ReadLine());
  
         	r=n/2;    
          	for(i=2;i<=r;i++)    
          	{    
           	if(n%i==0)    
            	{    
             		Console.Write("Number is not Prime.");    
             		flag=1;    
             		break;    
            	}    
          	}    
          	if (flag==0)    
         	 Console.Write("Number is Prime.");  
        break;
    
        case 3:
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
        break;

	case 4:
          
        break;

	case 5:
          
        break;
    
        default:
          Console.WriteLine("Unknown choice");
          break;
     			 }
        }
    }
}