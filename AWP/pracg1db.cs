using System;

namespace Practical1db
{
    class pracg1db
    {
        public static void Main()
        {
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

        }
    }
}