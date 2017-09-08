using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = 800000000;
                checked // check for overflow
                {
                    int square = value * value;
                    Console.WriteLine("{0} ^ 2 = {1}", value, square);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
