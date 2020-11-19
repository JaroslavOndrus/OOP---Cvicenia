using System;
using System.Collections.Generic;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine();

            Book LOTR = new Book("Nazov", 3);
            Console.WriteLine(LOTR.Title);*/

            /*Console.WriteLine("Zadajte nazov knihy: ");
            string title = Console.ReadLine();

            Console.WriteLine("Zadajte pocet stran: ");
            int pages = Int32.Parse(Console.ReadLine());
            if(pages < 0)
            {
                pages = 1;
            }

            Console.WriteLine("Zadajte kategoriu: ");
            string category = Console.ReadLine();

            Console.WriteLine("Zadajte autora: ");
            string author = Console.ReadLine();

            Console.WriteLine("Zadajte datum vydania knihy: ");
            int releaseDate = int.Parse(Console.ReadLine());
            if(releaseDate <= 1450 || releaseDate >= 2021)
            {
                releaseDate = -1;
            }

            Book LOTR = new Book(title, pages, category, author, releaseDate);
            Console.WriteLine($"{LOTR.Title} {LOTR.Pages} {LOTR.Category} {LOTR.Author} {LOTR.ReleaseDate}");*/

            /*Book LOTR2 = new Book();
            LOTR2.VypisInformacie();

            Book LOTR3 = new Book("nazov knihy", 158);
            LOTR3.VypisInformacie();

            Book HOBIT = new Book("HOBIT", 2, "fantasy", "autor hobita", 2009);
            HOBIT.VypisInformacie();*/

            Book HOBIT = new Book("Hobit", 2588, Book.categoryList[0], "Autor hobita", 2015);
            HOBIT.VypisInformacie();
        }
    }

    

    class Book
    {
        /// <summary>
        /// trojlomitkovyzapis
        /// </summary>
        public static List<string> categoryList = new List<string> {"detske", "romanticke", "naucne", "scifi", "doubrodruzne" };

        /// <summary>
        /// trojlomitkovyzapis
        /// </summary>
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Category { private get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }

        public void VypisInformacie()
        {
            Console.WriteLine($"{Title} {Pages} {Category} {Author} {ReleaseDate}");
        }

        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }
    }
}
