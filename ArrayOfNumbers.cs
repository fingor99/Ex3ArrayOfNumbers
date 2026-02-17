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
            return string.Join(", ", ArrayValues);
        }

        public void GetMax()
        {
            return ToString(ArrayValues.Max());
        }


    }
}
