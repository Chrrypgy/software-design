
namespace lab6
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            btnAddBook = new Button();
            txtBookTitle = new TextBox();
            txtUpdateBookID = new TextBox();
            txtUpdateBookTitle = new TextBox();
            txtUpdateAuthorName = new TextBox();
            btnUpdateBook = new Button();
            txtDeleteBookID = new TextBox();
            btnDeleteBook = new Button();
            progressBar = new ProgressBar();
            txtSearchBookTitle = new TextBox();
            btnSearchBook = new Button();
            lblPageNumber = new Label();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(198, 12);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(112, 34);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Book";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 25;
            listBoxBooks.Location = new Point(765, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(564, 504);
            listBoxBooks.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(25, 161);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(150, 31);
            txtAuthorName.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(357, 161);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(112, 34);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click_1;
       
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(181, 161);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(150, 31);
            txtBookTitle.TabIndex = 4;
            // 
            // txtUpdateBookID
            // 
            txtUpdateBookID.Location = new Point(25, 259);
            txtUpdateBookID.Name = "txtUpdateBookID";
            txtUpdateBookID.Size = new Size(150, 31);
            txtUpdateBookID.TabIndex = 5;
            // 
            // txtUpdateBookTitle
            // 
            txtUpdateBookTitle.Location = new Point(229, 259);
            txtUpdateBookTitle.Name = "txtUpdateBookTitle";
            txtUpdateBookTitle.Size = new Size(150, 31);
            txtUpdateBookTitle.TabIndex = 6;
            // 
            // txtUpdateAuthorName
            // 
            txtUpdateAuthorName.Location = new Point(436, 259);
            txtUpdateAuthorName.Name = "txtUpdateAuthorName";
            txtUpdateAuthorName.Size = new Size(150, 31);
            txtUpdateAuthorName.TabIndex = 7;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(647, 259);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(112, 34);
            btnUpdateBook.TabIndex = 8;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // txtDeleteBookID
            // 
            txtDeleteBookID.Location = new Point(229, 334);
            txtDeleteBookID.Name = "txtDeleteBookID";
            txtDeleteBookID.Size = new Size(150, 31);
            txtDeleteBookID.TabIndex = 9;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(647, 322);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(112, 34);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(25, 334);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(150, 34);
            progressBar.TabIndex = 11;
            // 
            // txtSearchBookTitle
            // 
            txtSearchBookTitle.Location = new Point(25, 405);
            txtSearchBookTitle.Name = "txtSearchBookTitle";
            txtSearchBookTitle.Size = new Size(150, 31);
            txtSearchBookTitle.TabIndex = 12;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(647, 402);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(112, 34);
            btnSearchBook.TabIndex = 13;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(1044, 555);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(59, 25);
            lblPageNumber.TabIndex = 14;
            lblPageNumber.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 669);
            Controls.Add(lblPageNumber);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearchBookTitle);
            Controls.Add(progressBar);
            Controls.Add(btnDeleteBook);
            Controls.Add(txtDeleteBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtUpdateAuthorName);
            Controls.Add(txtUpdateBookTitle);
            Controls.Add(txtUpdateBookID);
            Controls.Add(txtBookTitle);
            Controls.Add(btnAddBook);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnFetchBooks_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private Button btnAddBook;
        private TextBox txtBookTitle;
        private TextBox txtUpdateBookID;
        private TextBox txtUpdateBookTitle;
        private TextBox txtUpdateAuthorName;
        private Button btnUpdateBook;
        private TextBox txtDeleteBookID;
        private Button btnDeleteBook;
        private ProgressBar progressBar;
        private TextBox txtSearchBookTitle;
        private Button btnSearchBook;
        private Label lblPageNumber;
    }
}
