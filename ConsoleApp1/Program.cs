using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           

           
            
            Console.Write("1 число: ");
          
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("умножения: "); 
            Console.WriteLine(a*a);

            Console.Write("деление: ");
            Console.WriteLine(a / a);


            Console.Write("2 число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("умножения: ");
            Console.WriteLine(b * b);

            Console.Write("деление: ");
            Console.WriteLine(b / b);

            Console.ReadKey();
        }
    }
}
