﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter ineger 2:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Two integers aer equal");
            }
            else
            {
                Console.WriteLine(" Two integer are  not equal");
            }
            // Q 2 cheaking for possitive or negative number
            int number;
            Console.WriteLine(" Enter the number to check wether number is possitive or negative");
            number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("number is possitve");
            }
            else
            {
                Console.WriteLine("number is negative");
            }
            
            //Q3
            int number1, number2, result;
            char operation;
            Console.Write("Enter the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number :");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the operation");
            Console.WriteLine("1 addititon");
            Console.WriteLine("2 subtraction");
            Console.WriteLine("3 multiplication");
            Console.WriteLine("4 division");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    Console.WriteLine("The addition of two number is : {0}", result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("The subtraction of two number is : {0}", result);
                    break;
                case '3':
                    result = number1 * number2;
                    Console.WriteLine("The multiplication of two number is : {0}", result);
                    break;
                case '4':
                    result = number1 / number2;
                    Console.WriteLine("The division of two number is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.ReadLine();

        } 
       
    }
}
