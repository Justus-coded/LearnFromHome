using System;

namespace Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double res = AdditionOfTwoValues();
            Console.WriteLine(res);

            int rem = Remainder(2,3);
            Console.WriteLine(rem);

            int sub = SubtractionOfTwoValues(5,3);
            Print(sub.ToString());

            double quad =  QuadraticEquation("1","2","3");
            //use a=1, b=5, c=6
            Print(quad.ToString());

            double far_cel = FarenheitToCelcuis("100");
            Print(far_cel.ToString());
        }
        
        static double AdditionOfTwoValues(double x=9, double y=6)
        {
            double z = x + y;
            return z;
        }

        static int Remainder(int x=9, int y=6)
        {
            int z = x % y;
            return z;
        }

        static int SubtractionOfTwoValues(int x=9, int y=6)
        {
            int z = x + y;
            return z;
        }

        static void Print(string val)
        {
            Console.WriteLine(val);
        }

        static int Factor(int x=9, int y=6)
        {
            int z = x + y;
            return z;
        }

        static double QuadraticEquation(string a , string b, string c)
        {

            //Console.WriteLine("Hello World!");

            /* A program that calculates the value of X in a quadratic equation given a user inputs a,b,c
                
                y = aX^2 + bX + c
                X1 = -b+sqrt(b^2-4ac)
                X2 = -b-sqrt(b^2-4ac)
            */
            Console.WriteLine("Quadratic Equation Calculator"); 
            
            Console.WriteLine("Enter your first value"); //Prompts user for first value
            a = Console.ReadLine(); //Gets the first value

            Console.WriteLine("Enter your second value"); //Prompts user for second value
            b = Console.ReadLine(); // Gets the second value

            Console.WriteLine("Enter your third value"); //Prompts user for third value
            c = Console.ReadLine(); //Gets the third value

            int A = Convert.ToInt32(a); //Converts first value to an integer
            int B = Convert.ToInt32(b); //Converts second value to an integer
            int C = Convert.ToInt32(c); //Converts third value to an integer

            Console.WriteLine("you have entered a = " + A + " , b = " + B + " , c = " + C); //Prints out the values entered by user 

            //Test case a=1, b=5, c=6
            double X1 = (-B+ Math.Sqrt(Math.Pow(B,2)-(4*A*C)))/2; //Calculates the value of X1
            double X2 = (-B- Math.Sqrt(Math.Pow(B,2)-(4*A*C)))/2; //Calculates the value of X2
                
            Console.WriteLine("The value of X1 is " + X1); 
            Console.WriteLine("The value of X2 is " + X2 );

            return X1;

            /*A few questions i have
            1. How do i return two values
            2. I also tried to use console.writeline in the return statement but it didnt work
            3. My program get an input from user but i still have to pass an argument when calling my method. WHY?
            
            */
            
        }

        static double FarenheitToCelcuis(string num )
        {
            /* A program that converts fahrenheit to celcius*/
            Console.WriteLine("              ");
            Console.WriteLine("Fahrenheit to Celcuis");

            Console.Write("Enter your value in Fahrenheit: ");//Prompts user for an input

            num = Console.ReadLine(); //Gets the input from the user

            int num1 = Convert.ToInt32(num); //Converts the input to an integer

            double ans = ((num1-32)*5)/9;  // Converts the value to fahrenheit

            Console.WriteLine("The answer is " + ans + " degree Celcius"); //Prints the answer

            return ans;
        }

        
    }
}
