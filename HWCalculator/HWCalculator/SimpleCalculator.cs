using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HWCalculator
{
    class SimpleCalculator : ISimpleCalculator
    {
        public int NumberGetter()
        {
            int number;

            Console.WriteLine("Insert a positive number (more than Zero)");
            number = Convert.ToInt32(Console.ReadLine());

            

            if (number <=0)

            {
                throw new WrongValueException("\n**Wrong value! The number should be positive. Please, exit and next time try again**\n");
            }

            else
            return number;

        }

        public void PrintMenu()
        {
            Console.WriteLine("Choose what you need to do with the numbers:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
        }
        public int GetUserChoise()
        {
            int choice;

            Console.WriteLine("Choose option from 1 to 4 and insert the number:");
            choice = Convert.ToInt32(Console.ReadLine());


            if ((choice < 1) || (choice > 4))

            { 
            throw new WrongChoiceException("\n**Wrong choice! You can't choose this number. Please, exit and next time try nubmer between 1 to 4**\n");
            }

            else
            return choice;
                               
                       
        }

      
        public double Calculate(int x, int y, int MatAction)
        {
            switch (MatAction)
            {
                case 1: return (x + y);
                case 2: return (x - y);
                case 3: return (x * y);
                case 4: return (x / Convert.ToDouble(y));
                default: return 0;
            }
        }

                   
        public void PrintResultNicely(double print_on_screen)
        {
            Console.WriteLine("Your result is:");
            Console.WriteLine("//");
            Thread.Sleep(500);
            Console.WriteLine("////");
            Thread.Sleep(500);
            Console.WriteLine("//////");
            Thread.Sleep(500);
            Console.WriteLine($"***************{print_on_screen}*******************");
            Thread.Sleep(500);
            Console.WriteLine("//////");
            Thread.Sleep(500);
            Console.WriteLine("////");
            Thread.Sleep(500);
            Console.WriteLine("//");
        }
    }
}
