using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISimpleCalculator simpleCalc = new SimpleCalculator();
            AtomicCalculator atomicCalc = new AtomicCalculator();

            atomicCalc.GetNumberFromUser = simpleCalc.NumberGetter;
            atomicCalc.GetUserChoise = simpleCalc.GetUserChoise;
            atomicCalc.MenuPrinter = simpleCalc.PrintMenu;
            atomicCalc.ResultPrint = simpleCalc.PrintResultNicely;
            atomicCalc.ResultPrint += (double print_on_screen) => Console.WriteLine($"Your result is: {print_on_screen}");
            atomicCalc.Calculate = simpleCalc.Calculate;

            atomicCalc.Go();

            Console.ReadKey();
        }
    }
}
