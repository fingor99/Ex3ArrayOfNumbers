using System;
using System.Collections.Generic;
using System.Linq;
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

        // may want to mess about with getters and setters for the accessor functions
        public int ArrayLength
        {
            set { _arrayLength = value;
                Array.Resize(ref _array, _arrayLength);
            }
        }

        public int[] ArrayValues
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

        public int[] NewArrayValues
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

        public int NewArrayLength
        {
            get { return _newArrayLength; }
            set {  _newArrayLength = _arrayLength; }
        }


        // constructors
        public ArrayOfNumbers(int array_length)
        {
            ArrayLength = array_length;
        }

        public ArrayOfNumbers(int[] array)
        {
            ArrayValues = array;
            createNewArray();
        }

        // functions
        private void createNewArray()
        {
            Array.Resize(ref _newArray, _newArrayLength);

            for (int i=0; i < _newArrayLength; i++)
            {
                NewArrayValues[i] = ArrayValues[i];
            }

        }
    }
}
