using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExceptionHandling
{
    class CheckFirstSymbolClass
    {
        static void Main(string[] args)
        {
            Console.Write("Input value:");
            while (true)
            {

                var input = Console.ReadLine();

                try
                {
                    Console.WriteLine("First Character:" + input.Substring(0, 1));

                }
                catch (Exception e)
                {
                    if (input is null || input == "")
                    {
                        Console.WriteLine("Empty value was entered, please type something");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, exception:" + e.GetType());
                    }  
                }
                finally
                {
                    Console.Write("Input value:");
                }

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}
