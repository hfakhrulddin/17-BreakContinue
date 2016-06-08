using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = new string[] { "First", "Second", "Third", "Fourth", "Fifth" };
            Console.WriteLine("Starting ........");
            foreach (string number in numbers)
            {
                if (number == "Second")
                    break;
                else
                    continue;
                Console.WriteLine(number);
            }
            Console.WriteLine("Done ........");
            Console.ReadLine();
        }
    }
}
