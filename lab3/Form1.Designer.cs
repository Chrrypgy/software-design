namespace lab3
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
            btnshowInfo = new Button();
            listBox1 = new ListBox();
            Task3 = new Button();
            SuspendLayout();
            // 
            // btnshowInfo
            // 
            btnshowInfo.Location = new Point(261, 202);
            btnshowInfo.Name = "btnshowInfo";
            btnshowInfo.Size = new Size(112, 34);
            btnshowInfo.TabIndex = 0;
            btnshowInfo.Text = "Show Info";
            btnshowInfo.UseVisualStyleBackColor = true;
            btnshowInfo.Click += btnshowInfo_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Book ", "Magazine", "Ebook" });
            listBox1.Location = new Point(137, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 129);
            listBox1.TabIndex = 2;
            // 
            // Task3
            // 
            Task3.Location = new Point(261, 274);
            Task3.Name = "Task3";
            Task3.Size = new Size(112, 34);
            Task3.TabIndex = 3;
            Task3.Text = "Task 3";
            Task3.UseVisualStyleBackColor = true;
            Task3.Click += Task3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Task3);
            Controls.Add(listBox1);
            Controls.Add(btnshowInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnshowInfo;
        private ListBox listBox1;
        private Button Task3;
    }
}
