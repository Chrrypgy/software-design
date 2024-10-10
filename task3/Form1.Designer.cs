namespace task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFibonacciInput = new TextBox();
            btnCalculatePower = new Button();
            lblPowerResult = new Label();
            txtExponent = new TextBox();
            txtBase = new TextBox();
            btnCalculateFibonacci = new Button();
            lblFibonacciResult = new Label();
            SuspendLayout();
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(66, 50);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(420, 31);
            txtFibonacciInput.TabIndex = 0;
            txtFibonacciInput.Text = "Fibonacci Input";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(536, 164);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(112, 34);
            btnCalculatePower.TabIndex = 1;
            btnCalculatePower.Text = "Power";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += button1_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(66, 207);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(121, 25);
            lblPowerResult.TabIndex = 2;
            lblPowerResult.Text = "Power Result: ";
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(303, 164);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(183, 31);
            txtExponent.TabIndex = 3;
            txtExponent.Text = "Exponent";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(66, 164);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(210, 31);
            txtBase.TabIndex = 4;
            txtBase.Text = "Base";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(536, 47);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(112, 34);
            btnCalculateFibonacci.TabIndex = 5;
            btnCalculateFibonacci.Text = "Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(66, 84);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(147, 25);
            lblFibonacciResult.TabIndex = 6;
            lblFibonacciResult.Text = "Fibonacci Result: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtBase);
            Controls.Add(txtExponent);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(txtFibonacciInput);
            Name = "Form1";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFibonacciInput;
        private Button btnCalculatePower;
        private Label lblPowerResult;
        private TextBox txtExponent;
        private TextBox txtBase;
        private Button btnCalculateFibonacci;
        private Label lblFibonacciResult;
    }
}
