using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            
            

            Console.WriteLine("Zadaj nazov knihy: ");
            string title = Console.ReadLine();

            Console.WriteLine("Zadajte pocet stran: ");
            int pages = int.Parse(Console.ReadLine());
            if(pages < 0)
            {
                pages = 1;
            }

            Console.WriteLine("Zadajte kategoriu: ");
            string category = Console.ReadLine();

            Console.WriteLine("Zadaj autora: ");
            string author = Console.ReadLine();

            Console.WriteLine("Zadaj datum vydania: ");
            int releaseDate = int.Parse(Console.ReadLine());
            if (releaseDate < 1450 || releaseDate > 2021)
            {
                releaseDate = -1;
            }

            Book LOTR = new Book(title, pages, category, author, releaseDate);
            Console.WriteLine($"{LOTR.category} {LOTR.author} {LOTR.releaseDate}");
        }
    }

    class Book
    {
        private string title { get; set; }
        private int pages { get; set; }
        public string category { get; set; }
        public string author { get; set; }
        public int releaseDate { get; set; }



        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;
        }

        public void ListInformation()
        {
            Console.WriteLine($"{title} {pages} {category} {author} {releaseDate}");
        }
    }
}
