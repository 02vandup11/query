using System;

namespace Practical1c
{
    class pracg1c
    {
        public static void Main()
        {
		int s_id, i;           
		string name, cname, DOB;  
          
		int[] id = new int[10];           
		string[] s_name = new string[10];            
		string[] c_name = new string[10];            
		string[] D_O_B = new string[10];  
          
		for (i = 0; i < 5; i++)            {                
			Console.WriteLine("enter student ID");                
			s_id = Convert.ToInt32(Console.ReadLine());                
			id[i] = s_id;

			Console.WriteLine("enter student name");                
			name = Console.ReadLine();               
			s_name[i] = name;   

			Console.WriteLine("enter student cname");                
			cname = Console.ReadLine();                
			c_name[i] = cname;                

			Console.WriteLine("enter student DOB");                
			DOB = Console.ReadLine();                
			D_O_B[i] = DOB;            
							} 
           
		for (i = 0; i < 5; i++)            {                
			Console.WriteLine("id: {0} s_name:{1} c_name:{2} D_O_B:{3}", id[i], s_name[i], c_name[i], D_O_B[i]);               
 							}            
			Console.ReadKey();                            
       	}
    }
}