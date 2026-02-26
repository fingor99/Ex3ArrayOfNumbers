using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ArrayOfNumbers
{
    public class ArrayOfNumbers
    {
        // Fields

        private int _arrayLength;
        private int[] _array;


        //Accessor modifiers
        private int ArrayLength
        {
            set { _arrayLength = value; }
            get { return _arrayLength; }
        }

        private int[] ArrayValues
        {
            set { _array = value; }
            get { return _array; }
        }


        // Constructors
        public ArrayOfNumbers(int array_length)
        {
            ArrayValues = new int[array_length];
        }

        // creates a new array with the argument array's length, copies the values from the argument array to the class array
        public ArrayOfNumbers(int[] array)
        {
            ArrayValues = new int[array.Length];
            Array.Copy(array, ArrayValues, array.Length);
            ArrayLength = array.Length;
        }


        // Functions/Methods

        // Returns a multi-line string for display onto the form's group box
        public override string ToString()
        {
            string string_text = $"ToString output :" +
                $"\n Maximum number in array : {GetMax()}" +
                $"\n The average of the values in the array : {GetAverage()}" +
                $"\n The sum of all values in the array : {GetSum()}" +
                $"\n The number of values in the array : {GetCount()}";

            return string_text;
        }

        // Returns the largest value in the user-inputted array
        public string GetMax()
        {
            return $"{ArrayValues.Max()}";
        }

        // Returns the string output of the array
        public string ShowArray()
        {
            return string.Join(", ", ArrayValues);
        }

        // Returns the number of values in the array
        public string GetCount()
        {
            return $"{ArrayValues.Count()}";
        }

        // Returns the total value of all the array values combined
        public string GetSum()
        {
            return $"{ArrayValues.Sum()}";
        }

        // Returns the average mean value of all the array values combined
        public string GetAverage()
        {
            return $"{Math.Round(ArrayValues.Average(), 2)}";
        }

        // Returns the full array
        public int[] GetArray()
        {
            return ArrayValues;
        }

        // Returns the greatest common denominator of two numbers passed in as arguments
        // Uses the euclidean algorithm
        public int GetGCD(int number_a, int number_b)
        {

            int remainder;

            while (number_b != 0)
            {
                if (number_b > number_a)
                {
                    int placeholder;
                    placeholder = number_a;
                    number_a = number_b;
                    number_a = placeholder;
                }


                if (number_b == 0 || number_a == 0)
                {
                    return number_b; // returns the number thats not empty if there is one
                }

                else if (number_b == number_a)
                {
                    return number_b;
                }

                else
                {
                    remainder = number_a % number_b;
                    if (remainder == 0)
                    {
                        return number_b;
                    }
                    else
                    {
                        number_a = number_b;
                        number_b = remainder;
                    }
                }


            } // end of for loop

            return number_a;

        } // end of getGCD function

        // Checks if two numbers passed in as arguments are equal, returns yes or no in string
        public bool AreEqual(int num_a, int num_b)
        {
            if (num_a == num_b)
            {
                //return "Yes";
                return true;
            }
            else
            {
                return false;
            }
        }

        // Multiplies each value in the array by the passed in argument, mutates the class array deliberatley
        public void ScalarMultiply(int scalar)
        {
            for (int i = 0; i < ArrayValues.Length; i++)
            {
                ArrayValues[i] = ArrayValues[i] * scalar;
            }
        }

        // Incriments each value in the array by the passed in argument, mutates the class array deliberatley
        public void AddConstant(int constant)
        {
            for (int i = 0; i < ArrayValues.Length; i++)
            {
                ArrayValues[i] = ArrayValues[i] + constant;
            }
        }


    }
}
