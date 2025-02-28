using System;
using System.Collections.Generic;

namespace Library_Management_System
{
    public class Library_Management
    {
        public List<Book> Books = new List<Book>();
        public List<Borrower> Borrowers = new List<Borrower>();

        // Add a book to the library
        public void AddBook(string title, string author, string isbn)
        {
            Books.Add(new Book(title, author, isbn));
        }

        // Register a borrower
        public void RegisterBorrower(string name, string cardNumber)
        {
            Borrowers.Add(new Borrower(name, cardNumber));
        }

        // Borrow a book
        public void BorrowBook(string isbn, string cardNumber)
        {
            Book book = Books.Find(b => b.ISBN == isbn && !b.IsBorrowed);
            Borrower borrower = Borrowers.Find(b => b.CardNumber == cardNumber);

            if (book != null && borrower != null)
            {
                book.Borrow();
                borrower.BorrowBook(book);
                Console.WriteLine($"'{book.Title}' borrowed by {borrower.Name}.");
            }
            else
            {
                Console.WriteLine("Book is not available or borrower not found.");
            }
        }

        // Return a borrowed book
        public void ReturnBook(string isbn, string cardNumber)
        {
            Borrower borrower = Borrowers.Find(b => b.CardNumber == cardNumber);
            Book book = borrower?.BorrowedBooks.Find(b => b.ISBN == isbn);

            if (book != null)
            {
                book.Return();
                borrower.ReturnBook(book);
                Console.WriteLine($"'{book.Title}' returned by {borrower.Name}.");
            }
            else
            {
                Console.WriteLine("Invalid return attempt.");
            }
        }

        // Display books in the library
        public void ViewBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"'{book.Title}' by {book.Author} - {(book.IsBorrowed ? "Borrowed" : "Available")}");
            }
        }
    }

    // Book class to represent a book
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public bool IsBorrowed { get; private set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
        }

        public void Borrow() => IsBorrowed = true;
        public void Return() => IsBorrowed = false;
    }

    // Borrower class to represent a library borrower
    public class Borrower
    {
        public string Name { get; }
        public string CardNumber { get; }
        public List<Book> BorrowedBooks { get; } = new List<Book>();

        public Borrower(string name, string cardNumber)
        {
            Name = name;
            CardNumber = cardNumber;
        }

        public void BorrowBook(Book book) => BorrowedBooks.Add(book);
        public void ReturnBook(Book book) => BorrowedBooks.Remove(book);
    }
}
