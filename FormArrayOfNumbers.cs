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

        bool arrayCounterReady = false;
        int arrayIndex = 0;
        int[] arrayValues;
        int arrayLength;

        ArrayOfNumbers array_of_numbers = new ArrayOfNumbers(0);

        private void ShowArrayValueCounter()
        {
            labelArrayAmountInput.Visible = true;
            label1.Visible = true;
            labelArrayCapacity.Visible = true;
        }

        private void HideArrayValueCounter()
        {
            labelArrayAmountInput.Visible = false;
            label1.Visible = false;
            labelArrayCapacity.Visible = false;
        }

        private void CheckIfArrayFull()
        {
            if (arrayIndex == arrayValues.Length)
            {
                buttonInputIntoArray.Enabled = false;
                buttonInputIntoArray.BackColor = Color.DarkGray;
            }
        }

        private void ResetArray()
        {
            arrayValues = new int[0];
        }

        private string ShowArray()
        {
            if (arrayValues == null || arrayIndex == 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Join(", ", arrayValues);
            }
        }

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

            numericUpDownAddConstant.Value = 0;
            numericUpDownArrayScalar.Value = 0;
        }

        private void ResetArrayFields()
        {
            labelMax.Text = string.Empty;
            labelAverage.Text = string.Empty;
            labelSum.Text = string.Empty;
            labelCount.Text = string.Empty;
        }

        public FormArrayOfNumbers()
        {
            InitializeComponent();
        }

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

                DisableMethodButtons();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input, please input a positive, whole integer");
                return;
            }

            if (arrayCounterReady == false)
            {
                ShowArrayValueCounter();
            }


        }

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
            arrayCounterReady = false;
            arrayLength = 0;
            groupBoxToString.Text = String.Empty;

            HideArrayValueCounter();
            ResetArrayFields();
            DisableMethodButtons();
            ResetArray();

            labelArray.Text = string.Empty;

        }



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



        private void buttonSetArray_Click(object sender, EventArgs e)
        {
            numericSetArrayLength.Value = 0;
            textBoxInputArrayValue.Text = "";
            arrayCounterReady = false;

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

        private void buttonMax_Click(object sender, EventArgs e)
        {
            labelMax.Text = $"{array_of_numbers.GetMax()}";
        }

        private void labelCount_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            labelCount.Text = $"{array_of_numbers.GetCount()}";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            labelSum.Text = $"{array_of_numbers.GetSum()}";
        }

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

        private void buttonToString_Click_1(object sender, EventArgs e)
        {
            groupBoxToString.Text = array_of_numbers.ToString();
        }

        private void buttonAreEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int numberA = Convert.ToInt32(textBoxAreEqualA.Text);
                int numberB = Convert.ToInt32(textBoxAreEqualB.Text);

                labelAreEqual.Text = array_of_numbers.AreEqual(numberA, numberB);
            }
            catch
            {
                MessageBox.Show("Invalid inputs, please enter two whole integer numbers.");
                textBoxAreEqualA.Text = " ";
                textBoxAreEqualB.Text = " ";
            }
        }

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
