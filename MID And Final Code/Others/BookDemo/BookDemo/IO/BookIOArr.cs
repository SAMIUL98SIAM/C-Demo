using System;
using System.Collections.Generic;
using System.Text;
using BookDemo.AllData;
namespace BookDemo.IO
{
    class BookIOArr : BookParentIO
    {
        private const int TOTAL_BOOK_SENSOR = 3;
        BookData[] book_arr_data = new BookData[TOTAL_BOOK_SENSOR];
        BookData book;
        protected override void collectBookData()
        {
            for (int i = 0; i < TOTAL_BOOK_SENSOR; i++)
            {
                Console.WriteLine("Enter the Book Name {0}", i);
                book.bookName = Console.ReadLine();
                Console.WriteLine("Enter the Book Title {0} (DR/STR/NVL)", i);
                String inp_type = Console.ReadLine();
                if (inp_type == "DR")
                {
                    book.book_title = bookTitle.DARK;
                }
                if (inp_type == "STR")
                {
                    book.book_title = bookTitle.STORY;
                }
                if (inp_type == "NVL")
                {
                    book.book_title = bookTitle.NOVEL;
                }
                Console.WriteLine("Enter the Book Author Name {0} ", i);
                book.authorName = Console.ReadLine();
                Console.WriteLine("Enter the Book Quantity {0} ", i);
                book.bookQuantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Book Price {0} ", i);
                book.bookPrice = double.Parse(Console.ReadLine());
                book_arr_data[i] = book;
            }
        }
        protected override void addQuantity(int bookQuantity)
        {
            this.book.bookQuantity += bookQuantity;
        }
        protected override void sellQuantity(int bookQuantity)
        {
            this.book.bookQuantity -= bookQuantity;
        }
            public override void showDetails()
            {
                collectBookData();
                double total_price = 0.00;
                for(int i=0;i<TOTAL_BOOK_SENSOR;i++)
                {
                    Console.WriteLine("Book Name: " + book_arr_data[i].bookName);
                    Console.WriteLine("Author Name: " + book_arr_data[i].authorName);
                    Console.WriteLine("Book Title: " + book_arr_data[i].book_title);
                    Console.WriteLine("Book Quantity: " + book_arr_data[i].bookQuantity);
                    Console.WriteLine("Book Price: " + book_arr_data[i].bookPrice);
                    total_price += book_arr_data[i].bookPrice*book_arr_data[i].bookQuantity;
                }
                Console.WriteLine("Total price: "+total_price);

            } 
        }
    }
