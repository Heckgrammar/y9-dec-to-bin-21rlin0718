﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
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

            //MAIN: NUMBER CONVERSION PROGRAM
            //Bin-Dec and Dec-Hex are extensions
            Console.WriteLine("Press: 1 = Denary to Binary, 2 = Binary to Denary, 3 = Denary to Hexadecimal, 4 = Hexadecimal to Denary");
            int option = Convert.ToInt32(Console.ReadLine());

            while (option > 4 || option < 1)
            {
                Console.WriteLine("Press: 1 = Denary to Binary, 2 = Binary to Denary, 3 = Denary to Hexadecimal, 4 = Hexadecimal to Denary");
                option = Convert.ToInt32(Console.ReadLine());
            } 

            if (option == 1)
            {
                Console.WriteLine("Enter number between 1-255");
                int denary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numberConversion(denary, 2));
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter 8-bit binary number");
                string binary = Console.ReadLine();
                Console.WriteLine(binToNumberConversion(binary));
            }
            else if (option == 3) 
            {
                Console.WriteLine("Enter number between 1-255");
                int denary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numberToHexConversion(denary, 16));
            }
            else
            {
                Console.WriteLine("Enter hex value between 1 and FF");
                string hex = Console.ReadLine();
                Console.WriteLine(hexToNumberConversion(hex));
            }
        }

        //static void means the function will not return a value so it does not need a data type
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            string result = " ";
            int remainder = 0;
            int count = 0;
            int[] binary = new int[8];

            while (number < 0 || number > 255)
            {
                Console.WriteLine("Enter number between 1-255");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Denary:" + number);

            while (number > 0)
            {
                remainder = number % numberbase;
                number = number / numberbase;
                binary[count] = remainder;
                count = count + 1;
            }

            Console.Write("Binary:");
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }

            return result;

        }

        static string binToNumberConversion(string number)
        {
            string result = " ";
            int denary = 0;

            while (Convert.ToInt32(number) > 11111111 || Convert.ToInt32(number) < 1)         
            {
                Console.WriteLine("Enter 8-bit binary number");
                number = Console.ReadLine();
            }

            denary = Convert.ToInt32(number, 2);   //converts 'number' to its integer form in base 2

            Console.WriteLine("Binary:" + number);
            Console.Write("Denary:" + denary);

            return result;
        }

        static string numberToHexConversion(int number, int numberbase)
        {
            string result = " ";
            int remainder = 0;
            int count = 0;
            string[] hex = new string[2];

            while (number < 0 || number > 255)
            {
                Console.WriteLine("Enter number between 1-255");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Denary:" + number);

            while (number > 0)
            {
                remainder = number % numberbase;
                number = number / numberbase;
                hex[count] = Convert.ToString(remainder);
                if (remainder > 9)
                {
                    if (remainder == 10)
                    {
                        hex[count] = "A";
                    }
                    else if (remainder == 11) 
                    {
                        hex[count] = "B";
                    }
                    else if (remainder == 12)
                    {
                        hex[count] = "C";
                    }
                    else if (remainder == 13)
                    {
                        hex[count] = "D";
                    }
                    else if (remainder == 14)
                    {
                        hex[count] = "E";
                    }
                    else
                    {
                        hex[count] = "F";
                    }
                } 
                count = count + 1;
                
            }

            Console.Write("Hex:");
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(hex[i]);
            }

            return result;

        }
        static string hexToNumberConversion(string number)
        {
            string result = " ";
            int denary = 0;

            while (Convert.ToInt32(number, 16) > 255 || Convert.ToInt32(number, 16) < 1)
            {
                Console.WriteLine("Enter hex value between 1 and FF");
                number = Console.ReadLine();
            }

            denary = Convert.ToInt32(number, 16);   //converts 'number' to its integer form in base 16

            Console.WriteLine("Hex:" + number);
            Console.Write("Denary:" + denary);

            return result;
        }
    }
}
