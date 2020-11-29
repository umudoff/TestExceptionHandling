﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberConverter;

namespace TestNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input value:");
            while (true)
            {

                var input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    Console.WriteLine("Integer Output:" + Converter.ConvertToInt(input));

                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, exception:" + e.GetType());
                }
                finally
                {
                    Console.Write("Input value:");
                }
            }

            Console.ReadLine();
        }
    }
}
