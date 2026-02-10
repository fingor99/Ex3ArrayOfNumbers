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
        }

        private void buttonInputIntoArray_Click(object sender, EventArgs e)
        {
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
        }
    }
}
