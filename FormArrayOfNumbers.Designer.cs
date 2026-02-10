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
            ((System.ComponentModel.ISupportInitialize)(this.numericSetArrayLength)).BeginInit();
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
            this.textBoxInputArrayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxInputArrayValue.Location = new System.Drawing.Point(388, 69);
            this.textBoxInputArrayValue.Name = "textBoxInputArrayValue";
            this.textBoxInputArrayValue.Size = new System.Drawing.Size(178, 26);
            this.textBoxInputArrayValue.TabIndex = 5;
            // 
            // buttonInputIntoArray
            // 
            this.buttonInputIntoArray.BackColor = System.Drawing.Color.DarkGray;
            this.buttonInputIntoArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonInputIntoArray.Location = new System.Drawing.Point(413, 120);
            this.buttonInputIntoArray.Name = "buttonInputIntoArray";
            this.buttonInputIntoArray.Size = new System.Drawing.Size(125, 59);
            this.buttonInputIntoArray.TabIndex = 6;
            this.buttonInputIntoArray.Text = "Input Into Array";
            this.buttonInputIntoArray.UseVisualStyleBackColor = false;
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
            // 
            // labelArrayDesc
            // 
            this.labelArrayDesc.AutoSize = true;
            this.labelArrayDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelArrayDesc.Location = new System.Drawing.Point(24, 217);
            this.labelArrayDesc.Name = "labelArrayDesc";
            this.labelArrayDesc.Size = new System.Drawing.Size(54, 20);
            this.labelArrayDesc.TabIndex = 11;
            this.labelArrayDesc.Text = "Array:";
            // 
            // labelArray
            // 
            this.labelArray.AutoSize = true;
            this.labelArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelArray.Location = new System.Drawing.Point(78, 218);
            this.labelArray.Name = "labelArray";
            this.labelArray.Size = new System.Drawing.Size(0, 20);
            this.labelArray.TabIndex = 12;
            // 
            // FormArrayOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 616);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericSetArrayLength)).EndInit();
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
    }
}

