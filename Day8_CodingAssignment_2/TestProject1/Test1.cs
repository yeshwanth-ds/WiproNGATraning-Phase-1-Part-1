using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library_Management_System;
using System;
using System.Linq;

namespace TestProject1
{
    [TestClass]
    public class LibraryTests
    {
        private Library_Management library;

        [TestInitialize]
        public void SetUp()
        {
            library = new Library_Management();
        }

        [TestMethod]
        public void AddBook_ShouldAddBookToLibrary()
        {
            // Arrange
            string title = "Test Book";
            string author = "Test Author";
            string isbn = "12345";

            // Act
            library.AddBook(title, author, isbn);

            // Assert
            var book = library.Books.FirstOrDefault(b => b.ISBN == isbn);
            Assert.IsNotNull(book, "Book should be added to the library.");
            Assert.AreEqual(title, book.Title, "Book title does not match.");
            Assert.AreEqual(author, book.Author, "Book author does not match.");
        }

        [TestMethod]
        public void RegisterBorrower_ShouldRegisterBorrower()
        {
            // Arrange
            string name = "John Doe";
            string cardNumber = "ABC123";

            // Act
            library.RegisterBorrower(name, cardNumber);

            // Assert
            var borrower = library.Borrowers.FirstOrDefault(b => b.CardNumber == cardNumber);
            Assert.IsNotNull(borrower, "Borrower should be registered.");
            Assert.AreEqual(name, borrower.Name, "Borrower's name does not match.");
        }

        [TestMethod]
        public void BorrowBook_ShouldBorrowBookSuccessfully()
        {
            // Arrange
            string title = "Test Book";
            string author = "Test Author";
            string isbn = "12345";
            string cardNumber = "ABC123";

            library.AddBook(title, author, isbn);
            library.RegisterBorrower("John Doe", cardNumber);

            // Act
            library.BorrowBook(isbn, cardNumber);

            // Assert
            var book = library.Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = library.Borrowers.FirstOrDefault(b => b.CardNumber == cardNumber);
            Assert.IsTrue(book.IsBorrowed, "Book should be borrowed.");
            Assert.AreEqual(1, borrower.BorrowedBooks.Count, "Borrower should have one borrowed book.");
        }

        [TestMethod]
        public void ReturnBook_ShouldReturnBookSuccessfully()
        {
            // Arrange
            string title = "Test Book";
            string author = "Test Author";
            string isbn = "12345";
            string cardNumber = "ABC123";

            library.AddBook(title, author, isbn);
            library.RegisterBorrower("John Doe", cardNumber);

            // Borrow the book first
            library.BorrowBook(isbn, cardNumber);

            // Act
            library.ReturnBook(isbn, cardNumber);

            // Assert
            var book = library.Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = library.Borrowers.FirstOrDefault(b => b.CardNumber == cardNumber);
            Assert.IsFalse(book.IsBorrowed, "Book should be returned.");
            Assert.AreEqual(0, borrower.BorrowedBooks.Count, "Borrower should have no borrowed books.");
        }
    }
}
