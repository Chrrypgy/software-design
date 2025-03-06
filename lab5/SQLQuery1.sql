CREATE TABLE Author (
    AuthorID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL	
);

CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,  -- Fixed typo in NVARCHAR
    AuthorID INT FOREIGN KEY REFERENCES Author(AuthorID)  -- Fixed table reference
);
