using System;

namespace freetime_simulator
{
    class Book : Media
    {
        public object obj;
        public string Author { get; }
        public int Pages { get; }
        public Book(int length, string title, string author, int pages) : base(length, title)
        {
            Author = author;
            Pages = pages;
        }

        // public override string ToString()
        // {
        //     string str = $"Title: {Title} | Author: {Author} | Number Of Pages: {Pages}";
        //     return str;
        // }

        public static Book StringToBook(string[] data, decimal readSpeed)
        {
            Book book = new Book(
                SetLength(int.Parse(data[2]), readSpeed),
                data[0],
                data[1],
                int.Parse(data[2])
            );
            return book;
        }
        public static int SetLength(int pages, decimal readSpeed)
        {
            decimal decimalResult = pages * readSpeed;
            int result = Convert.ToInt32(decimalResult);
            return result;
        }
    }
}