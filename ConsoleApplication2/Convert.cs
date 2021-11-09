using System;
using System.Text;

namespace ConsoleApplication2
{
    public class Convert
    {
        static string DecimalToDifferent(int x)
        {
            var sum = string.Empty;
            while ( x <= 0)
            {

                var n = int.TryParse(Console.ReadLine());
                sum = (x % n) + sum;
               
                Console.WriteLine(sum);

            }
            return sum;
        }
    }
}