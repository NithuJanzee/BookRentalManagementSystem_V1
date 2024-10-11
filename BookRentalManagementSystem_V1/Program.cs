using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("BOOK_001", "PONNIYIN SELVAN", "kalki", 10.00m);
            Console.WriteLine(book1);
            Console.ReadLine();
            BookManager bookManager = new BookManager();
            int choise;

            do
            {
                Console.WriteLine("\nBook Rental System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. view All book");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Exit");
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        string bookId = Console.ReadLine();
                        Console.Write("Enter Title: ");
                        string Title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        decimal rentalPrice = Convert.ToDecimal(Console.ReadLine());
                        Book book = new Book(bookId, Title, author, rentalPrice);
                        bookManager.CreateBook(book);
                        break;

                    case 2:
                        bookManager.ReadBooks();

                        break;

                    case 3:
                        Console.Write("Enter Book Id: ");
                        string bookid = Console.ReadLine();
                        Console.Write("enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Ener Author: ");
                        string authorr = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());
                        bookManager.UpdateBook(bookid, title, authorr, price);

                        break;

                        case 4:
                        Console.Write("Enter Id: ");
                        string boookid= Console.ReadLine();
                        bookManager.DeleteBook(boookid);
                        break;

                    case 5:
                        Console.WriteLine("Exiting....!");
                        break;
                    default:
                        Console.WriteLine("\n Invalid Input \n");
                        break;
                }


            } while (choise != 5);
        }
    }
}
