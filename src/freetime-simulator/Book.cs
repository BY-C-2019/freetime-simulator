namespace freetime_simulator
{
    class Book : Media
    {
        public string Author { get; }
        public int Pages { get; }
        public Book(int length, string title, string author, int pages) : base(length, title)
        {
            Author = author;
            Pages = pages;
        }

        public override string ToString()
        {
            string str = $"Title: {Title} | Author: {Author} | Number Of Pages: {Pages}";
            return str;
        }
    }
}