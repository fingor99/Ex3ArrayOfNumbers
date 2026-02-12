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

        private void showArrayValueCounter()
        {
            labelArrayAmountInput.Visible = true;
            label1.Visible = true;
            labelArrayCapacity.Visible = true;
        }

        private void hideArrayValueCounter()
        {
            labelArrayAmountInput.Visible = false;
            label1.Visible = false;
            labelArrayCapacity.Visible = false;
        }

        private void checkIfArrayFull()
        {
            if (arrayIndex == arrayValues.Length)
            {
                buttonInputIntoArray.Enabled = false;
                buttonInputIntoArray.BackColor = Color.DarkGray;
            }
        }

        private string showArray()
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input, please input a positive, whole integer");
                return;
            }

            if (arrayCounterReady == false)
            {
                showArrayValueCounter();
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
            hideArrayValueCounter();
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
                checkIfArrayFull();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid input");
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
            hideArrayValueCounter();
            buttonInputIntoArray.BackColor = Color.DarkGray;
            buttonInputIntoArray.Enabled = false;
            textBoxInputArrayValue.Enabled = false;

            labelArray.Text = $"{showArray()}";
        }

        private void FormArrayOfNumbers_Load(object sender, EventArgs e)
        {

        }

        private void labelArrayDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
