using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace A7vshourie
{
    class LibrarySystem
    {

        // Stores a list of all books and their characteristics.
        private Book temporaryBook;
        private ArrayList bookList;

        // Stores the count of books the user wishes to input.
        private int bookCount;

        // Only initializes the ArrayList because the book object should be instantiated only when a book is added.
        public LibrarySystem()
        {
            bookList = new ArrayList();
        }

        // Asks for information about one book and adds it to the ArrayList.
        public void AddBook()
        {
            string bookTitle = "";
            int publicationYear = 0;

            Write("Enter Book Title: ");
            bookTitle = ReadLine();

            Write("Enter Book Year: ");
            publicationYear = Convert.ToInt32(ReadLine());

            temporaryBook = new Book(bookTitle, publicationYear);
            bookList.Add(temporaryBook);

            Write("Title '{0}' added to the library.\n", temporaryBook.GetBookTitle());
        }

        // Loops through the list of books, displays books' names and publication year in a neat column.
        public void DisplayBookList()
        {
            DisplayHeader();
            Write("{0, -70} {1, -4}\n", "Book Title", "Year");

            foreach (Book b in bookList)
            {
                Write("{0, -70} {1, -4}\n", b.GetBookTitle(), b.GetPublicationYear());
            }
        }

        public void DisplayHeader()
        {
            Write("\t\t\tNew Library System\n\n\n");
        }

        // Asks the user for the number of books needed, executes the menu, and displays the list of books.
        public void LoadLibrarySystem()
        {
            DisplayHeader();

            Write("How many new books do you want to add to the library? ");
            bookCount = Convert.ToInt32(ReadLine());

            Write("\n");

            // Allows the user to input as many books as they wish.
            for (int i = 0; i < bookCount; i++)
                AddBook();

            Write("\n");

            Write("Adding books complete. Press enter to continue.\n");
            ReadLine();
            Console.Clear();

            DisplayBookList();
        }

        public static void Main(string[] args)
        {
            LibrarySystem librarySystem = new LibrarySystem();
            librarySystem.LoadLibrarySystem();
        }
    }
}
