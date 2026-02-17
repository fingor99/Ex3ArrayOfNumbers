namespace Ex3ArrayOfNumbers
{
    partial class FormArrayOfNumbers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInputArrayDesc = new System.Windows.Forms.Label();
            this.buttonSetArrayLength = new System.Windows.Forms.Button();
            this.numericSetArrayLength = new System.Windows.Forms.NumericUpDown();
            this.buttonResetArray = new System.Windows.Forms.Button();
            this.labelInputArrayValue = new System.Windows.Forms.Label();
            this.textBoxInputArrayValue = new System.Windows.Forms.TextBox();
            this.buttonInputIntoArray = new System.Windows.Forms.Button();
            this.labelArrayAmountInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelArrayCapacity = new System.Windows.Forms.Label();
            this.buttonSetArray = new System.Windows.Forms.Button();
            this.labelArrayDesc = new System.Windows.Forms.Label();
            this.labelArray = new System.Windows.Forms.Label();
            this.buttonToString = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonGCD = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericSetArrayLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInputArrayDesc
            // 
            this.labelInputArrayDesc.AutoSize = true;
            this.labelInputArrayDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelInputArrayDesc.Location = new System.Drawing.Point(144, 25);
            this.labelInputArrayDesc.Name = "labelInputArrayDesc";
            this.labelInputArrayDesc.Size = new System.Drawing.Size(179, 20);
            this.labelInputArrayDesc.TabIndex = 0;
            this.labelInputArrayDesc.Text = "Enter your array length";
            // 
            // buttonSetArrayLength
            // 
            this.buttonSetArrayLength.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSetArrayLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSetArrayLength.Location = new System.Drawing.Point(166, 120);
            this.buttonSetArrayLength.Name = "buttonSetArrayLength";
            this.buttonSetArrayLength.Size = new System.Drawing.Size(125, 59);
            this.buttonSetArrayLength.TabIndex = 1;
            this.buttonSetArrayLength.Text = "Set Array Length";
            this.buttonSetArrayLength.UseVisualStyleBackColor = false;
            this.buttonSetArrayLength.Click += new System.EventHandler(this.buttonSetArrayLength_Click);
            // 
            // numericSetArrayLength
            // 
            this.numericSetArrayLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numericSetArrayLength.Location = new System.Drawing.Point(166, 69);
            this.numericSetArrayLength.Name = "numericSetArrayLength";
            this.numericSetArrayLength.Size = new System.Drawing.Size(131, 26);
            this.numericSetArrayLength.TabIndex = 2;
            // 
            // buttonResetArray
            // 
            this.buttonResetArray.BackColor = System.Drawing.Color.IndianRed;
            this.buttonResetArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonResetArray.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResetArray.Location = new System.Drawing.Point(18, 69);
            this.buttonResetArray.Name = "buttonResetArray";
            this.buttonResetArray.Size = new System.Drawing.Size(107, 58);
            this.buttonResetArray.TabIndex = 3;
            this.buttonResetArray.Text = "Reset Array";
            this.buttonResetArray.UseVisualStyleBackColor = false;
            this.buttonResetArray.Visible = false;
            this.buttonResetArray.Click += new System.EventHandler(this.buttonResetArray_Click);
            // 
            // labelInputArrayValue
            // 
            this.labelInputArrayValue.AutoSize = true;
            this.labelInputArrayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelInputArrayValue.Location = new System.Drawing.Point(384, 25);
            this.labelInputArrayValue.Name = "labelInputArrayValue";
            this.labelInputArrayValue.Size = new System.Drawing.Size(182, 20);
            this.labelInputArrayValue.TabIndex = 4;
            this.labelInputArrayValue.Text = "Enter your array values";
            // 
            // textBoxInputArrayValue
            // 
            this.textBoxInputArrayValue.Enabled = false;
            this.textBoxInputArrayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxInputArrayValue.Location = new System.Drawing.Point(388, 69);
            this.textBoxInputArrayValue.Name = "textBoxInputArrayValue";
            this.textBoxInputArrayValue.Size = new System.Drawing.Size(178, 26);
            this.textBoxInputArrayValue.TabIndex = 5;
            // 
            // buttonInputIntoArray
            // 
            this.buttonInputIntoArray.BackColor = System.Drawing.Color.DarkGray;
            this.buttonInputIntoArray.Enabled = false;
            this.buttonInputIntoArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonInputIntoArray.Location = new System.Drawing.Point(413, 120);
            this.buttonInputIntoArray.Name = "buttonInputIntoArray";
            this.buttonInputIntoArray.Size = new System.Drawing.Size(125, 59);
            this.buttonInputIntoArray.TabIndex = 6;
            this.buttonInputIntoArray.Text = "Input Into Array";
            this.buttonInputIntoArray.UseVisualStyleBackColor = false;
            this.buttonInputIntoArray.Click += new System.EventHandler(this.buttonInputIntoArray_Click);
            // 
            // labelArrayAmountInput
            // 
            this.labelArrayAmountInput.AutoSize = true;
            this.labelArrayAmountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelArrayAmountInput.Location = new System.Drawing.Point(640, 35);
            this.labelArrayAmountInput.Name = "labelArrayAmountInput";
            this.labelArrayAmountInput.Size = new System.Drawing.Size(18, 20);
            this.labelArrayAmountInput.TabIndex = 7;
            this.labelArrayAmountInput.Text = "0";
            this.labelArrayAmountInput.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(635, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Of";
            this.label1.Visible = false;
            // 
            // labelArrayCapacity
            // 
            this.labelArrayCapacity.AutoSize = true;
            this.labelArrayCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelArrayCapacity.Location = new System.Drawing.Point(640, 107);
            this.labelArrayCapacity.Name = "labelArrayCapacity";
            this.labelArrayCapacity.Size = new System.Drawing.Size(18, 20);
            this.labelArrayCapacity.TabIndex = 9;
            this.labelArrayCapacity.Text = "0";
            this.labelArrayCapacity.Visible = false;
            // 
            // buttonSetArray
            // 
            this.buttonSetArray.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSetArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSetArray.Location = new System.Drawing.Point(695, 68);
            this.buttonSetArray.Name = "buttonSetArray";
            this.buttonSetArray.Size = new System.Drawing.Size(125, 59);
            this.buttonSetArray.TabIndex = 10;
            this.buttonSetArray.Text = "Set Array";
            this.buttonSetArray.UseVisualStyleBackColor = false;
            this.buttonSetArray.Click += new System.EventHandler(this.buttonSetArray_Click);
            // 
            // labelArrayDesc
            // 
            this.labelArrayDesc.AutoSize = true;
            this.labelArrayDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelArrayDesc.Location = new System.Drawing.Point(26, 311);
            this.labelArrayDesc.Name = "labelArrayDesc";
            this.labelArrayDesc.Size = new System.Drawing.Size(54, 20);
            this.labelArrayDesc.TabIndex = 11;
            this.labelArrayDesc.Text = "Array:";
            this.labelArrayDesc.Click += new System.EventHandler(this.labelArrayDesc_Click);
            // 
            // labelArray
            // 
            this.labelArray.AutoSize = true;
            this.labelArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelArray.Location = new System.Drawing.Point(92, 311);
            this.labelArray.Name = "labelArray";
            this.labelArray.Size = new System.Drawing.Size(0, 20);
            this.labelArray.TabIndex = 12;
            // 
            // buttonToString
            // 
            this.buttonToString.BackColor = System.Drawing.Color.DarkGray;
            this.buttonToString.Enabled = false;
            this.buttonToString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonToString.Location = new System.Drawing.Point(12, 209);
            this.buttonToString.Name = "buttonToString";
            this.buttonToString.Size = new System.Drawing.Size(125, 59);
            this.buttonToString.TabIndex = 13;
            this.buttonToString.Text = "Output Array To String";
            this.buttonToString.UseVisualStyleBackColor = false;
            this.buttonToString.Click += new System.EventHandler(this.buttonToString_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMax.Enabled = false;
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonMax.Location = new System.Drawing.Point(105, 406);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(93, 59);
            this.buttonMax.TabIndex = 14;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonGCD
            // 
            this.buttonGCD.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGCD.Enabled = false;
            this.buttonGCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonGCD.Location = new System.Drawing.Point(145, 701);
            this.buttonGCD.Name = "buttonGCD";
            this.buttonGCD.Size = new System.Drawing.Size(93, 59);
            this.buttonGCD.TabIndex = 15;
            this.buttonGCD.Text = "Get GCD";
            this.buttonGCD.UseVisualStyleBackColor = false;
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCount.Enabled = false;
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonCount.Location = new System.Drawing.Point(288, 406);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(93, 59);
            this.buttonCount.TabIndex = 16;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSum.Enabled = false;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSum.Location = new System.Drawing.Point(469, 406);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(93, 59);
            this.buttonSum.TabIndex = 17;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAverage.Enabled = false;
            this.buttonAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonAverage.Location = new System.Drawing.Point(644, 406);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(93, 59);
            this.buttonAverage.TabIndex = 18;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = false;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax.AutoEllipsis = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelMax.Location = new System.Drawing.Point(105, 499);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(93, 31);
            this.labelMax.TabIndex = 19;
            this.labelMax.Text = "0";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.AutoEllipsis = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelCount.Location = new System.Drawing.Point(288, 499);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(93, 31);
            this.labelCount.TabIndex = 21;
            this.labelCount.Text = "0";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // labelSum
            // 
            this.labelSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSum.AutoEllipsis = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelSum.Location = new System.Drawing.Point(469, 499);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(93, 31);
            this.labelSum.TabIndex = 22;
            this.labelSum.Text = "0";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAverage
            // 
            this.labelAverage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAverage.AutoEllipsis = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelAverage.Location = new System.Drawing.Point(644, 499);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(93, 31);
            this.labelAverage.TabIndex = 23;
            this.labelAverage.Text = "0";
            this.labelAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(41, 638);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 26);
            this.numericUpDown1.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numericUpDown2.Location = new System.Drawing.Point(226, 638);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(131, 26);
            this.numericUpDown2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(37, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Find the GCD of two numbers in your array :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(145, 793);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormArrayOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 876);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonGCD);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonToString);
            this.Controls.Add(this.labelArray);
            this.Controls.Add(this.labelArrayDesc);
            this.Controls.Add(this.buttonSetArray);
            this.Controls.Add(this.labelArrayCapacity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelArrayAmountInput);
            this.Controls.Add(this.buttonInputIntoArray);
            this.Controls.Add(this.textBoxInputArrayValue);
            this.Controls.Add(this.labelInputArrayValue);
            this.Controls.Add(this.buttonResetArray);
            this.Controls.Add(this.numericSetArrayLength);
            this.Controls.Add(this.buttonSetArrayLength);
            this.Controls.Add(this.labelInputArrayDesc);
            this.Name = "FormArrayOfNumbers";
            this.Text = "Array of Numbers";
            this.Load += new System.EventHandler(this.FormArrayOfNumbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSetArrayLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputArrayDesc;
        private System.Windows.Forms.Button buttonSetArrayLength;
        private System.Windows.Forms.NumericUpDown numericSetArrayLength;
        private System.Windows.Forms.Button buttonResetArray;
        private System.Windows.Forms.Label labelInputArrayValue;
        private System.Windows.Forms.TextBox textBoxInputArrayValue;
        private System.Windows.Forms.Button buttonInputIntoArray;
        private System.Windows.Forms.Label labelArrayAmountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelArrayCapacity;
        private System.Windows.Forms.Button buttonSetArray;
        private System.Windows.Forms.Label labelArrayDesc;
        private System.Windows.Forms.Label labelArray;
        private System.Windows.Forms.Button buttonToString;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonGCD;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

