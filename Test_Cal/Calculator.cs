using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Cal
{
    public class Calculator
    {
        //Fields
        private static Random rng = new Random();
        private static double result;
        
        //Properties
        public static double Result {
            get { return result; }

            set { result = value; } 
        }
        public Calculator()
        {
            //Initiates a Calculator object
        }

        //Addition
        public static double Addition(double numb1, double numb2)
        {
            Result = numb1 + numb2;
            return Result;
        }
        
        //Uses array for the calculation
        public static double Addition(double[]numbers)
        {
            result = 0;
            try {


                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!double.IsNaN(numbers[i]))
                    {
                result += numbers[i];
                    }
                    else
                    {
                        
                    }
            }
             
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Input must be atleast one number.");
                result = 0;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Input can not be null.");
                result = 0;
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("Input must be a number.");
                result = 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be a number.");
                result = 0;
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Input must be a number.");
                result = 0;
            }
            return Result;
        }
        
        //Subtraction
        public static double Subtraction(double numb1, double numb2)
        {
            Result = numb1 - numb2;
            return Result;
        }
        //Uses array for the calculation
        public static double Subtraction(double[] numbers)
        {
            try
            {
                if (double.IsNaN(numbers[0]))
                {
                    numbers[0] = 0;
                }
                
                result = numbers[0];

                if(numbers.Length > 1) { 
              
                    for (int i = 1; i < numbers.Length; i++)
                {
                        if (double.IsNaN(numbers[i]))
                        {
                            numbers[i] = 0;
                        }
                        result -= numbers[i];
                }
               
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Input must be atleast one number.");
                result = 0;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Input can not be null.");
                result = 0;
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("Input must be a number.");
                result = 0;
            }
            catch(FormatException)
            {
                Console.WriteLine("Input must be a number.");
                result = 0;
            }
            return Result;
        }
        //Division
        public static double Division(double numb1, double numb2)
        {
            try
            {
                Result = numb1 / numb2;
                
                if (Double.IsInfinity(Result))
                {
                    throw new DivideByZeroException("Dividing by zero is not allowed."); 
                }
            }
            catch (DivideByZeroException)
            {
                Result = 0;
                Console.WriteLine("\nDivided by zero is not allowed. Result will be set to zero.");
               
            }       
            return Result;              
        }
        //Multiplication
        public static double Multiplication(double numb1, double numb2)
        {
            Result = numb1 * numb2;
            return Result;
        }

        //Creates an array where parameter sets its length and the random range for each index value. 
        public static double[] ArrayCreation(int arrayLength, int randomEnd) 
        {
            double[] arrRandom = new double[arrayLength];

            for (int i = 0; i < arrRandom.Length; i++)
            {
                arrRandom[i] = rng.Next(1, randomEnd);
            }
            return arrRandom;
        }
    }
}
