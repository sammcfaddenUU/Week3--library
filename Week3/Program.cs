﻿class Book
{
    string Title;
    string Author;
    string ISBN;

    // Example of a constructor that allows us to 'construct' a new
    // Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }

    // Example of a method within the Book class
    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }