using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Please enter two numbers");

                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());

                //double c = a / b;
                //Console.WriteLine("The result is " + c + ".");

                //Console.Write("Please enter the length of your array: ");
                //int arrayLength = int.Parse(Console.ReadLine());
                //int[] array1 = new int [arrayLength];
                //for (int i = 0; i < arrayLength; i++)
                //{
                //    Console.Write("Your {0} integer: ", i + 1);
                //    array1[i] = int.Parse(Console.ReadLine());
                //}
                //Console.WriteLine(array1[arrayLength]);
                Console.WriteLine("Enter your input: ");
                int num1 = int.Parse(Console.ReadLine());

            }
            catch (Exception c)
            {
                //Console.WriteLine("Math Error: Denominator equal to zero");
                //Console.WriteLine("Out of bound");
                Console.WriteLine(c.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}
