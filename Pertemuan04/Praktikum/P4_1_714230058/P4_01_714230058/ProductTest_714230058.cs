using P4_01_71420058;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_01_714230058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book_714230058 product1 = new Book_714230058("Book", "C# Object Oriented Solution", "300");
            DVD_714230058 product2 = new DVD_714230058("Eternal sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();

            Console.Write("Please press anykey....");
            string p = Console.ReadLine();
        }
    }
}
