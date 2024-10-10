namespace lab2
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
            Factorial = new Button();
            lblresult = new Label();
            txtinput = new TextBox();
            sum = new TextBox();
            resultsum = new Label();
            clcsum = new Button();
            task3 = new Button();
            SuspendLayout();
            // 
            // Factorial
            // 
            Factorial.Location = new Point(522, 71);
            Factorial.Name = "Factorial";
            Factorial.Size = new Size(112, 34);
            Factorial.TabIndex = 0;
            Factorial.Text = "Factorial";
            Factorial.UseVisualStyleBackColor = true;
            Factorial.Click += Factorial_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(29, 117);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(129, 25);
            lblresult.TabIndex = 1;
            lblresult.Text = "Result Factorial";
            // 
            // txtinput
            // 
            txtinput.Location = new Point(29, 74);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(476, 31);
            txtinput.TabIndex = 2;
            // 
            // sum
            // 
            sum.Location = new Point(29, 196);
            sum.Name = "sum";
            sum.Size = new Size(476, 31);
            sum.TabIndex = 5;
            // 
            // resultsum
            // 
            resultsum.AutoSize = true;
            resultsum.Location = new Point(29, 239);
            resultsum.Name = "resultsum";
            resultsum.Size = new Size(100, 25);
            resultsum.TabIndex = 4;
            resultsum.Text = "Result Sum";
            // 
            // clcsum
            // 
            clcsum.Location = new Point(522, 193);
            clcsum.Name = "clcsum";
            clcsum.Size = new Size(112, 34);
            clcsum.TabIndex = 3;
            clcsum.Text = "Sum";
            clcsum.UseVisualStyleBackColor = true;
            clcsum.Click += clcsum_Click;
            // 
            // task3
            // 
            task3.Location = new Point(294, 285);
            task3.Name = "task3";
            task3.Size = new Size(112, 34);
            task3.TabIndex = 6;
            task3.Text = "Task3";
            task3.UseVisualStyleBackColor = true;
            task3.Click += task3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 414);
            Controls.Add(task3);
            Controls.Add(sum);
            Controls.Add(resultsum);
            Controls.Add(clcsum);
            Controls.Add(txtinput);
            Controls.Add(lblresult);
            Controls.Add(Factorial);
            Name = "Form1";
            Text = "Lab2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Factorial;
        private Label lblresult;
        private TextBox txtinput;
        private TextBox sum;
        private Label resultsum;
        private Button clcsum;
        private Button task3;
    }
}
