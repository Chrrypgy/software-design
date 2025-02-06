namespace lab1
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
            listBoxResults = new ListBox();
            Sort = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(235, 69);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(270, 199);
            listBoxResults.TabIndex = 0;
            // 
            // Sort
            // 
            Sort.Location = new Point(154, 69);
            Sort.Name = "Sort";
            Sort.Size = new Size(75, 23);
            Sort.TabIndex = 1;
            Sort.Text = "button1";
            Sort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sort);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Lab1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button Sort;
    }
}
