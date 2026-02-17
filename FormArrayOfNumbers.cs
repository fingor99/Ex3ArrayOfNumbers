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

        private void EnableMethodButtons()
        {
            buttonToString.Enabled = true;
            buttonMax.Enabled = true;
            buttonAverage.Enabled = true;
            buttonCount.Enabled = true;
            buttonGCD.Enabled = true;
            buttonSum.Enabled = true;

            buttonToString.BackColor = Color.LightSteelBlue;
            buttonMax.BackColor = Color.LightSteelBlue;
            buttonAverage.BackColor = Color.LightSteelBlue;
            buttonCount.BackColor = Color.LightSteelBlue;
            buttonGCD.BackColor = Color.LightSteelBlue;
            buttonSum.BackColor = Color.LightSteelBlue;
        }

        private void DisableMethodButtons()
        {
            buttonToString.Enabled = false;
            buttonMax.Enabled = false;
            buttonAverage.Enabled = false;
            buttonCount.Enabled = false;
            buttonGCD.Enabled = false;
            buttonSum.Enabled = false;

            buttonToString.BackColor = Color.DarkGray;
            buttonMax.BackColor = Color.DarkGray;
            buttonAverage.BackColor = Color.DarkGray;
            buttonCount.BackColor = Color.DarkGray;
            buttonGCD.BackColor = Color.DarkGray;
            buttonSum.BackColor = Color.DarkGray;
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
                buttonSetArrayLength.Enabled = false;
                buttonSetArrayLength.BackColor = Color.DarkGray;
                numericSetArrayLength.Enabled = false;
                buttonInputIntoArray.Enabled = true;
                buttonInputIntoArray.BackColor = Color.LightSteelBlue;
                buttonInputIntoArray.Enabled = true;
                textBoxInputArrayValue.Enabled = true;

                //array_of_numbers.ArrayLength = arrayLength; // change
                array_of_numbers.SetArrayLength(arrayLength);

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
            buttonSetArrayLength.BackColor = Color.LightSteelBlue;
            buttonSetArrayLength.Enabled = true;
            numericSetArrayLength.Enabled = true;
            numericSetArrayLength.Value = 0;
            textBoxInputArrayValue.Text = "";
            arrayCounterReady = false;
            HideArrayValueCounter();
            buttonInputIntoArray.BackColor = Color.DarkGray;
            buttonInputIntoArray.Enabled = false;
            textBoxInputArrayValue.Enabled = false;
            arrayLength = 0;
        }



        private void buttonInputIntoArray_Click(object sender, EventArgs e)
        {

            try
            {
                int arrayValue = Convert.ToInt32(textBoxInputArrayValue.Text);

                if (arrayValues == null)
                {
                    MessageBox.Show("Please input a whole number into the array");
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
            buttonResetArray.Visible = false;
            buttonSetArrayLength.BackColor = Color.LightSteelBlue;
            buttonSetArrayLength.Enabled = true;
            numericSetArrayLength.Enabled = true;
            numericSetArrayLength.Value = 0;
            textBoxInputArrayValue.Text = "";
            arrayCounterReady = false;
            HideArrayValueCounter();
            buttonInputIntoArray.BackColor = Color.DarkGray;
            buttonInputIntoArray.Enabled = false;
            textBoxInputArrayValue.Enabled = false;

            labelArray.Text = $"{ShowArray()}";

            ArrayOfNumbers array_of_numbers = new ArrayOfNumbers(arrayValues);

            EnableMethodButtons();
        }

        private void FormArrayOfNumbers_Load(object sender, EventArgs e)
        {

        }

        private void labelArrayDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
