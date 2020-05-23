using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static double addition;
        public static double subtract;
        public static double divide;
        public static double multiply;
        public static int first;
        public static int second;
        //public static bool calculate;
        static void Main()
        {
            
            do
            {
                Console.WriteLine("Choose which operation do you want to perform? ");
                Console.WriteLine("Enter \"A\" for addition, \"S\" for Subtraction, \"D\" for division and \"M\" for multiplication. ");
                String decision = Convert.ToString(Console.ReadLine());
                string des = decision.ToLower();
                if (des =="a" || des == "s" || des == "d" || des == "m")
                {
                    Console.WriteLine("Enter first number: ");
                    first = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    second = int.Parse(Console.ReadLine());
                }

                if (des == "a")
                {
                    Console.WriteLine("The Addition of {0} and {1} is {2}.", first, second, Addition(first, second));
                }
                if (des == "s")
                {
                    Console.WriteLine("The Subtraction of {0} and {1} is {2}.", first, second, Subtraction(first, second));
                }
                if (des == "d")
                {
                    Console.WriteLine("The Division of {0} and {1} is {2}.", first, second, Division(first, second));
                }
                if (des == "m")
                {
                    Console.WriteLine("The Multiplication of {0} and {1} is {2}.", first, second, Multiplication(first, second));
                }
                //
                
            } while (ToContinue());
        }
        public static double Addition(int a, int b)
        {
            addition = a + b;
            return addition;
        }
        public static double Subtraction(int a, int b)
        {
            subtract = a - b;
            if (a>b)
            {
                return subtract;
            }
            else
            {
                return -(Math.Abs(subtract));
            }
        }
        public static double Division(int a, int b)
        {
            try
            {
                divide = a / b;
            }
            catch (Exception e)
            {
                throw e;
            }
            
            
        }
        public static double Multiplication(int a, int b)
        {
            multiply = a * b;
            return multiply;
        }
        public static bool ToContinue()
        {
            Console.WriteLine("Do you want to perform another operation? Enter Yes to continue or NO to Stop program");
            string toContinue = Console.ReadLine();
            if (toContinue.ToLower() == "yes")
                return true;
            else
                return false;

        }

    }
}
