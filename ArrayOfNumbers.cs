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

        private int _arrayLength;
        private int[] _array;

        private int _newArrayLength;
        private int[] _newArray;

        private int _arrayIndex;

        
        private int ArrayLength
        {
            set { _arrayLength = value;
                Array.Resize(ref _array, _arrayLength);
            }
        }

        private int[] ArrayValues
        {
            get
            {
                return _array; 
            }
            set
            {
                _array = value;
            }
        }

        private int[] NewArrayValues
        {
            get
            {
                return _newArray; 
            }
            set
            {
                _newArray = value;
            }
        }

        private int NewArrayLength
        {
            get { return _newArrayLength; }
            set {  _newArrayLength = _arrayLength; }
        }

        // more accessor methods for array elements

        private int ArrayIndex
        {
            get { return _arrayIndex;  }
            set { _arrayIndex = value; }
        }

        // accessor methods for later use
        private int GetArrayElement
        {
            get => NewArrayValues[ArrayIndex];
        }

        private int SetArrayElement
        {
            set
            {
                NewArrayValues[ArrayIndex] = value;
                //ArrayIndex++;
            }
        }



        // constructors
        public ArrayOfNumbers(int array_length)
        {
            ArrayLength = array_length;
        }

        public ArrayOfNumbers(int[] array)
        {
            ArrayValues = array;
            CreateNewArray();
        }

        // functions
        private void CreateNewArray()
        {
            Array.Resize(ref _newArray, NewArrayLength);

            for (int ArrayIndex= 0; ArrayIndex < NewArrayLength; ArrayIndex++)
            {
                NewArrayValues[ArrayIndex] = ArrayValues[ArrayIndex];
            }

        }

        public void SetArrayLength(int array_length)
        {
            ArrayLength = array_length;
        }

        private string override ToString()
        {
            if (NewArrayValues == null || ArrayIndex == 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Join(", ", NewArrayValues);
            }
        }


    }
}
