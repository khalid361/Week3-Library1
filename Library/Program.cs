class Book
{
    string Title;
    string Author;
    string ISBN;

    public Book(string bookTitle, string bookAuthor,string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }
    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();

    }

    static void Main(string[] args)
    {
        //Create a new instance (object)of the Book class
        //note how the object name differs from the class name 
        Book book = new Book();

        //this information id for one book in our library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        //The is another book object.
        //note that the object name is 'book1' and not 'book'
        Book book1 = new Book();
        book1.Title = "methods";
        book1.Author = "KHALID";
        book1.ISBN = "1253643987";

        
        //output book information to console 
        book.DisplayInfo();
        book1.DisplayInfo();

    }
}
