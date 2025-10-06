class Book
{
    string Title;
    string Author;
    string ISBN;

    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book();

        // This information is for one book in our library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        // This is another book object.
        // Note that the object name is 'book1' and not 'book'
        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        // Output first book information to the console
        Console.WriteLine($"Book title: {book.Title}");
        Console.WriteLine($"Book Author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");
        Console.WriteLine();

        // Output second book information to the console
        Console.WriteLine($"Book title: {book1.Title}");
        Console.WriteLine($"Book Author: {book1.Author}");
        Console.WriteLine($"Book ISBN: {book1.ISBN}");
    }
}