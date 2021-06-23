﻿using System;
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
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
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
            result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
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
