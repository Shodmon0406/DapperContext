using Domain.Models;

namespace Infrastructure.Services;

public interface IBookService
{
    void AddBook(Book book);
}