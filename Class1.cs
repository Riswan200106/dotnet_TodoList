using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number : ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number : ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Operator (+, -, /, *): ");
            string myOperator = Console.ReadLine();

            if (myOperator.Length > 1)
            {
                Console.WriteLine("Enter a valid Operator (+, -, /, *): ");
                myOperator = Console.ReadLine();
            }

            else if (myOperator == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            else if (myOperator == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (myOperator == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            else (myOperator == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            Console.ReadLine();

        }
    }
}


