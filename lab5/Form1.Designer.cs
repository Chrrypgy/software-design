namespace lab5
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
            txtAuthorName = new TextBox();
            btnAddbook = new Button();
            listBoxBooks = new ListBox();
            txtBookTitle = new TextBox();
            btnshowbooks = new Button();
            txtBookID = new TextBox();
            label1 = new Label();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnSearchBooks = new Button();
            SearchBooksByAuthor = new TextBox();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(0, 12);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(150, 31);
            txtAuthorName.TabIndex = 0;
            txtAuthorName.TextChanged += textBox1_TextChanged;
            // 
            // btnAddbook
            // 
            btnAddbook.Location = new Point(24, 71);
            btnAddbook.Name = "btnAddbook";
            btnAddbook.Size = new Size(112, 34);
            btnAddbook.TabIndex = 1;
            btnAddbook.Text = "Add Books";
            btnAddbook.UseVisualStyleBackColor = true;
            btnAddbook.Click += btnAddbook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 25;
            listBoxBooks.Location = new Point(24, 127);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(180, 129);
            listBoxBooks.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(221, 12);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(150, 31);
            txtBookTitle.TabIndex = 3;
            // 
            // btnshowbooks
            // 
            btnshowbooks.Location = new Point(221, 61);
            btnshowbooks.Name = "btnshowbooks";
            btnshowbooks.Size = new Size(112, 34);
            btnshowbooks.TabIndex = 4;
            btnshowbooks.Text = "Show Info\r\n";
            btnshowbooks.UseVisualStyleBackColor = true;
            btnshowbooks.Click += btnshowbooks_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(24, 323);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(150, 31);
            txtBookID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 295);
            label1.Name = "label1";
            label1.Size = new Size(310, 25);
            label1.TabIndex = 6;
            label1.Text = "Update Book and Author Information";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(210, 321);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(112, 34);
            btnUpdateBook.TabIndex = 7;
            btnUpdateBook.Text = "Update Books";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(245, 198);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(112, 34);
            btnDeleteBook.TabIndex = 8;
            btnDeleteBook.Text = "Delete Books";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(363, 198);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(112, 34);
            btnSearchBooks.TabIndex = 9;
            btnSearchBooks.Text = "Search Books";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // SearchBooksByAuthor
            // 
            SearchBooksByAuthor.Location = new Point(245, 161);
            SearchBooksByAuthor.Name = "SearchBooksByAuthor";
            SearchBooksByAuthor.Size = new Size(230, 31);
            SearchBooksByAuthor.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBooksByAuthor);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(label1);
            Controls.Add(txtBookID);
            Controls.Add(btnshowbooks);
            Controls.Add(txtBookTitle);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddbook);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private Button btnAddbook;
        private ListBox listBoxBooks;
        private TextBox txtBookTitle;
        private Button btnshowbooks;
        private TextBox txtBookID;
        private Label label1;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Button btnSearchBooks;
        private TextBox SearchBooksByAuthor;
    }
}
