using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Book
    {
        private string bookId;
        private string title;
        private string author;
        private decimal rentalPrice;
        public int TotalBook { get; private set; }
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set
            {
                author = value;
            }
        }

        public decimal RentalPrice
        {
            get { return rentalPrice; }
            set { rentalPrice = value; }
        }

        public Book(string bookID, string title, string author, decimal rentalPrice)
        {
            BookId = bookID;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }

        public Book()
        {
            TotalBook++;
        }

        public override string ToString()
        {
            return $"Book ID : {BookId} Title : {Title} Author : {Author} RentalPrice {RentalPrice}";
        }

       

    }
}
