using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCalculator
{
    interface ISimpleCalculator
    {
        int NumberGetter();
        void PrintMenu();
        int GetUserChoise();
        double Calculate(int x, int y, int z);
        void PrintResultNicely(double print_on_screen);
    }
}
