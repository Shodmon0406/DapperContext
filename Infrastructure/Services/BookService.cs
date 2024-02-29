using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class BookService : IBookService
{

    private readonly DapperContext _context;

    public BookService()
    {
        _context = new DapperContext();
    }
    
    public void AddBook(Book book)
    {
        var sql = "insert into book (name, category_id) values (@name, @category_id)";
        _context.Connection().Execute(sql, book);
    }

    public void DeleteBook(int id)
    {
        var sql = "delete from book where id = @id";
        _context.Connection().Execute(sql, new { Id = id });
    }
}