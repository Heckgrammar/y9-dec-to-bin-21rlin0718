using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int
             
            ////STARTER 2: INSERT A STRING AT THE START OF ANOTHER STRING
            //Console.WriteLine("Enter string");
            //string myString1 = Console.ReadLine();
            //Console.WriteLine("Enter another string");
            //string myString2 = Console.ReadLine();
            //Console.WriteLine(myString1 + myString2);



            //MAIN:  NUMBER CONVERSION PROGRAM

            Console.WriteLine("Enter number");
            int denary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberConversion(denary, 2));

        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            string result = " ";
            int remainder = 0;
            while (number / numberbase > 0)
            {
                remainder = number % numberbase;
                Console.Write(remainder);
                number = number / numberbase;
                if (number == 1)
                {
                    Console.WriteLine(number % numberbase);
                }

            }
           
            return result;

            //string result = " ";
            //int remainder = 0;
            //while (number / numberbase > 0)
            //{
            //    remainder = number % numberbase;
            //    Console.Write(remainder);
            //    number = number / numberbase;
            //    if (number == 1)
            //    {
            //        Console.WriteLine(number % numberbase);
            //    }

            //}
        }
    }
}
