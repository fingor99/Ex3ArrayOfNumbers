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


        //public override string ToString(int max, int sum, int avg, int count, int equal, int )
        //{
        //    return string.Join(", ", ArrayValues);
        //}

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
            return $"{ArrayValues.Average()}";
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


    }
}
