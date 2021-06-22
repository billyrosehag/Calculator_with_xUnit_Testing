using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Cal
{
    public class Formating
    {
        public Formating()
        {

        }

        public char[] arrOperators = new char[] { '+', '-', '/', '*' };

        public string[] StringSeperator(string playerInput)
        {
            string[] arrInputSeperated = playerInput.Split(" ");

            return arrInputSeperated;
        }

        public bool CheckInput(string[] Seperatedstring)
        {
            char[] arrOperators = new char[] { '+', '-', '/', '*' };
            bool correctInput = false;

            try
            {
                char op = char.Parse(Seperatedstring[1]);
                double numb1 = double.Parse(Seperatedstring[0]);
                double numb2 = double.Parse(Seperatedstring[2]);

                for (int i = 0; i < arrOperators.Length; i++)
                {
                    if (op == arrOperators[i])
                    {
                        correctInput = true;
                    
                    }
                    if (Seperatedstring.Length != 3)
                    {
                        throw new IndexOutOfRangeException("the format must be number operator number.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.Write("Wrong Format. Try again: ");
                
            }
            catch(OverflowException)
            {
                Console.Write("Input too big. Try again: ");
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("the format must be 'number operator number'.");
                correctInput = false;
            }
            return correctInput;
        }
    }
}
