using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCalculator
{
    class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoise { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<double> ResultPrint { get; set; }

        public void Go()
        {
            int numX, numY;
            int Choise;
            double print_on_screen;
            
            numX = GetNumberFromUser.Invoke();
            numY = GetNumberFromUser.Invoke();
            MenuPrinter.Invoke();
            Choise = GetUserChoise.Invoke();
            print_on_screen = Calculate.Invoke(numX, numY, Choise);
            ResultPrint.Invoke(print_on_screen);
                     
        }

    }
}
