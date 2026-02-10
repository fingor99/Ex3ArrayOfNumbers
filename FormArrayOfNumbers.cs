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
            buttonResetArray.Visible = true;
            buttonSetArrayLength.Enabled = false;
            buttonSetArrayLength.BackColor = Color.DarkGray;
            numericSetArrayLength.Enabled = false;
            buttonInputIntoArray.Enabled = true;
            buttonInputIntoArray.BackColor = Color.LightSteelBlue;
            buttonInputIntoArray.Enabled = true;
            textBoxInputArrayValue.Enabled = true;

            try
            {
                arrayLength = Convert.ToInt32(numericSetArrayLength.Value);

                if (arrayLength == 0)
                {
                    // show error message
                    return;
                }

                Array.Resize(ref arrayValues, arrayLength);
                arrayIndex = 0;
            }
            catch (Exception ex)
            {
                //
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
                    // show error message on form
                    return;
                }

                else if (arrayIndex >= arrayValues.Length)
                {
                    // show error message on form
                    return;
                }


                arrayValues[arrayIndex++] = arrayValue;

            }

            catch (Exception ex)
            {
                // show error message of form thats different
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
