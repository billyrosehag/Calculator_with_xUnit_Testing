using System;

namespace Test_Cal
{
    public class Program
    {
        public static bool isAlive = true;
        public static double result = 0;
        static double numb1 = 0;
        static double numb2 = 0;
        static void Main(string[] args)
        {

            Console.Write("Calculation is done by inputting 'number1 Operation Number2', example '5 - 5'. Each step must be seperated by a space.\n" +
                              "Operations available: +, -, *, /.\n");
            do
            {
                Formating myFormating = new Formating();

                bool correctInput = true;
                string[] arrSeperation = new string[] { };

                Console.Write("What do you want to calculate: ");
                do
                {
                    arrSeperation = myFormating.StringSeperator(Console.ReadLine());

                    correctInput = myFormating.CheckInput(arrSeperation);

                } while (!correctInput);

                foreach (string word in arrSeperation)
                {
                    Console.Write(" " + word + " ");
                }

                numb1 = double.Parse(arrSeperation[0]);
                numb2 = double.Parse(arrSeperation[2]);

                CalculationChoiceAndResult(arrSeperation[1], numb1, numb2);

                Console.WriteLine($"\nCalculation Reslut: {result}");

                Console.ReadLine();

            } while (isAlive);

        }//End of Main Method

        public static double CalculationChoiceAndResult(string opt, double numb1, double numb2)
        {
            switch (opt)
            {

                case "+":
                    result = Calculator.Addition(numb1, numb2);
                    break;
                case "-":
                    result = Calculator.Subtraction(numb1, numb2);
                    break;
                case "/":
                    result = Calculator.Division(numb1, numb2);
                    break;
                case "*":
                    result = Calculator.Multiplication(numb1, numb2);
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again: ");
                    break;
            }
            return result;
        }

        public static double StoreValue(double input)
        {
            Console.Write("Do you want to store value for further(y/n): ");
            string answer = Console.ReadLine();
            input = answer == "y" ? input : 0;
            return input;
        }
    }


}
