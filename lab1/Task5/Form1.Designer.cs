namespace Task5
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
            Sort = new Button();
            bubblesort = new ListBox();
            SuspendLayout();
            // 
            // Sort
            // 
            Sort.Location = new Point(182, 73);
            Sort.Name = "Sort";
            Sort.Size = new Size(75, 23);
            Sort.TabIndex = 5;
            Sort.Text = "button1";
            Sort.UseVisualStyleBackColor = true;
            // 
            // bubblesort
            // 
            bubblesort.FormattingEnabled = true;
            bubblesort.ItemHeight = 15;
            bubblesort.Location = new Point(263, 73);
            bubblesort.Name = "bubblesort";
            bubblesort.Size = new Size(270, 199);
            bubblesort.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sort);
            Controls.Add(bubblesort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Sort;
        private ListBox bubblesort;
    }
}
