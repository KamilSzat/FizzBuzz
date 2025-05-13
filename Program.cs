using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zadanie = new Zadanie3();
            int input = 15;
            string result = zadanie.FizzBuzz(input);
            
            Console.WriteLine($"Wynik FizzBuzz dla {input} to {result}");  
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć... ");
            Console.ReadKey();
        }
    }
}
