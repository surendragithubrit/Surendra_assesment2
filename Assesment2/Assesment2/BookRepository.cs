using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{

    interface IRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int BookId);
        List<Book> GetBooksByName(string BookName);
        List<Book> GetBooksByAuthor(string Author);
        List<Book> GetBooksByAuthorAndPublisher(string Author, string Publisher);
        void AddBook(Book book);
        void UpdateBook(Book book);
    }

    class BookRepository : IRepository
    {
        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int bookId)
        {
            return books.FirstOrDefault(b => b.BookId == bookId);
        }

        public List<Book> GetBooksByName(string bookName)
        {
            return books;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return books.Where(b => b.Author.Equals(author.ToList());
        }

        public List<Book> GetBooksByAuthorAndPublisher(string author, string publisher)
        {
            return books.Where(b => b.Author.Equals(author.ToList()) && b.Publisher.Equals(publisher.ToList());

        }

       

        public void UpdateBook(Book book)
        {
            var eBook = GetBookById(book.BookId);
            if (eBook != null)
            {
                eBook.BookName = book.BookName;
                eBook.Price = book.Price;
                eBook.Author = book.Author;
                eBook.Publisher = book.Publisher;
            }
        }
        internal class FileHan {
            static void write(string path, string s)
            {
                using (StreamWriter sw = new StreamWriter(path, true)) {
                    sw.WriteLine(s);
                }

                static void Main()
                {
                    BookRepository bookRepository = new BookRepository();
                    try
                    {
                        do
                        {
                            Console.WriteLine("1.AddBook\n 2.GetAllBooks\n3.GetBookById\n4.GetBooksByName\n5.GetBooksByAuthor\n6.GetBooksByAuthor and Publusher\n7.Update\n8.exit");
                            int op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    {
                                        Book book = new Book();
                                        book.BookId = new Random().Next();
                                        book.BookName = Console.ReadLine();
                                        book.Author = Console.ReadLine();
                                        book.Price = int.Parse(Console.ReadLine());
                                        bookRepository.AddBook(book);
                                        FileHan.write("C:\\new\\demo3.txt", book.ToString());

                                    }
                                    break;

                                case 2:
                                    {
                                        List<Book> books = bookRepository.GetAllBooks();
                                        if (books.Count > 0)
                                        {
                                            foreach (Book b in books)
                                            {
                                                Console.WriteLine(b);
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("no books");
                                        }

                                    }
                                    break;

                                case 3:
                                    {
                                        int bookId = int.Parse(Console.ReadLine());
                                        Book book = bookRepository.GetBookById(bookId);
                                        if (book != null)
                                        {
                                            Console.WriteLine(book.ToString());

                                        }
                                        else
                                        {
                                            Console.WriteLine("invalid Id");
                                        }
                                    }
                                    break;
                                case 4:
                                    {

                                        Console.WriteLine("Enter Book Name:");
                                        string bookName = Console.ReadLine();
                                        List<Book> books = bookRepository.GetBooksByName(bookName);
                                        foreach (Book book in books)
                                        {
                                            Console.WriteLine(book);
                                        }

                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine("Enter Book Name:");
                                        string bookName = Console.ReadLine();
                                        List<Book> books = bookRepository.GetBooksByAuthor(bookName);
                                        foreach (Book book in books)
                                        {
                                            Console.WriteLine(book);
                                        }

                                    }
                                    break;
                                
                                   
                                case 6:
                                    {
                                        Console.WriteLine("update book");
                                        Book book = new Book();
                                        book.BookId = int.Parse(Console.ReadLine());
                                        book.BookName = Console.ReadLine();
                                        bookRepository.UpdateBook(book);
                                    }
                                    break;
                                case 7:
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                                default:
                                    {
                                        break;
                                    }




                            } while (true) ;




                        }
                    } catch (Exception ex) {

                        Console.WriteLine(ex.Message);
                    }

                }


            }
        }
    }
}

    

