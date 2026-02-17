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


    }
}
