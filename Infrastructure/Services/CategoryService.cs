using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class CategoryService
{
    private readonly DapperContext _context;

    public CategoryService()
    {
        _context = new DapperContext();
    }

    public void AddCategory(string categoryName)
    {
        var sql = "insert into category (category_name) values (@CategoryName)";
        _context.Connection().Execute(sql, new { CategoryName = categoryName });
    }

    public Category GetCategoryById(int id)
    {
        var sql = "select id, category_name as CategoryName from category where id = @id";
        var category = _context.Connection().QueryFirstOrDefault<Category>(sql);
        return category;
    }
}