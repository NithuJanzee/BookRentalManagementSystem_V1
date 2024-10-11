using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class EBook : Book
    {
        private int fileSize;
        private string format;

        public int FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }

        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        public EBook(string bookID, string title, string author, decimal rentalPrice, int fileSize, string format)
            : base(bookID, title, author, rentalPrice)
        {
            FileSize = fileSize;
            Format = format;
        }

        public override string ToString()
        {
            return base.ToString() + $" FileSize: {FileSize} Format: {Format}";
        }

        public void DisplayDigitalBookInfo()
        {
            Console.WriteLine("Digital Book Information:");
            Console.WriteLine(base.ToString());
            Console.WriteLine($"FileSize: {FileSize} Format: {Format}");
        }
    }
}
