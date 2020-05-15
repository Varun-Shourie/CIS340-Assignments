using System;

namespace A7vshourie
{
    public class Book
    {

        // Characteristics of a book which are of interest to the library.
        private string bookTitle;
        private int publicationYear;

        // In place just in case the user does not provide any input. 
        public Book()
        {

        }

        // Uses the setter since the library system must comply with any possible business rules provided. Refer to
        // setters for any potential business rules.
        public Book(string bookTitle, int publicationYear)
        {
            SetBookTitle(bookTitle);
            SetPublicationYear(publicationYear);
        }

        // Uses the setter since the library system must comply with any possible business rules provided.
        public Book(int publicationYear, string bookTitle)
        {
            SetPublicationYear(publicationYear);
            SetBookTitle(bookTitle);
        }

        public string GetBookTitle()
        {
            return bookTitle;
        }

        public int GetPublicationYear()
        {
            return publicationYear;
        }

        public void SetBookTitle(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }

        // A book can only have a publication year between 1100 and 2017; if it doesn't, then the book
        // automatically assumes a publication year of 1900.
        public void SetPublicationYear(int publicationYear)
        {
            if (publicationYear >= 1100 && publicationYear <= 2017)
                this.publicationYear = publicationYear;
            else
                this.publicationYear = 1900;
        }
    }
}
