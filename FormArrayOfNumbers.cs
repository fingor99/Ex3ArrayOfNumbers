using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3ArrayOfNumbers
{
    public partial class FormArrayOfNumbers : Form
    {
        // Local variables for handling the local array (array index number, array length, array)

        int arrayIndex = 0;
        int[] arrayValues;
        int arrayLength;

        // creating a new ArrayOfNumbers class upon form initialisation, and initialising the array length to 0

        ArrayOfNumbers array_of_numbers = new ArrayOfNumbers(0);

        // Shows the form counter for telling the user how many array elements they have left to input into the array
        private void ShowArrayValueCounter()
        {
            labelArrayAmountInput.Visible = true;
            label1.Visible = true;
            labelArrayCapacity.Visible = true;
        }

        // Hides the form counter for telling the user how many array elements they have left to input into the array
        private void HideArrayValueCounter()
        {
            labelArrayAmountInput.Visible = false;
            label1.Visible = false;
            labelArrayCapacity.Visible = false;
        }

        // Checks if the array has been filled up with all of the user-inputted elements, if so then the "Input Into Array" button is disabled
        private void CheckIfArrayFull()
        {
            if (arrayIndex == arrayValues.Length)
            {
                buttonInputIntoArray.Enabled = false;
                buttonInputIntoArray.BackColor = Color.DarkGray;
            }
        }

        // Removes all elements and indexing in the array by creating a new empty one
        private void ResetArray()
        {
            arrayValues = new int[0];
        }


        // Displays the local array onto the form if there is values in the array to display
        private string ShowArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Join(", ", array);
            }
        }

        // Enables all buttons and fields relating to array manipulation
        private void EnableMethodButtons()
        {
            buttonToString.Enabled = true;
            buttonMax.Enabled = true;
            buttonAverage.Enabled = true;
            buttonCount.Enabled = true;
            buttonSum.Enabled = true;
            buttonAddConstant.Enabled = true;
            buttonArrayScalar.Enabled = true;

            buttonToString.BackColor = Color.LightSteelBlue;
            buttonMax.BackColor = Color.LightSteelBlue;
            buttonAverage.BackColor = Color.LightSteelBlue;
            buttonCount.BackColor = Color.LightSteelBlue;
            buttonSum.BackColor = Color.LightSteelBlue;
            buttonAddConstant.BackColor = Color.LightSteelBlue;
            buttonArrayScalar.BackColor = Color.LightSteelBlue;

            numericUpDownArrayScalar.Enabled = true;
            numericUpDownAddConstant.Enabled = true;
        }

        // Disables all buttons and fields relating to array manipulation
        private void DisableMethodButtons()
        {
            buttonToString.Enabled = false;
            buttonMax.Enabled = false;
            buttonAverage.Enabled = false;
            buttonCount.Enabled = false;
            buttonSum.Enabled = false;
            buttonAddConstant.Enabled = false;
            buttonArrayScalar.Enabled = false;

            buttonToString.BackColor = Color.DarkGray;
            buttonMax.BackColor = Color.DarkGray;
            buttonAverage.BackColor = Color.DarkGray;
            buttonCount.BackColor = Color.DarkGray;
            buttonSum.BackColor = Color.DarkGray;
            buttonAddConstant.BackColor = Color.DarkGray;
            buttonArrayScalar.BackColor = Color.DarkGray;

            numericUpDownArrayScalar.Enabled = false;
            numericUpDownAddConstant.Enabled = false;

        }

        // Resets all text fields relating to array input and output
        private void ResetArrayFields()
        {
            labelMax.Text = string.Empty;
            labelAverage.Text = string.Empty;
            labelSum.Text = string.Empty;
            labelCount.Text = string.Empty;

            numericUpDownAddConstant.Value = 0;
            numericUpDownArrayScalar.Value = 0;
        }

        // Launches the form
        public FormArrayOfNumbers()
        {
            InitializeComponent();
        }

        // Upon clicking the "Set Array Length" button, the array length field is disabled, the input array element value field enabled
        // and a new ArrayOfNumbers class is created with the user inputted array length as it's argument
        private void buttonSetArrayLength_Click(object sender, EventArgs e)
        {

            try
            {
                arrayLength = Convert.ToInt32(numericSetArrayLength.Value);

                if (arrayLength == 0)
                {
                    MessageBox.Show("Please input a value more than 0");
                    return;
                }

                Array.Resize(ref arrayValues, arrayLength);
                arrayIndex = 0;
                labelArrayCapacity.Text = arrayLength.ToString();

                buttonResetArray.Visible = true;
                buttonSetArray.Visible = true;

                buttonSetArrayLength.Enabled = false;
                numericSetArrayLength.Enabled = false;
                buttonInputIntoArray.Enabled = true;
                buttonInputIntoArray.Enabled = true;
                textBoxInputArrayValue.Enabled = true;

                buttonSetArrayLength.BackColor = Color.DarkGray;
                buttonInputIntoArray.BackColor = Color.LightSteelBlue;

                array_of_numbers = new ArrayOfNumbers(arrayLength);

                ShowArrayValueCounter();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input, please input a positive, whole integer");
                return;
            }



        }

        // Upon clicking the "Reset Array" button, reverts form back to it's launch state, wipes current array and creates a new one with no values or length
        private void buttonResetArray_Click(object sender, EventArgs e)
        {
            buttonResetArray.Visible = false;
            buttonSetArray.Visible = false;

            buttonSetArrayLength.BackColor = Color.LightSteelBlue;
            buttonInputIntoArray.BackColor = Color.DarkGray;

            buttonSetArrayLength.Enabled = true;
            numericSetArrayLength.Enabled = true;
            buttonInputIntoArray.Enabled = false;
            textBoxInputArrayValue.Enabled = false;

            labelArrayAmountInput.Text = "0";

            numericSetArrayLength.Value = 0;
            textBoxInputArrayValue.Text = "";
            arrayLength = 0;
            groupBoxToString.Text = String.Empty;

            HideArrayValueCounter();
            ResetArrayFields();
            DisableMethodButtons();
            ResetArray();

            labelArray.Text = string.Empty;

        }


        // Upon clicking the "Input Into Array" button, validates the respective fields content and inserts it into the local array
        private void buttonInputIntoArray_Click(object sender, EventArgs e)
        {

            try
            {
                int arrayValue = Convert.ToInt32(textBoxInputArrayValue.Text);

                if (arrayValues == null)
                {
                    MessageBox.Show("Please input a whole number into the array");
                    textBoxInputArrayValue.Text = string.Empty;
                    return;
                }

                else if (arrayIndex >= arrayValues.Length)
                {
                    MessageBox.Show("Cannot input more values into the array");
                    return;
                }


                arrayValues[arrayIndex++] = arrayValue;
                labelArrayAmountInput.Text = arrayIndex.ToString();
                CheckIfArrayFull();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid input, please input a whole number into the array");
                return;
            }

            textBoxInputArrayValue.Text = "";

        }

        // Upon clicking the "Set Array" button, disables the input array value field, creates a new ArrayOfNumbers class with the user input array as an argument
        // and displays the local array to the form
        private void buttonSetArray_Click(object sender, EventArgs e)
        {
            numericSetArrayLength.Value = 0;
            textBoxInputArrayValue.Text = "";

            HideArrayValueCounter();

            buttonInputIntoArray.BackColor = Color.DarkGray;
            buttonInputIntoArray.Enabled = false;
            textBoxInputArrayValue.Enabled = false;
            buttonSetArray.Visible = false;

            array_of_numbers = new ArrayOfNumbers(arrayValues);

            EnableMethodButtons();

            labelArray.Text = array_of_numbers.ShowArray();

        }

        private void FormArrayOfNumbers_Load(object sender, EventArgs e)
        {

        }

        private void labelArrayDesc_Click(object sender, EventArgs e)
        {

        }

        private void buttonToString_Click(object sender, EventArgs e)
        {
            //
        }

        // Calls the function from the ArrayOfNumbers class to return the maximum value of the class array for output to the form
        private void buttonMax_Click(object sender, EventArgs e)
        {
            labelMax.Text = $"{array_of_numbers.GetMax()}";
        }

        private void labelCount_Click(object sender, EventArgs e)
        {
          
        }

        // Calls the function from the ArrayOfNumbers class to return the number of values in the class array for output to the form
        private void buttonCount_Click(object sender, EventArgs e)
        {
            labelCount.Text = $"{array_of_numbers.GetCount()}";
        }

        // Calls the function from the ArrayOfNumbers class to return the total values of all elements in the class array for output to the form
        private void buttonSum_Click(object sender, EventArgs e)
        {
            labelSum.Text = $"{array_of_numbers.GetSum()}";
        }

        // Calls the function from the ArrayOfNumbers class to return the mean average from all elements in the class array for output to the form
        private void buttonAverage_Click(object sender, EventArgs e)
        {
            labelAverage.Text = $"{array_of_numbers.GetAverage()}";
        }

        private void numericUpDownGCDa_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void numericUpDownGCDa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        // Calls the function from the ArrayOfNumbers class to reutrn the greatest common denominator from two input values in the GCD fields for output to the form.
        // Upon clicking the Get GCD button, the two values in the GCD fields are validated and passed into the GetGCD function as arguments in the ArrayOfNumbers class
        private void buttonGCD_Click(object sender, EventArgs e)
        {
            try
            {
                int numberA = Convert.ToInt32(textBoxGcdA.Text);
                int numberB = Convert.ToInt32(textBoxGcdB.Text);

                labelGCD.Text = $"{array_of_numbers.GetGCD(numberA, numberB)}";
            }
            catch
            {
                MessageBox.Show("Invalid inputs, please enter two whole integer numbers.");
                textBoxGcdA.Text = " ";
                textBoxGcdB.Text = " ";
            }
        }

        // Upon clicking the "To String" button, the ToString overrride function from the ArrayOfNumbers class is called, and outputs the return value to the group box
        private void buttonToString_Click_1(object sender, EventArgs e)
        {
            groupBoxToString.Text = array_of_numbers.ToString();
        }

        // Upon clicking the "Check" button, the two "Check" field values next to the button are validated and passed into the AreEqual function in the ArrayOfNumbers class
        private void buttonAreEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int numberA = Convert.ToInt32(textBoxAreEqualA.Text);
                int numberB = Convert.ToInt32(textBoxAreEqualB.Text);

                if (array_of_numbers.AreEqual(numberA, numberB) == true)
                {
                    labelAreEqual.Text = "Yes";
                } else
                {
                    labelAreEqual.Text = "No";
                }

                //labelAreEqual.Text = array_of_numbers.AreEqual(numberA, numberB);
            }
            catch
            {
                MessageBox.Show("Invalid inputs, please enter two whole integer numbers.");
                textBoxAreEqualA.Text = " ";
                textBoxAreEqualB.Text = " ";
            }
        }

        // Upon clicking the "Scalar Multiply" button, the scalar multiply field is validated and passed in as an argument for the ScalarMultiply function in the ArrayOfNumbers class
        // the result of the scalar multiplication is outputted to the form by updating the array field in the form with the new values from the class array
        private void buttonArrayScalar_Click(object sender, EventArgs e)
        {
            try
            {
                array_of_numbers.ScalarMultiply(Convert.ToInt32(numericUpDownArrayScalar.Value));
                labelArray.Text = ShowArray(array_of_numbers.GetArray());
            }
            catch
            {
                MessageBox.Show("Invalid inputs, please enter two whole integer numbers.");
                numericUpDownArrayScalar.Value = 0;
            }
        }

        // Upon clicking the "Add Constant" button, the add constant field is validated and passed in as an argument for the AddConstant function in the ArrayOfNumbers class
        // the result of the given constant to the array is outputted to the form by updating the array field in the form with the new values from the class array
        private void buttonAddConstant_Click(object sender, EventArgs e)
        {
            try
            {
                array_of_numbers.AddConstant(Convert.ToInt32(numericUpDownAddConstant.Value));
                labelArray.Text = ShowArray(array_of_numbers.GetArray());
            }
            catch
            {
                MessageBox.Show("Invalid inputs, please enter two whole integer numbers.");
                numericUpDownAddConstant.Value = 0;
            }
        }
    }
}
