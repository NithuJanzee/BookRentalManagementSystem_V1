using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Book
    {
        public string BookId;
        public string Title;
        public string Author;
        public decimal RentalPrice;

        public Book(string bookID , string title , string author , decimal rentalPrice)
        {
            BookId = bookID;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"Book ID : {BookId} Title : {Title} Author : {Author} RentalPrice {RentalPrice}";
        }
    }
}
