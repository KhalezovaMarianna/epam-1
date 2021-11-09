using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введите число:\n");
            int x = Convert.ToInt32( Console.ReadLine());
           
            Console.Write("Введите систему счисления:\n");
             int n = Convert.ToInt32( Console.ReadLine());
           
            string result = string.Empty;
            for (; x > 0;)
            {
                var res = x % n;
                result = (res == 0 ? "0" : res.ToString()) + result;
                Console.Write(Convert.ToString(x) + "/" + Convert.ToString(n) + "=" + Convert.ToString(x/n) + " Остаток: "
                              + Convert.ToString(res) + " \n ");
                x /= n;
                
            }
            Console.WriteLine("результат: "+ result);
            Console.ReadLine();
            
        }
        
    }
}