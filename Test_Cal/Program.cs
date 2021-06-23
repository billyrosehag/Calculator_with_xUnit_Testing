using System;

namespace Test_Cal
{
    public class Program
    {
        //Fields for the program
        public static bool isAlive = true;
        public static double result = 0;
        static double numb1 = 0;
        static double numb2 = 0;
        static void Main(string[] args)
        {
            
            Console.Write("Calculation is done by inputting 'number1 Operation Number2', example '5 - 5'. Each step must be seperated by a space.\n" +
                              "Operations available: +, -, *, /.\n");
            
            do
            {//Calculation program starts
                Formating myFormating = new Formating();

                bool correctInput = true;
                string[] arrSeperation = new string[] { };

                

                Console.Write("\nWhat do you want to calculate: ");
                do//Calculation fase
                {
                    arrSeperation = myFormating.StringSeperator(Console.ReadLine());

                    correctInput = myFormating.CheckInput(arrSeperation);

                } while (!correctInput);//If the user does not input in a valid way, it will repeat

                foreach (string word in arrSeperation) // Presents the calculation
                {
                    Console.Write(" " + word + " ");
                }

                //Creates the numbers used for the calculation
                numb1 = double.Parse(arrSeperation[0]);
                numb2 = double.Parse(arrSeperation[2]);

                //Uses a switch to see which type of calculation that will be done
                CalculationChoiceAndResult(arrSeperation[1], numb1, numb2);

                //Presents results 
                Console.WriteLine($"\nCalculation Reslut: {result}");


                Console.Write("Do you want to do another Calculation(Y/N): ");

                //Player decides whether or not to make a new calculation
                isAlive = Endprogram(Console.ReadKey().KeyChar);
                Console.ReadKey();

            } while (isAlive);

        }//End of Main Method


        // Switch that chooses operation
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

        //Endprogram where player chooses how to proceed
        public static bool Endprogram(char answer)
        {
            bool playAgain;

            if (answer == 'y' || answer == 'Y')
            {
                Console.WriteLine();
                playAgain = true;
            }
            else if (answer == 'n' || answer == 'N')
            {
                Console.WriteLine("\nProgram will exit. Press any key to continue");
                
                playAgain = false;
            }
            else
            {
                Console.WriteLine("\nInvalid answer. Program will exit. Press any key to continue");
                
                playAgain = false;
            }

            return playAgain;
        }
    }


}
