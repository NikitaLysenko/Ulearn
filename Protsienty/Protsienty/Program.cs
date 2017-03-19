using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protsienty
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Calculate(Console.ReadLine());
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static double Calculate(string userInput)
        {
            var userInputList = userInput.Split(' ');
            var deposit = double.Parse(userInputList[0]);
            var procent = double.Parse(userInputList[1])/100;
            var term = int.Parse(userInputList[2]);

            for (int i = 0; i < term; i++)
            {   
                deposit += deposit * (procent/12);
            }

            return deposit;
        }

    }
}
