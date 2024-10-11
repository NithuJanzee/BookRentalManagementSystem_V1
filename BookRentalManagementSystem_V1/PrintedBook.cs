using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class PrintedBook : Book
    {
        private string isbn;
        private int numberOfPages;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        public PrintedBook(string bookID, string title, string author, decimal rentalPrice, string isbn, int numberOfPages)
            : base(bookID, title, author, rentalPrice)
        {
            ISBN = isbn;
            NumberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            return base.ToString() + $" ISBN: {ISBN} NumberOfPages: {NumberOfPages}";
        }
        public void DisplayPrintedBookInfo()
        {
            Console.WriteLine("Printed Book Information:");
            Console.WriteLine(base.ToString());
            Console.WriteLine($"ISBN: {ISBN} NumberOfPages: {NumberOfPages}");
        }
    }
}
