using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Book
    {
        private string BookId;
        private string Title;
        private string Author;
        private decimal RentalPrice;

        public Book(string bookID , string title , string author , decimal rentalPrice)
        {
            BookId = bookID;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }
    }
}
