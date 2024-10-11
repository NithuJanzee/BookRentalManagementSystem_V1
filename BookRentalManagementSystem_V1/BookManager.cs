using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        List<Book> books = new List<Book>();
        //add Book
        public void CreateBook(Book book)
        {
            try
            {
                books.Add(book);
                Console.WriteLine("Book Added succesfuly");

            }
            catch (Exception ex)
            {

                Console.WriteLine("cannot add");
            }
        }

        //Read book
        public void ReadBooks()
        {
            try
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("Books not found");
                }
                else
                {
                    foreach (var item in books)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Books not found");
            }
        }

        //Update book
        public void UpdateBook(string bookId, string title, string author, decimal rentalPrice)
        {
            var findBook = books.Find(b => b.BookId == bookId);
            if (findBook != null)
            {
                findBook.Title = title;
                findBook.Author = author;
                findBook.RentalPrice = rentalPrice;
            }
            else
            {
                Console.WriteLine("Book Not found");
            }
        }

        //Delete Book
        public void DeleteBook(string bookId)
        {

            var findBook = books.Find(b => b.BookId == bookId);
            if (findBook != null)
            {
                books.Remove(findBook);
                Console.WriteLine("Book removed successfully");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}

