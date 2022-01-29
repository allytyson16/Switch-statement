using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year - ");
		    int year = int.Parse(Console.ReadLine());
		
		    if(year == 1)
		    {
		    	Console.WriteLine("Freshman");
		    }
		     else if(year == 2)
		    {
			    Console.WriteLine("Sophomore");
		    }
		    else if(year == 3)
		    {
		    	Console.WriteLine("Junior");
		    }   
		    else if(year == 4)
		    {
		    	Console.WriteLine("Senior");
		    }
            
	//switch statement	
		    switch(year)
		    {
			    case 1:
			   	{
					Console.WriteLine("Freshman");
					break;
				}
			    case 2:
				{
					Console.WriteLine("Sophomore");
					break;
				}
			    case 3:
				{
					Console.WriteLine("Junior");
					break;
				}
			    case 4:
				
				{
					Console.WriteLine("Senior");	
					break;
				}
			    default:
				{
					Console.WriteLine("Invalid year");
					break;
				}
		   }
    }
}
