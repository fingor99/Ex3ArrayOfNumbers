using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ArrayOfNumbers
{
    internal class ArrayOfNumbers
    {

        //Accessor modifiers

        private int _arrayLength;
        private int[] _array;


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


        // constructors
        public ArrayOfNumbers(int array_length)
        {
            ArrayValues = new int[array_length];
        }

        public ArrayOfNumbers(int[] array)
        {
            ArrayValues = new int[array.Length];
            Array.Copy(array, ArrayValues, array.Length);
            ArrayLength = array.Length;
        }


        // functions


        public override string ToString()
        {
            string string_text = $"ToString output :" +
                $"\n Maximum number in array : {GetMax()}" +
                $"\n The average of the values in the array : {GetAverage()}" +
                $"\n The sum of all values in the array : {GetSum()}" +
                $"\n The number of values in the array : {GetCount()}";

            return string_text;
        }

        public string GetMax()
        {
            return $"{ArrayValues.Max()}";
        }

        public string ShowArray()
        {
            return string.Join(", ", ArrayValues);
        }

        public string GetCount()
        {
            return $"{ArrayValues.Count()}";
        }

        public string GetSum()
        {
            return $"{ArrayValues.Sum()}";
        }

        public string GetAverage()
        {
            return $"{Math.Round(ArrayValues.Average(), 2)}";
        }

        public int[] GetArray()
        {
            return ArrayValues;
        }

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


        public string AreEqual(int num_a, int num_b)
        {
            if (num_a == num_b)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public void ScalarMultiply(int scalar)
        {
            for (int i = 0; i < ArrayValues.Length; i++)
            {
                ArrayValues[i] = ArrayValues[i] * scalar;
            }
        }

        public void AddConstant(int constant)
        {
            for (int i = 0; i < ArrayValues.Length; i++)
            {
                ArrayValues[i] = ArrayValues[i] + constant;
            }
        }


    }
}
