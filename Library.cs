using System;
using Interface;
using Interface.Interface;
using Utils;

public class Library : IEntity
{
    private int BookLimit { get; set; }
    private List<Book> Books { get; set; }

    public int Id => throw new NotImplementedException();

    public Library(int bookLimit)
    {
        BookLimit = bookLimit;
        Books = new List<Book>();

    }
    public void AddBook(Book book)
    {
        if (Books.Exists(b =>b.Name==book.Name && !b.IsDeleted))
        {
            throw new AlreadyExistsException("Already exists");
        }
        if (Books.Count>=BookLimit)
        {
            throw new CapacityLimitException("Limit was reached");
        }
        Books.Add(book);

    }
    public Book GetBookById(int id)
    {
        foreach(Book book in Books)
        {
            if(book.Id==id && !book.IsDeleted)
            {
                return book;
            }
        }
        throw new NotFoundException("Not found");
    }
}