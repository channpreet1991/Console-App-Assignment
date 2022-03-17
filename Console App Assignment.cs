//Part 1

using System;


class ABC {

	
	public static void Main()
	{

		
		char[] arr = {'s', 'u', 'e', 'k', 'f',
						'n', 'o', 'm', 'r', 'e',
								'a', 's', 'g'};
		

		Console.Write("Array printing using for loop = ");

		
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i]);
		}

		Console.WriteLine();

		Console.Write("Array printing using foreach loop = ");

		
		foreach(char ch in arr)
		{
			Console.Write(ch);
		}
	}
}
 

//Part 2


using System;

class ABC{
	
static public void Main ()
{
	
	
	while (true)
	{
		
		
		Console.WriteLine("Hey!Welcome");
	}
}
}
 

//Part 3-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Comparison_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
 
           
            Console.Write("Enter first number\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number\t");
            num2 = Convert.ToInt32(Console.ReadLine());
 
            
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            
            else if (num2 > num1)
            {
                Console.WriteLine("{0} is greater than {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            Console.ReadLine();
        }
    }
}
 

//Part 4-

int index = strList.FindIndex(str => str.Contains("Chicken"));
 

//Part 5-

bool exists = s1.Any(s => s.Contains(s2));
