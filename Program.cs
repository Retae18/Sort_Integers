using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array
{
    class Program
    {
        static void Main(string[] arg)

        {
            //User enters 3 integers and the computer sorts and outputs the largest number

            int num1;                   //variables for equation
            int num2;
            int num3;
            int answer;

            Console.WriteLine("Enter the first number");        //user input
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");       //user input
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");        //user input
            num3 = Convert.ToInt32(Console.ReadLine());


        }

        static int largest(int x, int y, int z)
        {
            int result = x;
            if (x > y)
            {
                if (y > z)
                {
                    smallest = z;
                    middle = y;
                    largest = x;
                }
            }

            else
            {
                if (x < y)
                {
                    if (x > z)
                    {
                        smallest = z;
                        middle = x;
                        largest = y;
                    }
                }
            }

           else{
                if (x > y)
                {
                    if (x < z)
                    {
                        smallest = x
                        middle =y
                        largest = z
                        
                    }
                }
            }
        }
    }
}
